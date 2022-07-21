using Parsys.DataLayer.Entities.EntityAbstracts;
using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer.Entities.EntityMethods
{
    public class ProductParameterValuesRepository : GenericRepo<ProductParameterValues> , IProductParameterValuesRepository
    {
        string conStr;
        public ProductParameterValuesRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductParameterValues> GetByProductId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductParameterValues where [ProductId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductParameterValues> GetByProductParameterId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductParameterValues where [ProductParameterId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductParameterValues> GetByValue(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductParameterValues where [Value] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
