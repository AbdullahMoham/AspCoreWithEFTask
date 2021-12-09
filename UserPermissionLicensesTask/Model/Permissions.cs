using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserPermissionLicensesTask.Model
{
    public class Permissions
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter the permission Title")]
        public string Permission_Title { get; set; }

    }
}
