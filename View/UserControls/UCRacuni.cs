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
    public partial class UCRacuni : UserControl
    {
        private RacuniController controller;
        public UCRacuni()
        {
            InitializeComponent();
            controller = new RacuniController(this);
        }

        private void btnPrikaziPodatke_Click(object sender, EventArgs e)
        {
            controller.PrikaziPodatke();
        }

        private void btnIzmeniPodatke_Click(object sender, EventArgs e)
        {
            controller.IzmeniRacun();
            dgvRacuni.DataSource = null;
            controller.UcitajRacune();
            dgvRacuni.Refresh();
        }

        private void btnPrikaziRacune_Click(object sender, EventArgs e)
        {
            if (dgvRacuni.DataSource != null)
            {
                dgvRacuni.DataSource = null;
                dgvRacuni.Refresh();
            }
            else { controller.UcitajRacune(); }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            controller.Pretrazi();
        }

        private void btnPonistiFilter_Click(object sender, EventArgs e)
        {
            controller.PonistiFilter();
        }
    }
}
