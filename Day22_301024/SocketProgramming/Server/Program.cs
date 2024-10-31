using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketProgrammingServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8080;
            
            var listener = new TcpListener(ip, port);
            listener.Start();
            System.Console.WriteLine($"App is listening on {ip}:{port}");
            
            Socket socket = listener.AcceptSocket();
            System.Console.WriteLine("Client connected");

            while (true)
            {
                var buffer = new byte[1024];
                var dataLength = socket.Receive(buffer);
                
                string message = Encoding.ASCII.GetString(buffer, 0, dataLength);
                System.Console.WriteLine($"Message received: {message}");

                System.Console.Write("Server: ");
                string response = Console.ReadLine();
                byte[] responseData = Encoding.ASCII.GetBytes(response);
                socket.Send(responseData);
            }
        }
    }
}