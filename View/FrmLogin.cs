using View.FormControllers;

namespace View
{
    public partial class FrmLogin : Form
    {
        private LoginController loginController;
        public FrmLogin()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginController.Login(this);
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginController.Close();
        }
    }
}
