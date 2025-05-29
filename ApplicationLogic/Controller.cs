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

        public Farmaceut Login(Farmaceut farmaceut)
        {
            PrijaviFarmaceutSO so = new PrijaviFarmaceutSO();
            so.ExecuteTemplate(farmaceut);
            return so.Result;
        }

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
        public void ObrisiLek(Lek lek)
        {
            ObrisiLekSO so = new ObrisiLekSO();
            so.ExecuteTemplate(lek);
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
            so.ExecuteTemplate(new Lokacija());
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

        #region kreiraj/ubaci methods
        public int KreirajFarmaceut()
        {
            KreirajFarmaceutSO so = new KreirajFarmaceutSO();
            so.ExecuteTemplate(new Farmaceut());
            return so.Result;
        }
        public int KreirajKorisnik()
        {
            KreirajKorisnikSO so = new KreirajKorisnikSO();
            so.ExecuteTemplate(new Korisnik());
            return so.Result;
        }
        public int KreirajLek()
        {
            KreirajLekSO so = new KreirajLekSO();
            so.ExecuteTemplate(new Lek());
            return so.Result;
        }
        public void UbaciLokacija(Lokacija lokacija)
        {
            UbaciLokacijaSO so = new UbaciLokacijaSO();
            so.ExecuteTemplate(lokacija);
        }
        public int KreirajPromoKod()
        {
            KreirajPromoKodSO so = new KreirajPromoKodSO();
            so.ExecuteTemplate(new PromoKod());
            return so.Result;
        }
        public int KreirajRacun()
        {
            KreirajRacunSO so = new KreirajRacunSO();
            so.ExecuteTemplate(new Racun());
            return so.Result;
        }
        #endregion

        #region pretrazi methods
        public List<Farmaceut> PretraziFarmaceut(Farmaceut farmaceut)
        {
            PretraziFarmaceutSO so = new PretraziFarmaceutSO();
            so.ExecuteTemplate(farmaceut);
            return so.Result;
        }
        public List<Korisnik> PretraziKorisnik(Korisnik korisnik)
        {
            PretraziKorisnikSO so = new PretraziKorisnikSO();
            so.ExecuteTemplate(korisnik);
            return so.Result;
        }
        public List<Lek> PretraziLek(Lek lek)
        {
            PretraziLekSO so = new PretraziLekSO();
            so.ExecuteTemplate(lek);
            return so.Result;
        }
        public List<Lokacija> PretraziLokacija(Lokacija lokacija)
        {
            PretraziLokacijaSO so = new PretraziLokacijaSO();
            so.ExecuteTemplate(lokacija);
            return so.Result;
        }
        public List<PromoKod> PretraziPromoKod(PromoKod promoKod)
        {
            PretraziPromoKodSO so = new PretraziPromoKodSO();
            so.ExecuteTemplate(promoKod);
            return so.Result;
        }
        public List<Racun> PretraziRacun(Racun racun)
        {
            PretraziRacunSO so = new PretraziRacunSO();
            so.ExecuteTemplate(racun);
            return so.Result;
        }
        #endregion
    }
}
