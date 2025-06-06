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
    internal class UnosRacunaController
    {
        private FrmUnosRacuna form;
        private int idNewRacun;
        private bool isDone = false;

        private BindingList<Farmaceut> farmaceuti;
        private BindingList<Korisnik> korisnici;
        public UnosRacunaController(FrmUnosRacuna form)
        {
            this.form = form;
            Racun racun = new Racun()
            {
                IdFarmaceut = 2,
                IdKorisnik = 4003,
                IznosPoreza = 0,
                UkupnaVrednost = 0,
                UkupnaVrednostSaPorezom = 0,
                DatumIzdavanja = DateTime.Today,
            };
            farmaceuti = new BindingList<Farmaceut>(Communication.Instance.UcitajFarmaceute());
            korisnici = new BindingList<Korisnik>(Communication.Instance.UcitajKorisnike());
            form.CmbFarmaceut1.DataSource = farmaceuti;
            form.CmbFarmaceut1.SelectedItem = null;
            form.CmbKorisnik.DataSource = korisnici;
            form.CmbKorisnik.SelectedItem = null;
            this.idNewRacun = Communication.Instance.KreirajRacun(racun);
        }
        internal void Leave()
        {
            // theres no SO for Racun delete, so its gonna be saved in the database with default foreign keys
            isDone = true;
            return;
        }

        internal void SaveRacun()
        {
            if (!ValidateInputs())
            {
                form.Success = false;
                return;
            }

            try
            {
                double Iznos = double.Parse(form.TxtUkupnaVrednost.Text);
                double Porez = double.Parse(form.TxtIznosPoreza.Text);
                Racun racun = new Racun
                {
                    IdRacun = idNewRacun,
                    UkupnaVrednost = Iznos,
                    IznosPoreza = Porez,
                    UkupnaVrednostSaPorezom = Iznos + (Iznos * (Porez / 100)),
                    DatumIzdavanja = DateTime.Today,
                    IdFarmaceut = ((Farmaceut)form.CmbFarmaceut1.SelectedItem).IdFarmaceut,
                    IdKorisnik = ((Korisnik)form.CmbKorisnik.SelectedItem).IdKorisnik,

            };

                Communication.Instance.PromeniRacun(racun);
                form.Success = true;
                form.Close();
            }
            catch (Exception)
            {
                throw;
            }
            MessageBox.Show("Račun uspesno sacuvan!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateInputs()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(form.TxtUkupnaVrednost.Text))
            {
                form.TxtUkupnaVrednost.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                form.TxtUkupnaVrednost.BackColor = default;
            }
            if (string.IsNullOrWhiteSpace(form.TxtIznosPoreza.Text))
            {
                form.TxtIznosPoreza.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                form.TxtIznosPoreza.BackColor = default;
            }
            if (form.CmbFarmaceut1.SelectedItem == null)
            {
                form.CmbFarmaceut1.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                form.CmbFarmaceut1.BackColor = default;
            }
            if (form.CmbKorisnik.SelectedItem == null)
            {
                form.CmbKorisnik.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                form.CmbKorisnik.BackColor = default;
            }
            if (!valid)
            {
                return false;
            }

            bool isUkupnaVrednostDouble = double.TryParse(form.TxtUkupnaVrednost.Text, out _);
            bool isIznosPorezaDouble = double.TryParse(form.TxtIznosPoreza.Text, out _);

            if (!isUkupnaVrednostDouble)
            {
                form.TxtUkupnaVrednost.BackColor = Color.Salmon;
                MessageBox.Show("Polje Ukupna vrednost mora biti broj.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                form.TxtUkupnaVrednost.BackColor = default;
            }

            if (!isIznosPorezaDouble)
            {
                form.TxtIznosPoreza.BackColor = Color.Salmon;
                MessageBox.Show("Polje Iznos poreza mora biti broj.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                form.TxtIznosPoreza.BackColor = default;
            }

            return true;
        }


        internal void HandleOtkaziButton()
        {
            form.Success = false;
            form.Close();
        }
    }
}
