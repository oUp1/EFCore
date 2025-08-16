using EFCore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCore.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Id).ValueGeneratedOnAdd();

        builder.Property(u => u.FirstName).IsRequired().HasMaxLength(100);
        builder.Property(u => u.LastName).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Email).IsRequired().HasMaxLength(255);
        builder.Property(u => u.Password).IsRequired().HasMaxLength(255);
        builder.Property(u => u.Username).IsRequired().HasMaxLength(100);
        builder.Property(u => u.PhoneNumber).IsRequired().HasMaxLength(20);
        builder.Property(u => u.Address).IsRequired().HasMaxLength(255);
        builder.Property(u => u.City).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Region).IsRequired().HasMaxLength(100);
        builder.Property(u => u.PostalCode).IsRequired().HasMaxLength(20);
        builder.Property(u => u.Country).IsRequired().HasMaxLength(100);
    }
}
