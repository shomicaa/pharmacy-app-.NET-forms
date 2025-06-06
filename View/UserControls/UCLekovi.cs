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
    public partial class UCLekovi : UserControl
    {
        private LekoviController controller;
        public UCLekovi()
        {
            InitializeComponent();
            controller = new LekoviController(this);
        }

        private void btnPrikaziPodatke_Click(object sender, EventArgs e)
        {
            controller.PrikaziPodatke();
        }
        private void btnIzmeniPodatke_Click(object sender, EventArgs e)
        {
            controller.IzmeniLek();
            dgvLekovi.DataSource = null;
            controller.UcitajLekove();
            dgvLekovi.Refresh();
        }
        private void btnObrisiLek_Click(object sender, EventArgs e)
        {
            controller.ObrisiLek();
            dgvLekovi.DataSource = null;
            controller.UcitajLekove();
            dgvLekovi.Refresh();
        }
        private void btnPrikaziSpisakLekova_Click(object sender, EventArgs e)
        {
            if (dgvLekovi.DataSource != null)
            {
                dgvLekovi.DataSource = null;
                dgvLekovi.Refresh();
            }
            else { controller.UcitajLekove(); }
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            controller.Pretrazi();
        }
  
    }
}
