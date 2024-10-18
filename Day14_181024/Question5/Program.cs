using System;

namespace Operation
{
    public delegate int Operation(int a, int b);

    internal class Program
    {
        public static int Add(int a, int b) => a + b;

        public static int Multiply(int a, int b) => a * b;

        static void Main()
        {
            Operation a = Add;
            int sum = a(2, 3);
            System.Console.WriteLine($"Sum: {sum}");

            a -= Add;
            a += Multiply;
            int product = a(2, 3);
            System.Console.WriteLine($"Product: {product}");
        }
    }
}