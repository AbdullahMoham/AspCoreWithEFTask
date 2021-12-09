using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserPermissionLicensesTask.Model
{
    public class LicenseFn : Ifunction<Licenses>
    {
        private readonly UserDB udb;

        public LicenseFn(UserDB Udb)
        {
            udb = Udb;
        }
        public void Add(Licenses tclass)
        {
            udb.licenses.Add(tclass);
            udb.SaveChanges();
        }

        public List<Licenses> GetAll()
        {
            return udb.licenses.ToList();
        }
    }
}
