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

        // methode
        internal Farmaceut Login(Farmaceut farmaceut)
        {
            SendRequest<Farmaceut>(Operation.Login, farmaceut);
            return HandleResponse<Farmaceut>();
        }

        #region ucitaj methods
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
        internal List<Korisnik> UcitajKorisnik()
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

        // gotta fix this
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
        internal PromoKod PretraziPromoKod(PromoKod promoKod)
        {
            SendRequest<PromoKod>(Operation.PretraziPromoKod, promoKod);
            return HandleResponse<PromoKod>();
        }
        internal Racun PretraziRacun(Racun racun)
        {
            SendRequest<Racun>(Operation.PretraziRacun, racun);
            return HandleResponse<Racun>();
        }
        #endregion

        #region kreiraj/ubaci methods
        internal void KreirajFarmaceuta(Farmaceut farmaceut)
        {
            SendRequest<Farmaceut>(Operation.KreirajFarmaceuta, farmaceut);
            HandleResponse<Farmaceut>();
        }
        internal void KreirajKorisnika(Korisnik korisnik)
        {
            SendRequest<Korisnik>(Operation.KreirajKorisnika, korisnik);
            HandleResponse<Korisnik>();
        }
        internal void KreirajLek(Lek lek)
        {
            SendRequest<Lek>(Operation.KreirajLek, lek);
            HandleResponse<Lek>();
        }
        internal void UbaciLokaciju(Lokacija lokacija)
        {
            SendRequest<Lokacija>(Operation.UbaciLokaciju, lokacija);
            HandleResponse<Lokacija>();
        }
        internal void KreirajPromoKod(PromoKod promoKod)
        {
            SendRequest<PromoKod>(Operation.KreirajPromoKod, promoKod);
            HandleResponse<PromoKod>();
        }
        internal void KreirajRacun(Racun racun)
        {
            SendRequest<Racun>(Operation.KreirajRacun, racun);
            HandleResponse<Racun>();
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

    }



}
