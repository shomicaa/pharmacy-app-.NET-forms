using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Exceptions;
using View.UserControls;

namespace View.UCControllers
{
    internal class RacuniController
    {
        private UCRacuni uc;
        private BindingList<Racun> racuni;
        private BindingList<Farmaceut> farmaceuti;
        private BindingList<Korisnik> korisnici;

        private BindingList<Racun> racuniFarmaceutFilter;
        private BindingList<Racun> racuniKorisnikFilter;

        public RacuniController(UCRacuni uc)
        {
            this.uc = uc;
            racuni = new BindingList<Racun>(Communication.Instance.UcitajRacune());
            farmaceuti = new BindingList<Farmaceut>(Communication.Instance.UcitajFarmaceute());
            korisnici = new BindingList<Korisnik>(Communication.Instance.UcitajKorisnike());
            uc.CmbFarmaceut.DataSource = farmaceuti;
            uc.CmbFarmaceut.SelectedItem = null;
            uc.CmbKorisnik.DataSource = korisnici;
            uc.CmbKorisnik.SelectedItem = null;
            uc.CmbFarmaceut.Enabled = false;
            uc.CmbKorisnik.Enabled = false;

            uc.CmbFarmaceutFilter.DataSource = farmaceuti;
            uc.CmbFarmaceutFilter.SelectedItem = null;
            uc.CmbFarmaceutFilter.Text = "--farmaceutu--";
            uc.CmbKorisnikFilter.DataSource = korisnici;
            uc.CmbKorisnikFilter.SelectedItem = null;
            uc.CmbKorisnikFilter.Text = "--korisniku--";
        }

        internal void UcitajRacune()
        {
            try
            {
                racuni = new BindingList<Racun>(Communication.Instance.UcitajRacune());

                if (racuni == null | racuni.Count == 0)
                {
                    MessageBox.Show("Trenutno nema unetih računa.");
                    uc.DgvRacuni.DataSource = null;
                    return;
                }

                uc.DgvRacuni.DataSource = racuni;
                uc.DgvRacuni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                LoadDgvSettings();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita račune.\n" + ex.Message);

            }
        }

        internal void IzmeniRacun()
        {
            if (uc.DgvRacuni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali račun za menjanje!");
                return;
            }
            if (string.IsNullOrEmpty(uc.TxtIznos.Text) || string.IsNullOrEmpty(uc.TxtStopaPoreza.Text) 
                || uc.CmbFarmaceut.SelectedItem == null || uc.CmbKorisnik.SelectedItem == null)
            {
                MessageBox.Show("Polja ne smeju ostati prazna!");
                return;
            }
            double iznos, stopaPoreza;

            bool isIznosValid = double.TryParse(uc.TxtIznos.Text, out iznos);
            bool isStopaPorezaValid = double.TryParse(uc.TxtStopaPoreza.Text, out stopaPoreza);

            if (!isIznosValid || !isStopaPorezaValid)
            {
                MessageBox.Show("Polja Iznos i Stopa Poreza moraju biti validni brojevi.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Stop further processing
            }
            try
            {
                DataGridViewRow red = uc.DgvRacuni.SelectedRows[0];
                Racun racunIzDgv = (Racun)red.DataBoundItem;

                Racun racun = Communication.Instance.PretraziRacun(racunIzDgv);

                racun.UkupnaVrednost = double.Parse(uc.TxtIznos.Text);
                racun.IznosPoreza = double.Parse(uc.TxtStopaPoreza.Text);
                racun.UkupnaVrednostSaPorezom = racun.UkupnaVrednost + (racun.UkupnaVrednost * (racun.IznosPoreza / 100));
                racun.DatumIzdavanja = uc.DtPickerDatumIzdavanja.Value;
                racun.IdFarmaceut = ((Farmaceut)uc.CmbFarmaceut.SelectedItem).IdFarmaceut;
                racun.IdKorisnik = ((Korisnik)uc.CmbKorisnik.SelectedItem).IdKorisnik;

                Communication.Instance.PromeniRacun(racun);
                MessageBox.Show("Sistem je promenio odabrani račun!", "Operacija uspesno izvršena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Sistem ne može da promeni odabrani račun.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da promeni odabrani račun.\n" + ex.Message);

            }
        }

        internal void PrikaziPodatke()
        {
            if (uc.DgvRacuni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite račun za prikaz!");
                return;
            }
            try
            {
                DataGridViewRow red = uc.DgvRacuni.SelectedRows[0];

                Racun racunIzDgv = (Racun)red.DataBoundItem;
                Racun racun = Communication.Instance.PretraziRacun(racunIzDgv);

                uc.TxtIznos.Text = racun.UkupnaVrednost.ToString();
                uc.TxtStopaPoreza.Text = racun.IznosPoreza.ToString();
                uc.DtPickerDatumIzdavanja.Value = racun.DatumIzdavanja;
                uc.CmbFarmaceut.SelectedItem = farmaceuti.FirstOrDefault(f => f.IdFarmaceut == racun.IdFarmaceut);
                uc.CmbKorisnik.SelectedItem = korisnici.FirstOrDefault(k => k.IdKorisnik == racun.IdKorisnik);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da promeni odabrani račun.\n" + ex.Message);

            }
        }

        internal void Pretrazi()
        {
            if (uc.CmbFarmaceutFilter.SelectedItem == null && uc.CmbKorisnikFilter.SelectedItem == null)
            {
                return;
            }

            try
            {
                Racun racunFarmaceut = new Racun();
                Racun racunKorisnik = new Racun();

                if (uc.CmbFarmaceutFilter.SelectedItem != null && uc.CmbKorisnikFilter.SelectedItem != null)
                {
                    Farmaceut farmaceut = (Farmaceut)uc.CmbFarmaceutFilter.SelectedItem;
                    racunFarmaceut.JoinClause = "JOIN Farmaceut f ON r.IdFarmaceut = f.Id";
                    racunFarmaceut.WhereClause = "f.Id = @id";
                    racunFarmaceut.JoinParameters = new Dictionary<string, object>
                    {
                        ["@id"] = farmaceut.IdFarmaceut
                    };

                    racuniFarmaceutFilter = new BindingList<Racun>(Communication.Instance.UcitajRacuneSaZahtevom(racunFarmaceut));


                    Korisnik korisnik = (Korisnik)uc.CmbKorisnikFilter.SelectedItem;
                    racunKorisnik.JoinClause = "JOIN Korisnik k ON r.IdKorisnik = k.Id";
                    racunKorisnik.WhereClause = "k.Id = @id";
                    racunKorisnik.JoinParameters = new Dictionary<string, object>
                    {
                        ["@id"] = korisnik.IdKorisnik
                    };
                    racuniKorisnikFilter = new BindingList<Racun>(Communication.Instance.UcitajRacuneSaZahtevom(racunKorisnik));

                    uc.DgvRacuni.DataSource = new BindingList<Racun>(racuniFarmaceutFilter
                                        .Where(rf => racuniKorisnikFilter.Any(rk => rk.IdRacun == rf.IdRacun))
                                        .ToList());



                }
                else if(uc.CmbFarmaceutFilter.SelectedItem != null && uc.CmbKorisnikFilter.SelectedItem == null)
                {
                    Farmaceut farmaceut = (Farmaceut)uc.CmbFarmaceutFilter.SelectedItem;
                    racunFarmaceut.JoinClause = "JOIN Farmaceut f ON r.IdFarmaceut = f.Id";
                    racunFarmaceut.WhereClause = "f.Id = @id";
                    racunFarmaceut.JoinParameters = new Dictionary<string, object>
                    {
                        ["@id"] = farmaceut.IdFarmaceut
                    };

                    uc.DgvRacuni.DataSource = new BindingList<Racun>(Communication.Instance.UcitajRacuneSaZahtevom(racunFarmaceut));
                }
                else
                {
                    Korisnik korisnik = (Korisnik)uc.CmbKorisnikFilter.SelectedItem;
                    racunKorisnik.JoinClause = "JOIN Korisnik k ON r.IdKorisnik = k.Id";
                    racunKorisnik.WhereClause = "k.Id = @id";
                    racunKorisnik.JoinParameters = new Dictionary<string, object>
                    {
                        ["@id"] = korisnik.IdKorisnik
                    };
                    uc.DgvRacuni.DataSource = new BindingList<Racun>(Communication.Instance.UcitajRacuneSaZahtevom(racunKorisnik));
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da pretraži račune.\n" + ex.Message);
            }
        }

        internal void PonistiFilter()
        {
            uc.CmbFarmaceutFilter.SelectedItem = null;
            uc.CmbKorisnikFilter.SelectedItem = null;
        }

        private void LoadDgvSettings()
        {
            uc.DgvRacuni.Columns["TableName"].Visible = false;
            uc.DgvRacuni.Columns["TableAlias"].Visible = false;
            uc.DgvRacuni.Columns["SelectValues"].Visible = false;
            uc.DgvRacuni.Columns["SearchKeyword"].Visible = false;
            uc.DgvRacuni.Columns["JoinClause"].Visible = false;
            uc.DgvRacuni.Columns["WhereClause"].Visible = false;
            uc.DgvRacuni.Columns["JoinParameters"].Visible = false;

            uc.DgvRacuni.Columns["UkupnaVrednost"].Visible = false;
            uc.DgvRacuni.Columns["IznosPoreza"].Visible = false;

            uc.DgvRacuni.Columns["UkupnaVrednostSaPorezom"].HeaderText = "Iznos sa porezom";
            uc.DgvRacuni.Columns["DatumIzdavanja"].HeaderText = "Datum izdavanja";
            uc.DgvRacuni.Columns["IdRacun"].HeaderText = "ID";

        }
    }
}
