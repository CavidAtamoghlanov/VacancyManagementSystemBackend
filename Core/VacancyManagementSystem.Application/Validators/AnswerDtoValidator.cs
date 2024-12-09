using FluentValidation;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.Application.Validators;

public class AnswerDtoValidator : AbstractValidator<AnswerDto>
{
    public AnswerDtoValidator()
    {
        RuleFor(x => x.QuestionId)
            .GreaterThan(0).WithMessage("QuestionId must be greater than 0.");

        RuleFor(x => x.SelectedOption)
            .NotEmpty().WithMessage("SelectedOption is required.")
            .MaximumLength(100).WithMessage("SelectedOption cannot exceed 100 characters.");
    }
}