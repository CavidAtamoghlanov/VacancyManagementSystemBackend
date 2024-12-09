namespace VacancyManagementSystem.Domain.DTOs;

public class UpdateQuestionDto
{
    public int Id { get; set; }  
    public string QuestionText { get; set; }
    public int CategoryId { get; set; }
}
