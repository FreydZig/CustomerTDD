using Customer.Validators;
using FluentValidation.TestHelper;
using System;
using System.Collections.Generic;
using Xunit;

namespace Customer.tests
{
    public class AddresTests
    {
        AddresValidator _addressValidator = new AddresValidator();

        [Fact]
        public void ShouldNotBeAbleToCreateAddres()
        {
            Addres address = new Addres("", "", AddresType.Shipping, "", "", "89236723262732", "Russia");

            var result = _addressValidator.TestValidate(address);
            result.ShouldHaveValidationErrorFor(x => x.AddresLine);
            result.ShouldHaveValidationErrorFor(x => x.AddresLine);
            result.ShouldHaveValidationErrorFor(x => x.City);
            result.ShouldHaveValidationErrorFor(x => x.PostalCode);
            result.ShouldHaveValidationErrorFor(x => x.Country);
        }
    }
}
