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
            btnOtkazi = new Button();
            btnSacuvajRacun = new Button();
            lblKorisnik = new Label();
            cmbFarmaceut = new Label();
            cmbKorisnik = new ComboBox();
            groupBox1 = new GroupBox();
            lblStavkeRacuna = new Label();
            btnUkloniStavku = new Button();
            btnDodajStavku = new Button();
            dgvStavkeRacuna = new DataGridView();
            txtKolicina = new TextBox();
            lblKolicina = new Label();
            lblLek = new Label();
            cmbLek = new ComboBox();
            lblIDRacun = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStavkeRacuna).BeginInit();
            SuspendLayout();
            // 
            // cmbFarmaceut1
            // 
            cmbFarmaceut1.FormattingEnabled = true;
            cmbFarmaceut1.Location = new Point(110, 72);
            cmbFarmaceut1.Name = "cmbFarmaceut1";
            cmbFarmaceut1.Size = new Size(309, 31);
            cmbFarmaceut1.TabIndex = 55;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Font = new Font("Constantia", 13F);
            btnOtkazi.Location = new Point(466, 571);
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
            btnSacuvajRacun.Location = new Point(298, 571);
            btnSacuvajRacun.Name = "btnSacuvajRacun";
            btnSacuvajRacun.Size = new Size(162, 39);
            btnSacuvajRacun.TabIndex = 51;
            btnSacuvajRacun.Text = "Sačuvaj Račun";
            btnSacuvajRacun.UseVisualStyleBackColor = true;
            btnSacuvajRacun.Click += btnSacuvajRacun_Click;
            // 
            // lblKorisnik
            // 
            lblKorisnik.AutoSize = true;
            lblKorisnik.Font = new Font("Constantia", 13F);
            lblKorisnik.Location = new Point(495, 77);
            lblKorisnik.Name = "lblKorisnik";
            lblKorisnik.Size = new Size(81, 22);
            lblKorisnik.TabIndex = 48;
            lblKorisnik.Text = "Korisnik:";
            // 
            // cmbFarmaceut
            // 
            cmbFarmaceut.AutoSize = true;
            cmbFarmaceut.Font = new Font("Constantia", 13F);
            cmbFarmaceut.Location = new Point(6, 77);
            cmbFarmaceut.Name = "cmbFarmaceut";
            cmbFarmaceut.Size = new Size(98, 22);
            cmbFarmaceut.TabIndex = 47;
            cmbFarmaceut.Text = "Farmaceut:";
            // 
            // cmbKorisnik
            // 
            cmbKorisnik.FormattingEnabled = true;
            cmbKorisnik.Location = new Point(593, 72);
            cmbKorisnik.Name = "cmbKorisnik";
            cmbKorisnik.Size = new Size(309, 31);
            cmbKorisnik.TabIndex = 57;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblIDRacun);
            groupBox1.Controls.Add(lblStavkeRacuna);
            groupBox1.Controls.Add(btnUkloniStavku);
            groupBox1.Controls.Add(btnDodajStavku);
            groupBox1.Controls.Add(dgvStavkeRacuna);
            groupBox1.Controls.Add(txtKolicina);
            groupBox1.Controls.Add(lblKolicina);
            groupBox1.Controls.Add(lblLek);
            groupBox1.Controls.Add(cmbLek);
            groupBox1.Controls.Add(cmbFarmaceut);
            groupBox1.Controls.Add(cmbKorisnik);
            groupBox1.Controls.Add(lblKorisnik);
            groupBox1.Controls.Add(cmbFarmaceut1);
            groupBox1.Font = new Font("Constantia", 14F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(908, 553);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unos Novog Računa";
            // 
            // lblStavkeRacuna
            // 
            lblStavkeRacuna.AutoSize = true;
            lblStavkeRacuna.Font = new Font("Constantia", 13F);
            lblStavkeRacuna.Location = new Point(8, 183);
            lblStavkeRacuna.Name = "lblStavkeRacuna";
            lblStavkeRacuna.Size = new Size(125, 22);
            lblStavkeRacuna.TabIndex = 65;
            lblStavkeRacuna.Text = "Stavke računa:";
            // 
            // btnUkloniStavku
            // 
            btnUkloniStavku.Font = new Font("Constantia", 13F);
            btnUkloniStavku.Location = new Point(736, 174);
            btnUkloniStavku.Name = "btnUkloniStavku";
            btnUkloniStavku.Size = new Size(162, 39);
            btnUkloniStavku.TabIndex = 64;
            btnUkloniStavku.Text = "Ukloni Stavku";
            btnUkloniStavku.UseVisualStyleBackColor = true;
            btnUkloniStavku.Click += btnUkloniStavku_Click;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.Font = new Font("Constantia", 13F);
            btnDodajStavku.Location = new Point(568, 174);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(162, 39);
            btnDodajStavku.TabIndex = 63;
            btnDodajStavku.Text = "Dodaj Stavku";
            btnDodajStavku.UseVisualStyleBackColor = true;
            btnDodajStavku.Click += btnDodajStavku_Click;
            // 
            // dgvStavkeRacuna
            // 
            dgvStavkeRacuna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavkeRacuna.Location = new Point(12, 221);
            dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            dgvStavkeRacuna.Size = new Size(896, 326);
            dgvStavkeRacuna.TabIndex = 62;
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(593, 125);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(309, 30);
            txtKolicina.TabIndex = 61;
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Font = new Font("Constantia", 13F);
            lblKolicina.Location = new Point(495, 129);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(79, 22);
            lblKolicina.TabIndex = 60;
            lblKolicina.Text = "Kolicina:";
            // 
            // lblLek
            // 
            lblLek.AutoSize = true;
            lblLek.Font = new Font("Constantia", 13F);
            lblLek.Location = new Point(6, 129);
            lblLek.Name = "lblLek";
            lblLek.Size = new Size(44, 22);
            lblLek.TabIndex = 58;
            lblLek.Text = "Lek:";
            // 
            // cmbLek
            // 
            cmbLek.FormattingEnabled = true;
            cmbLek.Location = new Point(110, 124);
            cmbLek.Name = "cmbLek";
            cmbLek.Size = new Size(309, 31);
            cmbLek.TabIndex = 59;
            // 
            // lblIDRacun
            // 
            lblIDRacun.AutoSize = true;
            lblIDRacun.Location = new Point(357, 26);
            lblIDRacun.Name = "lblIDRacun";
            lblIDRacun.Size = new Size(101, 23);
            lblIDRacun.TabIndex = 66;
            lblIDRacun.Text = "ID Računa:";
            // 
            // FrmUnosRacuna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 622);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvajRacun);
            Name = "FrmUnosRacuna";
            Text = "FrmUnosRacuna";
            FormClosing += FrmUnosRacuna_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStavkeRacuna).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmbFarmaceut1;
        private Button btnOtkazi;
        private Button btnSacuvajRacun;
        private Label lblKorisnik;
        private Label cmbFarmaceut;
        private ComboBox cmbKorisnik;
        private GroupBox groupBox1;
        private Label lblLek;
        private ComboBox cmbLek;
        private TextBox txtKolicina;
        private Label lblKolicina;
        private Label lblStavkeRacuna;
        private Button btnUkloniStavku;
        private Button btnDodajStavku;
        private DataGridView dgvStavkeRacuna;
        private Label lblIDRacun;

        public ComboBox CmbFarmaceut1 { get => cmbFarmaceut1; set => cmbFarmaceut1 = value; }
        public Button BtnOtkazi { get => btnOtkazi; set => btnOtkazi = value; }
        public Button BtnSacuvajRacun { get => btnSacuvajRacun; set => btnSacuvajRacun = value; }
        public Label LblKorisnik { get => lblKorisnik; set => lblKorisnik = value; }
        public Label CmbFarmaceut { get => cmbFarmaceut; set => cmbFarmaceut = value; }
        public ComboBox CmbKorisnik { get => cmbKorisnik; set => cmbKorisnik = value; }
        public ComboBox CmbKorisnik1 { get => cmbKorisnik; set => cmbKorisnik = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public Label LblLek { get => lblLek; set => lblLek = value; }
        public ComboBox CmbLek { get => cmbLek; set => cmbLek = value; }
        public TextBox TxtKolicina { get => txtKolicina; set => txtKolicina = value; }
        public Label LblKolicina { get => lblKolicina; set => lblKolicina = value; }
        public Label LblStavkeRacuna { get => lblStavkeRacuna; set => lblStavkeRacuna = value; }
        public Button BtnUkloniStavku { get => btnUkloniStavku; set => btnUkloniStavku = value; }
        public Button BtnDodajStavku { get => btnDodajStavku; set => btnDodajStavku = value; }
        public DataGridView DgvStavkeRacuna { get => dgvStavkeRacuna; set => dgvStavkeRacuna = value; }
        public Label LblIDRacun { get => lblIDRacun; set => lblIDRacun = value; }
    }
}