using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;

namespace Parsys.DataLayer.Entities.EntityAbstracts
{
    public interface IInventoryInsTypeRepository : IGenericRepo<InventoryInsType>
    {
        List<InventoryInsType> GetById(int value);

        List<InventoryInsType> GetByTitle(string value);

        List<InventoryInsType> GetByDescription(string value);

        List<InventoryInsType> GetByIsDeleted(bool value);

        List<InventoryInsType> GetByDeleteDate(Nullable<DateTime> value);

        List<InventoryInsType> GetByDeleteByUserId(Nullable<int> value);

    }
}
