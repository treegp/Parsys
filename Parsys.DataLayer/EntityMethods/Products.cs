using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer
{
    public class ProductsRepository : GenericRepository<Products> , IProductsRepository
    {
        string conStr;
        public ProductsRepository(string connection) : base(connection) { conStr = connection; }

        public List<Products> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Products where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Products> GetByProductCategoryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Products where [ProductCategoryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Products> GetByProductUnitId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Products where [ProductUnitId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Products> GetByCode(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Products where [Code] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Products> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Products where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Products> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Products where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Products> GetByIsDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Products where [IsDeleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Products> GetByDeleteDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Products where [DeleteDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Products> GetByDeleteByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Products where [DeleteByUserId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
