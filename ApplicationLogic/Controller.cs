using Domain;
using SystemOperations.FarmaceutOperations;
using SystemOperations.KorisnikOperations;
using SystemOperations.LekOperations;
using SystemOperations.LokacijaOperations;
using SystemOperations.PromoKodOperations;
using SystemOperations.RacunOperations;

namespace ApplicationLogic
{
    public class Controller
    {
        #region singleton
        private volatile static Controller instance;
        private static object _lock = new object();
        
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Controller();
                        }
                    }
                }
                return instance;
            }
        }

        private Controller()
        {
        }
        #endregion

        #region delete methods
        public void ObrisiFarmaceut(Farmaceut farmaceut)
        {
            ObrisiFarmaceutSO so = new ObrisiFarmaceutSO();
            so.ExecuteTemplate(farmaceut);
        }
        public void ObrisiKorisnik(Korisnik korisnik)
        {
            ObrisiKorisnikSO so = new ObrisiKorisnikSO();
            so.ExecuteTemplate(korisnik);
        }
        public void ObrisiLek(Lek farmaceut)
        {
            ObrisiFarmaceutSO so = new ObrisiFarmaceutSO();
            so.ExecuteTemplate(farmaceut);
        }
        public void ObrisiLokacija(Lokacija lokacija)
        {
            ObrisiLokacijaSO so = new ObrisiLokacijaSO();
            so.ExecuteTemplate(lokacija);
        }
        public void ObrisiPromoKod(PromoKod promoKod)
        {
            ObrisiPromoKodSO so = new ObrisiPromoKodSO();
            so.ExecuteTemplate(promoKod);
        }
        #endregion

        #region update methods

        public void PromeniFarmaceut(Farmaceut farmaceut)
        {
            PromeniFarmaceutSO so = new PromeniFarmaceutSO();
            so.ExecuteTemplate(farmaceut);
        }
        public void PromeniKorisnik(Korisnik korisnik)
        {
            PromeniKorisnikSO so = new PromeniKorisnikSO();
            so.ExecuteTemplate(korisnik);
        }
        public void PromeniLek(Lek lek)
        {
            PromeniLekSO so = new PromeniLekSO();
            so.ExecuteTemplate(lek);
        }
        public void PromeniLokacija(Lokacija lokacija)
        {
            PromeniLokacijaSO so = new PromeniLokacijaSO();
            so.ExecuteTemplate(lokacija);
        }
        public void PromeniPromoKod(PromoKod promoKod)
        {
            PromeniPromoKodSO so = new PromeniPromoKodSO();
            so.ExecuteTemplate(promoKod);
        }
        public void PromeniRacun(Racun racun)
        {
            PromeniRacunSO so = new PromeniRacunSO();
            so.ExecuteTemplate(racun);
        }

        #endregion

        #region getAll methods
        public List<Farmaceut> UcitajFarmaceute()
        {
            UcitajSveFarmaceuteSO so = new UcitajSveFarmaceuteSO();
            so.ExecuteTemplate(new Farmaceut());
            return so.Result;
        }
        public List<Korisnik> UcitajKorisnike()
        {
            UcitajSveKorisnikeSO so = new UcitajSveKorisnikeSO();
            so.ExecuteTemplate(new Korisnik());
            return so.Result;
        }
        public List<Lek> UcitajLekove()
        {
            UcitajSveLekoveSO so = new UcitajSveLekoveSO();
            so.ExecuteTemplate(new Lek());
            return so.Result;
        }
        public List<Lokacija> UcitajLokacije()
        {
            UcitajSveLokacijeSO so = new UcitajSveLokacijeSO();
            so.ExecuteTemplate(new Lek());
            return so.Result;
        }
        public List<PromoKod> UcitajPromoKodove()
        {
            UcitajSvePromoKodoveSO so = new UcitajSvePromoKodoveSO();
            so.ExecuteTemplate(new PromoKod());
            return so.Result;
        }
        public List<Racun> UcitajRacune()
        {
            UcitajSveRacuneSO so = new UcitajSveRacuneSO();
            so.ExecuteTemplate(new Racun());
            return so.Result;
        }
        #endregion

    }
}
