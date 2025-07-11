namespace View.UserControls
{
    partial class FrmPrikazRacuna
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
            gbPodaciRacuna = new GroupBox();
            lblKorisnikIme = new Label();
            lblFarmaceutIme = new Label();
            textBox1 = new TextBox();
            lblIDRacun = new Label();
            txtIznosSaPorezom = new TextBox();
            lblIznosSaPorezom = new Label();
            dtPickerDatumIzdavanja = new DateTimePicker();
            lblKorisnik = new Label();
            lblFarmaceut = new Label();
            lblDatumIzdavanja = new Label();
            txtStopaPoreza = new TextBox();
            lblStopaPoreza = new Label();
            txtIznos = new TextBox();
            lblUkupnaVrednost = new Label();
            gbStavke = new GroupBox();
            btnDodajStavku = new Button();
            txtKolicina = new TextBox();
            lblKolicina = new Label();
            lblLek = new Label();
            cmbLek = new ComboBox();
            btnUkloniStavku = new Button();
            btnIzmeniStavku = new Button();
            dgvStavke = new DataGridView();
            btnSacuvajPromene = new Button();
            btnOtkazi = new Button();
            gbPodaciRacuna.SuspendLayout();
            gbStavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            SuspendLayout();
            // 
            // gbPodaciRacuna
            // 
            gbPodaciRacuna.Controls.Add(lblKorisnikIme);
            gbPodaciRacuna.Controls.Add(lblFarmaceutIme);
            gbPodaciRacuna.Controls.Add(textBox1);
            gbPodaciRacuna.Controls.Add(lblIDRacun);
            gbPodaciRacuna.Controls.Add(txtIznosSaPorezom);
            gbPodaciRacuna.Controls.Add(lblIznosSaPorezom);
            gbPodaciRacuna.Controls.Add(dtPickerDatumIzdavanja);
            gbPodaciRacuna.Controls.Add(lblKorisnik);
            gbPodaciRacuna.Controls.Add(lblFarmaceut);
            gbPodaciRacuna.Controls.Add(lblDatumIzdavanja);
            gbPodaciRacuna.Controls.Add(txtStopaPoreza);
            gbPodaciRacuna.Controls.Add(lblStopaPoreza);
            gbPodaciRacuna.Controls.Add(txtIznos);
            gbPodaciRacuna.Controls.Add(lblUkupnaVrednost);
            gbPodaciRacuna.Location = new Point(12, 12);
            gbPodaciRacuna.Name = "gbPodaciRacuna";
            gbPodaciRacuna.Size = new Size(385, 472);
            gbPodaciRacuna.TabIndex = 17;
            gbPodaciRacuna.TabStop = false;
            gbPodaciRacuna.Text = "Parametri računa";
            // 
            // lblKorisnikIme
            // 
            lblKorisnikIme.AutoSize = true;
            lblKorisnikIme.Location = new Point(168, 332);
            lblKorisnikIme.Name = "lblKorisnikIme";
            lblKorisnikIme.Size = new Size(49, 19);
            lblKorisnikIme.TabIndex = 28;
            lblKorisnikIme.Text = "label1";
            // 
            // lblFarmaceutIme
            // 
            lblFarmaceutIme.AutoSize = true;
            lblFarmaceutIme.Location = new Point(168, 284);
            lblFarmaceutIme.Name = "lblFarmaceutIme";
            lblFarmaceutIme.Size = new Size(49, 19);
            lblFarmaceutIme.TabIndex = 27;
            lblFarmaceutIme.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 26;
            // 
            // lblIDRacun
            // 
            lblIDRacun.AutoSize = true;
            lblIDRacun.Location = new Point(12, 45);
            lblIDRacun.Name = "lblIDRacun";
            lblIDRacun.Size = new Size(77, 19);
            lblIDRacun.TabIndex = 25;
            lblIDRacun.Text = "ID računa";
            // 
            // txtIznosSaPorezom
            // 
            txtIznosSaPorezom.Location = new Point(168, 184);
            txtIznosSaPorezom.Name = "txtIznosSaPorezom";
            txtIznosSaPorezom.Size = new Size(211, 27);
            txtIznosSaPorezom.TabIndex = 24;
            // 
            // lblIznosSaPorezom
            // 
            lblIznosSaPorezom.AutoSize = true;
            lblIznosSaPorezom.Location = new Point(12, 187);
            lblIznosSaPorezom.Name = "lblIznosSaPorezom";
            lblIznosSaPorezom.Size = new Size(135, 19);
            lblIznosSaPorezom.TabIndex = 23;
            lblIznosSaPorezom.Text = "Iznos sa porezom:";
            // 
            // dtPickerDatumIzdavanja
            // 
            dtPickerDatumIzdavanja.Location = new Point(168, 233);
            dtPickerDatumIzdavanja.Name = "dtPickerDatumIzdavanja";
            dtPickerDatumIzdavanja.Size = new Size(211, 27);
            dtPickerDatumIzdavanja.TabIndex = 20;
            // 
            // lblKorisnik
            // 
            lblKorisnik.AutoSize = true;
            lblKorisnik.Location = new Point(12, 332);
            lblKorisnik.Name = "lblKorisnik";
            lblKorisnik.Size = new Size(73, 19);
            lblKorisnik.TabIndex = 19;
            lblKorisnik.Text = "Korisnik:";
            // 
            // lblFarmaceut
            // 
            lblFarmaceut.AutoSize = true;
            lblFarmaceut.Location = new Point(12, 284);
            lblFarmaceut.Name = "lblFarmaceut";
            lblFarmaceut.Size = new Size(87, 19);
            lblFarmaceut.TabIndex = 18;
            lblFarmaceut.Text = "Farmaceut:";
            // 
            // lblDatumIzdavanja
            // 
            lblDatumIzdavanja.AutoSize = true;
            lblDatumIzdavanja.Location = new Point(12, 236);
            lblDatumIzdavanja.Name = "lblDatumIzdavanja";
            lblDatumIzdavanja.Size = new Size(133, 19);
            lblDatumIzdavanja.TabIndex = 17;
            lblDatumIzdavanja.Text = "Datum Izdavanja:";
            // 
            // txtStopaPoreza
            // 
            txtStopaPoreza.Location = new Point(168, 137);
            txtStopaPoreza.Name = "txtStopaPoreza";
            txtStopaPoreza.Size = new Size(211, 27);
            txtStopaPoreza.TabIndex = 16;
            // 
            // lblStopaPoreza
            // 
            lblStopaPoreza.AutoSize = true;
            lblStopaPoreza.Location = new Point(12, 140);
            lblStopaPoreza.Name = "lblStopaPoreza";
            lblStopaPoreza.Size = new Size(105, 19);
            lblStopaPoreza.TabIndex = 15;
            lblStopaPoreza.Text = "Stopa poreza:";
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(168, 90);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(211, 27);
            txtIznos.TabIndex = 14;
            // 
            // lblUkupnaVrednost
            // 
            lblUkupnaVrednost.AutoSize = true;
            lblUkupnaVrednost.Location = new Point(12, 93);
            lblUkupnaVrednost.Name = "lblUkupnaVrednost";
            lblUkupnaVrednost.Size = new Size(50, 19);
            lblUkupnaVrednost.TabIndex = 13;
            lblUkupnaVrednost.Text = "Iznos:";
            // 
            // gbStavke
            // 
            gbStavke.Controls.Add(btnDodajStavku);
            gbStavke.Controls.Add(txtKolicina);
            gbStavke.Controls.Add(lblKolicina);
            gbStavke.Controls.Add(lblLek);
            gbStavke.Controls.Add(cmbLek);
            gbStavke.Controls.Add(btnUkloniStavku);
            gbStavke.Controls.Add(btnIzmeniStavku);
            gbStavke.Controls.Add(dgvStavke);
            gbStavke.Location = new Point(403, 12);
            gbStavke.Name = "gbStavke";
            gbStavke.Size = new Size(608, 472);
            gbStavke.TabIndex = 18;
            gbStavke.TabStop = false;
            gbStavke.Text = "Stavke računa:";
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.Font = new Font("Constantia", 13F);
            btnDodajStavku.Location = new Point(52, 427);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(162, 39);
            btnDodajStavku.TabIndex = 66;
            btnDodajStavku.Text = "Dodaj Stavku";
            btnDodajStavku.UseVisualStyleBackColor = true;
            btnDodajStavku.Click += btnDodajStavku_Click;
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(376, 349);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(202, 27);
            txtKolicina.TabIndex = 65;
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Font = new Font("Constantia", 13F);
            lblKolicina.Location = new Point(293, 351);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(79, 22);
            lblKolicina.TabIndex = 64;
            lblKolicina.Text = "Kolicina:";
            // 
            // lblLek
            // 
            lblLek.AutoSize = true;
            lblLek.Font = new Font("Constantia", 13F);
            lblLek.Location = new Point(17, 352);
            lblLek.Name = "lblLek";
            lblLek.Size = new Size(44, 22);
            lblLek.TabIndex = 62;
            lblLek.Text = "Lek:";
            // 
            // cmbLek
            // 
            cmbLek.FormattingEnabled = true;
            cmbLek.Location = new Point(67, 349);
            cmbLek.Name = "cmbLek";
            cmbLek.Size = new Size(202, 27);
            cmbLek.TabIndex = 63;
            // 
            // btnUkloniStavku
            // 
            btnUkloniStavku.Font = new Font("Constantia", 13F);
            btnUkloniStavku.Location = new Point(388, 427);
            btnUkloniStavku.Name = "btnUkloniStavku";
            btnUkloniStavku.Size = new Size(162, 39);
            btnUkloniStavku.TabIndex = 44;
            btnUkloniStavku.Text = "Ukloni Stavku";
            btnUkloniStavku.UseVisualStyleBackColor = true;
            btnUkloniStavku.Click += btnUkloniStavku_Click;
            // 
            // btnIzmeniStavku
            // 
            btnIzmeniStavku.Font = new Font("Constantia", 13F);
            btnIzmeniStavku.Location = new Point(220, 427);
            btnIzmeniStavku.Name = "btnIzmeniStavku";
            btnIzmeniStavku.Size = new Size(162, 39);
            btnIzmeniStavku.TabIndex = 43;
            btnIzmeniStavku.Text = "Izmeni Stavku";
            btnIzmeniStavku.UseVisualStyleBackColor = true;
            btnIzmeniStavku.Click += btnIzmeniStavku_Click;
            // 
            // dgvStavke
            // 
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavke.Location = new Point(6, 26);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.Size = new Size(588, 317);
            dgvStavke.TabIndex = 0;
            // 
            // btnSacuvajPromene
            // 
            btnSacuvajPromene.Font = new Font("Constantia", 13F);
            btnSacuvajPromene.Location = new Point(330, 516);
            btnSacuvajPromene.Name = "btnSacuvajPromene";
            btnSacuvajPromene.Size = new Size(162, 39);
            btnSacuvajPromene.TabIndex = 39;
            btnSacuvajPromene.Text = "Sačuvaj Promene";
            btnSacuvajPromene.UseVisualStyleBackColor = true;
            btnSacuvajPromene.Click += btnSacuvajPromene_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Font = new Font("Constantia", 13F);
            btnOtkazi.Location = new Point(498, 516);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(162, 39);
            btnOtkazi.TabIndex = 40;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // FrmPrikazRacuna
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 584);
            ControlBox = false;
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvajPromene);
            Controls.Add(gbStavke);
            Controls.Add(gbPodaciRacuna);
            Font = new Font("Constantia", 12F);
            Margin = new Padding(4);
            Name = "FrmPrikazRacuna";
            Text = "FrmPrikazRacuna";
            gbPodaciRacuna.ResumeLayout(false);
            gbPodaciRacuna.PerformLayout();
            gbStavke.ResumeLayout(false);
            gbStavke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPodaciRacuna;
        private DateTimePicker dtPickerDatumIzdavanja;
        private Label lblKorisnik;
        private Label lblFarmaceut;
        private Label lblDatumIzdavanja;
        private TextBox txtStopaPoreza;
        private Label lblStopaPoreza;
        private TextBox txtIznos;
        private Label lblUkupnaVrednost;
        private TextBox textBox1;
        private Label lblIDRacun;
        private TextBox txtIznosSaPorezom;
        private Label lblIznosSaPorezom;
        private GroupBox gbStavke;
        private DataGridView dgvStavke;
        private Button btnSacuvajPromene;
        private Button btnOtkazi;
        private Button btnUkloniStavku;
        private Button btnIzmeniStavku;
        private Label lblKorisnikIme;
        private Label lblFarmaceutIme;
        private Button btnDodajStavku;
        private TextBox txtKolicina;
        private Label lblKolicina;
        private Label lblLek;
        private ComboBox cmbLek;

        public GroupBox GbPodaciRacuna { get => gbPodaciRacuna; set => gbPodaciRacuna = value; }
        public DateTimePicker DtPickerDatumIzdavanja { get => dtPickerDatumIzdavanja; set => dtPickerDatumIzdavanja = value; }
        public Label LblKorisnik { get => lblKorisnik; set => lblKorisnik = value; }
        public Label LblFarmaceut { get => lblFarmaceut; set => lblFarmaceut = value; }
        public Label LblDatumIzdavanja { get => lblDatumIzdavanja; set => lblDatumIzdavanja = value; }
        public TextBox TxtStopaPoreza { get => txtStopaPoreza; set => txtStopaPoreza = value; }
        public Label LblStopaPoreza { get => lblStopaPoreza; set => lblStopaPoreza = value; }
        public TextBox TxtIznos { get => txtIznos; set => txtIznos = value; }
        public Label LblUkupnaVrednost { get => lblUkupnaVrednost; set => lblUkupnaVrednost = value; }
        public TextBox TextBox1 { get => textBox1; set => textBox1 = value; }
        public Label LblIDRacun { get => lblIDRacun; set => lblIDRacun = value; }
        public TextBox TxtIznosSaPorezom { get => txtIznosSaPorezom; set => txtIznosSaPorezom = value; }
        public Label LblIznosSaPorezom { get => lblIznosSaPorezom; set => lblIznosSaPorezom = value; }
        public GroupBox GbStavke { get => gbStavke; set => gbStavke = value; }
        public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
        public Button BtnSacuvajPromene { get => btnSacuvajPromene; set => btnSacuvajPromene = value; }
        public Button BtnOtkazi { get => btnOtkazi; set => btnOtkazi = value; }
        public Button Button1 { get => btnUkloniStavku; set => btnUkloniStavku = value; }
        public Button BtnIzmeniStavku { get => btnIzmeniStavku; set => btnIzmeniStavku = value; }
        public Label LblKorisnikIme { get => lblKorisnikIme; set => lblKorisnikIme = value; }
        public Label LblFarmaceutIme { get => lblFarmaceutIme; set => lblFarmaceutIme = value; }
        public Button BtnDodajStavku { get => btnDodajStavku; set => btnDodajStavku = value; }
        public TextBox TxtKolicina { get => txtKolicina; set => txtKolicina = value; }
        public Label LblKolicina { get => lblKolicina; set => lblKolicina = value; }
        public Label LblLek { get => lblLek; set => lblLek = value; }
        public ComboBox CmbLek { get => cmbLek; set => cmbLek = value; }
    }
}