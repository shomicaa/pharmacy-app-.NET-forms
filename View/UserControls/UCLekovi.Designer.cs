namespace View.UserControls
{
    partial class UCLekovi
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
            cmbFilter = new ComboBox();
            btnIzmeniPodatke = new Button();
            btnObrisiLek = new Button();
            btnPrikaziPodatke = new Button();
            gbPodaciLeka = new GroupBox();
            lblZemljaPorekla = new Label();
            lblCena = new Label();
            lblKolicina = new Label();
            lblRokTrajanja = new Label();
            lblNaziv = new Label();
            btnPrikaziSpisakLekova = new Button();
            btnPretrazi = new Button();
            txtUserInput = new TextBox();
            dgvLekovi = new DataGridView();
            labelFilter = new Label();
            txtCena = new TextBox();
            cmbZemljaPorekla = new ComboBox();
            txtKolicina = new TextBox();
            txtNaziv = new TextBox();
            dtPickerRokTrajanja = new DateTimePicker();
            gbPodaciLeka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLekovi).BeginInit();
            SuspendLayout();
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(16, 50);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(167, 27);
            cmbFilter.TabIndex = 20;
            // 
            // btnIzmeniPodatke
            // 
            btnIzmeniPodatke.Location = new Point(633, 479);
            btnIzmeniPodatke.Name = "btnIzmeniPodatke";
            btnIzmeniPodatke.Size = new Size(166, 35);
            btnIzmeniPodatke.TabIndex = 19;
            btnIzmeniPodatke.Text = "Izmeni podatke";
            btnIzmeniPodatke.UseVisualStyleBackColor = true;
            btnIzmeniPodatke.Click += btnIzmeniPodatke_Click;
            // 
            // btnObrisiLek
            // 
            btnObrisiLek.Location = new Point(633, 537);
            btnObrisiLek.Name = "btnObrisiLek";
            btnObrisiLek.Size = new Size(166, 35);
            btnObrisiLek.TabIndex = 18;
            btnObrisiLek.Text = "Obriši Lek";
            btnObrisiLek.UseVisualStyleBackColor = true;
            btnObrisiLek.Click += btnObrisiLek_Click;
            // 
            // btnPrikaziPodatke
            // 
            btnPrikaziPodatke.Location = new Point(633, 422);
            btnPrikaziPodatke.Name = "btnPrikaziPodatke";
            btnPrikaziPodatke.Size = new Size(166, 35);
            btnPrikaziPodatke.TabIndex = 17;
            btnPrikaziPodatke.Text = "Prikaži podatke";
            btnPrikaziPodatke.UseVisualStyleBackColor = true;
            btnPrikaziPodatke.Click += btnPrikaziPodatke_Click;
            // 
            // gbPodaciLeka
            // 
            gbPodaciLeka.Controls.Add(dtPickerRokTrajanja);
            gbPodaciLeka.Controls.Add(lblZemljaPorekla);
            gbPodaciLeka.Controls.Add(cmbZemljaPorekla);
            gbPodaciLeka.Controls.Add(txtCena);
            gbPodaciLeka.Controls.Add(lblCena);
            gbPodaciLeka.Controls.Add(txtKolicina);
            gbPodaciLeka.Controls.Add(lblKolicina);
            gbPodaciLeka.Controls.Add(lblRokTrajanja);
            gbPodaciLeka.Controls.Add(txtNaziv);
            gbPodaciLeka.Controls.Add(lblNaziv);
            gbPodaciLeka.Location = new Point(633, 54);
            gbPodaciLeka.Name = "gbPodaciLeka";
            gbPodaciLeka.Size = new Size(442, 345);
            gbPodaciLeka.TabIndex = 16;
            gbPodaciLeka.TabStop = false;
            gbPodaciLeka.Text = "Podaci o leku";
            // 
            // lblZemljaPorekla
            // 
            lblZemljaPorekla.AutoSize = true;
            lblZemljaPorekla.Location = new Point(17, 193);
            lblZemljaPorekla.Name = "lblZemljaPorekla";
            lblZemljaPorekla.Size = new Size(119, 19);
            lblZemljaPorekla.TabIndex = 9;
            lblZemljaPorekla.Text = "Zemlja porekla:";
            // 
            // lblCena
            // 
            lblCena.AutoSize = true;
            lblCena.Location = new Point(17, 238);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(48, 19);
            lblCena.TabIndex = 6;
            lblCena.Text = "Cena:";
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Location = new Point(17, 146);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(72, 19);
            lblKolicina.TabIndex = 4;
            lblKolicina.Text = "Količina:";
            // 
            // lblRokTrajanja
            // 
            lblRokTrajanja.AutoSize = true;
            lblRokTrajanja.Location = new Point(17, 99);
            lblRokTrajanja.Name = "lblRokTrajanja";
            lblRokTrajanja.Size = new Size(98, 19);
            lblRokTrajanja.TabIndex = 2;
            lblRokTrajanja.Text = "Rok trajanja:";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(17, 52);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(54, 19);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "Naziv:";
            // 
            // btnPrikaziSpisakLekova
            // 
            btnPrikaziSpisakLekova.ForeColor = SystemColors.ControlText;
            btnPrikaziSpisakLekova.Location = new Point(16, 106);
            btnPrikaziSpisakLekova.Name = "btnPrikaziSpisakLekova";
            btnPrikaziSpisakLekova.Size = new Size(350, 37);
            btnPrikaziSpisakLekova.TabIndex = 15;
            btnPrikaziSpisakLekova.Text = "Prikaži spisak Lekova";
            btnPrikaziSpisakLekova.UseVisualStyleBackColor = true;
            btnPrikaziSpisakLekova.Click += btnPrikaziSpisakLekova_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(407, 44);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(112, 37);
            btnPretrazi.TabIndex = 14;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // txtUserInput
            // 
            txtUserInput.Location = new Point(189, 50);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(212, 27);
            txtUserInput.TabIndex = 13;
            // 
            // dgvLekovi
            // 
            dgvLekovi.AllowUserToAddRows = false;
            dgvLekovi.AllowUserToDeleteRows = false;
            dgvLekovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLekovi.Location = new Point(16, 169);
            dgvLekovi.Name = "dgvLekovi";
            dgvLekovi.ReadOnly = true;
            dgvLekovi.Size = new Size(611, 411);
            dgvLekovi.TabIndex = 12;
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
            // txtCena
            // 
            txtCena.Location = new Point(151, 235);
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(274, 27);
            txtCena.TabIndex = 7;
            // 
            // cmbZemljaPorekla
            // 
            cmbZemljaPorekla.FormattingEnabled = true;
            cmbZemljaPorekla.Location = new Point(151, 190);
            cmbZemljaPorekla.Name = "cmbZemljaPorekla";
            cmbZemljaPorekla.Size = new Size(274, 27);
            cmbZemljaPorekla.TabIndex = 8;
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(151, 143);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(274, 27);
            txtKolicina.TabIndex = 5;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(151, 49);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(274, 27);
            txtNaziv.TabIndex = 1;
            // 
            // dtPickerRokTrajanja
            // 
            dtPickerRokTrajanja.Location = new Point(151, 93);
            dtPickerRokTrajanja.MaxDate = new DateTime(2030, 7, 12, 0, 0, 0, 0);
            dtPickerRokTrajanja.MinDate = new DateTime(2024, 6, 14, 0, 0, 0, 0);
            dtPickerRokTrajanja.Name = "dtPickerRokTrajanja";
            dtPickerRokTrajanja.Size = new Size(274, 27);
            dtPickerRokTrajanja.TabIndex = 10;
            // 
            // UCLekovi
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbFilter);
            Controls.Add(btnIzmeniPodatke);
            Controls.Add(btnObrisiLek);
            Controls.Add(btnPrikaziPodatke);
            Controls.Add(gbPodaciLeka);
            Controls.Add(btnPrikaziSpisakLekova);
            Controls.Add(btnPretrazi);
            Controls.Add(txtUserInput);
            Controls.Add(dgvLekovi);
            Controls.Add(labelFilter);
            Font = new Font("Constantia", 12F);
            Margin = new Padding(4);
            Name = "UCLekovi";
            Size = new Size(1091, 605);
            gbPodaciLeka.ResumeLayout(false);
            gbPodaciLeka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLekovi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFilter;
        private Button btnIzmeniPodatke;
        private Button btnObrisiLek;
        private Button btnPrikaziPodatke;
        private GroupBox gbPodaciLeka;
        private Label lblCena;
        private Label lblKolicina;
        private Label lblRokTrajanja;
        private Label lblNaziv;
        private Button btnPrikaziSpisakLekova;
        private Button btnPretrazi;
        private TextBox txtUserInput;
        private DataGridView dgvLekovi;
        private Label labelFilter;
        private Label lblZemljaPorekla;
        private DateTimePicker dtPickerRokTrajanja;
        private ComboBox cmbZemljaPorekla;
        private TextBox txtCena;
        private TextBox txtKolicina;
        private TextBox txtNaziv;

        public DateTimePicker DtPickerRokTrajanja { get => dtPickerRokTrajanja; set => dtPickerRokTrajanja = value; }
        public ComboBox CmbZemljaPorekla { get => cmbZemljaPorekla; set => cmbZemljaPorekla = value; }
        public ComboBox CmbFilter { get => cmbFilter; set => cmbFilter = value; }
        public Button BtnIzmeniPodatke { get => btnIzmeniPodatke; set => btnIzmeniPodatke = value; }
        public Button BtnObrisiKorisnika { get => btnObrisiLek; set => btnObrisiLek = value; }
        public Button BtnPrikaziPodatke { get => btnPrikaziPodatke; set => btnPrikaziPodatke = value; }
        public GroupBox GbPodaciLeka { get => gbPodaciLeka; set => gbPodaciLeka = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public Label LblCena { get => lblCena; set => lblCena = value; }
        public TextBox TxtKolicina { get => txtKolicina; set => txtKolicina = value; }
        public Label LblKolicina { get => lblKolicina; set => lblKolicina = value; }
        public Label LblRokTrajanja { get => lblRokTrajanja; set => lblRokTrajanja = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public Button BtnPrikaziSpisakLekova { get => btnPrikaziSpisakLekova; set => btnPrikaziSpisakLekova = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public TextBox TxtUserInput { get => txtUserInput; set => txtUserInput = value; }
        public DataGridView DgvLekovi { get => dgvLekovi; set => dgvLekovi = value; }
        public Label LabelFilter { get => labelFilter; set => labelFilter = value; }
    }
}
