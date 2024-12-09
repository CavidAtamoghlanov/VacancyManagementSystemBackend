using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VacancyManagementSystem.Application.Services.InternalServices;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class AdminController : ControllerBase
{
    private readonly IVacancyService _vacancyService;
    private readonly IApplicantService _applicantService;
    private readonly IQuestionBankService _questionBankService;

    public AdminController(IVacancyService vacancyService, IApplicantService applicantService, IQuestionBankService questionBankService)
    {
        _vacancyService = vacancyService;
        _applicantService = applicantService;
        _questionBankService = questionBankService;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> AddVacancy([FromBody] AddVacancyDto vacancyDto)
    {
        var response = await _vacancyService.CreateVacancyAsync(vacancyDto);
        return Ok(response);
    }

    [HttpGet("[action]/{id}")]
    public async Task<IActionResult> GetVacancyDetails(int id)
    {
        var response = await _vacancyService.GetVacancyById(id);
        return Ok(response);
    }

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateVacancy([FromBody] UpdateVacancyDto vacancyDto)
    {
        var response = await _vacancyService.UpdateVacancyAsync(vacancyDto);
        return Ok(response);
    }

    [HttpGet("[action]/{applicantId}")]
    public async Task<IActionResult> GetApplicantVacancies(int applicantId)
    {
        var response = await _applicantService.GetApplicantVacanciesAsync(applicantId);
        return StatusCode(response.StatusCode, response);
    }

    [HttpDelete("[action]/{id}")]
    public async Task<IActionResult> DeleteVacancy(int id)
    {
        var response = await _vacancyService.DeleteVacancyAsync(id);
        return Ok(response);
    }

    [HttpPatch("[action]")]
    public async Task<IActionResult> SetVacancyStatus([FromBody] SetVacancyStatusDto vacancyStatusDto)
    {
        var response = await _vacancyService.SetVacancyStatusAsync(vacancyStatusDto);
        return Ok(response);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetApplicants()
    {
        var response = await _applicantService.GetAllApplicantsAsync();
        return Ok(response);
    }

    [HttpGet("[action]/{id}")]
    public async Task<IActionResult> GetApplicantDetails(int id)
    {
        var response = await _applicantService.GetApplicantByIdAsync(id);
        return Ok(response);
    }

    [HttpGet("[action]/{id}")]
    public async Task<IActionResult> DownloadApplicantCV(int id)
    {
        var response = await _applicantService.DownloadApplicantCvAsync(id);

        if (response.StatusCode != 200)
            return StatusCode(response.StatusCode, response.Content);

        var result = response.Content as dynamic;
        var fileName = result?.FileName;
        var fileContent = Convert.FromBase64String(result?.FileContent);

        return File(fileContent, "application/octet-stream", fileName);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> AddQuestion([FromBody] CreateQuestionDto questionDto)
    {
        var response = await _questionBankService.AddQuestionAsync(questionDto);

        return StatusCode(response.StatusCode, response);
    }

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateQuestion([FromBody] UpdateQuestionDto dto)
    {
        var response = await _questionBankService.UpdateQuestionAsync(dto);
        return StatusCode(response.StatusCode, response);
    }

    [HttpDelete("[action]/{id}")]
    public async Task<IActionResult> DeleteQuestion(int id)
    {
        var response = await _questionBankService.DeleteQuestionAsync(id);
        return StatusCode(response.StatusCode, response);
    }

    [HttpGet("[action]/{vacancyId}")]
    public async Task<IActionResult> GetVacancyWithApplicants(int vacancyId)
    {
        var response = await _vacancyService.GetVacancyWithApplicantsAsync(vacancyId);
        return StatusCode(response.StatusCode, response);
    }
    [HttpGet("[action]/{applicantId}/{vacancyId}")]
    public async Task<IActionResult> GetApplicantAnswersForVacancy(int applicantId, int vacancyId)
    {
        var response = await _applicantService.GetApplicantAnswersForVacancyAsync(applicantId, vacancyId);
        return StatusCode(response.StatusCode, response);
    }

}
