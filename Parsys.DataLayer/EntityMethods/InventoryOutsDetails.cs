using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer
{
    public class InventoryOutsDetailsRepository : GenericRepository<InventoryOutsDetails> , IInventoryOutsDetailsRepository
    {
        string conStr;
        public InventoryOutsDetailsRepository(string connection) : base(connection) { conStr = connection; }

        public List<InventoryOutsDetails> GetByInventoryOutsHeaderId(long value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsDetails where [InventoryOutsHeaderId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsDetails> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsDetails where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsDetails> GetByAmount(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsDetails where [Amount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<InventoryOutsDetails> GetByTotalPrice(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from InventoryOutsDetails where [TotalPrice] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
