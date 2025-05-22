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
            panel1 = new Panel();
            lblPromoKod = new Label();
            lblLokacija = new Label();
            lblLek = new Label();
            lblRacun = new Label();
            lblKorisnik = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblPromoKod);
            panel1.Controls.Add(lblLokacija);
            panel1.Controls.Add(lblLek);
            panel1.Controls.Add(lblRacun);
            panel1.Controls.Add(lblKorisnik);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(115, 501);
            panel1.TabIndex = 0;
            // 
            // lblPromoKod
            // 
            lblPromoKod.Cursor = Cursors.Hand;
            lblPromoKod.Font = new Font("Constantia", 14F);
            lblPromoKod.ForeColor = Color.FromArgb(41, 41, 58);
            lblPromoKod.Location = new Point(3, 231);
            lblPromoKod.Name = "lblPromoKod";
            lblPromoKod.Size = new Size(109, 19);
            lblPromoKod.TabIndex = 5;
            lblPromoKod.Text = "PromoKod";
            lblPromoKod.Click += lblPromoKod_Click;
            // 
            // lblLokacija
            // 
            lblLokacija.Cursor = Cursors.Hand;
            lblLokacija.Font = new Font("Constantia", 14F);
            lblLokacija.ForeColor = Color.FromArgb(41, 41, 58);
            lblLokacija.Location = new Point(3, 205);
            lblLokacija.Name = "lblLokacija";
            lblLokacija.Size = new Size(78, 21);
            lblLokacija.TabIndex = 4;
            lblLokacija.Text = "Lokacija";
            lblLokacija.Click += lblLokacija_Click;
            // 
            // lblLek
            // 
            lblLek.Cursor = Cursors.Hand;
            lblLek.Font = new Font("Constantia", 14F);
            lblLek.ForeColor = Color.FromArgb(41, 41, 58);
            lblLek.Location = new Point(3, 179);
            lblLek.Name = "lblLek";
            lblLek.Size = new Size(44, 19);
            lblLek.TabIndex = 3;
            lblLek.Text = "Lek";
            lblLek.Click += lblLek_Click;
            // 
            // lblRacun
            // 
            lblRacun.Cursor = Cursors.Hand;
            lblRacun.Font = new Font("Constantia", 14F);
            lblRacun.ForeColor = Color.FromArgb(41, 41, 58);
            lblRacun.Location = new Point(3, 153);
            lblRacun.Name = "lblRacun";
            lblRacun.Size = new Size(64, 19);
            lblRacun.TabIndex = 2;
            lblRacun.Text = "Racun";
            lblRacun.Click += lblRacun_Click;
            // 
            // lblKorisnik
            // 
            lblKorisnik.Cursor = Cursors.Hand;
            lblKorisnik.Font = new Font("Constantia", 14F);
            lblKorisnik.ForeColor = Color.FromArgb(41, 41, 58);
            lblKorisnik.Location = new Point(3, 127);
            lblKorisnik.Name = "lblKorisnik";
            lblKorisnik.Size = new Size(87, 19);
            lblKorisnik.TabIndex = 1;
            lblKorisnik.Text = "Korisnik";
            lblKorisnik.Click += lblKorisnik_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pharmacy_logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(115, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(807, 49);
            panel2.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 501);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shomica Pharmacy";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lblKorisnik;
        private Label lblLokacija;
        private Label lblLek;
        private Label lblRacun;
        private Label lblPromoKod;
    }
}