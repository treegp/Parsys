using System;
using System.Collections.Generic;

namespace Parsys.DataLayer
{
    public interface IInventoryOutsTypeRepository : IRepository<InventoryOutsType>
    {
        List<InventoryOutsType> GetById(int value);

        List<InventoryOutsType> GetByTitle(string value);

        List<InventoryOutsType> GetByDescription(string value);

        List<InventoryOutsType> GetByIsDeleted(bool value);

        List<InventoryOutsType> GetByDeleteDate(Nullable<DateTime> value);

        List<InventoryOutsType> GetByDeleteByUserId(Nullable<int> value);

    }
}
