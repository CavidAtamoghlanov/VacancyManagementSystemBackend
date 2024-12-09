using FluentValidation;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.Application.Validators;

public class UpdateQuestionDtoValidator : AbstractValidator<UpdateQuestionDto>
{
    public UpdateQuestionDtoValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0).WithMessage("Id must be greater than 0.");

        RuleFor(x => x.QuestionText)
            .NotEmpty().WithMessage("QuestionText is required.")
            .MaximumLength(500).WithMessage("QuestionText cannot exceed 500 characters.");

        RuleFor(x => x.CategoryId)
            .GreaterThan(0).WithMessage("CategoryId must be greater than 0.");
    }
}