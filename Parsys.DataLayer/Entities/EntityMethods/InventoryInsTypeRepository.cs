using Parsys.DataLayer.Entities.EntityAbstracts;
using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer.Entities.EntityMethods
{
    public class InventoryInsTypeRepository : GenericRepo<InventoryInsType> , IInventoryInsTypeRepository
    {
        string conStr;
        public InventoryInsTypeRepository(string connection) : base(connection) { conStr = connection; }

        public List<InventoryInsType> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsType where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsType> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsType where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsType> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsType where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsType> GetByIsDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsType where [IsDeleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsType> GetByDeleteDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsType where [DeleteDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsType> GetByDeleteByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsType where [DeleteByUserId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
