using System;
using System.Collections.Generic;
using System.Text;
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("Login");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired(true);
        }
    }
}
