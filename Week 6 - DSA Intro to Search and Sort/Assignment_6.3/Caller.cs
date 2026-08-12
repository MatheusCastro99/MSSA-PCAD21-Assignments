using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6._3
{
    internal class Caller
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string CallerID {  get; set; }

        public Caller(string name, string phoneNum, string callerID) 
        {
            Name = name;
            PhoneNumber = phoneNum;
            CallerID = callerID;
        }

        public override string ToString()
        {
            string person = $"Name: {Name}\n" +
                            $"Phone number: {PhoneNumber}\n";

            return person;
        }
    }
}
