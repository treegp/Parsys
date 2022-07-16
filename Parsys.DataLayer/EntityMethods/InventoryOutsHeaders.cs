using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer
{
    public class InventoryOutsHeadersRepository : GenericRepository<InventoryOutsHeaders> , IInventoryOutsHeadersRepository
    {
        string conStr;
        public InventoryOutsHeadersRepository(string connection) : base(connection) { conStr = connection; }

        public List<InventoryOutsHeaders> GetById(long value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsHeaders where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsHeaders> GetByInventoryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsHeaders where [InventoryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsHeaders> GetByTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsHeaders where [TypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsHeaders> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsHeaders where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsHeaders> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsHeaders where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsHeaders> GetByDate(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsHeaders where [Date] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsHeaders> GetByAccepted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsHeaders where [Accepted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsHeaders> GetByAcceptDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsHeaders where [AcceptDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsHeaders> GetByAcceptedByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsHeaders where [AcceptedByUserId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsHeaders> GetByIsDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsHeaders where [IsDeleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsHeaders> GetByDeleteDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsHeaders where [DeleteDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsHeaders> GetByDeleteByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsHeaders where [DeleteByUserId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
