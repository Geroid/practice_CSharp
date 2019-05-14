using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveAgency
{
    class AppContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Request> Requests { get; set; }
        public AppContext() : base("DBConnection")
        {
        }
    }
}
