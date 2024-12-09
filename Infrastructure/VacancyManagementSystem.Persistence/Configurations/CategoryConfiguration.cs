using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VacancyManagementSystem.Domain.Entities.Concretes;

namespace VacancyManagementSystem.Persistence.Configurations;
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");

        builder.HasKey(x => x.Id);

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(c => c.Description)
            .HasMaxLength(500);

        builder.HasMany(x => x.Vacancies)
            .WithOne(v => v.Category)
            .HasForeignKey(v => v.CategoryId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(x => x.QuestionBanks)
            .WithOne(qb => qb.Category)
            .HasForeignKey(qb => qb.CategoryId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(
                      new Category { Id = 1, Name = "IT", Description = "Information Technology", CreatedDate = DateTime.Now },
                      new Category { Id = 2, Name = "Finance", Description = "Financial Services", CreatedDate = DateTime.Now },
                      new Category { Id = 3, Name = "Marketing", Description = "Marketing and Advertising", CreatedDate = DateTime.Now },
                      new Category { Id = 4, Name = "Healthcare", Description = "Healthcare Services", CreatedDate = DateTime.Now },
                      new Category { Id = 5, Name = "Education", Description = "Educational Services", CreatedDate = DateTime.Now },
                      new Category { Id = 6, Name = "Engineering", Description = "Engineering Services", CreatedDate = DateTime.Now },
                      new Category { Id = 7, Name = "Retail", Description = "Retail and Sales", CreatedDate = DateTime.Now },
                      new Category { Id = 8, Name = "Construction", Description = "Construction and Real Estate", CreatedDate = DateTime.Now },
                      new Category { Id = 9, Name = "Design", Description = "Design and Creative Arts", CreatedDate = DateTime.Now },
                      new Category { Id = 10, Name = "Logistics", Description = "Logistics and Transportation", CreatedDate = DateTime.Now }
                  );
    }
}