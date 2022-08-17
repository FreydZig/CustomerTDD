using System;

namespace CustomerTDD
{
    public class Addres
    {
        public string? AddresLine { get; set; } = null;
        public string? AddresLine2 { get; set; } = null;
        public AddresType AddresType { get; set; } = AddresType.Shipping;
        public string? City { get; set; } = null;
        public string? PostalCode { get; set; } = null;
        public string? State { get; set; } = null;
        public string? Country { get; set; } = null;

        public Addres(string addresLine, string addresLine2, AddresType addresType, string city, string postalCode, string state, string country)
        {
            AddresLine = addresLine;
            AddresLine2 = addresLine2;
            AddresType = addresType;
            City = city;
            PostalCode = postalCode;
            State = state;
            Country = country;
        }       
    }
}
