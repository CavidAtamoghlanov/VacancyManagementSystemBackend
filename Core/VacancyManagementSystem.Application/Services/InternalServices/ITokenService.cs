using VacancyManagementSystem.Domain.Entities.Concretes;

namespace VacancyManagementSystem.Application.Services.InternalServices;

public interface ITokenService
{
    string GenerateAccessToken(ApplicationUser user);
}