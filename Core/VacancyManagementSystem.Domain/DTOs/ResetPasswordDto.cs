﻿namespace VacancyManagementSystem.Domain.DTOs;

public class ResetPasswordDto
{
    public string Email { get; set; }
    public string Token { get; set; }  
    public string Password { get; set; }  
    public string ComfirmPassword { get; set; }  
}