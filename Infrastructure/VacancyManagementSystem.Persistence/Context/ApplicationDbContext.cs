using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using VacancyManagementSystem.Domain.Entities.Abstacts;
using VacancyManagementSystem.Domain.Entities.Concretes;

namespace VacancyManagementSystem.Persistence.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            // Seed Datas
            modelBuilder.Entity<Category>().HasData(
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

            modelBuilder.Entity<Vacancy>().HasData(
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


            modelBuilder.Entity<QuestionBank>().HasData(
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


            modelBuilder.Entity<AnswerOption>().HasData(
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

            modelBuilder.Entity<Applicant>().HasData(
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

            modelBuilder.Entity<VacancyQuestion>().HasData(
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

            modelBuilder.Entity<TestAnswer>().HasData(
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

            modelBuilder.Entity<ApplicationUser>().HasData(
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

            modelBuilder.Entity<ApplicationRole>().HasData(
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


            // Seed Datas

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        private void UpdateAuditFields(EntityState state)
        {
            var entries = ChangeTracker.Entries()
                                       .Where(e => e.Entity is IBaseEntity<int> &&
                                                   (e.State == EntityState.Added || e.State == EntityState.Modified))
                                       .ToList();

            var currentUtcDate = DateTime.UtcNow;

            foreach (var entry in entries)
            {
                var entity = (IBaseEntity<int>)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedDate = currentUtcDate;
                }

                entity.ModifiedDate = currentUtcDate;

                if (entry.State == EntityState.Modified && entity.IsDeleted)
                {
                    entity.IsDeleted = true;
                }
            }
        }

        public override int SaveChanges()
        {
            UpdateAuditFields(EntityState.Modified);
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateAuditFields(EntityState.Modified);
            return await base.SaveChangesAsync(cancellationToken);
        }

        // DbSet-lər
        public DbSet<AnswerOption> AnswerOptions { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<VacancyQuestion> VacancyQuestions { get; set; }
        public DbSet<QuestionBank> QuestionBanks { get; set; }
        public DbSet<TestAnswer> TestAnswers { get; set; }
    }
}
