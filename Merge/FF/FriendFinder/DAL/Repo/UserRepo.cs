using DAL.Database;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class UserRepo : IUserRepository<User>
    {

        friend_finderEntities db;

        public UserRepo(friend_finderEntities db)
        {
            this.db = db;
        }

        public bool Login(User e)
        {
            var data = (from u in db.Users where u.Id == e.Id && u.Password == e.Password select u).FirstOrDefault(); ;
            if (data != null)
            {
                return true;
            }

            return false;
        }

        public bool Register(User e)
        {
            throw new NotImplementedException();
        }
    }
}
