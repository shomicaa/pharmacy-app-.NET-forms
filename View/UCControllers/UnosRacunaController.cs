using Domain;
using Microsoft.IdentityModel.Tokens;
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
        private bool isDone = false;

        private BindingList<Farmaceut> farmaceuti;
        private BindingList<Korisnik> korisnici;
        private BindingList<Lek> lekovi;

        private const double stopaPoreza = 5;

        private Racun racun;
        private int brojStavki = 0;

        private BindingList<StavkaRacuna> stavkeRacuna = new BindingList<StavkaRacuna>();
        public UnosRacunaController(FrmUnosRacuna form)
        {
            this.form = form;
            farmaceuti = VratiFarmaceute();
            korisnici = VratiKorisnike();
            lekovi = new BindingList<Lek>(Communication.Instance.UcitajLekove());

            form.CmbFarmaceut1.DataSource = farmaceuti;
            form.CmbFarmaceut1.SelectedItem = null;
            form.CmbKorisnik.DataSource = korisnici;
            form.CmbKorisnik.SelectedItem = null;
            form.CmbLek.DataSource = lekovi;
            form.CmbLek.SelectedItem = null;

            form.DgvStavkeRacuna.DataSource = stavkeRacuna;
            LoadDgvSettings();

            racun = new Racun()
            {
                IdFarmaceut = 2,
                IdKorisnik = 4003,
                IznosPoreza = 0,
                UkupnaVrednost = 0,
                UkupnaVrednostSaPorezom = 0,
                DatumIzdavanja = DateTime.Today,
            };

            int idNewRacun = Communication.Instance.KreirajRacun(racun);
            racun.IdRacun = idNewRacun;
        }

        private void LoadDgvSettings()
        {
            form.DgvStavkeRacuna.Columns["TableName"].Visible = false;
            form.DgvStavkeRacuna.Columns["SelectValues"].Visible = false;
            form.DgvStavkeRacuna.Columns["SearchKeyword"].Visible = false;
            form.DgvStavkeRacuna.Columns["IdRacun"].Visible = false;
            form.DgvStavkeRacuna.Columns["IdLek"].Visible = false;
        }

        internal void Leave()
        {
            // theres no SO for Racun delete, so its gonna be saved in the database with default foreign keys
            isDone = true;
            return;
        }

        internal void SaveRacun()
        {
            if (stavkeRacuna == null || stavkeRacuna.Count == 0 )
            {
                form.Success = false;
                MessageBox.Show("Mora postojati makar jedna stavka računa!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double ukupnaVrednost = 0;
                foreach(var item in stavkeRacuna)
                {
                    ukupnaVrednost += item.ProdajnaVrednost;
                }
                double ukupnaVrednostSaPorezom = ukupnaVrednost + (ukupnaVrednost * (stopaPoreza / 100));

                racun.UkupnaVrednost = ukupnaVrednost;
                racun.IznosPoreza = stopaPoreza;
                racun.UkupnaVrednostSaPorezom = ukupnaVrednostSaPorezom;
                racun.DatumIzdavanja = DateTime.Today;
                racun.IdFarmaceut = ((Farmaceut)form.CmbFarmaceut1.SelectedItem).IdFarmaceut;
                racun.IdKorisnik = ((Korisnik)form.CmbKorisnik.SelectedItem).IdKorisnik;
                racun.Stavke = stavkeRacuna.ToList();
                
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
            if (form.CmbLek.SelectedItem == null)
            {
                form.CmbLek.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                form.CmbLek.BackColor = default;
            }

            if (string.IsNullOrEmpty(form.TxtKolicina.Text))
            {
                form.CmbKorisnik.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                form.CmbKorisnik.BackColor = default;
            }
            if(!(int.TryParse(form.TxtKolicina.Text, out int _)))
            {
                form.TxtKolicina.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                form.TxtKolicina.BackColor = default;
            }

            if (!valid)
            {
                return false;
            }


            return true;
        }


        internal void HandleOtkaziButton()
        {
            form.Success = false;
            form.Close();
        }

        internal void DodajStavku()
        {
            if (!ValidateInputs())
            {
                return;
            }
            form.CmbFarmaceut1.Enabled = false;
            form.CmbKorisnik.Enabled = false;

            Lek lek = (Lek)form.CmbLek.SelectedItem;
            int kolicina = int.Parse(form.TxtKolicina.Text);

            StavkaRacuna stavka = new StavkaRacuna
            {
                IdRacun = racun.IdRacun,
                RbStavke = ++brojStavki,
                Kolicina = int.Parse(form.TxtKolicina.Text),
                Lek = lek,
                IdLek = lek.IdLek,
                ProdajnaVrednost = lek.Cena * kolicina,
            };

            bool repeatedItem = false;

            foreach(var item in stavkeRacuna)
            {
                if (item.IdLek == stavka.IdLek)
                    repeatedItem = true;               
            }

            if (repeatedItem)
            {
                for (int i = 0; i < stavkeRacuna.Count; i++)
                {
                    if (stavkeRacuna[i].IdLek == stavka.IdLek)
                    {
                        stavka.Kolicina += stavkeRacuna[i].Kolicina;
                        stavka.ProdajnaVrednost += stavkeRacuna[i].ProdajnaVrednost;
                        stavkeRacuna.Remove(stavkeRacuna[i]);
                        stavkeRacuna.Add(stavka);
                    }
                    stavkeRacuna = HandleOrder(stavkeRacuna);
                }
            }
            else
            {
                stavkeRacuna.Add(stavka);
            }
            
        }

        internal void UkloniStavku()
        {
            if (form.DgvStavkeRacuna.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali stavku za uklanjanje!");
                return;
            }

            DataGridViewRow red = form.DgvStavkeRacuna.SelectedRows[0];

            StavkaRacuna stavka = (StavkaRacuna)red.DataBoundItem;
            stavkeRacuna.Remove(stavka);

            stavkeRacuna = HandleOrder(stavkeRacuna);

        }

        internal BindingList<StavkaRacuna> HandleOrder(BindingList<StavkaRacuna> list)
        {
            int counter = 1;

            foreach(var stavka in list)
            {
                stavka.RbStavke = counter++;
            }
            brojStavki = list.Count;

            return list;
        }

        private BindingList<Farmaceut> VratiFarmaceute()
        {
            BindingList<Farmaceut> farmaceuti = new BindingList<Farmaceut>(Communication.Instance.UcitajFarmaceute());
            BindingList<Farmaceut> farmaceutiFiltered = new BindingList<Farmaceut>();
            foreach (var farmaceut in farmaceuti)
            {
                if (farmaceut.IdFarmaceut != 2)
                    farmaceutiFiltered.Add(farmaceut);
            }
            return farmaceutiFiltered;
        }
        private BindingList<Korisnik> VratiKorisnike()
        {
            BindingList<Korisnik> korisnici = new BindingList<Korisnik>(Communication.Instance.UcitajKorisnike());
            BindingList<Korisnik> korisniciFiltered = new BindingList<Korisnik>();
            foreach (var korisnik in korisnici)
            {
                if (korisnik.IdKorisnik != 4003)
                    korisniciFiltered.Add(korisnik);
            }
            return korisniciFiltered;
        }
    }
}
