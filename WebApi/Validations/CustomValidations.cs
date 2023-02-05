using FluentValidation.Validators;
using FluentValidation;
using System.Net.Mail;

namespace WebApi.Validations
{
    public static class CustomValidations
    {
        public static IRuleBuilderOptions<T, string> MatchEmailRules<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new RegularExpressionValidator<T>(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$"));
        }
    }
}
