using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;

namespace Parsys.DataLayer.Entities.EntityAbstracts
{
    public interface IInventoryOutsDetailsRepository : IGenericRepo<InventoryOutsDetails>
    {
        List<InventoryOutsDetails> GetByInventoryOutsHeaderId(long value);

        List<InventoryOutsDetails> GetByProductId(int value);

        List<InventoryOutsDetails> GetByAmount(decimal value);

        List<InventoryOutsDetails> GetByTotalPrice(decimal value);

    }
}
