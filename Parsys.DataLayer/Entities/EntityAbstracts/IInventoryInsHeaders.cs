using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;

namespace Parsys.DataLayer.Entities.EntityAbstracts
{
    public interface IInventoryInsHeadersRepository : IGenericRepo<InventoryInsHeaders>
    {
        List<InventoryInsHeaders> GetById(long value);

        List<InventoryInsHeaders> GetByInventoryId(int value);

        List<InventoryInsHeaders> GetByTypeId(int value);

        List<InventoryInsHeaders> GetByTitle(string value);

        List<InventoryInsHeaders> GetByDescription(string value);

        List<InventoryInsHeaders> GetByDate(DateTime value);

        List<InventoryInsHeaders> GetByAccepted(bool value);

        List<InventoryInsHeaders> GetByAcceptDate(Nullable<DateTime> value);

        List<InventoryInsHeaders> GetByAcceptedByUserId(Nullable<int> value);

        List<InventoryInsHeaders> GetByIsDeleted(bool value);

        List<InventoryInsHeaders> GetByDeleteDate(Nullable<DateTime> value);

        List<InventoryInsHeaders> GetByDeleteByUserId(Nullable<int> value);

    }
}
