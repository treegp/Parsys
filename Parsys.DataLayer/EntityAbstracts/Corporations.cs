using System;
using System.Collections.Generic;

namespace Parsys.DataLayer
{
    public interface ICorporationsRepository : IRepository<Corporations>
    {
        List<Corporations> GetById(int value);

        List<Corporations> GetByTitle(string value);

        List<Corporations> GetByAddress(string value);

        List<Corporations> GetByTelephone(string value);

        List<Corporations> GetByFax(string value);

        List<Corporations> GetByDescription(string value);

        List<Corporations> GetByIsDeleted(bool value);

        List<Corporations> GetByDeleteDate(Nullable<DateTime> value);

        List<Corporations> GetByDeleteByUserId(Nullable<int> value);

    }
}
