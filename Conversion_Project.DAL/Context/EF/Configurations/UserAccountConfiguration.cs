using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Project.DAL.Context.EF.Configurations
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserAccountConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.HasKey(t0 => t0.UserId);
            builder.Property(t0 => t0.UserName).HasMaxLength(200).IsRequired();
            builder.Property(t0 => t0.Password).HasMaxLength(100).IsRequired();
            builder.Property(t0 => t0.FirstName).HasMaxLength(100);
            builder.Property(t0 => t0.LastName).HasMaxLength(100);
            builder.HasIndex(u => u.UserName).IsUnique();
        }
    }
}
