namespace View.UserControls
{
    partial class UCKorisnici
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
            labelKorisnici = new Label();
            dgvKorisnici = new DataGridView();
            lblImePrezime = new Label();
            txtImePrezime = new TextBox();
            btnPretrazi = new Button();
            btnPrikaziKorisnike = new Button();
            gbPodaciKorisnika = new GroupBox();
            txtKontaktTelefon = new TextBox();
            lblKontaktTelefon = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPrezime = new TextBox();
            lblPrezime = new Label();
            txtIme = new TextBox();
            lblIme = new Label();
            btnPrikaziPodatke = new Button();
            btnObrisiKorisnika = new Button();
            btnIzmeniPodatke = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).BeginInit();
            gbPodaciKorisnika.SuspendLayout();
            SuspendLayout();
            // 
            // labelKorisnici
            // 
            labelKorisnici.AutoSize = true;
            labelKorisnici.Font = new Font("Constantia", 14F);
            labelKorisnici.Location = new Point(16, 12);
            labelKorisnici.Name = "labelKorisnici";
            labelKorisnici.Size = new Size(83, 23);
            labelKorisnici.TabIndex = 0;
            labelKorisnici.Text = "Korisnici";
            // 
            // dgvKorisnici
            // 
            dgvKorisnici.AllowUserToAddRows = false;
            dgvKorisnici.AllowUserToDeleteRows = false;
            dgvKorisnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKorisnici.Location = new Point(16, 167);
            dgvKorisnici.Name = "dgvKorisnici";
            dgvKorisnici.ReadOnly = true;
            dgvKorisnici.Size = new Size(528, 411);
            dgvKorisnici.TabIndex = 1;
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Location = new Point(14, 61);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(181, 19);
            lblImePrezime.TabIndex = 2;
            lblImePrezime.Text = "Ime i prezime korisnika:";
            // 
            // txtImePrezime
            // 
            txtImePrezime.Location = new Point(201, 58);
            txtImePrezime.Name = "txtImePrezime";
            txtImePrezime.Size = new Size(212, 27);
            txtImePrezime.TabIndex = 3;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(432, 52);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(112, 37);
            btnPretrazi.TabIndex = 4;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziKorisnike
            // 
            btnPrikaziKorisnike.ForeColor = SystemColors.ControlText;
            btnPrikaziKorisnike.Location = new Point(16, 111);
            btnPrikaziKorisnike.Name = "btnPrikaziKorisnike";
            btnPrikaziKorisnike.Size = new Size(528, 37);
            btnPrikaziKorisnike.TabIndex = 5;
            btnPrikaziKorisnike.Text = "Prikaži Korisnike";
            btnPrikaziKorisnike.UseVisualStyleBackColor = true;
            btnPrikaziKorisnike.Click += btnPrikaziKorisnike_Click;
            // 
            // gbPodaciKorisnika
            // 
            gbPodaciKorisnika.Controls.Add(txtKontaktTelefon);
            gbPodaciKorisnika.Controls.Add(lblKontaktTelefon);
            gbPodaciKorisnika.Controls.Add(txtEmail);
            gbPodaciKorisnika.Controls.Add(lblEmail);
            gbPodaciKorisnika.Controls.Add(txtPrezime);
            gbPodaciKorisnika.Controls.Add(lblPrezime);
            gbPodaciKorisnika.Controls.Add(txtIme);
            gbPodaciKorisnika.Controls.Add(lblIme);
            gbPodaciKorisnika.Location = new Point(569, 52);
            gbPodaciKorisnika.Name = "gbPodaciKorisnika";
            gbPodaciKorisnika.Size = new Size(498, 345);
            gbPodaciKorisnika.TabIndex = 6;
            gbPodaciKorisnika.TabStop = false;
            gbPodaciKorisnika.Text = "Podaci korisnika";
            // 
            // txtKontaktTelefon
            // 
            txtKontaktTelefon.Location = new Point(163, 191);
            txtKontaktTelefon.Name = "txtKontaktTelefon";
            txtKontaktTelefon.Size = new Size(309, 27);
            txtKontaktTelefon.TabIndex = 7;
            // 
            // lblKontaktTelefon
            // 
            lblKontaktTelefon.AutoSize = true;
            lblKontaktTelefon.Location = new Point(29, 194);
            lblKontaktTelefon.Name = "lblKontaktTelefon";
            lblKontaktTelefon.Size = new Size(128, 19);
            lblKontaktTelefon.TabIndex = 6;
            lblKontaktTelefon.Text = "Kontakt Telefon:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(163, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 27);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(29, 146);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 19);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(163, 96);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(309, 27);
            txtPrezime.TabIndex = 3;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(29, 99);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(71, 19);
            lblPrezime.TabIndex = 2;
            lblPrezime.Text = "Prezime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(163, 49);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(309, 27);
            txtIme.TabIndex = 1;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(29, 52);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(40, 19);
            lblIme.TabIndex = 0;
            lblIme.Text = "Ime:";
            // 
            // btnPrikaziPodatke
            // 
            btnPrikaziPodatke.Location = new Point(569, 418);
            btnPrikaziPodatke.Name = "btnPrikaziPodatke";
            btnPrikaziPodatke.Size = new Size(166, 35);
            btnPrikaziPodatke.TabIndex = 7;
            btnPrikaziPodatke.Text = "Prikaži podatke";
            btnPrikaziPodatke.UseVisualStyleBackColor = true;
            btnPrikaziPodatke.Click += btnPrikaziPodatke_Click;
            // 
            // btnObrisiKorisnika
            // 
            btnObrisiKorisnika.Location = new Point(569, 533);
            btnObrisiKorisnika.Name = "btnObrisiKorisnika";
            btnObrisiKorisnika.Size = new Size(166, 35);
            btnObrisiKorisnika.TabIndex = 8;
            btnObrisiKorisnika.Text = "Obriši korisnika";
            btnObrisiKorisnika.UseVisualStyleBackColor = true;
            btnObrisiKorisnika.Click += btnObrisiKorisnika_Click;
            // 
            // btnIzmeniPodatke
            // 
            btnIzmeniPodatke.Location = new Point(569, 475);
            btnIzmeniPodatke.Name = "btnIzmeniPodatke";
            btnIzmeniPodatke.Size = new Size(166, 35);
            btnIzmeniPodatke.TabIndex = 9;
            btnIzmeniPodatke.Text = "Izmeni podatke";
            btnIzmeniPodatke.UseVisualStyleBackColor = true;
            btnIzmeniPodatke.Click += btnIzmeniPodatke_Click;
            // 
            // UCKorisnici
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnIzmeniPodatke);
            Controls.Add(btnObrisiKorisnika);
            Controls.Add(btnPrikaziPodatke);
            Controls.Add(gbPodaciKorisnika);
            Controls.Add(btnPrikaziKorisnike);
            Controls.Add(btnPretrazi);
            Controls.Add(txtImePrezime);
            Controls.Add(lblImePrezime);
            Controls.Add(dgvKorisnici);
            Controls.Add(labelKorisnici);
            Font = new Font("Constantia", 12F);
            Margin = new Padding(4);
            Name = "UCKorisnici";
            Size = new Size(1091, 605);
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).EndInit();
            gbPodaciKorisnika.ResumeLayout(false);
            gbPodaciKorisnika.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelKorisnici;
        private DataGridView dgvKorisnici;
        private Label lblImePrezime;
        private TextBox txtImePrezime;
        private Button btnPretrazi;
        private Button btnPrikaziKorisnike;
        private GroupBox gbPodaciKorisnika;
        private Button btnPrikaziPodatke;
        private Button btnObrisiKorisnika;
        private TextBox txtPrezime;
        private Label lblPrezime;
        private TextBox txtIme;
        private Label lblIme;
        private TextBox txtKontaktTelefon;
        private Label lblKontaktTelefon;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnIzmeniPodatke;

        public Label LabelKorisnici { get => labelKorisnici; set => labelKorisnici = value; }
        public DataGridView DgvKorisnici { get => dgvKorisnici; set => dgvKorisnici = value; }
        public Label LblImePrezime { get => lblImePrezime; set => lblImePrezime = value; }
        public TextBox TxtImePrezime { get => txtImePrezime; set => txtImePrezime = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public Button BtnPrikaziKorisnike { get => btnPrikaziKorisnike; set => btnPrikaziKorisnike = value; }
        public GroupBox GbPodaciKorisnika { get => gbPodaciKorisnika; set => gbPodaciKorisnika = value; }
        public Button BtnPrikaziPodatke { get => btnPrikaziPodatke; set => btnPrikaziPodatke = value; }
        public Button BtnObrisiKorisnika { get => btnObrisiKorisnika; set => btnObrisiKorisnika = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public TextBox TxtKontaktTelefon { get => txtKontaktTelefon; set => txtKontaktTelefon = value; }
        public Label LblKontaktTelefon { get => lblKontaktTelefon; set => lblKontaktTelefon = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Button BtnIzmeniPodatke { get => btnIzmeniPodatke; set => btnIzmeniPodatke = value; }
    }
}
