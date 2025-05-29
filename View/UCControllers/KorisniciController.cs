using Domain;
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
        BindingList<Korisnik> korisnici;
        public KorisniciController(UCKorisnici uc)
        {
            this.uc = uc;
            korisnici = new BindingList<Korisnik>(Communication.Instance.UcitajKorisnike());
        }
        internal void UcitajKorisnike()
        {
            try
            {
                korisnici = new BindingList<Korisnik>(Communication.Instance.UcitajKorisnike());

                if (korisnici == null | korisnici.Count == 0)
                {
                    MessageBox.Show("Trenutno nema unetih korisnika.");
                    uc.DgvKorisnici.DataSource = null;
                    return;
                }

                        uc.DgvKorisnici.DataSource = korisnici;
                        uc.DgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        uc.DgvKorisnici.Columns["IdKorisnik"].Visible = false;
                        uc.DgvKorisnici.Columns["GodineClanstva"].Visible = false;
                        uc.DgvKorisnici.Columns["IdPromoKod"].Visible = false;

                        uc.DgvKorisnici.Columns["TableName"].Visible = false;
                        uc.DgvKorisnici.Columns["WhereCondition"].Visible = false;
                        uc.DgvKorisnici.Columns["SelectValues"].Visible = false;
                        uc.DgvKorisnici.Columns["UpdateValues"].Visible = false;
                        uc.DgvKorisnici.Columns["InsertValues"].Visible = false;

                        uc.DgvKorisnici.Columns["DatumUclanjenja"].HeaderText = "Datum učlanjenja";
                        uc.DgvKorisnici.Columns["DatumUclanjenja"].DefaultCellStyle.Format = "dd.MM.yyyy";
                        uc.DgvKorisnici.Columns["KontaktTelefon"].HeaderText = "Kontakt Telefon";

                        uc.DgvKorisnici.Columns["Ime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        uc.DgvKorisnici.Columns["Prezime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
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
                Korisnik korisnik = (Korisnik)red.DataBoundItem;

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
            Korisnik korisnik = (Korisnik)red.DataBoundItem;

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
                Korisnik korisnik = (Korisnik)red.DataBoundItem;

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
    }
}
