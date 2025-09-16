using Microsoft.EntityFrameworkCore;
using SalesDatabase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Data
{
    internal class SalesContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial catalog=SalesDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().Property(p => p.Name).HasColumnType("nvarchar(50)");
            modelBuilder.Entity<Customer>().Property(c =>c.Name).HasColumnType("nvarchar(100)");
            modelBuilder.Entity<Customer>().Property(c =>c.Email).HasColumnType("varchar(80)");
            modelBuilder.Entity<Store>().Property(s =>s.Name).HasColumnType("nvarchar(80)");
            // Adding Constraint on the new Column Description up to 250 symbols constraint
            modelBuilder.Entity<Product>().Property(p => p.Description).HasMaxLength(250);

        }
    }
}
