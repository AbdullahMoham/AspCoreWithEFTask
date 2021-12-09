using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserPermissionLicensesTask.Model
{
    interface Ifunction<TClass>
    {
        List<TClass> GetAll();

        void Add(TClass tclass);

        //TClass Find(int id);

        //void Edit(TClass tclass);

        //void Delete(TClass tclass);

    }
}
