

using System.Net.Sockets;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Diagnostics;
using Common;
using View.Exceptions;
using Microsoft.VisualBasic.ApplicationServices;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        public EventHandler LoggedOutClient;

        bool end = false;

        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            PropertyNameCaseInsensitive = true,
            MaxDepth = 256 // increase if needed
        };
        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream) { AutoFlush = true };
        }

        public void HandleRequests()
        {
            try
            {

                while (!end)
                {
                    // getting and deserializing the request
                    string jsonRequest = reader.ReadLine();
                    Request request = JsonSerializer.Deserialize<Request>(jsonRequest);

                    //making a response based on request data
                    WriteResponse(request);
                }

            }
            catch (InvalidCastException invalidEx)
            {

                MessageBox.Show("Invalid Cast! " + invalidEx);
            }
            catch (IOException ex)
            {

                Debug.WriteLine(">>>" + ex.Message);
            }
            catch (SystemOperationException ex)
            {

                Debug.WriteLine(">>>" + ex.Message);
            }
            catch (JsonException ex)
            {

                var errorResponse = new Response
                {
                    IsSuccessful = false,
                    Message = "Invalid request format"
                };
                string errorJson = JsonSerializer.Serialize(errorResponse);
                writer.WriteLine(errorJson);
                stream.Flush();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>> " + ex.Message);

            }
            finally
            {
                CloseSocket();
            }
        }

        // returns response object only
        public T DeserializeDomain<T>(Request request)
        {
            var element = (JsonElement)request.RequestObject;
            T t = JsonSerializer.Deserialize<T>(element);
            return t;
        }

        // returns both the response variable and the response object variable
        public Tuple<Response<T>, T> DeserializeTupleDomain<T>(Request request)
        {
            Response<T> responseT = new Response<T>();
            var element = (JsonElement)request.RequestObject;
            T t = JsonSerializer.Deserialize<T>(element);
            return new Tuple<Response<T>, T>(responseT, t);
        }

        public void WriteResponse(Request request)
        {
            // could have made it less redundant by boxing response.Result - not done for the sake of generics performance

            switch (request.Operation)
            {
                default:

                    break;

            }
        }

        private object lockobject = new object();
        internal void CloseSocket()
        {
            lock (lockobject)
            {
                if (socket != null)
                {
                    end = true;
                    writer?.Dispose();
                    reader?.Dispose();
                    stream?.Dispose();
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null;
                    LoggedOutClient?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}