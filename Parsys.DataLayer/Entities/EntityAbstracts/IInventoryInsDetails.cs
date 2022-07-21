using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;

namespace Parsys.DataLayer.Entities.EntityAbstracts
{
    public interface IInventoryInsDetailsRepository : IGenericRepo<InventoryInsDetails>
    {
        List<InventoryInsDetails> GetByInventoryInsHeaderId(long value);

        List<InventoryInsDetails> GetByProductId(int value);

        List<InventoryInsDetails> GetByAmount(decimal value);

        List<InventoryInsDetails> GetByTotalPrice(decimal value);

    }
}
