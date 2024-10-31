using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketProgrammingClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8080;

            var client = new TcpClient();
            client.Connect(ip, port);
            System.Console.WriteLine("Connected to server.");

            while (true)
            {
                System.Console.Write("Client: ");
                var message = Console.ReadLine();
                
                // Send message to server.
                byte[] data = Encoding.ASCII.GetBytes(message);
                client.GetStream().Write(data, 0, data.Length);
                
                // Receive message from server.
                byte[] response = new byte[1024];
                var dataLength = client.GetStream()
                    .Read(response, 0, response.Length);
                var responseText = Encoding.ASCII
                    .GetString(response, 0, dataLength);

                System.Console.WriteLine(responseText);
            }
        }
    }
}