using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VacancyManagementSystem.Domain.Entities.Concretes;
using System.Reflection.Emit;

namespace VacancyManagementSystem.Persistence.Configurations;


public class ApplicantConfiguration : IEntityTypeConfiguration<Applicant>
{
    public void Configure(EntityTypeBuilder<Applicant> builder)
    {
        builder.ToTable("Applicants");

        builder.HasKey(x => x.Id);

        builder.Property(a => a.TestScore).IsRequired();
        builder.Property(a => a.CVPath).HasMaxLength(500);

        builder.Property(a => a.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.Email)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(a => a.PhoneNumber)
            .HasMaxLength(15);

        builder.Ignore(a => a.FullName);


        builder.HasOne(x => x.Vacancy)
            .WithMany(v => v.Applicants)
            .HasForeignKey(x => x.VacancyId)
            .OnDelete(DeleteBehavior.NoAction);

      builder.HasData(
new Applicant { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "+123456789", TestScore = 85, CVPath = "cv1.pdf", VacancyId = 1, UserId = 1 },
new Applicant { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", PhoneNumber = "+987654321", TestScore = 90, CVPath = "cv2.pdf", VacancyId = 1, UserId = 2 },
new Applicant { Id = 3, FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@example.com", PhoneNumber = "+234567891", TestScore = 78, CVPath = "cv3.pdf", VacancyId = 2, UserId = 3 },
new Applicant { Id = 4, FirstName = "Alice", LastName = "Brown", Email = "alice.brown@example.com", PhoneNumber = "+345678912", TestScore = 88, CVPath = "cv4.pdf", VacancyId = 2, UserId = 4 },
new Applicant { Id = 5, FirstName = "Charlie", LastName = "Davis", Email = "charlie.davis@example.com", PhoneNumber = "+456789123", TestScore = 95, CVPath = "cv5.pdf", VacancyId = 3, UserId = 5 },
new Applicant { Id = 6, FirstName = "Emily", LastName = "Clark", Email = "emily.clark@example.com", PhoneNumber = "+567891234", TestScore = 70, CVPath = "cv6.pdf", VacancyId = 4, UserId = 6 },
new Applicant { Id = 7, FirstName = "Daniel", LastName = "Harris", Email = "daniel.harris@example.com", PhoneNumber = "+678912345", TestScore = 85, CVPath = "cv7.pdf", VacancyId = 5, UserId = 7 },
new Applicant { Id = 8, FirstName = "Sophia", LastName = "Martinez", Email = "sophia.martinez@example.com", PhoneNumber = "+789123456", TestScore = 82, CVPath = "cv8.pdf", VacancyId = 6, UserId = 8 },
new Applicant { Id = 9, FirstName = "Liam", LastName = "Anderson", Email = "liam.anderson@example.com", PhoneNumber = "+891234567", TestScore = 77, CVPath = "cv9.pdf", VacancyId = 7, UserId = 9 },
new Applicant { Id = 10, FirstName = "Olivia", LastName = "Lee", Email = "olivia.lee@example.com", PhoneNumber = "+912345678", TestScore = 92, CVPath = "cv10.pdf", VacancyId = 8, UserId = 10 }
);
    }
}
