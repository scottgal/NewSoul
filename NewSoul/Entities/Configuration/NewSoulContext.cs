using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Entities.Configuration
{
    public class NewSoulContext : DbContext   
    {

        public DbSet<Image> Images { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Profile> Profiles { get; set; }

    }
}
