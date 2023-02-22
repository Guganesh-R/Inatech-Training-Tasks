using EFConsole.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    internal class ProductContext:DbContext
    {
        private const string connectionstring = "Server=(localdb)\\mssqllocaldb; Database=Productcore; Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionstring);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBatch> ProductBatchs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> standards { get; set; }
    }
}
