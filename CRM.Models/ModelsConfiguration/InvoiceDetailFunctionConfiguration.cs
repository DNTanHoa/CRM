using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.ModelsConfiguration
{
    public class InvoiceDetailFunctionConfiguration : IEntityTypeConfiguration<InvoiceDetailFunction>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetailFunction> builder)
        {
            builder.HasKey(x => x.code);
            builder.Property(x => x.code)
                .HasMaxLength(1000);
            builder.Property(x => x.CreateDate)
                .HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdateDate)
                .HasDefaultValue(DateTime.Now);
        }
    }
}
