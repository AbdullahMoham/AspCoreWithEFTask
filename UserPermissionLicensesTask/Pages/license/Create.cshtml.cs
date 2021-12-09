using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserPermissionLicensesTask.Model;

namespace UserPermissionLicensesTask.Pages.license
{
    public class CreateModel : PageModel
    {
        private readonly LicenseFn lfn;
        private readonly UserFn ufn;
        private readonly PermissionFn pfn;

        [BindProperty]
        public Licenses  license { get; set; }
        public List<Users> AllUsers { get; set; }
        public List<Permissions> AllPermissions { get; set; }
        public string Message1 { get; private set; }

        public CreateModel(LicenseFn Lfn, UserFn Ufn, PermissionFn Pfn)
        {
            lfn = Lfn;
            ufn = Ufn;
            pfn = Pfn;
        }
        public void OnGet()
        {
            AllUsers = GetUserList();
            AllPermissions = GetPermissionList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var uid = license.user_ID.ID;
            var pid = license.per_ID.ID;
            if (uid == 0||pid==0)
            {
                Message1 = "Please Select User_Name And The Permission Title ";
                AllUsers = GetUserList();
                AllPermissions = GetPermissionList();
                return Page();
            }
            license.user_ID = ufn.Find(uid);
            license.per_ID = pfn.Find(pid);
            lfn.Add(license);

            return RedirectToPage("showlicenses");
        }

        public List<Permissions> GetPermissionList()
        {
            AllPermissions = pfn.GetAll();
            List<Permissions> Lper = new List<Permissions>
            {new Permissions{ID=0 ,Permission_Title="Select Permission"} };
            for (int i = 0; i < AllPermissions.Count; i++)
            {
                Lper.Add(AllPermissions[i]);
            }

            return Lper;
        }

        public List<Users> GetUserList()
        {
            AllUsers = ufn.GetAll();
            List<Users> Lper = new List<Users>
            {new Users{ID=0 ,F_Name="Select User Name "} };
            for (int i = 0; i < AllUsers.Count; i++)
            {
                Lper.Add(AllUsers[i]);
            }

            return Lper;
        }

    }
}
