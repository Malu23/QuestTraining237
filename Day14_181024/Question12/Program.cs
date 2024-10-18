using System;

namespace CheckString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> startsWithA = str => str.StartsWith("A", StringComparison.OrdinalIgnoreCase);
            
            System.Console.WriteLine("apple starts with A: " + startsWithA("apple"));
            System.Console.WriteLine("Andaman starts with A: " + startsWithA("Andaman"));
            System.Console.WriteLine("bus starts with: " + startsWithA("bus")); 
        }
    }
}