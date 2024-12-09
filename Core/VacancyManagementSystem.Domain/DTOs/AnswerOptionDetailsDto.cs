namespace VacancyManagementSystem.Domain.DTOs;

public class AnswerOptionDetailsDto
{
    public int AnswerOptionId { get; set; }
    public string OptionText { get; set; }
    public bool IsCorrect { get; set; }
    public bool? ApplicantAnswer { get; set; }
}

