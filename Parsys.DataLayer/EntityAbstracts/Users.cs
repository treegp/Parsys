using System;
using System.Collections.Generic;

namespace Parsys.DataLayer
{
    public interface IUsersRepository : IRepository<Users>
    {
        List<Users> GetById(int value);

        List<Users> GetByUserName(string value);

        List<Users> GetByIsDeleted(bool value);

        List<Users> GetByDeleteDate(Nullable<DateTime> value);

        List<Users> GetByDeleteByUserId(Nullable<int> value);

    }
}
