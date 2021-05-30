using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.ModelsConfiguration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.code);
            builder.Property(x => x.code)
                .HasMaxLength(100);
            builder.Property(x => x.name)
                .HasMaxLength(1000);
            builder.Property(x => x.email)
                .HasMaxLength(1000);
            builder.Property(x => x.displyEmail)
                .HasMaxLength(1000);
            builder.Property(x => x.address)
                .HasMaxLength(1000);
            builder.Property(x => x.displayAddress)
                .HasMaxLength(1000);
            builder.Property(x => x.faxNumber)
                .HasMaxLength(1000);
            builder.Property(x => x.displayFaxNumber)
                .HasMaxLength(1000);
            builder.Property(x => x.phone)
                .HasMaxLength(1000);
            builder.Property(x => x.displayPhone)
                .HasMaxLength(1000);
            builder.Property(x => x.taxCode)
                .HasMaxLength(1000);
            builder.Property(x => x.displayTaxCode)
                .HasMaxLength(1000);
            builder.Property(x => x.contactPerson)
                .HasMaxLength(1000);
            builder.Property(x => x.representPerson)
                .HasMaxLength(1000);
            builder.Property(x => x.contactPosition)
                .HasMaxLength(1000);
            builder.Property(x => x.representPosition)
                .HasMaxLength(1000);
            builder.Property(x => x.CreateDate)
                .HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdateDate)
                .HasDefaultValue(DateTime.Now);
        }
    }
}
