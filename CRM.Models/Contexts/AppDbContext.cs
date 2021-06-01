using CRM.Models.ModelsConfiguration;
using CRM.SharedUltilities.Global;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionGlobal.DatabaseConnectionString);
            }
        }

        #region DbSet
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerType> CustomerType { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new CurrecyConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerTypeConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceDetailConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceDetailFunctionConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceHeaderConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentStatusConfiguration());
            modelBuilder.ApplyConfiguration(new TaxTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UnitConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
