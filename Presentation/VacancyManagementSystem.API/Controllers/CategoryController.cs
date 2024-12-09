using Microsoft.AspNetCore.Mvc;
using VacancyManagementSystem.Application.Services.InternalServices;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateCategory([FromBody] AddCategoryDto categoryDto)
    {
        var response = await _categoryService.CreateCategoryAsync(categoryDto);
        return Ok(response);
    }

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryDto categoryDto)
    {
        var response = await _categoryService.UpdateCategoryAsync(categoryDto);
        return Ok(response);
    }

    [HttpGet("[action]/{id}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
        var response = await _categoryService.GetCategoryById(id);
        return Ok(response);
    }

    [HttpGet("[action]/{id}")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        var response = await _categoryService.DeleteCategoryAsync(id);
        return Ok(response);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetCategories()
    {
        var response = await _categoryService.GetCategoriesAsync();
        return Ok(response);
    }
}
