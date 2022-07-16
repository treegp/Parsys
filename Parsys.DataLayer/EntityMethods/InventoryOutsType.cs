using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer
{
    public class InventoryOutsTypeRepository : GenericRepository<InventoryOutsType> , IInventoryOutsTypeRepository
    {
        string conStr;
        public InventoryOutsTypeRepository(string connection) : base(connection) { conStr = connection; }

        public List<InventoryOutsType> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsType where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsType> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsType where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsType> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsType where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsType> GetByIsDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsType where [IsDeleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsType> GetByDeleteDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsType where [DeleteDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsType> GetByDeleteByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsType where [DeleteByUserId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
