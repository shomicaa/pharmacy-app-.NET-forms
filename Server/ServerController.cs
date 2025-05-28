using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;

namespace Server
{
    public class ServerController
    {
        private Server server;
        private FrmServer form;

        public ServerController(Server server, FrmServer form)
        {
            this.server = server;
            this.form = form;
        }

        internal void Init()
        {
            form.BtnStart.Enabled = true;
            form.BtnStop.Enabled = false;
            form.LblServerStatus.BackColor = Color.Red;
            form.LblServerStatus.Text = "Server Closed";
        }

        internal void CloseServerForm()
        {
            Application.Exit();
        }

        internal void StartClick()
        {
            server = new Server();
            if (server.Start())
            {
                SwitchButtons();
                Thread thread = new Thread(server.Listen) { IsBackground = true };
                thread.Start();
            }
        }

        internal void StopClick()
        {
            SwitchButtons();
            server?.Stop();
            server = null;
        }

        internal void SwitchButtons()
        {
            form.BtnStart.Enabled = !form.BtnStart.Enabled;
            form.BtnStop.Enabled = !form.BtnStop.Enabled;
            if(form.LblServerStatus.BackColor == Color.Red)
            {
                form.LblServerStatus.BackColor = Color.Green;
                form.LblServerStatus.Text = "Server Open";
            }
            else
            {
                form.LblServerStatus.BackColor = Color.Red;
                form.LblServerStatus.Text = "Server Closed";
            }
        }
    }
}
