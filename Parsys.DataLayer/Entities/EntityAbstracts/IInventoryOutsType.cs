using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;

namespace Parsys.DataLayer.Entities.EntityAbstracts
{
    public interface IInventoryOutsTypeRepository : IGenericRepo<InventoryOutsType>
    {
        List<InventoryOutsType> GetById(int value);

        List<InventoryOutsType> GetByTitle(string value);

        List<InventoryOutsType> GetByDescription(string value);

        List<InventoryOutsType> GetByIsDeleted(bool value);

        List<InventoryOutsType> GetByDeleteDate(Nullable<DateTime> value);

        List<InventoryOutsType> GetByDeleteByUserId(Nullable<int> value);

    }
}
