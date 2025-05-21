

using System.Net.Sockets;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Diagnostics;
using Common;
using View.Exceptions;
using Microsoft.VisualBasic.ApplicationServices;
using ApplicationLogic;
using Domain;
using Operation = Common.Operation;
using Response = Common.Response;

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
                // obrisi cases
                case Operation.ObrisiFarmaceuta:
                    Controller.Instance.ObrisiFarmaceut((Farmaceut)request.RequestObject);
                    break;
                case Operation.ObrisiKorisnika:
                    Controller.Instance.ObrisiKorisnik((Korisnik)request.RequestObject);
                    break;
                case Operation.ObrisiLek:
                    Controller.Instance.ObrisiLek((Lek)request.RequestObject);
                    break;
                case Operation.ObrisiLokaciju:
                    Controller.Instance.ObrisiLokacija((Lokacija)request.RequestObject);
                    break;
                case Operation.ObrisiPromoKod:
                    Controller.Instance.ObrisiPromoKod((PromoKod)request.RequestObject);
                    break;
                // promeni cases
                case Operation.PromeniFarmaceuta:
                    Controller.Instance.PromeniFarmaceut((Farmaceut)request.RequestObject);
                    break;
                case Operation.PromeniKorisnika:
                    Controller.Instance.PromeniKorisnik((Korisnik)request.RequestObject);
                    break;
                case Operation.PromeniLek:
                    Controller.Instance.PromeniLek((Lek)request.RequestObject);
                    break;
                case Operation.PromeniLokaciju:
                    Controller.Instance.PromeniLokacija((Lokacija)request.RequestObject);
                    break;
                case Operation.PromeniPromoKod:
                    Controller.Instance.PromeniPromoKod((PromoKod)request.RequestObject);
                    break;
                case Operation.PromeniRacun:
                    Controller.Instance.PromeniRacun((Racun)request.RequestObject);
                    break;
                // getAll cases
                case Operation.UcitajFarmaceute:
                    Response<List<Farmaceut>> responseFarmaceuti = new Response<List<Farmaceut>>();
                    responseFarmaceuti.Result = Controller.Instance.UcitajFarmaceute();
                    break;
                case Operation.UcitajKorisnike:
                    Response<List<Korisnik>> responseKorisnici = new Response<List<Korisnik>>();
                    responseKorisnici.Result = Controller.Instance.UcitajKorisnike();
                    break;
                case Operation.UcitajLekove:
                    Response<List<Lek>> responseLekovi = new Response<List<Lek>>();
                    responseLekovi.Result = Controller.Instance.UcitajLekove();
                    break;
                case Operation.UcitajLokacije:
                    Response<List<Lokacija>> responseLokacije = new Response<List<Lokacija>>();
                    responseLokacije.Result = Controller.Instance.UcitajLokacije();
                    break;
                case Operation.UcitajPromoKodove:
                    Response<List<PromoKod>> responsePromoKodovi = new Response<List<PromoKod>>();
                    responsePromoKodovi.Result = Controller.Instance.UcitajPromoKodove();
                    break;
                case Operation.UcitajRacune:
                    Response<List<Racun>> responseRacuni = new Response<List<Racun>>();
                    responseRacuni.Result = Controller.Instance.UcitajRacune();
                    break;
                case Operation.Login:

                    (Response<Farmaceut> responseFarmaceut, Farmaceut farmaceut) = DeserializeTupleDomain<Farmaceut>(request);

                    responseFarmaceut.Result = Controller.Instance.Login(farmaceut);

                    if (responseFarmaceut.Result == null)
                    {
                        responseFarmaceut.IsSuccessful = false;
                        responseFarmaceut.Message = "User doesn't exist!";
                    }

                    string jsonResponseUser = JsonSerializer.Serialize(responseFarmaceut, JsonOptions);
                    writer.WriteLine(jsonResponseUser);
                    break;
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