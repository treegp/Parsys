using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;

namespace Parsys.DataLayer.Entities.EntityAbstracts
{
    public interface IProductParameterValuesRepository : IGenericRepo<ProductParameterValues>
    {
        List<ProductParameterValues> GetByProductId(int value);

        List<ProductParameterValues> GetByProductParameterId(int value);

        List<ProductParameterValues> GetByValue(string value);

    }
}
