using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserPermissionLicensesTask.Model
{
    public class Users
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter User first name ")]
        public string F_Name { get; set; }
        [Required(ErrorMessage = "Please enter user second name ")]
        public string L_Name { get; set; }

    }
}
