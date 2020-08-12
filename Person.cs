using System;
using System.Linq;

namespace Persons
{
    class Person
    {
        private string firstName;
        private string lastName;
        public int age;
        private Address address;
        
        

        public void SetName(string FirstName, string lastName)
        {
            firstName = FirstName;
            this.lastName = lastName;
        }

        public void SetAge(int age)
        {
            if (age > 0)
            {
                this.age = age;
                            
            }
               
           
        }

       
      
        public void SetAddress(Address address)
        {
            this.address = address;
        }

        public string PrintInfo()
        {
            var result = string.Empty;
            if (age == 0)
            {
                result = $"{firstName} {lastName}.";
            }
            else
            {
                result = $"{firstName} {lastName}, {age} years old.";
            }

            result = $"{result} Address: {address.GetAddress()}";

            return result;
        }
        
        
    }
}