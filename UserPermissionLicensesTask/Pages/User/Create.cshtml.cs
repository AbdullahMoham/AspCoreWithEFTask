using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserPermissionLicensesTask.Model;

namespace UserPermissionLicensesTask.Pages.User
{
    public class CreateModel : PageModel
    {
        private readonly UserFn ufn;

        [BindProperty]
        public Users user { get; set; }
        public CreateModel(UserFn Ufn)
        {
            ufn = Ufn;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ufn.Add(user);
            return RedirectToPage("showusers");
        }

    }
}
