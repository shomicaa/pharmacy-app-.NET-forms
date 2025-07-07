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
    internal class LekoviController
    {
        private UCLekovi uc;
        private BindingList<Lek> lekovi;
        private string[] filteri = new string[] { "rednom broju", "nazivu"};
        private UCLokacije uCLokacije;

        public LekoviController(UCLekovi uc)
        {
            this.uc = uc;
            uc.CmbZemljaPorekla.DataSource = Enum.GetValues(typeof(ZemljaPorekla));
            uc.CmbZemljaPorekla.SelectedItem = null;
            uc.CmbZemljaPorekla.Text = "--izaberite zemlju porekla--";
            lekovi = new BindingList<Lek>(Communication.Instance.UcitajLekove());
            uc.CmbFilter.DataSource = filteri;
        }

        public LekoviController(UCLokacije uCLokacije)
        {
            this.uCLokacije = uCLokacije;
        }

        internal void UcitajLekove()
        {
            try
            {
                lekovi = new BindingList<Lek>(Communication.Instance.UcitajLekove());

                if (lekovi == null || lekovi.Count == 0)
                {
                    MessageBox.Show("Trenutno nema unetih lekova.");
                    uc.DgvLekovi.DataSource = null;
                    return;
                }

                uc.DgvLekovi.DataSource = lekovi;
                uc.DgvLekovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                LoadDgvSettings();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita lekove.\n" + ex.Message);

            }
        }

        internal void IzmeniLek()
        {
            if (uc.DgvLekovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali lek za menjanje!");
                return;
            }
            if (string.IsNullOrEmpty(uc.TxtNaziv.Text) || string.IsNullOrEmpty(uc.TxtKolicina.Text) || string.IsNullOrEmpty(uc.TxtCena.Text) || 
                uc.CmbZemljaPorekla.SelectedItem == null)
            {
                MessageBox.Show("Polja ne smeju ostati prazna!");
                return;
            }
            if (!int.TryParse(uc.TxtKolicina.Text, out int kolicina))
            {
                MessageBox.Show("Polje Količina mora biti brojne vrednosti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(uc.TxtCena.Text, out double cena))
            {
                MessageBox.Show("Polje Cena mora biti brojne vrednosti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataGridViewRow red = uc.DgvLekovi.SelectedRows[0];
                Lek lekIzDgv = (Lek)red.DataBoundItem;

                Lek lek = Communication.Instance.PretraziLek(lekIzDgv);

                lek.Naziv = uc.TxtNaziv.Text;
                lek.RokTrajanja = uc.DtPickerRokTrajanja.Value;
                lek.Kolicina = int.Parse(uc.TxtKolicina.Text);
                lek.Cena = double.Parse(uc.TxtCena.Text);
                lek.ZemljaPorekla = (ZemljaPorekla)uc.CmbZemljaPorekla.SelectedItem;

                Communication.Instance.PromeniLek(lek);
                MessageBox.Show("Sistem je promenio odabrani lek!", "Operacija uspesno izvršena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Sistem ne može da promeni odabrani lek.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da promeni odabrani lek.\n" + ex.Message);

            }
        }

        internal void ObrisiLek()
        {
            if (uc.DgvLekovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali lek za brisanje!");
                return;
            }

            DataGridViewRow red = uc.DgvLekovi.SelectedRows[0];
            Lek lekIzDgv = (Lek)red.DataBoundItem;

            Lek lek = Communication.Instance.PretraziLek(lekIzDgv);

            try
            {
                Communication.Instance.ObrisiLek(lek);
                MessageBox.Show("Sistem je izbrisao odabrani lek!", "Operacija uspesno izvršena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabrani lek.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabrani lek.\n" + ex.Message);

            }
        }

        internal void PrikaziPodatke()
        {
            if (uc.DgvLekovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite lek za prikaz!");
                return;
            }
            try
            {
                DataGridViewRow red = uc.DgvLekovi.SelectedRows[0];

                Lek lekIzDgv = (Lek)red.DataBoundItem;
                Lek lek = Communication.Instance.PretraziLek(lekIzDgv);

                uc.TxtNaziv.Text = lek.Naziv;
                uc.DtPickerRokTrajanja.Value = lek.RokTrajanja;
                uc.TxtKolicina.Text = lek.Kolicina.ToString();
                uc.TxtCena.Text = lek.Cena.ToString();
                uc.CmbZemljaPorekla.SelectedItem = lek.ZemljaPorekla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da promeni odabrani lek.\n" + ex.Message);

            }
        }

        internal void Pretrazi()
        {
            if (string.IsNullOrEmpty(uc.TxtUserInput.Text))
            {
                UcitajLekove();
                return;
            }

            try
            {
                Lek lek = new Lek
                {
                    SearchKeyword = uc.TxtUserInput.Text
                };

                if ((string)uc.CmbFilter.SelectedItem == filteri[0])
                {
                    if (int.TryParse(uc.TxtUserInput.Text, out int id))
                    {
                        lek.IdLek = id;
                        Lek vraceniLek = Communication.Instance.PretraziLek(lek);
                        lekovi = [vraceniLek];
                    }
                    else
                    {
                        MessageBox.Show("Redni broj mora biti ceo broj!");
                        return;
                    }
                }
                else if ((string)uc.CmbFilter.SelectedItem == filteri[1])
                {
                    List<Lek> lista = Communication.Instance.UcitajSpecificLekove(lek);
                    lekovi = new BindingList<Lek>(lista);
                }

                if (lekovi == null || lekovi.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe lekove po zadatoj vrednosti!");
                    uc.TxtUserInput.Text = "";
                }
                else
                {
                    uc.DgvLekovi.DataSource = new BindingList<Lek>(lekovi);
                    uc.DgvLekovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
            uc.DgvLekovi.Columns["TableName"].Visible = false;
            uc.DgvLekovi.Columns["TableAlias"].Visible = false;
            uc.DgvLekovi.Columns["SelectValues"].Visible = false;
            uc.DgvLekovi.Columns["SearchKeyword"].Visible = false;
            uc.DgvLekovi.Columns["JoinClause"].Visible = false;
            uc.DgvLekovi.Columns["WhereClause"].Visible = false;
            uc.DgvLekovi.Columns["JoinParameters"].Visible = false;

            uc.DgvLekovi.Columns["RokTrajanja"].HeaderText = "Rok trajanja";
            uc.DgvLekovi.Columns["ZemljaPorekla"].HeaderText = "Zemlja porekla";
            uc.DgvLekovi.Columns["IdLek"].HeaderText = "RB";


            uc.DgvLekovi.Columns["Naziv"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            uc.DgvLekovi.Columns["ZemljaPorekla"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
