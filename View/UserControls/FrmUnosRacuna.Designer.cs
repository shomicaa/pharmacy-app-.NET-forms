namespace View.UserControls
{
    partial class FrmUnosRacuna
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
            cmbFarmaceut1 = new ComboBox();
            txtUkupnaVrednost = new TextBox();
            lblUkupnaVrednost = new Label();
            btnOtkazi = new Button();
            btnSacuvajRacun = new Button();
            lblUnosNovogRacuna = new Label();
            lblKorisnik = new Label();
            cmbFarmaceut = new Label();
            txtIznosPoreza = new TextBox();
            lblIznosPoreza = new Label();
            cmbKorisnik = new ComboBox();
            SuspendLayout();
            // 
            // cmbFarmaceut1
            // 
            cmbFarmaceut1.FormattingEnabled = true;
            cmbFarmaceut1.Location = new Point(321, 222);
            cmbFarmaceut1.Name = "cmbFarmaceut1";
            cmbFarmaceut1.Size = new Size(309, 23);
            cmbFarmaceut1.TabIndex = 55;
            // 
            // txtUkupnaVrednost
            // 
            txtUkupnaVrednost.Location = new Point(321, 123);
            txtUkupnaVrednost.Name = "txtUkupnaVrednost";
            txtUkupnaVrednost.Size = new Size(309, 23);
            txtUkupnaVrednost.TabIndex = 54;
            // 
            // lblUkupnaVrednost
            // 
            lblUkupnaVrednost.AutoSize = true;
            lblUkupnaVrednost.Font = new Font("Constantia", 13F);
            lblUkupnaVrednost.Location = new Point(161, 126);
            lblUkupnaVrednost.Name = "lblUkupnaVrednost";
            lblUkupnaVrednost.Size = new Size(152, 22);
            lblUkupnaVrednost.TabIndex = 53;
            lblUkupnaVrednost.Text = "Ukupna Vrednost:";
            // 
            // btnOtkazi
            // 
            btnOtkazi.Font = new Font("Constantia", 13F);
            btnOtkazi.Location = new Point(405, 343);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(162, 39);
            btnOtkazi.TabIndex = 52;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // btnSacuvajRacun
            // 
            btnSacuvajRacun.Font = new Font("Constantia", 13F);
            btnSacuvajRacun.Location = new Point(216, 343);
            btnSacuvajRacun.Name = "btnSacuvajRacun";
            btnSacuvajRacun.Size = new Size(162, 39);
            btnSacuvajRacun.TabIndex = 51;
            btnSacuvajRacun.Text = "Sačuvaj Račun";
            btnSacuvajRacun.UseVisualStyleBackColor = true;
            btnSacuvajRacun.Click += btnSacuvajRacun_Click;
            // 
            // lblUnosNovogRacuna
            // 
            lblUnosNovogRacuna.AutoSize = true;
            lblUnosNovogRacuna.Font = new Font("Constantia", 14F);
            lblUnosNovogRacuna.Location = new Point(85, 48);
            lblUnosNovogRacuna.Name = "lblUnosNovogRacuna";
            lblUnosNovogRacuna.Size = new Size(177, 23);
            lblUnosNovogRacuna.TabIndex = 50;
            lblUnosNovogRacuna.Text = "Unos Novog Računa";
            // 
            // lblKorisnik
            // 
            lblKorisnik.AutoSize = true;
            lblKorisnik.Font = new Font("Constantia", 13F);
            lblKorisnik.Location = new Point(161, 273);
            lblKorisnik.Name = "lblKorisnik";
            lblKorisnik.Size = new Size(81, 22);
            lblKorisnik.TabIndex = 48;
            lblKorisnik.Text = "Korisnik:";
            // 
            // cmbFarmaceut
            // 
            cmbFarmaceut.AutoSize = true;
            cmbFarmaceut.Font = new Font("Constantia", 13F);
            cmbFarmaceut.Location = new Point(161, 223);
            cmbFarmaceut.Name = "cmbFarmaceut";
            cmbFarmaceut.Size = new Size(98, 22);
            cmbFarmaceut.TabIndex = 47;
            cmbFarmaceut.Text = "Farmaceut:";
            // 
            // txtIznosPoreza
            // 
            txtIznosPoreza.Location = new Point(321, 173);
            txtIznosPoreza.Name = "txtIznosPoreza";
            txtIznosPoreza.Size = new Size(309, 23);
            txtIznosPoreza.TabIndex = 46;
            // 
            // lblIznosPoreza
            // 
            lblIznosPoreza.AutoSize = true;
            lblIznosPoreza.Font = new Font("Constantia", 13F);
            lblIznosPoreza.Location = new Point(161, 176);
            lblIznosPoreza.Name = "lblIznosPoreza";
            lblIznosPoreza.Size = new Size(116, 22);
            lblIznosPoreza.TabIndex = 45;
            lblIznosPoreza.Text = "Iznos poreza:";
            // 
            // cmbKorisnik
            // 
            cmbKorisnik.FormattingEnabled = true;
            cmbKorisnik.Location = new Point(321, 272);
            cmbKorisnik.Name = "cmbKorisnik";
            cmbKorisnik.Size = new Size(309, 23);
            cmbKorisnik.TabIndex = 57;
            // 
            // FrmUnosRacuna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 497);
            ControlBox = false;
            Controls.Add(cmbKorisnik);
            Controls.Add(cmbFarmaceut1);
            Controls.Add(txtUkupnaVrednost);
            Controls.Add(lblUkupnaVrednost);
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvajRacun);
            Controls.Add(lblUnosNovogRacuna);
            Controls.Add(lblKorisnik);
            Controls.Add(cmbFarmaceut);
            Controls.Add(txtIznosPoreza);
            Controls.Add(lblIznosPoreza);
            Name = "FrmUnosRacuna";
            Text = "FrmUnosRacuna";
            FormClosing += FrmUnosRacuna_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbFarmaceut1;
        private TextBox txtUkupnaVrednost;
        private Label lblUkupnaVrednost;
        private Button btnOtkazi;
        private Button btnSacuvajRacun;
        private Label lblUnosNovogRacuna;
        private Label lblKorisnik;
        private Label cmbFarmaceut;
        private TextBox txtIznosPoreza;
        private Label lblIznosPoreza;
        private ComboBox cmbKorisnik;
        public ComboBox CmbFarmaceut1 { get => cmbFarmaceut1; set => cmbFarmaceut1 = value; }
        public TextBox TxtUkupnaVrednost { get => txtUkupnaVrednost; set => txtUkupnaVrednost = value; }
        public Label LblUkupnaVrednost { get => lblUkupnaVrednost; set => lblUkupnaVrednost = value; }
        public Button BtnOtkazi { get => btnOtkazi; set => btnOtkazi = value; }
        public Button BtnSacuvajRacun { get => btnSacuvajRacun; set => btnSacuvajRacun = value; }
        public Label LblUnosNovogRacuna { get => lblUnosNovogRacuna; set => lblUnosNovogRacuna = value; }
        public Label LblKorisnik { get => lblKorisnik; set => lblKorisnik = value; }
        public Label CmbFarmaceut { get => cmbFarmaceut; set => cmbFarmaceut = value; }
        public TextBox TxtIznosPoreza { get => txtIznosPoreza; set => txtIznosPoreza = value; }
        public Label LblIznosPoreza { get => lblIznosPoreza; set => lblIznosPoreza = value; }
        public ComboBox CmbKorisnik { get => cmbKorisnik; set => cmbKorisnik = value; }
    }
}