using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserPermissionLicensesTask.Model;

namespace UserPermissionLicensesTask.Pages.permission
{
    public class showpermissionsModel : PageModel
    {
        private readonly PermissionFn pFN;

        public List<Permissions> AllPer { get; set; }
        public showpermissionsModel(PermissionFn PFN)
        {
            pFN = PFN;
        }
        public void OnGet()
        {
            AllPer = pFN.GetAll();
        }
    }
}
