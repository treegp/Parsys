using System;
using System.Collections.Generic;

namespace Parsys.DataLayer
{
    public interface IProductPricesRepository : IRepository<ProductPrices>
    {
        List<ProductPrices> GetById(int value);

        List<ProductPrices> GetByProductId(int value);

        List<ProductPrices> GetByDate(DateTime value);

        List<ProductPrices> GetByPrice(decimal value);

    }
}
