using Parsys.DataLayer.Entities.EntityAbstracts;
using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer.Entities.EntityMethods
{
    public class ProductParametersRepository : GenericRepo<ProductParameters> , IProductParametersRepository
    {
        string conStr;
        public ProductParametersRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductParameters> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductParameters where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductParameters> GetByProductCategoryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductParameters where [ProductCategoryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductParameters> GetByKey(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductParameters where [Key] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductParameters> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductParameters where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductParameters> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductParameters where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductParameters> GetByData(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductParameters where [Data] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductParameters> GetByIsDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductParameters where [IsDeleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductParameters> GetByDeleteDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductParameters where [DeleteDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductParameters> GetByDeleteByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductParameters where [DeleteByUserId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
