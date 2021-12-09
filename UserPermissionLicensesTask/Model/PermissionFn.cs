using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserPermissionLicensesTask.Model
{
  
    public class PermissionFn : Ifunction<Permissions>
    {
        private readonly UserDB udb;

        public PermissionFn(UserDB Udb)
        {
            udb = Udb;
        }
        public void Add(Permissions tclass)
        {
            udb.permissions.Add(tclass);
            udb.SaveChanges();
        }

        public List<Permissions> GetAll()
        {
            return udb.permissions.ToList();
        }

        public Permissions Find(int id)
        {
            var user = udb.permissions.SingleOrDefault(u => u.ID == id);
            return user;
        }

    }
}
