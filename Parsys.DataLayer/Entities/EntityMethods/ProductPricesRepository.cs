using Parsys.DataLayer.Entities.EntityAbstracts;
using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer.Entities.EntityMethods
{
    public class ProductPricesRepository : GenericRepo<ProductPrices> , IProductPricesRepository
    {
        string conStr;
        public ProductPricesRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductPrices> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductPrices where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductPrices> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductPrices where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductPrices> GetByDate(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductPrices where [Date] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductPrices> GetByPrice(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductPrices where [Price] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
