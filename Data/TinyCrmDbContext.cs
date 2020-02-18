using Microsoft.EntityFrameworkCore;
using NewTinyCRMApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyCrmApi.Data
{
    public class TinyCrmDbContext : DbContext
    {
        private readonly string connectionString_;

        public TinyCrmDbContext()
        {
            connectionString_ =
                 "Server =localhost; Database=TinyCRM_Accenture; Integrated Security = SSPI; Persist Security Info=False;";
        }

        public TinyCrmDbContext(string connString)
        {
            connectionString_ = connString;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Customer>()
                .ToTable("Customer", "core");

            modelBuilder
                .Entity<Customer>()
                .HasIndex(c => c.VatNumber)
                .IsUnique();

            modelBuilder
                .Entity<Order>()
                .ToTable("Order", "core");

            modelBuilder
            .Entity<Customer>()
            .Property(c => c.VatNumber)
            .HasMaxLength(9)
            .IsFixedLength();

            modelBuilder
                   .Entity<Product>()
                   .ToTable("Product", "core");

            modelBuilder
                   .Entity<OrderProduct>()
                   .ToTable("OrderProduct", "core");

            modelBuilder
                .Entity<OrderProduct>()
                .HasKey(op => new { op.OrderId, op.ProductId });

        }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString_);
        }
    }
}
