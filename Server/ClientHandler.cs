

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
                    Request request = GetRequest();
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

        // getting and deserializing the request
        public Request GetRequest()
        {
            string jsonRequest = reader.ReadLine();
            return JsonSerializer.Deserialize<Request>(jsonRequest);
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
        public Tuple<Response<List<T>>, T> DeserializeTupleListDomain<T>(Request request)
        {
            Response<List<T>> responseT = new Response<List<T>>();
            var element = (JsonElement)request.RequestObject;
            T t = JsonSerializer.Deserialize<T>(element);
            return new Tuple<Response<List<T>>, T>(responseT, t);
        }

        public void SendResponse<T>(Response<T> result, string errorMessage)
        {
            if (result == null)
            {
                result.IsSuccessful = false;
                result.Message = errorMessage;
            }

            string jsonResponseProducts = JsonSerializer.Serialize(result, JsonOptions);
            writer.WriteLine(jsonResponseProducts);
        }

        public void MakeResponse<T>(Request request, Action<T> funkcija, string errorMessage)
        {
            (Response<T> response, T entity) = DeserializeTupleDomain<T>(request);
            funkcija(entity);
            SendResponse(response, errorMessage);
        }

        public void MakeResponse<T>(Func<T> pretraziFunkcija, string errorMessage)
        {
            Response<T> response = new Response<T>();
            response.Result = pretraziFunkcija();
            SendResponse(response, errorMessage);
        }

        public void MakeResponse<T>(Func<List<T>> ucitajFunkcija, string errorMessage)
        {
            Response<List<T>> response = new Response<List<T>>();
            response.Result = ucitajFunkcija();
            SendResponse(response, errorMessage);
        }

        public void MakeResponseList<T>(Request request, Func<T,List<T>> ucitajFunkcija, string errorMessage)
        {
            (Response<List<T>> response, T entity) = DeserializeTupleListDomain<T>(request);
            response.Result = ucitajFunkcija(entity);
            SendResponse(response, errorMessage);
        }


        public void WriteResponse(Request request)
        {
            // could have made it less redundant by boxing response.Result - not done for the sake of generics performance

            switch (request.Operation)
            {
                case Operation.Login:

                    (Response<Farmaceut> responseFarmaceut, Farmaceut farmaceut) = DeserializeTupleDomain<Farmaceut>(request);
                    responseFarmaceut.Result = Controller.Instance.Login(farmaceut);
                    SendResponse(responseFarmaceut, "Farmaceut ne postoji!");
                    break;
                case Operation.End:
                    end = true;
                    break;
                // obrisi cases
                case Operation.ObrisiFarmaceuta:
                    MakeResponse<Farmaceut>(request, Controller.Instance.ObrisiFarmaceut, "Greska pri brisanju odabranog farmaceuta");
                    break;
                case Operation.ObrisiKorisnika:
                    MakeResponse<Korisnik>(request, Controller.Instance.ObrisiKorisnik, "Greska pri brisanju odabranog korisnika");
                    break;
                case Operation.ObrisiLek:
                    MakeResponse<Lek>(request, Controller.Instance.ObrisiLek, "Greska pri brisanju odabranog leka");
                    break;
                case Operation.ObrisiLokaciju:
                    MakeResponse<Lokacija>(request, Controller.Instance.ObrisiLokacija, "Greska pri brisanju odabrane lokacije");
                    break;
                case Operation.ObrisiPromoKod:
                    MakeResponse<PromoKod>(request, Controller.Instance.ObrisiPromoKod, "Greska pri brisanju odabranog promo koda");
                    break;
                // promeni cases
                case Operation.PromeniFarmaceuta:
                    MakeResponse<Farmaceut>(request, Controller.Instance.PromeniFarmaceut, "Greska pri menjanju odabranog farmaceuta");
                    break;
                case Operation.PromeniKorisnika:
                    MakeResponse<Korisnik>(request, Controller.Instance.PromeniKorisnik, "Greska pri menjanju odabranog korisnika");
                    break;
                case Operation.PromeniLek:
                    MakeResponse<Lek>(request, Controller.Instance.PromeniLek, "Greska pri menjanju odabranog leka");
                    break;
                case Operation.PromeniLokaciju:
                    MakeResponse<Lokacija>(request, Controller.Instance.PromeniLokacija, "Greska pri menjanju odabrane lokacije");
                    break;
                case Operation.PromeniPromoKod:
                    MakeResponse<PromoKod>(request, Controller.Instance.PromeniPromoKod, "Greska pri menjanju odabranog promo koda");
                    break;
                case Operation.PromeniRacun:
                    MakeResponse<Racun>(request, Controller.Instance.PromeniRacun, "Greska pri menjanju odabranog racuna");
                    break;
                // getAll cases
                case Operation.UcitajFarmaceute:
                    MakeResponse(Controller.Instance.UcitajFarmaceute, "Greska pri vracanju liste farmaceuta");
                    break;
                case Operation.UcitajKorisnike:
                    MakeResponse(Controller.Instance.UcitajKorisnike, "Greska pri vracanju liste korisnika");
                    break;
                case Operation.UcitajLekove:
                    MakeResponse(Controller.Instance.UcitajLekove, "Greska pri vracanju liste lekova");
                    break;
                case Operation.UcitajLokacije:
                    MakeResponse(Controller.Instance.UcitajLokacije, "Greska pri vracanju liste lokacija");
                    break;
                case Operation.UcitajPromoKodove:
                    MakeResponse(Controller.Instance.UcitajPromoKodove, "Greska pri vracanju liste promo kodova");
                    break;
                case Operation.UcitajRacune:
                    MakeResponse(Controller.Instance.UcitajRacune, "Greska pri vracanju liste racuna");
                    break;             
                // kreiraj/ubaci cases
                case Operation.KreirajFarmaceuta:
                    MakeResponse<int>(Controller.Instance.KreirajFarmaceut, "Greska pri kreiranju farmaceuta");
                    break;
                case Operation.KreirajKorisnika:
                    MakeResponse<int>(Controller.Instance.KreirajKorisnik, "Greska pri kreiranju korisnika");
                    break;
                case Operation.KreirajLek:
                    MakeResponse<int>(Controller.Instance.KreirajLek, "Greska pri kreiranju leka");
                    break;
                case Operation.UbaciLokaciju:
                    Response<Lek> response = new Response<Lek>();
                    Controller.Instance.UbaciLokacija((Lokacija)request.RequestObject);
                    SendResponse(response, "Greska pri ubacivanju lokacije u bazu");
                    break;
                case Operation.KreirajPromoKod:
                    MakeResponse<int>(Controller.Instance.KreirajPromoKod, "Greska pri kreiranju promo koda");
                    break;
                case Operation.KreirajRacun:
                    MakeResponse<int>(Controller.Instance.KreirajRacun, "Greska pri kreiranju racuna");
                    break;
                // pretrazi cases
                case Operation.PretraziFarmaceuta:
                    MakeResponseList<Farmaceut>(request, Controller.Instance.PretraziFarmaceut, "Greska pri vracanju farmaceuta");
                    break;
                case Operation.PretraziKorisnika:
                    MakeResponseList<Korisnik>(request, Controller.Instance.PretraziKorisnik, "Greska pri vracanju korisnika");
                    break;
                case Operation.PretraziLek:
                    MakeResponseList<Lek>(request, Controller.Instance.PretraziLek, "Greska pri vracanju leka");
                    break;
                case Operation.PretraziLokaciju:
                    MakeResponseList<Lokacija>(request, Controller.Instance.PretraziLokacija, "Greska pri vracanju lokacije");
                    break;
                case Operation.PretraziPromoKod:
                    MakeResponseList<PromoKod>(request, Controller.Instance.PretraziPromoKod, "Greska pri vracanju promo koda");
                    break;
                case Operation.PretraziRacun:
                    MakeResponseList<Racun>(request, Controller.Instance.PretraziRacun, "Greska pri vracanju racuna");
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