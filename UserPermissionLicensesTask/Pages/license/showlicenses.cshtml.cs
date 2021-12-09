using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserPermissionLicensesTask.Model;

namespace UserPermissionLicensesTask.Pages.license
{
    public class showlicensesModel : PageModel
    {
        private readonly LicenseFn lfn;
        private readonly UserFn ufn;
        private readonly PermissionFn pfn;

        public List<Licenses> Alllicense { get; set; }
        public List<Users> AllUsers { get; set; }
        public List<Permissions> AllPermissions { get; set; }

        public showlicensesModel(LicenseFn Lfn,UserFn Ufn,PermissionFn Pfn)
        {
            lfn = Lfn;
            ufn = Ufn;
            pfn = Pfn;
        }
        public void OnGet()
        {
            Alllicense = lfn.GetAll();
            AllUsers = ufn.GetAll();
            AllPermissions = pfn.GetAll();
        }
    }
}
