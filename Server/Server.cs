using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private Socket socket;
        private List<ClientHandler> clients = new List<ClientHandler>();

        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        // initialises welcoming server socket and puts it in a listening state
        public bool Start()
        {

            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                socket.Bind(endpoint);
                socket.Listen(5);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                return false;
            }
        }


        // makes a thread for the new client which handles its requests
        public void Listen()
        {
            try
            {
                while (true)
                {
                    Socket clientSocket = socket.Accept();
                    ClientHandler clientHandler = new ClientHandler(clientSocket);
                    clients.Add(clientHandler);
                    clientHandler.LoggedOutClient += Handler_LoggedOutClient;
                    Thread clientThread = new Thread(clientHandler.HandleRequests) { IsBackground = true };
                    clientThread.Start();
                }
            }
            catch (SocketException ex)
            {

                Debug.WriteLine(">>>" + ex.Message);
            }
        }
        public void Handler_LoggedOutClient(object sender, EventArgs args)
        {
            clients.Remove((ClientHandler)sender);
        }

        public void Stop()
        {
            socket.Close();
            foreach (ClientHandler clientHandler in clients.ToList())
            {
                clientHandler.CloseSocket();
            }
            clients.Clear();
        }

    }
}
