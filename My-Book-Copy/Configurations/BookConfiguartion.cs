
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My_Book_Copy.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace My_Book_Copy.Configurations
{
    class BookConfiguartion : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
            
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).UseIdentityColumn().IsRequired();

            builder.Property(b => b.Title).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(b => b.Description).IsRequired();
            builder.Property(b => b.Rate).HasDefaultValue(0);
            builder.Property(b => b.IsRead).HasDefaultValue(false);
            builder.Property(b => b.Genre).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(b => b.CoverUrl).HasColumnType("nvarchar").IsRequired();
            builder.Property(b => b.DateAdded).HasColumnType("Date").HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(b => b.DateRead).HasColumnType("Date").HasDefaultValue(DateTime.Now).IsRequired();

            builder.HasOne(b => b.Publisher).WithMany(p => p.Books).HasForeignKey(b => b.PublisherId);       
        }
    }
}
