using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

                new Product() { Id = Guid.NewGuid(), Name = "pen", Quantity = 100, Value = 11 },
                new Product() { Id = Guid.NewGuid(), Name = "book", Quantity = 100, Value = 11 },
                new Product() { Id = Guid.NewGuid(), Name = "notebook", Quantity = 100, Value = 11 },
                new Product() { Id = Guid.NewGuid(), Name = "pencil", Quantity = 100, Value = 11 },
                new Product() { Id = Guid.NewGuid(), Name = "ruler", Quantity = 100, Value = 11 });

            base.OnModelCreating(modelBuilder);
        }
    }
}
