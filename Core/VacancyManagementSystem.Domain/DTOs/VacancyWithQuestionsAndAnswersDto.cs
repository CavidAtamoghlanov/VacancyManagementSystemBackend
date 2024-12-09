namespace VacancyManagementSystem.Domain.DTOs;

public class VacancyWithQuestionsAndAnswersDto
{
    public VacancyDetailsDto VacancyDetails { get; set; }
    public List<QuestionDetailsDto> Questions { get; set; }
}

