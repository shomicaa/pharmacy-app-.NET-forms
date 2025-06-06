using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;

namespace View.UCControllers
{
    public class UnosLekaController
    {
        private FrmUnosLeka form;
        private int idNewLek;
        private bool isDeleted = false;

        public UnosLekaController(FrmUnosLeka form)
        {
            this.form = form;
            Lek lek = new Lek()
            {
                Naziv = "",
                RokTrajanja = DateTime.Today,
                Kolicina = 0,
                ZemljaPorekla = 0,
                Cena = 0,
            };
            this.idNewLek = Communication.Instance.KreirajLek(lek);
            form.CmbZemljaPorekla.DataSource = Enum.GetValues(typeof(ZemljaPorekla));
            form.CmbZemljaPorekla.SelectedItem = null;
            form.CmbZemljaPorekla.Text = "--izaberite zemlju porekla--";
        }

        internal void Leave()
        {
            if (isDeleted) return;
            try
            {
                Lek noviLek = new Lek { IdLek = idNewLek};
                Communication.Instance.ObrisiLek(noviLek);
                isDeleted = true;
                return;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        internal void SaveLek()
        {
            if (!ValidateInputs())
            {
                form.Success = false;
                return;
            }

            try
            {
                Lek lek = new Lek
                {
                    IdLek = idNewLek,
                    Naziv = form.TxtNaziv.Text,
                    Cena = double.Parse(form.TxtCena.Text),
                    Kolicina = int.Parse(form.TxtKolicina.Text),
                    ZemljaPorekla = (ZemljaPorekla)form.CmbZemljaPorekla.SelectedItem,
                    RokTrajanja = form.DtPickerRokTrajanja.Value,
                };

                Communication.Instance.PromeniLek(lek);
                form.Success = true;
                form.Close();
            }
            catch (Exception)
            {
                throw;
            }
            MessageBox.Show("Lek uspesno sacuvan!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(form.TxtNaziv.Text) || string.IsNullOrWhiteSpace(form.TxtCena.Text)
                || string.IsNullOrWhiteSpace(form.TxtKolicina.Text) 
                || form.CmbZemljaPorekla.SelectedItem == null || form.DtPickerRokTrajanja.Value == DateTime.Now)
            {
                if (string.IsNullOrEmpty(form.TxtNaziv.Text))
                {
                    form.TxtNaziv.BackColor = Color.Salmon;
                }
                else { form.TxtNaziv.BackColor = default; }
                if (string.IsNullOrEmpty(form.TxtCena.Text))
                {
                    form.TxtCena.BackColor = Color.Salmon;
                }
                else { form.TxtCena.BackColor = default; }
                if (string.IsNullOrEmpty(form.TxtKolicina.Text))
                {
                    form.TxtKolicina.BackColor = Color.Salmon;
                }
                else { form.TxtKolicina.BackColor = default; }
                if (form.CmbZemljaPorekla.SelectedItem == null)
                {
                    form.CmbZemljaPorekla.BackColor = Color.Salmon;
                }
                else { form.CmbZemljaPorekla.BackColor = default; }
                if (form.DtPickerRokTrajanja.Value == DateTime.Now)
                {
                    form.DtPickerRokTrajanja.BackColor = Color.Salmon;
                }
                else { form.DtPickerRokTrajanja.BackColor = default; }
                return false;
            }
            else
            {
                form.TxtNaziv.BackColor = default;
                form.TxtCena.BackColor = default;
                form.TxtKolicina.BackColor = default;
                form.CmbZemljaPorekla.BackColor = default;
                form.DtPickerRokTrajanja.BackColor = default;
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
