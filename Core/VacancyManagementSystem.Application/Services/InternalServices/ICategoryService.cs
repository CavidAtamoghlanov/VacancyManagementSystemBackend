
using VacancyManagementSystem.Application.Responses;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.Application.Services.InternalServices;

public interface ICategoryService
{
    Task<Response> CreateCategoryAsync(AddCategoryDto categoryDto);
    Task<Response> UpdateCategoryAsync(UpdateCategoryDto categoryDto);
    Task<Response> DeleteCategoryAsync(int id);
    Task<Response> GetCategoriesAsync();
    Task<Response> GetCategoryById(int id);
}
