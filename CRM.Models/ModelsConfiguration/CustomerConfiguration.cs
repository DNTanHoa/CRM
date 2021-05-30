using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.ModelsConfiguration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.code);
            builder.Property(x => x.code)
                .HasMaxLength(1000);
            builder.Property(x => x.name)
                .HasMaxLength(1000);
            builder.Property(x => x.taxCode)
                .HasMaxLength(1000);
            builder.Property(x => x.address)
                .HasMaxLength(1000);
            builder.Property(x => x.bankAccountName)
                .HasMaxLength(1000);
            builder.Property(x => x.bankName)
                .HasMaxLength(1000);
            builder.Property(x => x.bankNumber)
                .HasMaxLength(1000);
            builder.Property(x => x.CreateDate)
                .HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdateDate)
                .HasDefaultValue(DateTime.Now);
        }
    }
}
