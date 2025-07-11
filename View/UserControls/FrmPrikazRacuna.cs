using Domain;
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
    public partial class FrmPrikazRacuna : Form
    {
        PrikazRacunaController controller;
        public bool Success = true;

        public FrmPrikazRacuna(Racun racun)
        {
            InitializeComponent();
            controller = new PrikazRacunaController(this, racun);

        }

        private void btnIzmeniStavku_Click(object sender, EventArgs e)
        {
            controller.IzmeniStavku();
        }

        private void btnUkloniStavku_Click(object sender, EventArgs e)
        {
            controller.UkloniStavku();
        }

        private void btnSacuvajPromene_Click(object sender, EventArgs e)
        {
            controller.SacuvajPromene();
            if (Success)
            {
                this.Close();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            controller.Otkazi();
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            controller.DodajStavku();
        }
    }
}
