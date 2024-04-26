using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Models
{
    internal class SMContext : DbContext
    {
        public DbSet<Security> Securitys { get; set; }

        public DbSet<Shift> Shifts { get; set; }

        public DbSet<Report> Reports { get; set; }

    }
}
