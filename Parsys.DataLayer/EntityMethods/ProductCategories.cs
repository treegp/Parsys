using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer
{
    public class ProductCategoriesRepository : GenericRepository<ProductCategories> , IProductCategoriesRepository
    {
        string conStr;
        public ProductCategoriesRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductCategories> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductCategories where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductCategories> GetByInventoryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductCategories where [InventoryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductCategories> GetByParentCategoryId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductCategories where [ParentCategoryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductCategories> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductCategories where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductCategories> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductCategories where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductCategories> GetByIsDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductCategories where [IsDeleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductCategories> GetByDeleteDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductCategories where [DeleteDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductCategories> GetByDeleteByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductCategories where [DeleteByUserId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
