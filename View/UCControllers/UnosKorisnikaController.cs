using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;

namespace View.UCControllers
{
    public class UnosKorisnikaController
    {
        private FrmUnosKorisnika form;
        private int idPromoKod;
        private int idNewKorisnik;
        private bool isDeleted = false;

        public UnosKorisnikaController(FrmUnosKorisnika form)
        {
            this.form = form;
            this.idPromoKod = Communication.Instance.KreirajPromoKod(new PromoKod());
            Korisnik k = new Korisnik()
            {
                Ime = "",
                Prezime = "",
                Email = "",
                KontaktTelefon = "",
                DatumUclanjenja = DateTime.Today,
                GodineClanstva = 0,
                IdPromoKod = idPromoKod
            };
            this.idNewKorisnik = Communication.Instance.KreirajKorisnika(k);
        }

        // this is the general event of leaving this user control
        internal void Leave()
        {
            if (isDeleted) return;
            try
            {
                Korisnik noviKorisnik = new Korisnik { IdKorisnik = idNewKorisnik };
                Communication.Instance.ObrisiKorisnika(noviKorisnik);
                Communication.Instance.ObrisiPromoKod(new PromoKod { IdPromoKod = idPromoKod });
                isDeleted = true;
                return;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        internal void SaveUser()
        {
            if (!ValidateInputs())
            {
                form.Success = false;
                return;
            }

            try
            {
                Korisnik korisnik = new Korisnik
                {
                    IdKorisnik = idNewKorisnik,
                    Ime = form.TxtIme.Text,
                    Prezime = form.TxtPrezime.Text,
                    Email = form.TxtEmail.Text,
                    KontaktTelefon = form.TxtKontaktTelefon.Text,
                    DatumUclanjenja = DateTime.Today,
                    GodineClanstva = 0,
                    IdPromoKod = idPromoKod,

                };

                Communication.Instance.PromeniKorisnika(korisnik);
                form.Success = true;
                form.Close();
            }
            catch (Exception)
            {
                throw;
            }
            MessageBox.Show("Korisnik uspesno sacuvan!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public int IzracunajBrojGodina(DateTime fromDate)
        {
            DateTime today = DateTime.Today;

            int yearDifference = today.Year - fromDate.Year;

            bool hasHadAnniversaryThisYear =
                (today.Month > fromDate.Month) ||
                (today.Month == fromDate.Month && today.Day >= fromDate.Day);

            if (!hasHadAnniversaryThisYear)
            {
                yearDifference--;
            }

            return yearDifference;
        }


        private bool ValidateInputs()
        {
            if(string.IsNullOrWhiteSpace(form.TxtIme.Text) || string.IsNullOrWhiteSpace(form.TxtPrezime.Text) 
                || string.IsNullOrWhiteSpace(form.TxtEmail.Text) || string.IsNullOrWhiteSpace(form.TxtKontaktTelefon.Text))
            {
                if (string.IsNullOrEmpty(form.TxtIme.Text))
                {
                    form.TxtIme.BackColor = Color.Salmon;
                }
                else { form.TxtIme.BackColor = default; }
                if (string.IsNullOrEmpty(form.TxtPrezime.Text))
                {
                    form.TxtPrezime.BackColor = Color.Salmon;
                }
                else { form.TxtPrezime.BackColor = default; }
                if (string.IsNullOrEmpty(form.TxtEmail.Text))
                {
                    form.TxtEmail.BackColor = Color.Salmon;
                }
                else { form.TxtEmail.BackColor = default; }
                if (string.IsNullOrEmpty(form.TxtKontaktTelefon.Text))
                {
                    form.TxtKontaktTelefon.BackColor = Color.Salmon;
                }
                else { form.TxtKontaktTelefon.BackColor = default; }
                return false;
            }
            else
            {
                form.TxtIme.BackColor = default;
                form.TxtPrezime.BackColor = default;
                form.TxtEmail.BackColor = default;
                form.TxtKontaktTelefon.BackColor = default;
                return true;
            }
        }

        internal void HandleOtkaziButton()
        {
            form.Success = false;
            form.Close();
        }
    }
}


