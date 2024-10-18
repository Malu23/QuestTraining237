using System;

namespace StringLength
{
    internal class Program
    {
        static int GetLength(string str) => str.Length;
        static void Main(string[] args)
        {
            Func<string, int> len = GetLength;

            var stringLength = len("Malavika Bysakh");
            System.Console.WriteLine(stringLength);
        }
    }
}