using VacancyManagementSystem.Application.Responses;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.Application.Services.InternalServices;

public interface IQuestionBankService
{
    Task<Response> AddQuestionAsync(CreateQuestionDto questionDto);
    Task<Response> AddQuestionsToVacancyAsync(AddQuestionToVacancyDto dto);
    Task<Response> UpdateQuestionAsync(UpdateQuestionDto dto);
    Task<Response> DeleteQuestionAsync(int id);
}
