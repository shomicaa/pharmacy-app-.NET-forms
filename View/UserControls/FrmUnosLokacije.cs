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
    public partial class FrmUnosLokacije : Form
    {
        private UnosLokacijeController controller;
        public bool Success = true;
        public FrmUnosLokacije()
        {
            InitializeComponent();
            controller = new UnosLokacijeController(this);
        }

        private void btnSacuvajLokaciju_Click(object sender, EventArgs e)
        {
            controller.SaveLokacija();
            if (Success)
            {
                this.Close();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            controller.HandleOtkaziButton();
        }
    }
}
