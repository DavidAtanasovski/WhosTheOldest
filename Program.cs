using System;
using System.Collections.Generic;
using System.Linq;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of people:");
            var countPersosns = int.Parse(Console.ReadLine());

            var persons = new List<Person>();
            for (int i = 0; i < countPersosns; i++)
           
            {
                Console.WriteLine($"Enter {i + 1} Person: ");
                Console.Write($"FirstName: ");
                var firstName = Console.ReadLine();
                Console.Write($"LastName: ");
                var lastName = Console.ReadLine();
                Console.Write($"Age: ");
                var age = int.Parse(Console.ReadLine());

                var person = new Person();
                person.SetName(firstName, lastName);
                person.SetAge(age);
                
              
                

                Console.Write("City:");
                var city = Console.ReadLine();

                Console.Write("Street:");
                var street = Console.ReadLine();

                Console.Write("Number:");
                var number = int.Parse(Console.ReadLine());

                var adress = new Address(city, street, number);
                person.SetAddress(adress);

                persons.Add(person);
            }

            Person oldestPerson = null;
            //var oldPerson = new Person();
            foreach (var person in persons)
            {
                Console.WriteLine(person.PrintInfo());

                if (oldestPerson == null)
                {
                    oldestPerson = person;
                }
                if (oldestPerson.age < person.age)
                {
                    oldestPerson = person;
                }
            }

            Console.WriteLine($"Oldest person is: {oldestPerson.PrintInfo()}");





            foreach (var person in persons)
            {
                
                var printInfo = person.PrintInfo();
                Console.WriteLine(printInfo);
            }
        }
    }
}
