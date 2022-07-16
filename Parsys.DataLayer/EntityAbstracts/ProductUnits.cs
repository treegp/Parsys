using System;
using System.Collections.Generic;

namespace Parsys.DataLayer
{
    public interface IProductUnitsRepository : IRepository<ProductUnits>
    {
        List<ProductUnits> GetById(int value);

        List<ProductUnits> GetByTitle(string value);

        List<ProductUnits> GetByDescription(string value);

        List<ProductUnits> GetByIsDeleted(bool value);

        List<ProductUnits> GetByDeleteDate(Nullable<DateTime> value);

        List<ProductUnits> GetByDeleteByUserId(Nullable<int> value);

    }
}
