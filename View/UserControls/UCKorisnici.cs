﻿using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.UCControllers;

namespace View.UserControls
{
    public partial class UCKorisnici : UserControl
    {
        private KorisniciController korisniciController;
        public UCKorisnici()
        {
            InitializeComponent();
            korisniciController = new KorisniciController(this);
        }

        private void btnPrikaziPodatke_Click(object sender, EventArgs e)
        {
            korisniciController.PrikaziPodatke();
        }

        private void btnIzmeniPodatke_Click(object sender, EventArgs e)
        {
            korisniciController.IzmeniKorisnika();
            dgvKorisnici.DataSource = null;
            korisniciController.UcitajKorisnike();
            dgvKorisnici.Refresh();
        }

        private void btnObrisiKorisnika_Click(object sender, EventArgs e)
        {
            korisniciController.ObrisiKorisnika();
            dgvKorisnici.DataSource = null;
            korisniciController.UcitajKorisnike();
            dgvKorisnici.Refresh();
        }

        private void btnPrikaziKorisnike_Click(object sender, EventArgs e)
        {
            if (dgvKorisnici.DataSource != null)
            {
                dgvKorisnici.DataSource = null;
                dgvKorisnici.Refresh();
            }
            else { korisniciController.UcitajKorisnike(); }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            korisniciController.Pretrazi();
        }
    }
}
