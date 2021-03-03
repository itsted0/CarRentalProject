using Entities.Concrete;
using FluentValidation;

namespace Business.Concrete
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CompanyName).MaximumLength(30);
        }
    }
}