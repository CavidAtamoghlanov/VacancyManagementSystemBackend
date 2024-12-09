using Microsoft.Extensions.DependencyInjection;
using VacancyManagementSystem.Application.Mappings;
using VacancyManagementSystem.Application.Services.ExternalServices;
using VacancyManagementSystem.Application.Services.InternalServices;
using VacancyManagementSystem.Infrastructure.Services.ExternalServices;
using VacancyManagementSystem.Infrastructure.Services.InternalServices;

namespace VacancyManagementSystem.Infrastructure;

public static class ServiceRegistration
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IVacancyService, VacancyService>();
        services.AddScoped<IAnswerOptionService, AnswerOptionService>();
        services.AddScoped<IApplicantService, ApplicantService>();
        services.AddScoped<ITestService, TestService>();
        services.AddScoped<IVacancyQuestionService, VacancyQuestionService>();
        services.AddScoped<IMailService,MailService>();

        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ICategoryService, CategoryService>();

    }
}