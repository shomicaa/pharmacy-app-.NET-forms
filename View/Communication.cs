using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using View.Exceptions;
using Microsoft.VisualBasic.ApplicationServices;
using Domain;
using Common;
using System.Diagnostics;

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
                if (socket == null || !IsConnected)
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
        public void EnsureConnected()
        {
            if (!IsConnected)
            {
                //Close();
                Connect();
            }
        }

        private void SendRequest<T>(Operation operation, T? requestObject = null) where T : class
        {
            try
            {
                Connect();
                Request<T> request = new Request<T>
                {
                    Operation = operation,
                    RequestObject = requestObject
                };
                string jsonRequest = JsonSerializer.Serialize(request);
                writer.WriteLine(jsonRequest);
            }
            catch (IOException ex)
            {

                throw new ServerCommunicationException(ex.Message);
            }
        }
        private T HandleResponse<T>()
        {
            string jsonResponse = reader.ReadLine();
            if (string.IsNullOrEmpty(jsonResponse))
                throw new SystemOperationException("Empty response from server");
            Response<T> response = JsonSerializer.Deserialize<Response<T>>(jsonResponse, JsonOptions);
            if (response.IsSuccessful)
            {
                return response.Result;
            }
            throw new SystemOperationException(response.Message);
        }


        #region ALL REQUESTS

        // code inside request methods couldve been less redundant, yet generics are used for performance

        internal Farmaceut Login(Farmaceut farmaceut)
        {
            SendRequest<Farmaceut>(Operation.Login, farmaceut);
            return HandleResponse<Farmaceut>();
        }

        #region getAll methods
        internal List<Farmaceut> UcitajFarmaceute()
        {
            SendRequest<List<Farmaceut>>(Operation.UcitajFarmaceute);
            return HandleResponse<List<Farmaceut>>();
        }
        internal List<Racun> UcitajRacune()
        {
            SendRequest<List<Racun>>(Operation.UcitajRacune);
            return HandleResponse<List<Racun>>();
        }
        internal List<Korisnik> UcitajKorisnike()
        {
            SendRequest<List<Korisnik>>(Operation.UcitajKorisnike);
            return HandleResponse<List<Korisnik>>();
        }
        internal List<Lek> UcitajLekove()
        {
            SendRequest<List<Lek>>(Operation.UcitajLekove);
            return HandleResponse<List<Lek>>();
        }
        internal List<PromoKod> UcitajPromoKodove()
        {
            SendRequest<List<PromoKod>>(Operation.UcitajPromoKodove);
            return HandleResponse<List<PromoKod>>();
        }
        internal List<Lokacija> UcitajLokacije()
        {
            SendRequest<List<Lokacija>>(Operation.UcitajLokacije);
            return HandleResponse<List<Lokacija>>();
        }
        #endregion

        #region obrisi methods
        internal void ObrisiFarmaceuta(Farmaceut farmaceut)
        {
            SendRequest<Farmaceut>(Operation.ObrisiFarmaceuta, farmaceut);
            HandleResponse<Farmaceut>();
        }
        internal void ObrisiKorisnika(Korisnik korisnik)
        {
            SendRequest<Korisnik>(Operation.ObrisiKorisnika, korisnik);
            HandleResponse<Korisnik>();
        }
        internal void ObrisiLek(Lek lek)
        {
            SendRequest<Lek>(Operation.ObrisiLek, lek);
            HandleResponse<Lek>();
        }
        internal void ObrisiLokaciju(Lokacija lokacija)
        {
            SendRequest<Lokacija>(Operation.ObrisiLokaciju, lokacija);
            HandleResponse<Lokacija>();
        }
        internal void ObrisiPromoKod(PromoKod promoKod)
        {
            SendRequest<PromoKod>(Operation.ObrisiPromoKod, promoKod);
            HandleResponse<PromoKod>();
        }
        #endregion

        #region promeni methods
        internal void PromeniFarmaceuta(Farmaceut farmaceut)
        {
            SendRequest<Farmaceut>(Operation.PromeniFarmaceuta, farmaceut);
            HandleResponse<Farmaceut>();
        }
        internal void PromeniKorisnika(Korisnik korisnik)
        {
            SendRequest<Korisnik>(Operation.PromeniKorisnika, korisnik);
            HandleResponse<Korisnik>();
        }
        internal void PromeniLek(Lek lek)
        {
            SendRequest<Lek>(Operation.PromeniLek, lek);
            HandleResponse<Lek>();
        }
        internal void PromeniLokaciju(Lokacija lokacija)
        {
            SendRequest<Lokacija>(Operation.PromeniLokaciju, lokacija);
            HandleResponse<Lokacija>();
        }
        internal void PromeniPromoKod(PromoKod promoKod)
        {
            SendRequest<PromoKod>(Operation.PromeniPromoKod, promoKod);
            HandleResponse<PromoKod>();
        }
        internal void PromeniRacun(Racun racun)
        {
            SendRequest<Racun>(Operation.PromeniRacun, racun);
            HandleResponse<Racun>();
        }
        #endregion

        #region pretrazi methods
        internal Farmaceut PretraziFarmaceuta(Farmaceut farmaceut)
        {
            SendRequest<Farmaceut>(Operation.PretraziFarmaceuta, farmaceut);
            return HandleResponse<Farmaceut>();
        }
        internal Korisnik PretraziKorisnika(Korisnik korisnik)
        {
            SendRequest<Korisnik>(Operation.PretraziKorisnika, korisnik);
            return HandleResponse<Korisnik>();
        }
        internal Lek PretraziLek(Lek lek)
        {
            SendRequest<Lek>(Operation.PretraziLek, lek);
            return HandleResponse<Lek>();
        }
        internal Lokacija PretraziLokaciju(Lokacija lokacija)
        {
            SendRequest<Lokacija>(Operation.PretraziLokaciju, lokacija);
            return HandleResponse<Lokacija>();
        }
        internal PromoKod PretraziPromoKod(PromoKod kod)
        {
            SendRequest<PromoKod>(Operation.PretraziPromoKod, kod);
            return HandleResponse<PromoKod>();
        }
        internal Racun PretraziRacun(Racun racun)
        {
            SendRequest<Racun>(Operation.PretraziRacun, racun);
            return HandleResponse<Racun>();
        }
        #endregion

        #region kreiraj/ubaci methods
        internal int KreirajFarmaceuta(Farmaceut farmaceut)
        {
            SendRequest<Farmaceut>(Operation.KreirajFarmaceuta, farmaceut);
            return HandleResponse<int>();
        }
        internal int KreirajKorisnika(Korisnik korisnik)
        {
            SendRequest<Korisnik>(Operation.KreirajKorisnika, korisnik);
            return HandleResponse<int>();
        }
        internal int KreirajLek(Lek lek)
        {
            SendRequest<Lek>(Operation.KreirajLek, lek);
            return HandleResponse<int>();
        }
        internal void UbaciLokaciju(Lokacija lokacija)
        {
            SendRequest<Lokacija>(Operation.UbaciLokaciju, lokacija);
            HandleResponse<Lokacija>();
        }
        internal int KreirajPromoKod(PromoKod kod)
        {
            SendRequest<PromoKod>(Operation.KreirajPromoKod, kod);
            return HandleResponse<int>();
        }
        internal int KreirajRacun(Racun racun)
        {
            SendRequest<Racun>(Operation.KreirajRacun, racun);
            return HandleResponse<int>();
        }
        #endregion

        #region ucitajSpecific methods
        internal List<Farmaceut> UcitajSpecificFarmaceute(Farmaceut farmaceut)
        {
            SendRequest<Farmaceut>(Operation.UcitajSpecificFarmaceute, farmaceut);
            return HandleResponse<List<Farmaceut>>();
        }
        internal List<Korisnik> UcitajSpecificKorisnike(Korisnik korisnik)
        {
            SendRequest<Korisnik>(Operation.UcitajSpecificKorisnike, korisnik);
            return HandleResponse<List<Korisnik>>();
        }
        internal List<Lek> UcitajSpecificLekove(Lek lek)
        {
            SendRequest<Lek>(Operation.UcitajSpecificLekove, lek);
            return HandleResponse<List<Lek>>();
        }
        internal List<PromoKod> UcitajSpecificPromoKodove(PromoKod kod)
        {
            SendRequest<PromoKod>(Operation.UcitajSpecificPromoKodove, kod);
            return HandleResponse<List<PromoKod>>();
        }
        internal List<Lokacija> UcitajSpecificLokacije(Lokacija lokacija)
        {
            SendRequest<Lokacija>(Operation.UcitajSpecificLokacije, lokacija);
            return HandleResponse<List<Lokacija>>();
        }
        #endregion

        #region ucitajJoin methods
        internal List<Farmaceut> UcitajFarmaceuteSaZahtevom(Farmaceut farmaceut)
        {
            SendRequest<Farmaceut>(Operation.UcitajFarmaceuteSaZahtevom, farmaceut);
            return HandleResponse<List<Farmaceut>>();
        }
        internal List<Racun> UcitajRacuneSaZahtevom(Racun racun)
        {
            SendRequest<Racun>(Operation.UcitajRacuneSaZahtevom, racun);
            return HandleResponse<List<Racun>>();
        }
        internal List<Korisnik> UcitajKorisnikeSaZahtevom(Korisnik korisnik)
        {
            SendRequest<Korisnik>(Operation.UcitajKorisnikeSaZahtevom, korisnik);
            return HandleResponse<List<Korisnik>>();
        }
        #endregion

        public void Close()
        {
            try
            {
                if (socket == null || !socket.Connected) return;

                if (writer != null && stream != null && socket.Connected)
                {

                    SendRequest<User>(Operation.End);

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error during close: {ex.Message}");
            }
            finally
            {
                writer?.Dispose();
                reader?.Dispose();
                stream?.Dispose();
                if (socket != null && socket.Connected)
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }

            }
        }
        #endregion
    }
}
