using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VacancyManagementSystem.Domain.Entities.Concretes;

namespace VacancyManagementSystem.Persistence.Configurations;

public class VacancyConfiguration : IEntityTypeConfiguration<Vacancy>
{
    public void Configure(EntityTypeBuilder<Vacancy> builder)
    {
        builder.ToTable("Vacancies");

        builder.HasKey(x => x.Id);

        builder.Property(v => v.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(v => v.Description)
            .HasMaxLength(1000);

        builder.Property(v => v.StartDate)
            .IsRequired();

        builder.Property(v => v.EndDate)
            .IsRequired();

        builder.HasOne(x => x.Category)
            .WithMany(c => c.Vacancies)
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(x => x.VacancyQuestions)
            .WithOne(q => q.Vacancy)
            .HasForeignKey(q => q.VacancyId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(x => x.Applicants)
            .WithOne(a => a.Vacancy)
            .HasForeignKey(a => a.VacancyId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(
new Vacancy { Id = 1, Title = "Junior Developer", Description = "Entry level IT position", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), IsActive = true, QuestionCount = 10, CategoryId = 1 },
new Vacancy { Id = 2, Title = "Senior Developer", Description = "Advanced IT position", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), IsActive = true, QuestionCount = 15, CategoryId = 1 },
new Vacancy { Id = 3, Title = "Financial Analyst", Description = "Analyze financial data", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), IsActive = true, QuestionCount = 8, CategoryId = 2 },
new Vacancy { Id = 4, Title = "Marketing Manager", Description = "Manage marketing campaigns", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), IsActive = true, QuestionCount = 12, CategoryId = 3 },
new Vacancy { Id = 5, Title = "Nurse", Description = "Provide healthcare services", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), IsActive = true, QuestionCount = 5, CategoryId = 4 },
new Vacancy { Id = 6, Title = "Teacher", Description = "Teach students", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), IsActive = true, QuestionCount = 6, CategoryId = 5 },
new Vacancy { Id = 7, Title = "Mechanical Engineer", Description = "Engineering role", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), IsActive = true, QuestionCount = 7, CategoryId = 6 },
new Vacancy { Id = 8, Title = "Sales Manager", Description = "Manage sales team", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), IsActive = true, QuestionCount = 9, CategoryId = 7 },
new Vacancy { Id = 9, Title = "Architect", Description = "Design buildings", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), IsActive = true, QuestionCount = 10, CategoryId = 8 },
new Vacancy { Id = 10, Title = "Logistics Coordinator", Description = "Coordinate logistics", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1), IsActive = true, QuestionCount = 8, CategoryId = 10 }
);
    }
}
