using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer
{
    public class CorporationsRepository : GenericRepository<Corporations> , ICorporationsRepository
    {
        string conStr;
        public CorporationsRepository(string connection) : base(connection) { conStr = connection; }

        public List<Corporations> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Corporations where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Corporations> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Corporations where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Corporations> GetByAddress(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Corporations where [Address] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Corporations> GetByTelephone(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Corporations where [Telephone] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Corporations> GetByFax(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Corporations where [Fax] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Corporations> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Corporations where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Corporations> GetByIsDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Corporations where [IsDeleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Corporations> GetByDeleteDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Corporations where [DeleteDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Corporations> GetByDeleteByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Corporations where [DeleteByUserId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
