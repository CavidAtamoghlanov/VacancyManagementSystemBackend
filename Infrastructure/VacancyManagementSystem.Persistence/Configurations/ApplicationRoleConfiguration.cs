using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VacancyManagementSystem.Domain.Entities.Concretes;

namespace VacancyManagementSystem.Persistence.Configurations;

public class ApplicationRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
{
    public void Configure(EntityTypeBuilder<ApplicationRole> builder)
    {
        builder.ToTable("ApplicationRoles");

        builder.HasKey(x => x.Id);

        builder.Property(r => r.Role)
            .IsRequired()
        .HasMaxLength(100);

        builder.HasData(
new ApplicationRole
{
    Id = 1,
    Role = "Admin",
    Name = "Admin",
    NormalizedName = "ADMIN",
    CreatedDate = DateTime.Now,
    IsDeleted = false
},
new ApplicationRole
{
    Id = 2,
    Role = "User",
    Name = "User",
    NormalizedName = "USER",
    CreatedDate = DateTime.Now,
    IsDeleted = false
}
);
    }
}