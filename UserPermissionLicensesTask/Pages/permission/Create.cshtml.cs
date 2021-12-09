using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserPermissionLicensesTask.Model;

namespace UserPermissionLicensesTask.Pages.permission
{
    public class CreateModel : PageModel
    {
        private readonly PermissionFn pfn;

        [BindProperty]
        public Permissions permission { get; set; }
        public CreateModel(PermissionFn Pfn)
        {
            pfn = Pfn;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            pfn.Add(permission);
            return RedirectToPage("showpermissions");
        }


    }
}
