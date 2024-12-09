namespace VacancyManagementSystem.Domain.DTOs;

public class QuestionDetailsDto
{
    public int QuestionId { get; set; }
    public string QuestionText { get; set; }
    public List<AnswerOptionDetailsDto> AnswerOptions { get; set; }
}
