using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PestKitOnionAB104.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnionAB104.Persistence.Configurations
{
    internal class BlogConfiguration: IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(a => a.Title).IsRequired().HasMaxLength(50);
            builder.HasIndex(a => a.Title).IsUnique();
        }
    }
}
