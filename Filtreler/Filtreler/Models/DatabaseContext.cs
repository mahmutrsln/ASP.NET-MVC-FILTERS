using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Filtreler.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }
        public DbSet<SiteUser> SiteUsers { get; set; }
    }
}