using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VacancyManagementSystem.Domain.Entities.Concretes;
using System.Reflection.Emit;

namespace VacancyManagementSystem.Persistence.Configurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.ToTable("ApplicationUsers");

        builder.HasKey(x => x.Id);

        builder.Property(u => u.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.PhoneNumber)
        .HasMaxLength(15);

        builder.HasData(
new ApplicationUser { Id = 1, FirstName = "Admin", LastName = "User", Email = "admin@example.com", PhoneNumber = "+123456789" },
new ApplicationUser { Id = 2, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "+987654321" },
new ApplicationUser { Id = 3, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", PhoneNumber = "+234567891" },
new ApplicationUser { Id = 4, FirstName = "Alice", LastName = "Brown", Email = "alice.brown@example.com", PhoneNumber = "+345678912" },
new ApplicationUser { Id = 5, FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@example.com", PhoneNumber = "+456789123" },
new ApplicationUser { Id = 6, FirstName = "Charlie", LastName = "Davis", Email = "charlie.davis@example.com", PhoneNumber = "+567891234" },
new ApplicationUser { Id = 7, FirstName = "Emily", LastName = "Clark", Email = "emily.clark@example.com", PhoneNumber = "+678912345" },
new ApplicationUser { Id = 8, FirstName = "Daniel", LastName = "Harris", Email = "daniel.harris@example.com", PhoneNumber = "+789123456" },
new ApplicationUser { Id = 9, FirstName = "Sophia", LastName = "Martinez", Email = "sophia.martinez@example.com", PhoneNumber = "+891234567" },
new ApplicationUser { Id = 10, FirstName = "Liam", LastName = "Anderson", Email = "liam.anderson@example.com", PhoneNumber = "+912345678" }
);
    }
}