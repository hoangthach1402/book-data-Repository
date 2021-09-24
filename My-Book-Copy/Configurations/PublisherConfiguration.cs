using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My_Book_Copy.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace My_Book_Copy.Configurations
{
    class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.ToTable("Publishers");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn().IsRequired();

            builder.Property(p => p.Name).HasColumnType("nvarchar(100)").IsRequired();

            builder.HasMany(p => p.Books).WithOne(p => p.Publisher);
        }
    }
}
