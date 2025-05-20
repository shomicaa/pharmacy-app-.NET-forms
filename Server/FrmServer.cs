namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server;

        public FrmServer()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblServerStatus.BackColor = Color.Red;
            lblServerStatus.Text = "Server Closed";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new Server();
            if (server.Start())
            {
                SwitchButtons();
                Thread thread = new Thread(server.Listen) { IsBackground = true };
                thread.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SwitchButtons();
            server?.Stop();
            server = null;
        }
        private void SwitchButtons()
        {
            btnStart.Enabled = !btnStart.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
            if(lblServerStatus.BackColor == Color.Red)
            {
                lblServerStatus.BackColor = Color.Green;
                lblServerStatus.Text = "Server Open";
            }
            else
            {
                lblServerStatus.BackColor = Color.Red;
                lblServerStatus.Text = "Server Closed";
            }
            
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
