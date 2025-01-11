using BuyCars.CORE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.DATA
{
    public class DataContext:DbContext
    {
        public DbSet<Car> cars { get; set; }
        public DbSet<Castomer> castomers { get; set; }
        public DbSet<Order> orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=my_db");
        }
    }
}
