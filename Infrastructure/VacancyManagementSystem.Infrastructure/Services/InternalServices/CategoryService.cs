using VacancyManagementSystem.Application;
using VacancyManagementSystem.Application.Mappings.Abstracts;
using VacancyManagementSystem.Application.Responses;
using VacancyManagementSystem.Application.Services.InternalServices;
using VacancyManagementSystem.Domain.DTOs;
using VacancyManagementSystem.Domain.Entities.Concretes;
using VacancyManagementSystem.Infrastructure.Services.Commons;

namespace VacancyManagementSystem.Infrastructure.Services.InternalServices;

public class CategoryService : BaseService, ICategoryService
{
    public CategoryService(IUnitOfWork unitOfWork, IAutoMapperConfiguration autoMapper) : base(unitOfWork, autoMapper)
    {
    }

    public async Task<Response> CreateCategoryAsync(AddCategoryDto categoryDto)
    {
        var category = _autoMapper.Map<Category, AddCategoryDto>(categoryDto);

        var categoryRepository = _unitOfWork.GetRepository<Category, int>();
        await categoryRepository.AddAsync(category);
        await _unitOfWork.Commit();

        return Success("Category successfully created.");
    }

    public async Task<Response> DeleteCategoryAsync(int id)
    {
        var categoryRepository = _unitOfWork.GetRepository<Category, int>();
        var category = await categoryRepository.GetByIdAsync(id);

        if (category == null)
            return NotFound("Category not found.");

        categoryRepository.Delete(category);
        await _unitOfWork.Commit();

        return Success("Category successfully deleted.");
    }

    public async Task<Response> GetCategoriesAsync()
    {
        var categoryRepository = _unitOfWork.GetRepository<Category, int>();
        var categories = (await categoryRepository.GetAllAsync()).ToList();

        if (!categories.Any())
            return NotFound("No categories found.");

        var categoryDtos = _autoMapper.Map<GetCategoryDto, Category>(categories);
        return Success(categoryDtos);
    }

    public async Task<Response> GetCategoryById(int id)
    {
        var categoryRepository = _unitOfWork.GetRepository<Category, int>();
        var category = await categoryRepository.GetByIdAsync(id);

        if (category == null)
            return NotFound("Category not found.");

        var categoryDto = _autoMapper.Map<GetCategoryDto, Category>(category);
        return Success(categoryDto);
    }

    public async Task<Response> UpdateCategoryAsync(UpdateCategoryDto categoryDto)
    {
        var categoryRepository = _unitOfWork.GetRepository<Category, int>();
        var category = await categoryRepository.GetByIdAsync(categoryDto.Id);

        if (category == null)
            return NotFound("Category not found.");

        category.Name = categoryDto.Name;
        category.Description = categoryDto.Description;

        categoryRepository.Update(category);
        await _unitOfWork.Commit();

        return Success("Category successfully updated.");
    }
}
