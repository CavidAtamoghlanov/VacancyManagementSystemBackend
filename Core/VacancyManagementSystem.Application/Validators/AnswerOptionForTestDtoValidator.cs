using FluentValidation;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.Application.Validators;

public class AnswerOptionForTestDtoValidator : AbstractValidator<AnswerOptionFortestDto>
{
    public AnswerOptionForTestDtoValidator()
    {
        RuleFor(x => x.AnswerOptionId)
            .GreaterThan(0).WithMessage("AnswerOptionId must be greater than 0.");

        RuleFor(x => x.OptionText)
            .NotEmpty().WithMessage("OptionText is required.")
            .MaximumLength(250).WithMessage("OptionText cannot exceed 250 characters.");
    }
}
