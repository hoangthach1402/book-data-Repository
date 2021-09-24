using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My_Book_Copy.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace My_Book_Copy.Configurations
{
    class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).UseIdentityColumn().IsRequired();

            builder.Property(a => a.FirstName).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(a => a.LastName).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
