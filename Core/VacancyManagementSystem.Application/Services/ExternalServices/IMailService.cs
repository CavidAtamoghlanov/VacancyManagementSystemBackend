using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.Application.Services.ExternalServices;

public interface IMailService
{
    Task<bool> SendMail(SendMailDTO _dto);
}
