using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VacancyManagementSystem.Domain.Entities.Concretes;
using System.Reflection.Emit;

namespace VacancyManagementSystem.Persistence.Configurations;

public class VacancyQuestionConfiguration : IEntityTypeConfiguration<VacancyQuestion>
{
    public void Configure(EntityTypeBuilder<VacancyQuestion> builder)
    {
        builder.ToTable("VacancyQuestions");

        builder.HasKey(x => x.Id);

 

        builder.HasOne(vq => vq.Vacancy)
            .WithMany(v => v.VacancyQuestions)
            .HasForeignKey(vq => vq.VacancyId)
            .OnDelete(DeleteBehavior.NoAction);

      builder.HasData(
new VacancyQuestion { Id = 1, VacancyId = 1, QuestionBankId = 1 },
new VacancyQuestion { Id = 2, VacancyId = 1, QuestionBankId = 2 },
new VacancyQuestion { Id = 3, VacancyId = 2, QuestionBankId = 1 },
new VacancyQuestion { Id = 4, VacancyId = 2, QuestionBankId = 3 },
new VacancyQuestion { Id = 5, VacancyId = 3, QuestionBankId = 3 },
new VacancyQuestion { Id = 6, VacancyId = 3, QuestionBankId = 4 },
new VacancyQuestion { Id = 7, VacancyId = 4, QuestionBankId = 5 },
new VacancyQuestion { Id = 8, VacancyId = 5, QuestionBankId = 7 },
new VacancyQuestion { Id = 9, VacancyId = 6, QuestionBankId = 9 },
new VacancyQuestion { Id = 10, VacancyId = 7, QuestionBankId = 6 }
);
    }
}