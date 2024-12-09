namespace VacancyManagementSystem.Domain.DTOs;

public class GetApplicantDto
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public int VacancyId { get; set; }
    public double TestScore { get; set; }
    public string CVPath { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string FullName => $"{FirstName} {LastName}";
}