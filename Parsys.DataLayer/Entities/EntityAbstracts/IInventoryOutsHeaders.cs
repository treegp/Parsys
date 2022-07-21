using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;

namespace Parsys.DataLayer.Entities.EntityAbstracts
{
    public interface IInventoryOutsHeadersRepository : IGenericRepo<InventoryOutsHeaders>
    {
        List<InventoryOutsHeaders> GetById(long value);

        List<InventoryOutsHeaders> GetByInventoryId(int value);

        List<InventoryOutsHeaders> GetByTypeId(int value);

        List<InventoryOutsHeaders> GetByTitle(string value);

        List<InventoryOutsHeaders> GetByDescription(string value);

        List<InventoryOutsHeaders> GetByDate(DateTime value);

        List<InventoryOutsHeaders> GetByAccepted(bool value);

        List<InventoryOutsHeaders> GetByAcceptDate(Nullable<DateTime> value);

        List<InventoryOutsHeaders> GetByAcceptedByUserId(Nullable<int> value);

        List<InventoryOutsHeaders> GetByIsDeleted(bool value);

        List<InventoryOutsHeaders> GetByDeleteDate(Nullable<DateTime> value);

        List<InventoryOutsHeaders> GetByDeleteByUserId(Nullable<int> value);

    }
}
