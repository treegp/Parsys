using System;
using System.Collections.Generic;

namespace Parsys.DataLayer
{
    public interface IInventoryInsDetailsRepository : IRepository<InventoryInsDetails>
    {
        List<InventoryInsDetails> GetByInventoryInsHeaderId(long value);

        List<InventoryInsDetails> GetByProductId(int value);

        List<InventoryInsDetails> GetByAmount(decimal value);

        List<InventoryInsDetails> GetByTotalPrice(decimal value);

    }
}
