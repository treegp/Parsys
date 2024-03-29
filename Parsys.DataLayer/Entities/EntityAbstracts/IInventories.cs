using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;

namespace Parsys.DataLayer.Entities.EntityAbstracts
{
    public interface IInventoriesRepository : IGenericRepo<Inventories>
    {
        List<Inventories> GetById(int value);

        List<Inventories> GetByCorporationId(int value);

        List<Inventories> GetByTitle(string value);

        List<Inventories> GetByDescription(string value);

        List<Inventories> GetByIsDeleted(bool value);

        List<Inventories> GetByDeleteDate(Nullable<DateTime> value);

        List<Inventories> GetByDeleteByUserId(Nullable<int> value);

    }
}
