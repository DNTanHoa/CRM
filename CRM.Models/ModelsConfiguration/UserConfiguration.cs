using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.ModelsConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.username);
            builder.Property(x => x.username)
                .HasMaxLength(1000)
                .IsRequired(true);
            builder.Property(x => x.password)
                .HasMaxLength(1000)
                .IsRequired(true);
            builder.Property(x => x.hashKey)
                .HasMaxLength(1000);
        }
    }
}
