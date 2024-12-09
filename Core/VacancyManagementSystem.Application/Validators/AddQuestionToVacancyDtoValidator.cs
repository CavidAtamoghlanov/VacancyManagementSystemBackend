using FluentValidation;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.Application.Validators;

public class AddQuestionToVacancyDtoValidator : AbstractValidator<AddQuestionToVacancyDto>
{
    public AddQuestionToVacancyDtoValidator()
    {
        RuleFor(x => x.VacancyId)
            .GreaterThan(0).WithMessage("VacancyId must be greater than 0.");

        RuleFor(x => x.QuestionIds)
            .NotEmpty().WithMessage("QuestionIds cannot be empty.")
            .Must(ids => ids.All(id => id > 0))
            .WithMessage("All QuestionIds must be greater than 0.");
    }
}