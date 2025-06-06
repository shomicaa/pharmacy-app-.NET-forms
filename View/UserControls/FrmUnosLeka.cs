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
    public partial class FrmUnosLeka : Form
    {
        private UnosLekaController controller;
        public bool Success = true;
        public FrmUnosLeka()
        {
            InitializeComponent();
            controller = new UnosLekaController(this);
        }

        private void btnSacuvajLek_Click(object sender, EventArgs e)
        {
            controller.SaveLek();
            if (Success)
            {
                this.Close();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            controller.HandleOtkaziButton();
        }

        private void FrmUnosLeka_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Success)
            {
                controller.Leave();
            }
        }
    }
}
