using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName)
               .MaximumLength(50).WithMessage(ErrorMessages.FirstNameLenghtException);
            RuleFor(c => c.LastName)
               .NotEmpty().WithMessage(ErrorMessages.LastNameIsRequared)
               .MaximumLength(50).WithMessage(ErrorMessages.LastNameLenghtException);
            RuleFor(c => c.Addres)
               .NotEmpty().WithMessage(ErrorMessages.AddressesIsRequared);
            RuleFor(c => c.PhoneNumber)
               .Matches(@"\+\d{11}").WithMessage(ErrorMessages.PhoneNumberInvalidFormat);
            RuleFor(c => c.Email)
               .Matches(@"^((\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)\s*[;]{0,1}\s*)+$").WithMessage(ErrorMessages.EmailInvalidFormat);
            RuleFor(c => c.Notes)
               .NotEmpty().WithMessage(ErrorMessages.NotesAreRequared);
        }
    }
}
