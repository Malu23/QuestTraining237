using System;
using System.Collections.Generic;
using System.IO;

namespace Interfaces
{

    class SchoolStudent: IStudent
    {
        public string Name {get; set; }
        public const string SchoolName = "school x";
        public void Display()
        {
            System.Console.WriteLine($"Student Name: {Name}, School Name: {SchoolName}");
        }
    }

    class CollegeStudent: IStudent
    {
        public string Name {get; set; }
        public const string CollegeName = "college x";
        public void Display()
        {
            System.Console.WriteLine($"Student Name: {Name}, College Name: {CollegeName}");
        }
    }

    internal class Program
    {
        static void Main()
        {
            // Covariant
            // This can only call things in parent class too.
            // IStudent ss = new SchoolStudent(); 
            // IStudent cs = new CollegeStudent();

            var students = new List<IStudent>
            {
                new SchoolStudent { Name = "John"},
                new SchoolStudent { Name = "Jane"},
                new CollegeStudent { Name = "Mark"},
                new CollegeStudent { Name = "Mary"}
            };

            foreach(var student in students)
            {
                student.Display();
            }
        }
    }   
}