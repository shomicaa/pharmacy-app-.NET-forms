namespace Server
{
    public partial class FrmServer : Form
    {
        public Server server = null;
        private ServerController controller;

        public FrmServer()
        {
            InitializeComponent();
            controller = new ServerController(server, this);
            Init();           
        }

        private void Init() => controller.Init();

        private void btnStart_Click(object sender, EventArgs e) => controller.StartClick();

        private void btnStop_Click(object sender, EventArgs e) => controller.StopClick();

        private void SwitchButtons() => controller.SwitchButtons();

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e) => controller.CloseServerForm();
    }
}
