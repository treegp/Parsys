using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;

namespace Parsys.DataLayer.Entities.EntityAbstracts
{
    public interface IUsersRepository : IGenericRepo<Users>
    {
        List<Users> GetById(int value);

        List<Users> GetByUserName(string value);

        List<Users> GetByIsDeleted(bool value);

        List<Users> GetByDeleteDate(Nullable<DateTime> value);

        List<Users> GetByDeleteByUserId(Nullable<int> value);

    }
}
