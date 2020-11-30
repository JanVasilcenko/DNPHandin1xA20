using DNPHandin1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServices.DataAccess
{
    public class AdultsDBContext : DbContext
    {
        public DbSet<Adult> adults { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = AdultsDB.db");
        }
    }
}
