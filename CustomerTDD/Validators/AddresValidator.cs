using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTDD.Validators
{
    public class AddresValidator : AbstractValidator<Addres>
    {
        public AddresValidator()
        {
            var availableCountries = new List<string> { "USA", "Canada" };
            RuleFor(a => a.AddresLine)
               .NotEmpty().WithMessage(ErrorMessages.AddressLineIsRequared)
               .MaximumLength(100).WithMessage(ErrorMessages.AddressLineLenghtException);
            RuleFor(a => a.AddresLine2)
               .MaximumLength(100).WithMessage(ErrorMessages.AddressLine2LenghtException);
            RuleFor(a => a.AddresType)
               .IsInEnum().WithMessage(ErrorMessages.AddressTypeIsNotEnum);
            RuleFor(a => a.City)
               .NotEmpty().WithMessage(ErrorMessages.CityIsRequared)
               .MaximumLength(50).WithMessage(ErrorMessages.CityLenghtException);
            RuleFor(a => a.PostalCode)
               .NotEmpty().WithMessage(ErrorMessages.PostalCodeIsRequared)
               .MaximumLength(6).WithMessage(ErrorMessages.PostalCodeLenghtException);
            RuleFor(a => a.State)
               .NotEmpty().WithMessage(ErrorMessages.StateIsRequared)
               .MaximumLength(20).WithMessage(ErrorMessages.StateLenghtException);
            RuleFor(a => a.Country)
              .NotEmpty().WithMessage(ErrorMessages.CountryIsRequared)
              .Must(a => availableCountries.Contains(a)).WithMessage(ErrorMessages.InvalidCountryName);
        }
    }
}
