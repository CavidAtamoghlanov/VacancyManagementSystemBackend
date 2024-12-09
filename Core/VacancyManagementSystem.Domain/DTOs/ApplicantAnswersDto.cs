
namespace VacancyManagementSystem.Domain.DTOs;

public class ApplicantAnswersDto
{
    public int ApplicantId { get; set; } 
    public List<AnswerOfApplicantDto> Answers { get; set; } 
}