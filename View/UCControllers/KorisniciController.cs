using Domain;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Exceptions;
using View.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace View.UCControllers
{
    internal class KorisniciController
    {
        private UCKorisnici uc;
        private BindingList<Korisnik> korisnici;
        private string[] filteri = new string[] { "rednom broju", "imenu", "max % popusta" };
        public KorisniciController(UCKorisnici uc)
        {
            this.uc = uc;
            korisnici = new BindingList<Korisnik>(Communication.Instance.UcitajKorisnike());
            uc.CmbFilter.DataSource = filteri;
        }
        internal void UcitajKorisnike()
        {
            try
            {
                korisnici = VratiKorisnike();

                if (korisnici == null || korisnici.Count == 0)
                {
                    MessageBox.Show("Trenutno nema unetih korisnika.");
                    uc.DgvKorisnici.DataSource = null;
                    return;
                }

                uc.DgvKorisnici.DataSource = korisnici;
                uc.DgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                LoadDgvSettings();             
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita korisnike.\n" + ex.Message);

            }
        }

        internal void IzmeniKorisnika()
        {
            if (uc.DgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali korisnika za menjanje!");
                return;
            }
            if(string.IsNullOrEmpty(uc.TxtIme.Text) || string.IsNullOrEmpty(uc.TxtPrezime.Text) || string.IsNullOrEmpty(uc.TxtEmail.Text) || string.IsNullOrEmpty(uc.TxtKontaktTelefon.Text))
            {
                MessageBox.Show("Polja ne smeju ostati prazna!");
                return;
            }

            try
            {
                DataGridViewRow red = uc.DgvKorisnici.SelectedRows[0];
                Korisnik korisnikIzDgv = (Korisnik)red.DataBoundItem;

                Korisnik korisnik = Communication.Instance.PretraziKorisnika(korisnikIzDgv);

                korisnik.Ime = uc.TxtIme.Text;
                korisnik.Prezime = uc.TxtPrezime.Text;
                korisnik.Email = uc.TxtEmail.Text;
                korisnik.KontaktTelefon = uc.TxtKontaktTelefon.Text;

                Communication.Instance.PromeniKorisnika(korisnik);
                MessageBox.Show("Sistem je promenio odabranog korisnika!", "Operacija uspesno izvršena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Sistem ne može da promeni odabranog korisnika.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da promeni odabranog korisnika.\n" + ex.Message);

            }
        }

        internal void ObrisiKorisnika()
        {
            if (uc.DgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali korisnika za brisanje!");
                return;
            }

            DataGridViewRow red = uc.DgvKorisnici.SelectedRows[0];
            Korisnik korisnikIzDgv = (Korisnik)red.DataBoundItem;

            Korisnik korisnik = Communication.Instance.PretraziKorisnika(korisnikIzDgv);

            try
            {
                Communication.Instance.ObrisiKorisnika(korisnik);
                MessageBox.Show("Sistem je izbrisao odabranog korisnika!", "Operacija uspesno izvršena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabranog korisnika.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabranog korisnika.\n" + ex.Message);

            }
        }

        internal void PrikaziPodatke()
        {
            if (uc.DgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite korisnika za prikaz!");
                return;
            }
            try
            {
                DataGridViewRow red = uc.DgvKorisnici.SelectedRows[0];

                //Korisnik korisnik = (Korisnik)red.DataBoundItem;
                Korisnik korisnikIzDgv = (Korisnik)red.DataBoundItem;
                Korisnik korisnik = Communication.Instance.PretraziKorisnika(korisnikIzDgv);

                uc.TxtIme.Text = korisnik.Ime;
                uc.TxtPrezime.Text = korisnik.Prezime;
                uc.TxtEmail.Text = korisnik.Email;
                uc.TxtKontaktTelefon.Text = korisnik.KontaktTelefon;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da promeni odabranog korisnika.\n" + ex.Message);

            }
        }

        internal void Pretrazi()
        {
            if (string.IsNullOrEmpty(uc.TxtUserInput.Text))
            {
                UcitajKorisnike();
                return;
            }

            try
            {
                Korisnik korisnik = new Korisnik
                {
                    SearchKeyword = uc.TxtUserInput.Text
                };

                if((string)uc.CmbFilter.SelectedItem == filteri[0])
                {
                    if (int.TryParse(uc.TxtUserInput.Text, out int id))
                    {
                        korisnik.IdKorisnik = id;
                        Korisnik vraceniKorisnik = Communication.Instance.PretraziKorisnika(korisnik);
                        korisnici = [vraceniKorisnik];
                    }
                    else
                    {
                        MessageBox.Show("Redni broj mora biti ceo broj!");
                        return;
                    }
                }
                else if((string)uc.CmbFilter.SelectedItem == filteri[1])
                {
                    List<Korisnik> lista = Communication.Instance.UcitajSpecificKorisnike(korisnik);
                    korisnici = new BindingList<Korisnik>(lista);
                }
                else if((string)uc.CmbFilter.SelectedItem == filteri[2])
                {
                    if (!double.TryParse(uc.TxtUserInput.Text, out double maxPopust))
                    {
                        MessageBox.Show("Unesite brojčanu vrednost za maksimalan popust!");
                        return;
                    }

                    korisnik.JoinClause = "JOIN PromoKod pk ON pk.Id = k.IdPromoKod";
                    korisnik.WhereClause = "pk.IznosPopusta <= @max";
                    korisnik.JoinParameters = new Dictionary<string, object>
                    {
                        ["@max"] = maxPopust
                    };

                    korisnici = new BindingList<Korisnik>(
                        Communication.Instance.UcitajKorisnikeSaZahtevom(korisnik)
                    );
                }
                

                if (korisnici == null || korisnici.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe korisnike po zadatoj vrednosti!");
                    uc.TxtUserInput.Text = "";
                }
                else
                {
                    uc.DgvKorisnici.DataSource = new BindingList<Korisnik>(korisnici);
                    uc.DgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    LoadDgvSettings();

                    uc.TxtUserInput.Text = "";
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da pretraži korisnike.\n" + ex.Message);
            }
        }

        private void LoadDgvSettings()
        {
            uc.DgvKorisnici.Columns["GodineClanstva"].Visible = false;
            uc.DgvKorisnici.Columns["IdPromoKod"].Visible = false;

            //uc.DgvKorisnici.Columns["IdKorisnik"].Visible = false;
            uc.DgvKorisnici.Columns["TableName"].Visible = false;
            uc.DgvKorisnici.Columns["TableAlias"].Visible = false;
            uc.DgvKorisnici.Columns["SelectValues"].Visible = false;
            uc.DgvKorisnici.Columns["SearchKeyword"].Visible = false;
            uc.DgvKorisnici.Columns["JoinClause"].Visible = false;
            uc.DgvKorisnici.Columns["WhereClause"].Visible = false;
            uc.DgvKorisnici.Columns["JoinParameters"].Visible = false;

            uc.DgvKorisnici.Columns["DatumUclanjenja"].HeaderText = "Datum učlanjenja";
            uc.DgvKorisnici.Columns["DatumUclanjenja"].DefaultCellStyle.Format = "dd.MM.yyyy";
            uc.DgvKorisnici.Columns["KontaktTelefon"].HeaderText = "Kontakt Telefon";
            uc.DgvKorisnici.Columns["IdKorisnik"].HeaderText = "RB";

            //uc.DgvKorisnici.Columns["Ime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            uc.DgvKorisnici.Columns["Prezime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            uc.DgvKorisnici.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
