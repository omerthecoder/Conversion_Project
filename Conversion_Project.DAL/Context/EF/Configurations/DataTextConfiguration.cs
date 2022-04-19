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

    public class DataTextConfiguration : IEntityTypeConfiguration<DataText>
    {
        public void Configure(EntityTypeBuilder<DataText> builder)
        {
            builder.HasKey(t0 => t0.DataId);
            builder.Property(t0 => t0.Text).HasMaxLength(4000);
            builder.Property(t0 => t0.Translated).HasMaxLength(4000);
            builder.Property(t0 => t0.Translation).HasMaxLength(255);
        }
    }
}