using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;

namespace View.UCControllers
{
    public class UnosLokacijeController
    {
        private FrmUnosLokacije form;

        public UnosLokacijeController(FrmUnosLokacije form)
        {
            this.form = form;
        }

        internal void SaveLokacija()
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Polja ne smeju ostati prazna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Lokacija lokacija = new Lokacija
                {
                    AdresaLokacije = form.TxtAdresa.Text,
                    Opstina = form.TxtOpstina.Text,
                };
                Communication.Instance.UbaciLokaciju(lokacija);
                form.Success = true;
                form.Close();
            }
            catch (Exception)
            {
                throw;
            }
            MessageBox.Show("Lokacija uspesno ubacena!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal void HandleOtkaziButton()
        {
            form.Success = false;
            form.Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(form.TxtAdresa.Text) || string.IsNullOrWhiteSpace(form.TxtOpstina.Text))
            {
                if (string.IsNullOrEmpty(form.TxtAdresa.Text))
                {
                    form.TxtAdresa.BackColor = Color.Salmon;
                }
                else { form.TxtAdresa.BackColor = default; }
                if (string.IsNullOrEmpty(form.TxtOpstina.Text))
                {
                    form.TxtOpstina.BackColor = Color.Salmon;
                }
                else { form.TxtOpstina.BackColor = default; }

                return false;
            }
            else
            {
                form.TxtAdresa.BackColor = default;
                form.TxtOpstina.BackColor = default;
                return true;

            }
        }

    }
}
