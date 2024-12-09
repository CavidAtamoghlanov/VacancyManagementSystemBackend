namespace VacancyManagementSystem.Domain.DTOs;

public class AddQuestionToVacancyDto
{
    public int VacancyId { get; set; }
    public List<int> QuestionIds { get; set; }
}