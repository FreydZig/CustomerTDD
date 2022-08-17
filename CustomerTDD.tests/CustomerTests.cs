using Customer.Validators;
using FluentValidation.TestHelper;
using System;
using System.Collections.Generic;
using Xunit;

namespace Customer.tests
{
    public class CustomerTests
    {
        CustomerValidator _customerValidator = new CustomerValidator();

        [Fact]
        public void ShouldBeAbleToCreateCustomer()
        {
            List<Addres> customerAddresses = new List<Addres>();
            Addres address = new Addres("Some Addres", "One More Addres", AddresType.Shipping, "Georgy", "142", "Georgy", "USA");
            customerAddresses.Add(address);
            List<string> testNotes = new List<string>();
            testNotes.Add("note");

            Customer actualCustomer = new Customer("Ivan", "Denin", customerAddresses, testNotes, "zigmunt.freyd.95@gmail.com", "+12345678901", 0);

            Assert.Equal("Ivan", actualCustomer.FirstName);
            Assert.Equal("Denin", actualCustomer.LastName);
            Assert.Equal(customerAddresses, actualCustomer.Addres);
            Assert.Equal("+12345678901", actualCustomer.PhoneNumber);
            Assert.Equal("zigmunt.freyd.95@gmail.com", actualCustomer.Email);
            Assert.Equal(testNotes, actualCustomer.Notes);
            Assert.Equal(0, actualCustomer.TotalPurchasesAmount);
        }

        [Fact]
        public void ShouldNotBeAbleToCreateCustomer()
        {
            Customer actualCustomer = new Customer("", "", new List<Addres>(), new List<string>(), "ss", "+2", 0);

            var result = _customerValidator.TestValidate(actualCustomer);
            result.ShouldHaveValidationErrorFor(x => x.LastName);
            result.ShouldHaveValidationErrorFor(x => x.Addres);
            result.ShouldHaveValidationErrorFor(x => x.PhoneNumber);
            result.ShouldHaveValidationErrorFor(x => x.Email);
            result.ShouldHaveValidationErrorFor(x => x.Notes);
        }
    }
}