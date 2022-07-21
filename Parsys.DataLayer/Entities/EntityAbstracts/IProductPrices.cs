using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;

namespace Parsys.DataLayer.Entities.EntityAbstracts
{
    public interface IProductPricesRepository : IGenericRepo<ProductPrices>
    {
        List<ProductPrices> GetById(int value);

        List<ProductPrices> GetByProductId(int value);

        List<ProductPrices> GetByDate(DateTime value);

        List<ProductPrices> GetByPrice(int value);

    }
}
