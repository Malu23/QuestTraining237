using System;
using System.Collections.Generic;

namespace Constructor
{
    class Person
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string[] PhoneNumbers { get; set; }

        public Person() // default constructor 
        {
            CreatedAt = DateTime.Now;
            PhoneNumbers = new string[5];
        }
        
        public Person(int PhoneNumbersCount) // parameterized constructor 
        {
            CreatedAt = DateTime.Now;
            PhoneNumbers = new string[PhoneNumbersCount];
        }

        public Person(string name, int PhoneNumbersCount) 
        {
            Name = name;
            CreatedAt = DateTime.Now;
            PhoneNumbers = new string[PhoneNumbersCount];
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name ?? "Not provided"}");
            Console.WriteLine($"Created At: {CreatedAt}");
            Console.WriteLine("Phone Numbers:");

            for (int i = 0; i < PhoneNumbers.Length; i++)
            {
                Console.WriteLine($"  [{i}] {PhoneNumbers[i] ?? "Not assigned"}");
            }

            Console.WriteLine();
        }


    }

    internal class Program
    {
        static void Main()
        {
            var obj1 = new Person(); // default constructor call
            var obj2 = new Person(2); // parameterized constructor call
            var obj3 = new Person("Malu", 2);

            Console.WriteLine("Details of obj1:");
            obj1.PrintDetails();

            Console.WriteLine("Details of obj2:");
            obj2.PrintDetails();

            Console.WriteLine("Details of obj3:");
            obj3.PrintDetails();
        }
    }
}