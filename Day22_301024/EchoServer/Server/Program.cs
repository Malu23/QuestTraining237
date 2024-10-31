using System;

namespace EchoServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serverBuilder = new ServerBuilder();
            
            serverBuilder.Run(HandleMessage);

            serverBuilder.ShutDown();
        }

        private static void HandleMessage(string message)
        {
            Console.WriteLine($"Message received: {message}");
        }
    }
}