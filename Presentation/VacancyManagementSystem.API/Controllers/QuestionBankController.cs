using Microsoft.AspNetCore.Mvc;
using VacancyManagementSystem.Application.Services.InternalServices;
using VacancyManagementSystem.Domain.DTOs;
using VacancyManagementSystem.Infrastructure.Services.InternalServices;

namespace VacancyManagementSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuestionBankController : ControllerBase
{
    private readonly IQuestionBankService _questionBankService;

    public QuestionBankController(IQuestionBankService questionBankService)
    {
        _questionBankService = questionBankService;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> AddQuestion([FromBody] CreateQuestionDto questionDto)
    {
        var response = await _questionBankService.AddQuestionAsync(questionDto);

        return StatusCode(response.StatusCode, response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> AddQuestionsToVacancy([FromBody] AddQuestionToVacancyDto dto)
    {
        var response = await _questionBankService.AddQuestionsToVacancyAsync(dto);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateQuestion([FromBody] UpdateQuestionDto dto)
    {
        var response = await _questionBankService.UpdateQuestionAsync(dto);
        return StatusCode(response.StatusCode, response);
    }

    [HttpDelete("[action]")]
    public async Task<IActionResult> DeleteQuestion(int id)
    {
        var response = await _questionBankService.DeleteQuestionAsync(id);
        return StatusCode(response.StatusCode, response);
    }

}
