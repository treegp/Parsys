using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer
{
    public class UsersRepository : GenericRepository<Users> , IUsersRepository
    {
        string conStr;
        public UsersRepository(string connection) : base(connection) { conStr = connection; }

        public List<Users> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Users where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Users> GetByUserName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Users where [UserName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Users> GetByIsDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Users where [IsDeleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Users> GetByDeleteDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Users where [DeleteDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Users> GetByDeleteByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Users where [DeleteByUserId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
