using Parsys.DataLayer.Entities.EntityAbstracts;
using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer.Entities.EntityMethods
{
    public class InventoryInsDetailsRepository : GenericRepo<InventoryInsDetails> , IInventoryInsDetailsRepository
    {
        string conStr;
        public InventoryInsDetailsRepository(string connection) : base(connection) { conStr = connection; }

        public List<InventoryInsDetails> GetByInventoryInsHeaderId(long value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsDetails where [InventoryInsHeaderId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsDetails> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsDetails where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsDetails> GetByAmount(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsDetails where [Amount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryInsDetails> GetByTotalPrice(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryInsDetails where [TotalPrice] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
