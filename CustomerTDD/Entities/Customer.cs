using System.Text.RegularExpressions;

namespace CustomerTDD
{
    public class Customer : Persone
    {
        public List<Addres> Addres { get; set; } = new List<Addres>();
        public List<string> Notes { get; set; } = new List<string>();
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public decimal? TotalPurchasesAmount { get; set; }

        public Customer(string firstName, string lastName, List<Addres> addres, List<string> notes, string email, string phoneNumber, decimal tpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Addres = addres;
            Notes = notes;
            Email = email;
            PhoneNumber = phoneNumber;
            TotalPurchasesAmount = tpa;
        }      
    }
}