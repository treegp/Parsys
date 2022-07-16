using System;
using System.Collections.Generic;

namespace Parsys.DataLayer
{
    public interface IProductParameterValuesRepository : IRepository<ProductParameterValues>
    {
        List<ProductParameterValues> GetByProductId(int value);

        List<ProductParameterValues> GetByProductParameterId(int value);

        List<ProductParameterValues> GetByValue(string value);

    }
}
