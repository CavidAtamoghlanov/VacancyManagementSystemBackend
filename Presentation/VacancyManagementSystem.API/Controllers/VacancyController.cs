﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VacancyManagementSystem.Application.Services.InternalServices;
using VacancyManagementSystem.Domain.DTOs;
using VacancyManagementSystem.Infrastructure.Services.InternalServices;

namespace VacancyManagementSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VacancyController : ControllerBase
{
    private readonly IVacancyService _vacancyService;

    public VacancyController(IVacancyService vacancyService)
    {
        _vacancyService = vacancyService;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateVacancy([FromBody] AddVacancyDto vacancyDto)
    {
        var response = await _vacancyService.CreateVacancyAsync(vacancyDto);
        return Ok(response);
    }

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateVacancy([FromBody] UpdateVacancyDto vacancyDto)
    {
        var response = await _vacancyService.UpdateVacancyAsync(vacancyDto);
        return Ok(response);
    }


    [HttpGet("[action]/{id}")]
    public async Task<IActionResult> GetVacancyByid(int id)
    {
        var response = await _vacancyService.GetVacancyById(id);
        return Ok(response);
    }

    [HttpGet("[action]/{id}")]
    public async Task<IActionResult> DeleteVacancy(int id)
    {
        var response = await _vacancyService.DeleteVacancyAsync(id);
        return Ok(response);
    }

    //[Authorize]
    [HttpGet("[action]")]
    public async Task<IActionResult> GetVacancies()
    {
        var response = await _vacancyService.GetVacanciesAsync();
        return Ok(response);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetActiveVacancies()
    {
        var response = await _vacancyService.GetActiveVacanciesAsync();
        return Ok(response);
    }

    [HttpGet("[action]/{vacancyId}")]
    public async Task<IActionResult> GetVacancyWithApplicants(int vacancyId)
    {
        var response = await _vacancyService.GetVacancyWithApplicantsAsync(vacancyId);
        return StatusCode(response.StatusCode, response);
    }


    [HttpPost("[action]")]
    public async Task<IActionResult> SetVacancyStatus([FromBody] SetVacancyStatusDto vacancyStatusDto)
    {
        var response = await _vacancyService.SetVacancyStatusAsync(vacancyStatusDto);
        return Ok(response);
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> FilterVacancies([FromBody] FilterVacancyDto filterDto)
    {
        var result = await _vacancyService.FilterVacanciesAsync(filterDto);
        return Ok(result);
    }

    [HttpGet("[action]/{id}")]
    public async Task<IActionResult> GetVacancyQuestionsWithAnswers(int id)
    {
        var response = await _vacancyService.GetVacancyQuestionsWithAnswersAsync(id);
        return Ok(response);
    }

    [HttpGet("[action]/{id}")]
    public async Task<IActionResult> ToggleVacancyStatus(int id)
    {
        var response = await _vacancyService.ToggleVacancyStatusAsync(id);
        return Ok(response);
    }
}
