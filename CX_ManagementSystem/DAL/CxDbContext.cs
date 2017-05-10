using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CX_ManagementSystem.DAL
{
    public class CxDbContext : DbContext
    {
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Role> Roles { get; set; }
        public DbSet<Models.UserRole> UserRoles { get; set; }

        public CxDbContext() : base("DefaultConnection") { }


    }
}