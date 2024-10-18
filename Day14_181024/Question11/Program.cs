using System;

namespace CheckEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = num => num % 2 ==0;
            
            System.Console.WriteLine("23 is even: " + isEven(23));
            System.Console.WriteLine("6 is even: " + isEven(6)); 
        }
    }
}