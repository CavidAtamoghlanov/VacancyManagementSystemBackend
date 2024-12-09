using FluentValidation;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.Application.Validators;

public class AddVacancyQuestionDtoValidator : AbstractValidator<AddVacancyQuestionDto>
{
    public AddVacancyQuestionDtoValidator()
    {
        RuleFor(x => x.VacancyId)
            .GreaterThan(0).WithMessage("VacancyId must be greater than 0.");

        RuleFor(x => x.QuestionBankId)
            .GreaterThan(0).WithMessage("QuestionBankId must be greater than 0.");
    }
}