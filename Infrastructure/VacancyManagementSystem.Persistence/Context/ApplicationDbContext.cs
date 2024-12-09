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
