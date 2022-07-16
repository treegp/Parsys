using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer
{
    public class InventoriesRepository : GenericRepository<Inventories> , IInventoriesRepository
    {
        string conStr;
        public InventoriesRepository(string connection) : base(connection) { conStr = connection; }

        public List<Inventories> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Inventories where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Inventories> GetByCorporationId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Inventories where [CorporationId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Inventories> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Inventories where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Inventories> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Inventories where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Inventories> GetByIsDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Inventories where [IsDeleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Inventories> GetByDeleteDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Inventories where [DeleteDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Inventories> GetByDeleteByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Inventories where [DeleteByUserId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
