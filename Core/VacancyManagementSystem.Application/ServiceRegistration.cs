using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using VacancyManagementSystem.Application.Mappings;
using VacancyManagementSystem.Application.Mappings.Abstracts;
using VacancyManagementSystem.Application.Mappings.Concretes;
using VacancyManagementSystem.Application.Validators;

namespace VacancyManagementSystem.Application;

public static class ServiceRegistration
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IAutoMapperConfiguration, AutoMapperConfiguration>();
        services.AddControllers()
                .AddFluentValidation(fv =>
                {
                    fv.RegisterValidatorsFromAssemblyContaining<AddApplicantDtoValidator>();
                });
    }
}