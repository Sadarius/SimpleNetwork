using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace SimpleNetwork
{
    class Program
    {
        private static  Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static  List<Socket> clientSockets = new List<Socket>();
        private const int PORT = 3546;      //ports like "21", "22" are already assigned 
        static void Main()
        {
            Console.WriteLine("set up server");
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
            serverSocket.Listen(0);
        }
    }
}
