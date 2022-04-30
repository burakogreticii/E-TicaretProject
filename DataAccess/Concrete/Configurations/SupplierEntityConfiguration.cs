﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class SupplierEntityConfiguration : BaseEntityConfiguration<Supplier>
    {
        public override void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(s => s.CustomerId).HasColumnName("CustomerId").IsRequired();
            builder.Property(s => s.CompanyName).HasColumnName("CompanyName").IsRequired().HasMaxLength(100);
            builder.Property(s => s.Fax).HasColumnName("Fax");
            builder.Property(s => s.Website).HasColumnName("Website");

            builder.HasOne(a => a.Customer)
                .WithMany(a => a.Suppliers)
                .HasForeignKey(a => a.CustomerId);

            builder.HasMany(a => a.Products)
                .WithOne(a => a.Supplier)
                .HasForeignKey(a => a.SupplierId);

            base.Configure(builder);
        }
    }
}