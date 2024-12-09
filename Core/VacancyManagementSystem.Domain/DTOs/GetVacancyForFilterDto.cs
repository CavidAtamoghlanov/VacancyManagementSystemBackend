﻿namespace VacancyManagementSystem.Domain.DTOs;

public class GetVacancyForFilterDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Location { get; set; }
    public string Category { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
}