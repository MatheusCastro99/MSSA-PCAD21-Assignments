using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4._1._1.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? SearchName => FirstName + LastName;
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }

        public Person (string firstName, string lastName, string phoneNumber, string address, string email) 
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
        }

        public Person ()
        {

        }

    }
}
