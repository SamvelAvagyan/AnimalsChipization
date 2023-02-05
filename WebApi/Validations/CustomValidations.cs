using FluentValidation.Validators;
using FluentValidation;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace WebApi.Validations
{
    public static class CustomValidations
    {
        public static IRuleBuilderOptions<T, string> MatchEmailRules<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new RegularExpressionValidator<T>(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase));
        }
    }
}
