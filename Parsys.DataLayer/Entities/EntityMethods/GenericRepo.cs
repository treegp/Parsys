using Parsys.DataLayer.Entities.EntityAbstracts;
using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Parsys.DataLayer.Entities.EntityMethods
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity>
    {
        string conStr;
        string tblSchema;
        string tblName = typeof(TEntity).Name;
        List<ColumnSpecifics> ColumnsSpecifics = new List<ColumnSpecifics>();



        public GenericRepo(string connection)
        {
            conStr = connection;
            var entityType = typeof(TEntity);


            var tableInfo = entityType.GetCustomAttributes(typeof(GenericRepoModel.Table), false).OfType<GenericRepoModel.Table>().FirstOrDefault();
            if (tableInfo != null)
            {
                tblSchema = tableInfo.Schema;
            }
            else
            {
                tblSchema = "dbo";
            }

            foreach (var column in entityType.GetProperties())
            {
                ColumnSpecifics spec = new ColumnSpecifics
                {
                    ColumnName = column.Name,
                    PropertyName = column.Name,
                    ColumnType = column
                };
                var Ises = column.GetCustomAttributes(typeof(GenericRepoModel.Column), false).OfType<GenericRepoModel.Column>().FirstOrDefault();
                if (Ises != null)
                {
                    spec.PrimaryKey = Ises.PrimaryKey;
                    spec.Required = Ises.Required;
                    spec.Computed = Ises.Computed;
                }
                else
                {
                    spec.PrimaryKey = false;
                    spec.Required = false;
                    spec.Computed = false;
                }
                ColumnsSpecifics.Add(spec);
            }
        }

        //INSERT INTO [dbo].[****] (Id,...) VALUES (@param1,...)
        public TEntity Insert(TEntity entity)
        {
            List<string> columnList = new List<string>();
            List<string> paramList = new List<string>();
            List<SqlParameter> parametersList = new List<SqlParameter>();

            int i = 1;
            foreach (var spec in ColumnsSpecifics)
            {
                if (spec.ColumnType.GetValue(entity) == null)
                    continue;
                else if (!spec.Computed)
                {
                    columnList.Add(spec.ColumnName);
                    paramList.Add("param" + i);
                    var val = spec.ColumnType.GetValue(entity);
                    if (val == null)
                        val = DBNull.Value;

                    parametersList.Add(new SqlParameter("param" + i, val));
                    i++;
                }

            }

            string insertPart = "INSERT INTO [" + tblSchema + "].[" + tblName + "]";
            string columnPart = "(" + string.Join(",", columnList.Select(c => "[" + c + "]")) + ")";
            string outputPart = "OUTPUT inserted.*";
            string paramPart = "VALUES (" + string.Join(",", paramList.Select(c => "@" + c)) + ")";

            string command = string.Join(" ", insertPart, columnPart, outputPart, paramPart);



            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand com = new SqlCommand(command, con);
                foreach (SqlParameter p in parametersList)
                    com.Parameters.Add(p);


                var reader = com.ExecuteReader();
                TEntity returnEntity = Activator.CreateInstance<TEntity>();
                if (reader.Read())
                {
                    foreach (var spec in returnEntity.GetType().GetProperties())
                    {
                        if (reader[spec.Name] == DBNull.Value)
                            spec.SetValue(returnEntity, null);
                        else
                            spec.SetValue(returnEntity, reader[spec.Name]);
                    }
                }
                return returnEntity;
            }

        }


        //DELETE FROM [dbo].[****] WHERE [Id]=1 , ...
        public TEntity Delete(TEntity entity)
        {
            List<string> conditionList = new List<string>();
            List<SqlParameter> parametersList = new List<SqlParameter>();

            int i = 1;
            foreach (var spec in ColumnsSpecifics)
            {
                if (spec.ColumnType.GetValue(entity) == null)
                    continue;
                else if (spec.PrimaryKey)
                {
                    conditionList.Add("[" + spec.ColumnName + "] = @param" + i);

                    var val = spec.ColumnType.GetValue(entity);
                    if (val == null)
                        val = DBNull.Value;

                    parametersList.Add(new SqlParameter("param" + i, val));
                    i++;
                }

            }

            string deletePart = "DELETE FROM [" + tblSchema + "].[" + tblName + "]";
            string outputPart = "OUTPUT deleted.*";
            string wherePart = "WHERE (" + string.Join(",", conditionList) + ")";

            string command = string.Join(" ", deletePart,outputPart, wherePart);


            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand com = new SqlCommand(command, con);
                foreach (SqlParameter p in parametersList)
                    com.Parameters.Add(p);

                var reader = com.ExecuteReader();
                TEntity returnEntity = Activator.CreateInstance<TEntity>();
                if (reader.Read())
                {
                    foreach (var spec in returnEntity.GetType().GetProperties())
                    {
                        if (reader[spec.Name] == DBNull.Value)
                            spec.SetValue(returnEntity, null);
                        else
                            spec.SetValue(returnEntity, reader[spec.Name]);
                    }
                }
                return returnEntity;
            }

        }


        //UPDATE [dbo].[****] SET [Name]=@param1 , ... WHERE [Id]=1
        public TEntity Update(TEntity entity)
        {
            List<string> conditionList = new List<string>();
            List<string> setList = new List<string>();
            List<SqlParameter> parametersList = new List<SqlParameter>();


            int i = 1;
            foreach (var spec in ColumnsSpecifics)
            {
                if (spec.ColumnType.GetValue(entity) == null)
                    continue;
                else if (spec.PrimaryKey)
                    conditionList.Add("[" + spec.ColumnName + "] = @param" + i);
                else if (!spec.Computed)
                    setList.Add("[" + spec.ColumnName + "] = @param" + i);



                var val = spec.ColumnType.GetValue(entity);
                if (val == null)
                    val = DBNull.Value;

                parametersList.Add(new SqlParameter("param" + i, val));
                i++;
            }


            string updatePart = "UPDATE [" + tblSchema + "].[" + tblName + "]";
            string setPart = "SET " + string.Join(",", setList);
            string outputPart = "OUTPUT inserted.*";
            string wherePart = "WHERE " + string.Join(",", conditionList);

            string command = string.Join(" ", updatePart, setPart,outputPart, wherePart);


            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand com = new SqlCommand(command, con);
                foreach (SqlParameter p in parametersList)
                    com.Parameters.Add(p);

                var reader = com.ExecuteReader();
                TEntity returnEntity = Activator.CreateInstance<TEntity>();
                if (reader.Read())
                {
                    foreach (var spec in returnEntity.GetType().GetProperties())
                    {
                        if (reader[spec.Name] == DBNull.Value)
                            spec.SetValue(returnEntity, null);
                        else
                            spec.SetValue(returnEntity, reader[spec.Name]);
                    }
                }
                return returnEntity;
            }



        }



        public List<TEntity> ExecutingReader(string command, params SqlParameter[] parametersList)
        {

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand com = new SqlCommand(command, con);
                foreach (SqlParameter p in parametersList)
                    com.Parameters.Add(p);
                SqlDataReader reader = com.ExecuteReader();

                List<TEntity> entities = new List<TEntity>();
                while (reader.Read())
                {
                    TEntity entity = Activator.CreateInstance<TEntity>();
                    foreach (var spec in ColumnsSpecifics)
                    {
                        if (reader[spec.ColumnName] == DBNull.Value)
                            spec.ColumnType.SetValue(entity, null);
                        else
                            spec.ColumnType.SetValue(entity, reader[spec.ColumnName]);
                    }
                    entities.Add(entity);
                }
                return entities;

            }


        }



        public List<TEntity> GetAll()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM [" + tblSchema + "].[" + tblName + "]", con);
                SqlDataReader reader = com.ExecuteReader();

                List<TEntity> entities = new List<TEntity>();
                while (reader.Read())
                {
                    TEntity entity = Activator.CreateInstance<TEntity>();
                    foreach (var spec in ColumnsSpecifics)
                    {
                        if (reader[spec.ColumnName] == DBNull.Value)
                            spec.ColumnType.SetValue(entity, null);
                        else
                            spec.ColumnType.SetValue(entity, reader[spec.ColumnName]);
                    }
                    entities.Add(entity);
                }
                return entities;
            }
        }



        public TEntity Top()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT TOP(1) * FROM [" + tblSchema + "].[" + tblName + "]", con);
                SqlDataReader reader = com.ExecuteReader();
                TEntity entity = Activator.CreateInstance<TEntity>();
                if (reader.Read())
                    foreach (var spec in ColumnsSpecifics)
                    {
                        if (reader[spec.ColumnName] == DBNull.Value)
                            spec.ColumnType.SetValue(entity, null);
                        else
                            spec.ColumnType.SetValue(entity, reader[spec.ColumnName]);
                    }
                return entity;
            }
        }



        public int Count()
        {
            string command = "SELECT COUNT(*) FROM [" + tblSchema + "].[" + tblName + "]";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand com = new SqlCommand(command, con);
                return (int)com.ExecuteScalar();
            }
        }

    }




}
