using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.ModelsConfiguration
{
    public class SequenceNumberConfiguration : IEntityTypeConfiguration<SequenceNumber>
    {
        public void Configure(EntityTypeBuilder<SequenceNumber> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id)
                .UseIdentityColumn();
            builder.Property(x => x.prefix)
                .HasMaxLength(1000)
                .HasDefaultValue(string.Empty);
            builder.Property(x => x.subfix)
                .HasMaxLength(1000)
                .HasDefaultValue(string.Empty);
            builder.Property(x => x.partern)
                .HasMaxLength(1000)
                .HasDefaultValue(string.Empty);
            builder.Property(x => x.serial)
                .HasMaxLength(1000)
                .HasDefaultValue(string.Empty);
            builder.Property(x => x.numberFrom)
                .HasDefaultValue("000000000")
                .HasMaxLength(1000);
            builder.Property(x => x.numberTo)
                .HasDefaultValue("999999999")
                .HasMaxLength(1000);
            builder.Property(x => x.lastNumber)
                .HasDefaultValue("000000000")
                .HasMaxLength(1000);
            builder.Property(x => x.CreateDate)
                .HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdateDate)
                .HasDefaultValue(DateTime.Now);
        }
    }
}
