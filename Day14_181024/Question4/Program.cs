using System;

namespace SimpleCalculator
{
    public class SimpleCalculator : ICalculator
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;
    }

    class Program
    {
        static void Main()
        {
            ICalculator c = new SimpleCalculator();

            int sum = c.Add(2, 3);
            System.Console.WriteLine($"Sum: {sum}");

            int difference = c.Subtract(5, 3);
            System.Console.WriteLine($"Difference: {difference}");
        }
    }
}