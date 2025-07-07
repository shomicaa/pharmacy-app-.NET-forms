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
    public class LokacijeController
    {
        private UCLokacije uc;
        private BindingList<Lokacija> lokacije;

        public LokacijeController(UCLokacije uc)
        {
            this.uc = uc;
            lokacije = new BindingList<Lokacija>(Communication.Instance.UcitajLokacije());
        }

        internal void UcitajLokacije()
        {
            lokacije = new BindingList<Lokacija>(Communication.Instance.UcitajLokacije());
            if(lokacije == null || lokacije.Count == 0)
            {
                MessageBox.Show("Trenutno nema unetih lokacija.");
                uc.DgvLokacije.DataSource = null;
                return;
            }
            uc.DgvLokacije.DataSource = lokacije;
            uc.DgvLokacije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadDgvSettings();
        }

        private void LoadDgvSettings()
        {
            uc.DgvLokacije.Columns["TableName"].Visible = false;
            uc.DgvLokacije.Columns["SelectValues"].Visible = false;
            uc.DgvLokacije.Columns["SearchKeyword"].Visible = false;

            uc.DgvLokacije.Columns["IdLokacija"].HeaderText = "ID lokacije";
            uc.DgvLokacije.Columns["AdresaLokacije"].HeaderText = "Adresa i broj";
            uc.DgvLokacije.Columns["Opstina"].HeaderText = "Opština";

            uc.DgvLokacije.Columns["AdresaLokacije"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            uc.DgvLokacije.Columns["Opstina"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
