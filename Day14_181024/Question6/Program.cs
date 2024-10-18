using System;

namespace Message
{
    internal class Program
    {
        public delegate void PrintMessage(string message);
        public static void DisplayMessage(string message) => System.Console.WriteLine($"The message is: {message}");

        static void Main()
        {
            PrintMessage pm = DisplayMessage;
            pm("hello");
            
        }
    }
}