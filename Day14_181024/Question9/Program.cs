using System;

namespace ActionMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> m = message => System.Console.WriteLine(message);
            m("Hello all!");
        }
    }
}