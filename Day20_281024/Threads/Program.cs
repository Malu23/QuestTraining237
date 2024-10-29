using System;

namespace Threads
{
    internal class Program
    {
        static void Action1()
        {
            Thread.Sleep(2000);
            System.Console.WriteLine("Hello from Action1.");
        }

        static void Action2()
        {
            System.Console.WriteLine("Hello from Action2.");
        }

        static void Main(string[] args)
        {
            var t1 = new Thread(Action1);
            var t2 = new Thread(Action2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            System.Console.WriteLine("COMPLETED");
        }
    }
}