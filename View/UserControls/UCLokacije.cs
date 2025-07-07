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
    public partial class UCLokacije : UserControl
    {
        private LokacijeController controller;
        public UCLokacije()
        {
            InitializeComponent();
            controller = new LokacijeController(this);
        }

        private void btnPrikaziSpisakLokacija_Click(object sender, EventArgs e)
        {
            if (dgvLokacije.DataSource != null)
            {
                dgvLokacije.DataSource = null;
                dgvLokacije.Refresh();
            }
            else { controller.UcitajLokacije(); }
        }
    }
}
