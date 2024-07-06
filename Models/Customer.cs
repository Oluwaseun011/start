using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using start.Enums;

namespace start.Models
{
    public class Customer
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Email;
        public string Address;
        public string PhoneNumber;
        public decimal Wallet;
        public Gender Gender;

        public Customer(int id, string fName, string lName, string email, string address, string phone, decimal wallet, Gender gender)
        {
            Id = id;
            FirstName = fName;
            LastName = lName;
            Email = email;
            Address = address;
            PhoneNumber = phone;
            Wallet = wallet;
            Gender = gender;
        }
    }
}