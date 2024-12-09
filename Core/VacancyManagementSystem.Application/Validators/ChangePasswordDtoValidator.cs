using FluentValidation;
using VacancyManagementSystem.Domain.DTOs;

namespace VacancyManagementSystem.Application.Validators;

public class ChangePasswordDtoValidator : AbstractValidator<ChangePasswordDto>
{
    public ChangePasswordDtoValidator()
    {
        RuleFor(x => x.UserId)
            .GreaterThan(0).WithMessage("UserId must be greater than 0.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Email must be a valid email address.");

        RuleFor(x => x.OldPassword)
            .NotEmpty().WithMessage("OldPassword is required.")
            .MinimumLength(6).WithMessage("OldPassword must be at least 6 characters long.");

        RuleFor(x => x.NewPassword)
            .NotEmpty().WithMessage("NewPassword is required.")
            .MinimumLength(6).WithMessage("NewPassword must be at least 6 characters long.")
            .NotEqual(x => x.OldPassword).WithMessage("NewPassword must be different from OldPassword.");
    }
}