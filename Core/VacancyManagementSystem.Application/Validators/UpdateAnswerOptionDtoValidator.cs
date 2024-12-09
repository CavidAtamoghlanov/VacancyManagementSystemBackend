using FluentValidation;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.Application.Validators;

public class UpdateAnswerOptionDtoValidator : AbstractValidator<UpdateAnswerOptionDto>
{
    public UpdateAnswerOptionDtoValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0).WithMessage("Id must be greater than 0.");

        RuleFor(x => x.OptionText)
            .NotEmpty().WithMessage("OptionText is required.")
            .MaximumLength(250).WithMessage("OptionText cannot exceed 250 characters.");

        RuleFor(x => x.QuestionBankId)
            .GreaterThan(0).WithMessage("QuestionBankId must be greater than 0.");
    }
}