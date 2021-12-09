using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserPermissionLicensesTask.Model;

namespace UserPermissionLicensesTask.Pages.User
{
    public class showusersModel : PageModel
    {
        public List<Users> AllUsers { get; set; }
        private readonly UserFn ufn;

        public showusersModel(UserFn Ufn)
        {
            ufn = Ufn;
        }
        public void OnGet()
        {
            AllUsers = ufn.GetAll();
        }
    }
}
