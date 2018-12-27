using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WCFApplication.Models
{
    public class WCFApplicationContext : DbContext
    {
        public WCFApplicationContext (DbContextOptions<WCFApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<WCFApplication.Models.Employee> Employee { get; set; }
    }
}
