using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UserManagement.Models
{
    public class UserDBContext:DbContext
    {
        public DbSet<users> Users { get; set; }
    }
}