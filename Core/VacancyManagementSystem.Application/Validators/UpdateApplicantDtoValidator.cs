using FluentValidation;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.Application.Validators;

public class UpdateApplicantDtoValidator : AbstractValidator<UpdateApplicantDto>
{
    public UpdateApplicantDtoValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0).WithMessage("Id must be greater than 0.");

        RuleFor(x => x.TestScore)
            .InclusiveBetween(0, 100).WithMessage("TestScore must be between 0 and 100.");

        RuleFor(x => x.CVPath)
            .NotEmpty().WithMessage("CVPath is required.")
            .Must(x => x.EndsWith(".pdf") || x.EndsWith(".doc") || x.EndsWith(".docx"))
            .WithMessage("CVPath must be a valid document (PDF, DOC, or DOCX).");

        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("FirstName is required.")
            .MaximumLength(50).WithMessage("FirstName cannot exceed 50 characters.");

        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("LastName is required.")
            .MaximumLength(50).WithMessage("LastName cannot exceed 50 characters.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Email must be a valid email address.");
    }
}