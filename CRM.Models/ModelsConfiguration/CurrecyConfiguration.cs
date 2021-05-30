using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.ModelsConfiguration
{
    public class CurrecyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.HasKey(x => x.code);
            builder.Property(x => x.code)
                .IsRequired(true)
                .HasMaxLength(1000);
            builder.Property(x => x.name)
                .HasMaxLength(1000);
            builder.Property(x => x.CreateDate)
                .HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdateDate)
                .HasDefaultValue(DateTime.Now);
        }
    }
}
