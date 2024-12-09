using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VacancyManagementSystem.Domain.Entities.Concretes;
using System.Reflection.Emit;

namespace VacancyManagementSystem.Persistence.Configurations;

public class QuestionBankConfiguration : IEntityTypeConfiguration<QuestionBank>
{
    public void Configure(EntityTypeBuilder<QuestionBank> builder)
    {
        builder.ToTable("QuestionBanks");

        builder.HasKey(x => x.Id);

        builder.Property(qb => qb.QuestionText)
            .IsRequired()
            .HasMaxLength(500);

        builder.HasOne(qb => qb.Category)
            .WithMany(c => c.QuestionBanks)
            .HasForeignKey(qb => qb.CategoryId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(qb => qb.AnswerOptions)
            .WithOne(a => a.QuestionBank)
            .HasForeignKey(a => a.QuestionBankId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(
new QuestionBank { Id = 1, QuestionText = "What is C#?", CategoryId = 1 },
new QuestionBank { Id = 2, QuestionText = "Explain polymorphism.", CategoryId = 1 },
new QuestionBank { Id = 3, QuestionText = "What is a balance sheet?", CategoryId = 2 },
new QuestionBank { Id = 4, QuestionText = "Define ROI.", CategoryId = 2 },
new QuestionBank { Id = 5, QuestionText = "What is SEO?", CategoryId = 3 },
new QuestionBank { Id = 6, QuestionText = "What is a target audience?", CategoryId = 3 },
new QuestionBank { Id = 7, QuestionText = "What is hypertension?", CategoryId = 4 },
new QuestionBank { Id = 8, QuestionText = "What is CPR?", CategoryId = 4 },
new QuestionBank { Id = 9, QuestionText = "What is pedagogy?", CategoryId = 5 },
new QuestionBank { Id = 10, QuestionText = "Explain lesson planning.", CategoryId = 5 }
);
    }
}