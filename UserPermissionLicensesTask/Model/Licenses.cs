using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserPermissionLicensesTask.Model
{
    public class Licenses
    {
        [Key]
        public int Licenses_ID { get; set; }
        public Users user_ID { get; set; }
        public Permissions per_ID { get; set; }

    }
}
