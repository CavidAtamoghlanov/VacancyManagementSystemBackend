using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VacancyManagementSystem.Domain.Entities.Concretes;
using System.Reflection.Emit;

namespace VacancyManagementSystem.Persistence.Configurations;
public class TestAnswerConfiguration : IEntityTypeConfiguration<TestAnswer>
{
    public void Configure(EntityTypeBuilder<TestAnswer> builder)
    {
        builder.ToTable("TestAnswers");

        builder.HasKey(x => x.Id);

        builder.Property(ta => ta.IsCorrect)
            .IsRequired();

        builder.HasOne(ta => ta.Applicant)
            .WithMany(a => a.TestAnswers)
            .HasForeignKey(ta => ta.ApplicantId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasData(
new TestAnswer { Id = 1, ApplicantId = 1, VacancyQuestionId = 1, AnswerOptionId = 1, IsCorrect = true },
new TestAnswer { Id = 2, ApplicantId = 1, VacancyQuestionId = 2, AnswerOptionId = 3, IsCorrect = true },
new TestAnswer { Id = 3, ApplicantId = 2, VacancyQuestionId = 1, AnswerOptionId = 1, IsCorrect = true },
new TestAnswer { Id = 4, ApplicantId = 2, VacancyQuestionId = 2, AnswerOptionId = 4, IsCorrect = false },
new TestAnswer { Id = 5, ApplicantId = 3, VacancyQuestionId = 3, AnswerOptionId = 1, IsCorrect = true },
new TestAnswer { Id = 6, ApplicantId = 3, VacancyQuestionId = 4, AnswerOptionId = 5, IsCorrect = true },
new TestAnswer { Id = 7, ApplicantId = 4, VacancyQuestionId = 4, AnswerOptionId = 5, IsCorrect = true },
new TestAnswer { Id = 8, ApplicantId = 5, VacancyQuestionId = 5, AnswerOptionId = 7, IsCorrect = true },
new TestAnswer { Id = 9, ApplicantId = 6, VacancyQuestionId = 6, AnswerOptionId = 9, IsCorrect = true },
new TestAnswer { Id = 10, ApplicantId = 7, VacancyQuestionId = 7, AnswerOptionId = 10, IsCorrect = false }
);
    }
}