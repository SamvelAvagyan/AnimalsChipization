using FluentValidation;
using WebApi.ViewModels;

namespace WebApi.Validations
{
    public class AccountRegistrationViewModelValidator : AbstractValidator<AccountRegistrationViewModel>
    {
        public AccountRegistrationViewModelValidator()
        {
            RuleFor(account => account.FirstName).NotNull().NotEmpty();
            RuleFor(account => account.LastName).NotNull().NotEmpty();
            RuleFor(account => account.Email).NotNull().NotEmpty().MatchEmailRules();
            RuleFor(account => account.Password).NotNull().NotEmpty();
        }
    }
}
