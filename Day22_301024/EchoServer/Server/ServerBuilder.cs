using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EchoServer
{
    public class ServerBuilder
    {
        private const string ipAddress = "127.0.0.1";
        private const int port = 8080;
        private TcpListener _listener;
        private Socket _socket;

        public void Build()
        {
            var ip = IPAddress.Parse(ipAddress);
            _listener = new TcpListener(ip, port);
        }

        public void Run(Action<string> callback)
        {
            Build();
            _listener.Start();
            Console.WriteLine($"App is listening on {ipAddress}:{port}.");
            
            _socket = _listener.AcceptSocket();
            Console.WriteLine("Client connected.");

            while (true)
            {
                var buffer = new byte[1024];
                var dataLength = _socket.Receive(buffer);
                string message = Encoding.ASCII.GetString(buffer, 0, dataLength);
                
                callback(message);

                byte[] responseData = Encoding.ASCII.GetBytes($"Echo: {message}");
                _socket.Send(responseData);
            }
        }

        public void ShutDown()
        {
            _socket.Close();
            _listener.Stop();
        }
    }
}