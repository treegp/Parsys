using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer
{
    public class InventoryInsHeadersRepository : GenericRepository<InventoryInsHeaders> , IInventoryInsHeadersRepository
    {
        string conStr;
        public InventoryInsHeadersRepository(string connection) : base(connection) { conStr = connection; }

        public List<InventoryInsHeaders> GetById(long value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsHeaders where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsHeaders> GetByInventoryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsHeaders where [InventoryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsHeaders> GetByTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsHeaders where [TypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsHeaders> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsHeaders where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsHeaders> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsHeaders where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsHeaders> GetByDate(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsHeaders where [Date] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsHeaders> GetByAccepted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsHeaders where [Accepted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsHeaders> GetByAcceptDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsHeaders where [AcceptDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsHeaders> GetByAcceptedByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsHeaders where [AcceptedByUserId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsHeaders> GetByIsDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsHeaders where [IsDeleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsHeaders> GetByDeleteDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsHeaders where [DeleteDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsHeaders> GetByDeleteByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsHeaders where [DeleteByUserId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
