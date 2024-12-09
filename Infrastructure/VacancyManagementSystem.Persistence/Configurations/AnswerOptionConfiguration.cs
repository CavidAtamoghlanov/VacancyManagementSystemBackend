using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VacancyManagementSystem.Domain.Entities.Concretes;
using System.Reflection.Emit;

namespace VacancyManagementSystem.Persistence.Configurations;


public class AnswerOptionConfiguration : IEntityTypeConfiguration<AnswerOption>
{
    public void Configure(EntityTypeBuilder<AnswerOption> builder)
    {
        builder.ToTable("AnswerOptions");

        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.QuestionBank)
            .WithMany(q => q.AnswerOptions)
            .HasForeignKey(x => x.QuestionBankId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(x => x.OptionText)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(x => x.IsCorrect)
        .IsRequired();

       builder.HasData(
new AnswerOption { Id = 1, OptionText = "A programming language", IsCorrect = true, QuestionBankId = 1 },
new AnswerOption { Id = 2, OptionText = "A database", IsCorrect = false, QuestionBankId = 1 },
new AnswerOption { Id = 3, OptionText = "The ability to take many forms", IsCorrect = true, QuestionBankId = 2 },
new AnswerOption { Id = 4, OptionText = "A type of inheritance", IsCorrect = false, QuestionBankId = 2 },
new AnswerOption { Id = 5, OptionText = "A financial statement", IsCorrect = true, QuestionBankId = 3 },
new AnswerOption { Id = 6, OptionText = "A legal document", IsCorrect = false, QuestionBankId = 3 },
new AnswerOption { Id = 7, OptionText = "Return on Investment", IsCorrect = true, QuestionBankId = 4 },
new AnswerOption { Id = 8, OptionText = "Rate of Increase", IsCorrect = false, QuestionBankId = 4 },
new AnswerOption { Id = 9, OptionText = "Search Engine Optimization", IsCorrect = true, QuestionBankId = 5 },
new AnswerOption { Id = 10, OptionText = "Social Engagement Online", IsCorrect = false, QuestionBankId = 5 }
);
    }
}