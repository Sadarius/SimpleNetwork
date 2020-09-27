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
        private const int port = 3546;      //ports like "21", "22" are already assigned 
        private const int buffer_size = 1024;

        private static byte[] buffer = new byte[buffer_size];
        static void Main()
        {
           Console.Title = "Server";
           SetupServer();
           Console.ReadLine();
        }

        private static void SetupServer()
        {
            Console.WriteLine("set up server");
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, port)); // change so each client socket gets his individual server socket
            serverSocket.Listen(0);
            serverSocket.BeginConnect(null, null, null); // check how I manage to let them exchange data after they binding the sockets togther
                                                         // investigate the different socket. ... what they do and need to work
                                                         // check into AsyncCallback
        }

        private static void ConnectSockets(IAsyncResult resultasync)
        {
            Socket socket;

            /*
            socket = serverSocket.EndAccept(resultasync);
            socket.BeginReceive
            socket.BeginConnect
            socket.BeginSend
            socket.Close
            */
        }
    }
}
