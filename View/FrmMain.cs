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
using View.FormControllers;

namespace View
{
    public partial class FrmMain : Form
    {
        private MainController mainController;
        public bool IsKorisnikActive { get; set; }
        public bool IsRacunActive { get; set; }
        public bool IsLekActive { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            mainController = new MainController(this);
            Init();
        }

        private void Init() => mainController.Init();

        public void SetPanel(UserControl userControl) => mainController.SetPanel(userControl);

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.Close();
        }
    }
}
