using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class PersonValidator:AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.Age).GreaterThanOrEqualTo(5).NotEmpty();
            RuleFor(p => p.PersonName).NotEmpty();
        }
    }
}
