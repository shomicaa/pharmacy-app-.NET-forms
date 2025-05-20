using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using View.Exceptions;

namespace View
{
    public class Communication
    {
        private Socket socket;
        #region singleton
        private volatile static Communication instance;
        private static object _lock = new object();

        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Communication();
                        }
                    }
                }
                return instance;
            }
        }

        private Communication()
        {
        }
        #endregion

        private NetworkStream stream;
        private StreamWriter writer;
        private StreamReader reader;

        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            PropertyNameCaseInsensitive = true,
            MaxDepth = 256 // increase if needed
        };

        public bool IsConnected => socket?.Connected == true;
        public void Connect()
        {
            try
            {
                if (socket == null || !socket.Connected)
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect("127.0.0.1", 9999);
                    stream = new NetworkStream(socket);
                    reader = new StreamReader(stream);
                    writer = new StreamWriter(stream) { AutoFlush = true };
                }

            }
            catch (SocketException ex)
            {
                if (Form.ActiveForm is FrmLogin)
                {
                    throw;
                }
                throw new ServerCommunicationException("Connection failed: " + ex);
            }
            catch (ObjectDisposedException ex)
            {
                throw new ServerCommunicationException("Connection closed: " + ex);
            }
        }
    }
}
