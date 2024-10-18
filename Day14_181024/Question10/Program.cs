using System;

namespace ActionSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> sum = (a, b) => System.Console.WriteLine($"Sum: {a + b}");
            sum(2, 3);
        }
    }
}