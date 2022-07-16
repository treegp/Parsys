using System;
using System.Collections.Generic;

namespace Parsys.DataLayer
{
    public interface IProductParametersRepository : IRepository<ProductParameters>
    {
        List<ProductParameters> GetById(int value);

        List<ProductParameters> GetByProductCategoryId(int value);

        List<ProductParameters> GetByKey(string value);

        List<ProductParameters> GetByTitle(string value);

        List<ProductParameters> GetByDescription(string value);

        List<ProductParameters> GetByData(string value);

        List<ProductParameters> GetByIsDeleted(bool value);

        List<ProductParameters> GetByDeleteDate(Nullable<DateTime> value);

        List<ProductParameters> GetByDeleteByUserId(Nullable<int> value);

    }
}
