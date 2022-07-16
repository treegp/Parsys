using System;
using System.Collections.Generic;

namespace Parsys.DataLayer
{
    public interface IFinancialYearsRepository : IRepository<FinancialYears>
    {
        List<FinancialYears> GetById(int value);

        List<FinancialYears> GetByCorporationId(int value);

        List<FinancialYears> GetByTitle(string value);

        List<FinancialYears> GetByDescription(string value);

        List<FinancialYears> GetByStartDate(DateTime value);

        List<FinancialYears> GetByFinishDate(DateTime value);

        List<FinancialYears> GetByIsClosed(bool value);

        List<FinancialYears> GetByCloseDate(Nullable<DateTime> value);

        List<FinancialYears> GetByClosedByUserId(Nullable<int> value);

        List<FinancialYears> GetByIsDeleted(bool value);

        List<FinancialYears> GetByDeleteDate(Nullable<DateTime> value);

        List<FinancialYears> GetByDeleteByUserId(Nullable<int> value);

    }
}
