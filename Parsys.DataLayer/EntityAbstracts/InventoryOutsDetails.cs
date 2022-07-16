using System;
using System.Collections.Generic;

namespace Parsys.DataLayer
{
    public interface IInventoryOutsDetailsRepository : IRepository<InventoryOutsDetails>
    {
        List<InventoryOutsDetails> GetByInventoryOutsHeaderId(long value);

        List<InventoryOutsDetails> GetByProductId(int value);

        List<InventoryOutsDetails> GetByAmount(decimal value);

        List<InventoryOutsDetails> GetByTotalPrice(decimal value);

    }
}
