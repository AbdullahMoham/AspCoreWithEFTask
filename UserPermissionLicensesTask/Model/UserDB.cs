using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserPermissionLicensesTask.Model
{
    public class UserDB:DbContext
    {
        public UserDB(DbContextOptions<UserDB> options):base(options)
        {

        }

        public DbSet<Users> users { get; set; }
        public DbSet<Permissions> permissions { get; set; }
        public DbSet<Licenses> licenses { get; set; }

    }
}
