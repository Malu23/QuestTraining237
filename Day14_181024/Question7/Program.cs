using System;

namespace Sum
{
    internal class Program
    {
        static void Main()
        {
            Func<int, int, int> sum = (a, b) => a + b;
            var res = sum(3, 4);
            System.Console.WriteLine($"Sum: {res}");
        }
    }
}