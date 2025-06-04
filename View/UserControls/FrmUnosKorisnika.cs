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
    public partial class FrmUnosKorisnika : Form
    {
        private UnosKorisnikaController controller;
        public bool Success = true;
        public FrmUnosKorisnika()
        {
            InitializeComponent();
            controller = new UnosKorisnikaController(this);
        }

        private void btnSacuvajKorisnika_Click(object sender, EventArgs e)
        {
            controller.SaveUser();         
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            controller.HandleOtkaziButton();
        }

        private void FrmUnosKorisnika_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Success)
            {
                controller.Leave();
            }
        }
    }
}
