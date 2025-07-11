using Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;

namespace View.UCControllers
{
    public class PrikazRacunaController
    {
        private FrmPrikazRacuna form;
        private Racun racun;
        private RacunFK racunFK;
        private BindingList<Lek> lekovi;
        private int brojStavki;
        private double defaultStopaPoreza;

        public PrikazRacunaController(FrmPrikazRacuna frmPrikazRacuna, Racun racun)
        {
            this.form = frmPrikazRacuna;
            this.racun = racun;
            racunFK = ConvertToRacunFK(racun);

            foreach (var stavka in racun.Stavke)
            {
                stavka.Lek = Communication.Instance.PretraziLek(new Lek { IdLek = stavka.IdLek });
            }

            form.DgvStavke.DataSource = racun.Stavke;
            brojStavki = racun.Stavke.Count;
            defaultStopaPoreza = racun.IznosPoreza;

            lekovi = new BindingList<Lek>(Communication.Instance.UcitajLekove());
            form.CmbLek.DataSource = lekovi;
            form.CmbLek.SelectedItem = null;

            LoadRacunSettings();
            LoadDgvSettings();

            
        }


        internal void DodajStavku()
        {
            if (form.CmbLek.SelectedItem is not Lek selectedLek)
            {
                MessageBox.Show("Morate odabrati lek.");
                return;
            }

            if (!int.TryParse(form.TxtKolicina.Text, out int kolicina) || kolicina <= 0)
            {
                MessageBox.Show("Unesite validnu količinu.");
                return;
            }

            StavkaRacuna stavka = new StavkaRacuna
            {
                IdRacun = racun.IdRacun,
                Lek = selectedLek,
                IdLek = selectedLek.IdLek,
                Kolicina = kolicina,
                ProdajnaVrednost = selectedLek.Cena * kolicina,
            };


            for (int i = 0; i < racun.Stavke.Count; i++)
            {
                if (racun.Stavke[i].IdLek == stavka.IdLek)
                {
                    racun.Stavke[i].Kolicina += stavka.Kolicina;
                    racun.Stavke[i].ProdajnaVrednost += stavka.ProdajnaVrednost;

                    SrediDgv();
                    return;
                }
            }
            racun.Stavke.Add(stavka);
            SrediDgv();
        }

        internal void IzmeniStavku()
        {
            if (form.DgvStavke.CurrentRow == null)
            {
                MessageBox.Show("Morate odabrati stavku za izmenu.");
                return;
            }

            if (form.CmbLek.SelectedItem is not Lek selectedLek)
            {
                MessageBox.Show("Morate odabrati lek.");
                return;
            }

            if (!int.TryParse(form.TxtKolicina.Text, out int kolicina) || kolicina <= 0)
            {
                MessageBox.Show("Unesite validnu količinu.");
                return;
            }

            StavkaRacuna selectedStavka = (StavkaRacuna)form.DgvStavke.CurrentRow.DataBoundItem;
            int indexSelectedStavka = form.DgvStavke.CurrentRow.Index;

            for (int i = 0; i < racun.Stavke.Count; i++)
            {
                Lek izabraniLek = (Lek)form.CmbLek.SelectedItem;
                int _kolicina = int.Parse(form.TxtKolicina.Text);

                if (racun.Stavke[i].IdLek == izabraniLek.IdLek && indexSelectedStavka != i)
                {
                    racun.Stavke[i].Kolicina += _kolicina;
                    racun.Stavke[i].ProdajnaVrednost += _kolicina * izabraniLek.Cena;

                    racun.Stavke.Remove(selectedStavka);

                    SrediDgv();
                    return;
                }
            }

            selectedStavka.IdLek = selectedLek.IdLek;
            selectedStavka.Lek = selectedLek;
            selectedStavka.Kolicina = kolicina;
            selectedStavka.ProdajnaVrednost = selectedLek.Cena * kolicina;

            SrediDgv();
        }

        internal void UkloniStavku()
        {
            if (form.DgvStavke.CurrentRow == null)
            {
                MessageBox.Show("Morate odabrati stavku za uklanjanje.");
                return;
            }

            StavkaRacuna selectedStavka = (StavkaRacuna)form.DgvStavke.CurrentRow.DataBoundItem;
            racun.Stavke.Remove(selectedStavka);
            SrediDgv();
        }

        internal void Otkazi()
        {
            form.Success = false;
            form.Close();
        }

        internal void SacuvajPromene()
        {
            if(string.IsNullOrEmpty(form.TxtStopaPoreza.Text.ToString()) || !int.TryParse(form.TxtStopaPoreza.Text, out int result))
            {
                MessageBox.Show("Lepo unesite poresku stopu!");
                return;
            }

            try
            {
                racun.UkupnaVrednost = double.Parse(form.TxtIznos.Text);
                racun.IznosPoreza = double.Parse(form.TxtStopaPoreza.Text);
                racun.UkupnaVrednostSaPorezom = racun.UkupnaVrednost + (racun.UkupnaVrednost * (racun.IznosPoreza / 100));

                Communication.Instance.PromeniRacun(racun);
                MessageBox.Show("Izmene sačuvane!", "Operacija uspesno izvršena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da promeni odabrani račun.\n" + ex.Message);
            }
        }
         

        internal void IzracunajVrednostiRacuna()
        {
            double ukupno = 0;

            foreach (var stavka in racun.Stavke)
            {
                ukupno += stavka.ProdajnaVrednost;
            }

            racun.UkupnaVrednost = ukupno;

            if (!double.TryParse(form.TxtStopaPoreza.Text, out double stopaPoreza))
            {
                stopaPoreza = defaultStopaPoreza; // fallback
            }

            racun.IznosPoreza = stopaPoreza;
            racun.UkupnaVrednostSaPorezom = ukupno + (ukupno * (stopaPoreza / 100));

            form.TxtIznos.Text = racun.UkupnaVrednost.ToString("F2");
            form.TxtIznosSaPorezom.Text = racun.UkupnaVrednostSaPorezom.ToString("F2");
        }

        private void RenumberStavke()
        {
            for (int i = 0; i < racun.Stavke.Count; i++)
            {
                racun.Stavke[i].RbStavke = i + 1;
            }     
        }
        private void SrediDgv()
        {
            RenumberStavke();
            IzracunajVrednostiRacuna();
            form.DgvStavke.Refresh();
        }

        internal BindingList<StavkaRacuna> HandleOrder(BindingList<StavkaRacuna> list)
        {
            int counter = 1;

            foreach (var stavka in list)
            {
                stavka.RbStavke = counter++;
            }
            brojStavki = list.Count;

            return list;
        }

        private void LoadDgvSettings()
        {
            form.DgvStavke.Columns["TableName"].Visible = false;
            form.DgvStavke.Columns["SelectValues"].Visible = false;
            form.DgvStavke.Columns["SearchKeyword"].Visible = false;
            form.DgvStavke.Columns["IdRacun"].Visible = false;
            form.DgvStavke.Columns["IdLek"].Visible = false;

            form.DgvStavke.Columns["Lek"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            form.DgvStavke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadRacunSettings()
        {
            form.TextBox1.Text = racunFK.IdRacun.ToString();
            form.TxtIznos.Text = racunFK.UkupnaVrednost.ToString();
            form.TxtStopaPoreza.Text = racunFK.IznosPoreza.ToString();
            form.TxtIznosSaPorezom.Text = racunFK.UkupnaVrednostSaPorezom.ToString();
            form.DtPickerDatumIzdavanja.Value = racunFK.DatumIzdavanja;
            form.LblKorisnikIme.Text = racunFK.Korisnik.ToString();
            form.LblFarmaceutIme.Text = racunFK.Farmaceut.ToString();

            form.TextBox1.Enabled = false;
            form.TxtIznos.Enabled = false;
            form.TxtIznosSaPorezom.Enabled = false;
            form.DtPickerDatumIzdavanja.Enabled = false;
            form.LblKorisnikIme.Enabled = false;
            form.LblFarmaceutIme.Enabled = false;
        }



        public RacunFK ConvertToRacunFK(Racun racun)
        {
            RacunFK displayRacun = new RacunFK()
            {
                IdRacun = racun.IdRacun,
                Stavke = racun.Stavke,
                UkupnaVrednost = racun.UkupnaVrednost,
                IznosPoreza = racun.IznosPoreza,
                UkupnaVrednostSaPorezom = racun.UkupnaVrednostSaPorezom,
                DatumIzdavanja = racun.DatumIzdavanja,
                Farmaceut = Communication.Instance.PretraziFarmaceuta(new Farmaceut { IdFarmaceut = racun.IdFarmaceut }),
                Korisnik = Communication.Instance.PretraziKorisnika(new Korisnik { IdKorisnik = racun.IdKorisnik }),
            };

            return displayRacun;
        }
        public Racun ConvertToRacun(RacunFK racunFK)
        {
            Racun racun = new Racun()
            {
                IdRacun = racunFK.IdRacun,
                Stavke = racunFK.Stavke,
                UkupnaVrednost = racunFK.UkupnaVrednost,
                IznosPoreza = racunFK.IznosPoreza,
                UkupnaVrednostSaPorezom = racunFK.UkupnaVrednostSaPorezom,
                DatumIzdavanja = racunFK.DatumIzdavanja,
                IdFarmaceut = racunFK.Farmaceut.IdFarmaceut,
                IdKorisnik = racunFK.Korisnik.IdKorisnik
            };

            return racun;
        }

    }
}
