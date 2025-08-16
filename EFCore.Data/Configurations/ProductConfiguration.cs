using EFCore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Data.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Id).ValueGeneratedOnAdd();

        builder.HasOne(p => p.User)
            .WithMany(u => u.Products)  
            .HasForeignKey(p => p.UserId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
