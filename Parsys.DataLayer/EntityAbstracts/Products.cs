using System;
using System.Collections.Generic;

namespace Parsys.DataLayer
{
    public interface IProductsRepository : IRepository<Products>
    {
        List<Products> GetById(int value);

        List<Products> GetByProductCategoryId(int value);

        List<Products> GetByProductUnitId(Nullable<int> value);

        List<Products> GetByCode(string value);

        List<Products> GetByTitle(string value);

        List<Products> GetByDescription(string value);

        List<Products> GetByIsDeleted(bool value);

        List<Products> GetByDeleteDate(Nullable<DateTime> value);

        List<Products> GetByDeleteByUserId(Nullable<int> value);

    }
}
