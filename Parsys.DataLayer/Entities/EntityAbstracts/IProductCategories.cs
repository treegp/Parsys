using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;

namespace Parsys.DataLayer.Entities.EntityAbstracts
{
    public interface IProductCategoriesRepository : IGenericRepo<ProductCategories>
    {
        List<ProductCategories> GetById(int value);

        List<ProductCategories> GetByInventoryId(int value);

        List<ProductCategories> GetByParentCategoryId(Nullable<int> value);

        List<ProductCategories> GetByTitle(string value);

        List<ProductCategories> GetByDescription(string value);

        List<ProductCategories> GetByIsDeleted(bool value);

        List<ProductCategories> GetByDeleteDate(Nullable<DateTime> value);

        List<ProductCategories> GetByDeleteByUserId(Nullable<int> value);

    }
}
