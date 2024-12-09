namespace VacancyManagementSystem.Domain.DTOs;

public class VacancyApplicantDetailsDto
{
    public int ApplicantId { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public double TestScore { get; set; }
}
