using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserPermissionLicensesTask.Model
{
    public class UserFn : Ifunction<Users>
    {
        private readonly UserDB udb;

        public UserFn(UserDB Udb)
        {
            udb = Udb;
        }
        public void Add(Users tclass)
        {
            udb.users.Add(tclass);
            udb.SaveChanges();
        }

        public List<Users> GetAll()
        {
            return udb.users.ToList();
        }

        public Users Find(int id)
        {
            var user = udb.users.SingleOrDefault(u => u.ID == id);
            return user;
        }


    }
}
