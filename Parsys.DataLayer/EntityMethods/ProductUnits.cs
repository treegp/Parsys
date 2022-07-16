using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer
{
    public class ProductUnitsRepository : GenericRepository<ProductUnits> , IProductUnitsRepository
    {
        string conStr;
        public ProductUnitsRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductUnits> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductUnits where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductUnits> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductUnits where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductUnits> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductUnits where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductUnits> GetByIsDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductUnits where [IsDeleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductUnits> GetByDeleteDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductUnits where [DeleteDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductUnits> GetByDeleteByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductUnits where [DeleteByUserId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
