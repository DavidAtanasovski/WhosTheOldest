using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Address
    {
        private string city;
        private string street;
        private int number;

        public Address(string city, string street, int number)
        {
            this.city = city;
            this.street = street;
            this.number = number;
        }

        public string GetAddress()
        {
            return $"{city}, {street} {number}";
        }
    }
}