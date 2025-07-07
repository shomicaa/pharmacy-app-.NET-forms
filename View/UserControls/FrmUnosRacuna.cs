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
    public partial class FrmUnosRacuna : Form
    {
        private UnosRacunaController controller;
        public bool Success = true;
        public FrmUnosRacuna()
        {
            InitializeComponent();
            controller = new UnosRacunaController(this);
        }

        private void btnSacuvajRacun_Click(object sender, EventArgs e)
        {
            controller.SaveRacun();
            if (Success)
            {
                this.Close();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            controller.HandleOtkaziButton();
        }

        private void FrmUnosRacuna_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Success)
            {
                controller.Leave();
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            controller.DodajStavku();
        }

        private void btnUkloniStavku_Click(object sender, EventArgs e)
        {
            controller.UkloniStavku();
        }
    }
}
