namespace View.UserControls
{
    partial class UCRacuni
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPrikaziPodatke = new Button();
            gbPodaciRacuna = new GroupBox();
            cmbKorisnik = new ComboBox();
            cmbFarmaceut = new ComboBox();
            dtPickerDatumIzdavanja = new DateTimePicker();
            lblKorisnik = new Label();
            lblFarmaceut = new Label();
            lblDatumIzdavanja = new Label();
            txtStopaPoreza = new TextBox();
            lblStopaPoreza = new Label();
            txtIznos = new TextBox();
            lblUkupnaVrednost = new Label();
            btnPrikaziRacune = new Button();
            btnPretrazi = new Button();
            dgvRacuni = new DataGridView();
            labelFilter = new Label();
            cmbFarmaceutFilter = new ComboBox();
            cmbKorisnikFilter = new ComboBox();
            btnPonistiFilter = new Button();
            gbPodaciRacuna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRacuni).BeginInit();
            SuspendLayout();
            // 
            // btnPrikaziPodatke
            // 
            btnPrikaziPodatke.Location = new Point(690, 418);
            btnPrikaziPodatke.Name = "btnPrikaziPodatke";
            btnPrikaziPodatke.Size = new Size(166, 35);
            btnPrikaziPodatke.TabIndex = 17;
            btnPrikaziPodatke.Text = "Prikaži podatke";
            btnPrikaziPodatke.UseVisualStyleBackColor = true;
            btnPrikaziPodatke.Click += btnPrikaziPodatke_Click;
            // 
            // gbPodaciRacuna
            // 
            gbPodaciRacuna.Controls.Add(cmbKorisnik);
            gbPodaciRacuna.Controls.Add(cmbFarmaceut);
            gbPodaciRacuna.Controls.Add(dtPickerDatumIzdavanja);
            gbPodaciRacuna.Controls.Add(lblKorisnik);
            gbPodaciRacuna.Controls.Add(lblFarmaceut);
            gbPodaciRacuna.Controls.Add(lblDatumIzdavanja);
            gbPodaciRacuna.Controls.Add(txtStopaPoreza);
            gbPodaciRacuna.Controls.Add(lblStopaPoreza);
            gbPodaciRacuna.Controls.Add(txtIznos);
            gbPodaciRacuna.Controls.Add(lblUkupnaVrednost);
            gbPodaciRacuna.Location = new Point(690, 54);
            gbPodaciRacuna.Name = "gbPodaciRacuna";
            gbPodaciRacuna.Size = new Size(385, 345);
            gbPodaciRacuna.TabIndex = 16;
            gbPodaciRacuna.TabStop = false;
            gbPodaciRacuna.Text = "Parametri računa";
            // 
            // cmbKorisnik
            // 
            cmbKorisnik.FormattingEnabled = true;
            cmbKorisnik.Location = new Point(168, 242);
            cmbKorisnik.Name = "cmbKorisnik";
            cmbKorisnik.Size = new Size(211, 27);
            cmbKorisnik.TabIndex = 22;
            // 
            // cmbFarmaceut
            // 
            cmbFarmaceut.FormattingEnabled = true;
            cmbFarmaceut.Location = new Point(168, 194);
            cmbFarmaceut.Name = "cmbFarmaceut";
            cmbFarmaceut.Size = new Size(211, 27);
            cmbFarmaceut.TabIndex = 21;
            // 
            // dtPickerDatumIzdavanja
            // 
            dtPickerDatumIzdavanja.Location = new Point(168, 146);
            dtPickerDatumIzdavanja.Name = "dtPickerDatumIzdavanja";
            dtPickerDatumIzdavanja.Size = new Size(211, 27);
            dtPickerDatumIzdavanja.TabIndex = 20;
            // 
            // lblKorisnik
            // 
            lblKorisnik.AutoSize = true;
            lblKorisnik.Location = new Point(12, 245);
            lblKorisnik.Name = "lblKorisnik";
            lblKorisnik.Size = new Size(73, 19);
            lblKorisnik.TabIndex = 19;
            lblKorisnik.Text = "Korisnik:";
            // 
            // lblFarmaceut
            // 
            lblFarmaceut.AutoSize = true;
            lblFarmaceut.Location = new Point(12, 197);
            lblFarmaceut.Name = "lblFarmaceut";
            lblFarmaceut.Size = new Size(87, 19);
            lblFarmaceut.TabIndex = 18;
            lblFarmaceut.Text = "Farmaceut:";
            // 
            // lblDatumIzdavanja
            // 
            lblDatumIzdavanja.AutoSize = true;
            lblDatumIzdavanja.Location = new Point(12, 149);
            lblDatumIzdavanja.Name = "lblDatumIzdavanja";
            lblDatumIzdavanja.Size = new Size(133, 19);
            lblDatumIzdavanja.TabIndex = 17;
            lblDatumIzdavanja.Text = "Datum Izdavanja:";
            // 
            // txtStopaPoreza
            // 
            txtStopaPoreza.Location = new Point(168, 99);
            txtStopaPoreza.Name = "txtStopaPoreza";
            txtStopaPoreza.Size = new Size(211, 27);
            txtStopaPoreza.TabIndex = 16;
            // 
            // lblStopaPoreza
            // 
            lblStopaPoreza.AutoSize = true;
            lblStopaPoreza.Location = new Point(12, 102);
            lblStopaPoreza.Name = "lblStopaPoreza";
            lblStopaPoreza.Size = new Size(105, 19);
            lblStopaPoreza.TabIndex = 15;
            lblStopaPoreza.Text = "Stopa poreza:";
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(168, 52);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(211, 27);
            txtIznos.TabIndex = 14;
            // 
            // lblUkupnaVrednost
            // 
            lblUkupnaVrednost.AutoSize = true;
            lblUkupnaVrednost.Location = new Point(12, 55);
            lblUkupnaVrednost.Name = "lblUkupnaVrednost";
            lblUkupnaVrednost.Size = new Size(50, 19);
            lblUkupnaVrednost.TabIndex = 13;
            lblUkupnaVrednost.Text = "Iznos:";
            // 
            // btnPrikaziRacune
            // 
            btnPrikaziRacune.ForeColor = SystemColors.ControlText;
            btnPrikaziRacune.Location = new Point(16, 109);
            btnPrikaziRacune.Name = "btnPrikaziRacune";
            btnPrikaziRacune.Size = new Size(350, 37);
            btnPrikaziRacune.TabIndex = 15;
            btnPrikaziRacune.Text = "Prikaži listu Računa";
            btnPrikaziRacune.UseVisualStyleBackColor = true;
            btnPrikaziRacune.Click += btnPrikaziRacune_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(455, 67);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(112, 37);
            btnPretrazi.TabIndex = 14;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // dgvRacuni
            // 
            dgvRacuni.AllowUserToAddRows = false;
            dgvRacuni.AllowUserToDeleteRows = false;
            dgvRacuni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRacuni.Location = new Point(16, 156);
            dgvRacuni.Name = "dgvRacuni";
            dgvRacuni.ReadOnly = true;
            dgvRacuni.Size = new Size(660, 424);
            dgvRacuni.TabIndex = 12;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Font = new Font("Constantia", 14F);
            labelFilter.Location = new Point(16, 24);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(101, 23);
            labelFilter.TabIndex = 11;
            labelFilter.Text = "Filtriraj po:";
            // 
            // cmbFarmaceutFilter
            // 
            cmbFarmaceutFilter.FormattingEnabled = true;
            cmbFarmaceutFilter.Location = new Point(16, 54);
            cmbFarmaceutFilter.Name = "cmbFarmaceutFilter";
            cmbFarmaceutFilter.Size = new Size(205, 27);
            cmbFarmaceutFilter.TabIndex = 20;
            cmbFarmaceutFilter.Text = "--farmaceutu--";
            // 
            // cmbKorisnikFilter
            // 
            cmbKorisnikFilter.FormattingEnabled = true;
            cmbKorisnikFilter.Location = new Point(227, 54);
            cmbKorisnikFilter.Name = "cmbKorisnikFilter";
            cmbKorisnikFilter.Size = new Size(205, 27);
            cmbKorisnikFilter.TabIndex = 21;
            cmbKorisnikFilter.Text = "--korisniku--";
            // 
            // btnPonistiFilter
            // 
            btnPonistiFilter.Location = new Point(455, 24);
            btnPonistiFilter.Name = "btnPonistiFilter";
            btnPonistiFilter.Size = new Size(112, 37);
            btnPonistiFilter.TabIndex = 22;
            btnPonistiFilter.Text = "Poništi filter";
            btnPonistiFilter.UseVisualStyleBackColor = true;
            btnPonistiFilter.Click += btnPonistiFilter_Click;
            // 
            // UCRacuni
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPonistiFilter);
            Controls.Add(cmbKorisnikFilter);
            Controls.Add(cmbFarmaceutFilter);
            Controls.Add(btnPrikaziPodatke);
            Controls.Add(gbPodaciRacuna);
            Controls.Add(btnPrikaziRacune);
            Controls.Add(btnPretrazi);
            Controls.Add(dgvRacuni);
            Controls.Add(labelFilter);
            Font = new Font("Constantia", 12F);
            Margin = new Padding(4);
            Name = "UCRacuni";
            Size = new Size(1091, 605);
            gbPodaciRacuna.ResumeLayout(false);
            gbPodaciRacuna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRacuni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPrikaziPodatke;
        private GroupBox gbPodaciRacuna;
        private Button btnPrikaziRacune;
        private Button btnPretrazi;
        private DataGridView dgvRacuni;
        private Label labelFilter;
        private ComboBox cmbKorisnik;
        private ComboBox cmbFarmaceut;
        private DateTimePicker dtPickerDatumIzdavanja;
        private Label lblKorisnik;
        private Label lblFarmaceut;
        private Label lblDatumIzdavanja;
        private TextBox txtStopaPoreza;
        private Label lblStopaPoreza;
        private TextBox txtIznos;
        private Label lblUkupnaVrednost;
        private ComboBox cmbFarmaceutFilter;
        private ComboBox cmbKorisnikFilter;
        private Button btnPonistiFilter;
        public Button BtnPrikaziPodatke { get => btnPrikaziPodatke; set => btnPrikaziPodatke = value; }
        public GroupBox GbPodaciRacuna { get => gbPodaciRacuna; set => gbPodaciRacuna = value; }
        public Button BtnPrikaziRacune { get => btnPrikaziRacune; set => btnPrikaziRacune = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public DataGridView DgvRacuni { get => dgvRacuni; set => dgvRacuni = value; }
        public Label LabelFilter { get => labelFilter; set => labelFilter = value; }
        public ComboBox CmbKorisnik { get => cmbKorisnik; set => cmbKorisnik = value; }
        public ComboBox CmbFarmaceut { get => cmbFarmaceut; set => cmbFarmaceut = value; }
        public DateTimePicker DtPickerDatumIzdavanja { get => dtPickerDatumIzdavanja; set => dtPickerDatumIzdavanja = value; }
        public Label LblKorisnik { get => lblKorisnik; set => lblKorisnik = value; }
        public Label LblFarmaceut { get => lblFarmaceut; set => lblFarmaceut = value; }
        public Label LblDatumIzdavanja { get => lblDatumIzdavanja; set => lblDatumIzdavanja = value; }
        public TextBox TxtStopaPoreza { get => txtStopaPoreza; set => txtStopaPoreza = value; }
        public Label LblStopaPoreza { get => lblStopaPoreza; set => lblStopaPoreza = value; }
        public TextBox TxtIznos { get => txtIznos; set => txtIznos = value; }
        public Label LblUkupnaVrednost { get => lblUkupnaVrednost; set => lblUkupnaVrednost = value; }
        public ComboBox CmbFarmaceutFilter { get => cmbFarmaceutFilter; set => cmbFarmaceutFilter = value; }
        public ComboBox CmbKorisnikFilter { get => cmbKorisnikFilter; set => cmbKorisnikFilter = value; }
    }
}
