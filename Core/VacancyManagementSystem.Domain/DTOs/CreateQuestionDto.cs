namespace VacancyManagementSystem.Domain.DTOs;

public class CreateQuestionDto
{
    public string QuestionText { get; set; }
    public int CategoryId { get; set; }
    public List<CreateAnswerOptionDto> AnswerOptions { get; set; }
}
