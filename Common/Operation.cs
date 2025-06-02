using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public enum Operation
    {
        Login,

        // farmaceut        korisnik          lek           lokacija         promo kod         racun

        UcitajFarmaceute, UcitajKorisnike, UcitajLekove, UcitajLokacije, UcitajPromoKodove, UcitajRacune,

        ObrisiFarmaceuta, ObrisiKorisnika, ObrisiLek, ObrisiLokaciju, ObrisiPromoKod,

        PromeniFarmaceuta, PromeniKorisnika, PromeniLek, PromeniLokaciju, PromeniPromoKod, PromeniRacun,

        PretraziFarmaceuta, PretraziKorisnika, PretraziLek, PretraziLokaciju, PretraziPromoKod, PretraziRacun,

        KreirajFarmaceuta, KreirajKorisnika, KreirajLek, UbaciLokaciju, KreirajPromoKod, KreirajRacun,

        UcitajSpecificFarmaceute, UcitajSpecificKorisnike, UcitajSpecificLekove, UcitajSpecificLokacije, UcitajSpecificPromoKodove,

        UcitajFarmaceuteSaZahtevom, UcitajKorisnikeSaZahtevom, UcitajRacuneSaZahtevom,

        End,
    }
}
