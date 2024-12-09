using FluentValidation;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.Application.Validators;

public class AddVacancyDtoValidator : AbstractValidator<AddVacancyDto>
{
    public AddVacancyDtoValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required.")
            .MaximumLength(100).WithMessage("Title cannot exceed 100 characters.");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description is required.")
            .MaximumLength(500).WithMessage("Description cannot exceed 500 characters.");

        RuleFor(x => x.StartDate)
            .LessThanOrEqualTo(x => x.EndDate)
            .WithMessage("StartDate must be before or equal to EndDate.");

        RuleFor(x => x.EndDate)
            .GreaterThanOrEqualTo(DateTime.Now)
            .WithMessage("EndDate must not be in the past.");

        RuleFor(x => x.CategoryId)
            .GreaterThan(0).WithMessage("CategoryId must be greater than 0.");

        RuleFor(x => x.QuestionCount)
            .GreaterThanOrEqualTo(0).WithMessage("QuestionCount must be zero or greater.");
    }
}