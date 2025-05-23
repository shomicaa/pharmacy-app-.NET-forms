namespace View
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelBoard = new Panel();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            lblExit = new Label();
            pictureBox1 = new PictureBox();
            lblPromoKod = new Label();
            lblLokacija = new Label();
            lblLek = new Label();
            lblRacun = new Label();
            lblKorisnik = new Label();
            panelHeader = new Panel();
            panelMain = new Panel();
            panelBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelBoard
            // 
            panelBoard.BackColor = Color.White;
            panelBoard.Controls.Add(lbl3);
            panelBoard.Controls.Add(lbl2);
            panelBoard.Controls.Add(lbl1);
            panelBoard.Controls.Add(lblExit);
            panelBoard.Controls.Add(pictureBox1);
            panelBoard.Dock = DockStyle.Left;
            panelBoard.Location = new Point(0, 0);
            panelBoard.Name = "panelBoard";
            panelBoard.Size = new Size(143, 622);
            panelBoard.TabIndex = 0;
            // 
            // lbl3
            // 
            lbl3.Cursor = Cursors.Hand;
            lbl3.Font = new Font("Constantia", 12F);
            lbl3.ForeColor = Color.FromArgb(41, 41, 58);
            lbl3.Location = new Point(3, 222);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(137, 19);
            lbl3.TabIndex = 9;
            lbl3.Text = "label3";
            // 
            // lbl2
            // 
            lbl2.Cursor = Cursors.Hand;
            lbl2.Font = new Font("Constantia", 12F);
            lbl2.ForeColor = Color.FromArgb(41, 41, 58);
            lbl2.Location = new Point(3, 194);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(134, 19);
            lbl2.TabIndex = 8;
            lbl2.Text = "label2";
            // 
            // lbl1
            // 
            lbl1.Cursor = Cursors.Hand;
            lbl1.Font = new Font("Constantia", 12F);
            lbl1.ForeColor = Color.FromArgb(41, 41, 58);
            lbl1.Location = new Point(3, 165);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(134, 19);
            lbl1.TabIndex = 7;
            lbl1.Text = "label1";
            // 
            // lblExit
            // 
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Constantia", 14F);
            lblExit.ForeColor = Color.FromArgb(41, 41, 58);
            lblExit.Location = new Point(3, 576);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(87, 19);
            lblExit.TabIndex = 6;
            lblExit.Text = "Exit";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pharmacy_logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblPromoKod
            // 
            lblPromoKod.Cursor = Cursors.Hand;
            lblPromoKod.Font = new Font("Constantia", 14F);
            lblPromoKod.ForeColor = Color.White;
            lblPromoKod.Location = new Point(310, 19);
            lblPromoKod.Name = "lblPromoKod";
            lblPromoKod.Size = new Size(99, 24);
            lblPromoKod.TabIndex = 5;
            lblPromoKod.Text = "PromoKod";
            // 
            // lblLokacija
            // 
            lblLokacija.Cursor = Cursors.Hand;
            lblLokacija.Font = new Font("Constantia", 14F);
            lblLokacija.ForeColor = Color.White;
            lblLokacija.Location = new Point(226, 19);
            lblLokacija.Name = "lblLokacija";
            lblLokacija.Size = new Size(78, 24);
            lblLokacija.TabIndex = 4;
            lblLokacija.Text = "Lokacija";
            // 
            // lblLek
            // 
            lblLek.Cursor = Cursors.Hand;
            lblLek.Font = new Font("Constantia", 14F);
            lblLek.ForeColor = Color.White;
            lblLek.Location = new Point(176, 19);
            lblLek.Name = "lblLek";
            lblLek.Size = new Size(44, 24);
            lblLek.TabIndex = 3;
            lblLek.Text = "Lek";
            // 
            // lblRacun
            // 
            lblRacun.Cursor = Cursors.Hand;
            lblRacun.Font = new Font("Constantia", 14F);
            lblRacun.ForeColor = Color.White;
            lblRacun.Location = new Point(106, 19);
            lblRacun.Name = "lblRacun";
            lblRacun.Size = new Size(64, 24);
            lblRacun.TabIndex = 2;
            lblRacun.Text = "Racun";
            // 
            // lblKorisnik
            // 
            lblKorisnik.Cursor = Cursors.Hand;
            lblKorisnik.Font = new Font("Constantia", 14F);
            lblKorisnik.ForeColor = Color.White;
            lblKorisnik.Location = new Point(20, 19);
            lblKorisnik.Name = "lblKorisnik";
            lblKorisnik.Size = new Size(80, 24);
            lblKorisnik.TabIndex = 1;
            lblKorisnik.Text = "Korisnik";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(39, 68, 112);
            panelHeader.Controls.Add(lblKorisnik);
            panelHeader.Controls.Add(lblPromoKod);
            panelHeader.Controls.Add(lblRacun);
            panelHeader.Controls.Add(lblLek);
            panelHeader.Controls.Add(lblLokacija);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(143, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(992, 54);
            panelHeader.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(143, 54);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(992, 568);
            panelMain.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 622);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelBoard);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shomica Pharmacy";
            panelBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBoard;
        private PictureBox pictureBox1;
        private Panel panelHeader;
        private Label lblKorisnik;
        private Label lblLokacija;
        private Label lblLek;
        private Label lblRacun;
        private Label lblPromoKod;
        private Label lblExit;
        private Label lbl2;
        private Label lbl1;
        private Label lbl3;
        private Panel panelMain;

        public Panel PanelBoard { get => panelBoard; set => panelBoard = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public Panel PanelHeader { get => panelHeader; set => panelHeader = value; }
        public Label LblKorisnik { get => lblKorisnik; set => lblKorisnik = value; }
        public Label LblLokacija { get => lblLokacija; set => lblLokacija = value; }
        public Label LblLek { get => lblLek; set => lblLek = value; }
        public Label LblRacun { get => lblRacun; set => lblRacun = value; }
        public Label LblPromoKod { get => lblPromoKod; set => lblPromoKod = value; }
        public Label LblExit { get => lblExit; set => lblExit = value; }
        public Label Lbl2 { get => lbl2; set => lbl2 = value; }
        public Label Lbl1 { get => lbl1; set => lbl1 = value; }
        public Label Lbl3 { get => lbl3; set => lbl3 = value; }
        public Panel PanelMain { get => panelMain; set => panelMain = value; }
    }
}