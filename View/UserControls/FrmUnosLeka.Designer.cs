namespace View.UserControls
{
    partial class FrmUnosLeka
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
            btnOtkazi = new Button();
            btnSacuvajLek = new Button();
            lblUnosNovogLeka = new Label();
            txtCena = new TextBox();
            lblCena = new Label();
            lblZemljaPorekla = new Label();
            txtKolicina = new TextBox();
            lblKolicina = new Label();
            lblRokTrajanja = new Label();
            txtNaziv = new TextBox();
            lblNaziv = new Label();
            cmbZemljaPorekla = new ComboBox();
            dtPickerRokTrajanja = new DateTimePicker();
            SuspendLayout();
            // 
            // btnOtkazi
            // 
            btnOtkazi.Font = new Font("Constantia", 13F);
            btnOtkazi.Location = new Point(408, 378);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(162, 39);
            btnOtkazi.TabIndex = 39;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // btnSacuvajLek
            // 
            btnSacuvajLek.Font = new Font("Constantia", 13F);
            btnSacuvajLek.Location = new Point(219, 378);
            btnSacuvajLek.Name = "btnSacuvajLek";
            btnSacuvajLek.Size = new Size(162, 39);
            btnSacuvajLek.TabIndex = 38;
            btnSacuvajLek.Text = "Sačuvaj Lek";
            btnSacuvajLek.UseVisualStyleBackColor = true;
            btnSacuvajLek.Click += btnSacuvajLek_Click;
            // 
            // lblUnosNovogLeka
            // 
            lblUnosNovogLeka.AutoSize = true;
            lblUnosNovogLeka.Font = new Font("Constantia", 14F);
            lblUnosNovogLeka.Location = new Point(88, 29);
            lblUnosNovogLeka.Name = "lblUnosNovogLeka";
            lblUnosNovogLeka.Size = new Size(155, 23);
            lblUnosNovogLeka.TabIndex = 37;
            lblUnosNovogLeka.Text = "Unos Novog Leka";
            // 
            // txtCena
            // 
            txtCena.Location = new Point(324, 309);
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(309, 27);
            txtCena.TabIndex = 36;
            // 
            // lblCena
            // 
            lblCena.AutoSize = true;
            lblCena.Font = new Font("Constantia", 13F);
            lblCena.Location = new Point(164, 312);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(55, 22);
            lblCena.TabIndex = 35;
            lblCena.Text = "Cena:";
            // 
            // lblZemljaPorekla
            // 
            lblZemljaPorekla.AutoSize = true;
            lblZemljaPorekla.Font = new Font("Constantia", 13F);
            lblZemljaPorekla.Location = new Point(164, 260);
            lblZemljaPorekla.Name = "lblZemljaPorekla";
            lblZemljaPorekla.Size = new Size(134, 22);
            lblZemljaPorekla.TabIndex = 33;
            lblZemljaPorekla.Text = "Zemlja porekla:";
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(324, 205);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(309, 27);
            txtKolicina.TabIndex = 32;
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Font = new Font("Constantia", 13F);
            lblKolicina.Location = new Point(164, 208);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(79, 22);
            lblKolicina.TabIndex = 31;
            lblKolicina.Text = "Količina:";
            // 
            // lblRokTrajanja
            // 
            lblRokTrajanja.AutoSize = true;
            lblRokTrajanja.Font = new Font("Constantia", 13F);
            lblRokTrajanja.Location = new Point(164, 157);
            lblRokTrajanja.Name = "lblRokTrajanja";
            lblRokTrajanja.Size = new Size(115, 22);
            lblRokTrajanja.TabIndex = 29;
            lblRokTrajanja.Text = "Rok Trajanja:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(324, 104);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(309, 27);
            txtNaziv.TabIndex = 41;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Constantia", 13F);
            lblNaziv.Location = new Point(164, 107);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(60, 22);
            lblNaziv.TabIndex = 40;
            lblNaziv.Text = "Naziv:";
            // 
            // cmbZemljaPorekla
            // 
            cmbZemljaPorekla.FormattingEnabled = true;
            cmbZemljaPorekla.Location = new Point(324, 255);
            cmbZemljaPorekla.Name = "cmbZemljaPorekla";
            cmbZemljaPorekla.Size = new Size(309, 27);
            cmbZemljaPorekla.TabIndex = 42;
            // 
            // dtPickerRokTrajanja
            // 
            dtPickerRokTrajanja.Location = new Point(324, 154);
            dtPickerRokTrajanja.Name = "dtPickerRokTrajanja";
            dtPickerRokTrajanja.Size = new Size(309, 27);
            dtPickerRokTrajanja.TabIndex = 43;
            // 
            // FrmUnosLeka
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 497);
            ControlBox = false;
            Controls.Add(dtPickerRokTrajanja);
            Controls.Add(cmbZemljaPorekla);
            Controls.Add(txtNaziv);
            Controls.Add(lblNaziv);
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvajLek);
            Controls.Add(lblUnosNovogLeka);
            Controls.Add(txtCena);
            Controls.Add(lblCena);
            Controls.Add(lblZemljaPorekla);
            Controls.Add(txtKolicina);
            Controls.Add(lblKolicina);
            Controls.Add(lblRokTrajanja);
            Font = new Font("Constantia", 12F);
            Margin = new Padding(4);
            MaximumSize = new Size(776, 536);
            MinimumSize = new Size(776, 536);
            Name = "FrmUnosLeka";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Unos Leka";
            FormClosing += FrmUnosLeka_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOtkazi;
        private Button btnSacuvajLek;
        private Label lblUnosNovogLeka;
        private TextBox txtCena;
        private Label lblCena;
        private Label lblZemljaPorekla;
        private TextBox txtKolicina;
        private Label lblKolicina;
        private Label lblRokTrajanja;
        private TextBox txtNaziv;
        private Label lblNaziv;
        private ComboBox cmbZemljaPorekla;
        private DateTimePicker dtPickerRokTrajanja;

        public Button BtnOtkazi { get => btnOtkazi; set => btnOtkazi = value; }
        public Button BtnSacuvajLek { get => btnSacuvajLek; set => btnSacuvajLek = value; }
        public Label LblUnosNovogLeka { get => lblUnosNovogLeka; set => lblUnosNovogLeka = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public Label LblCena { get => lblCena; set => lblCena = value; }
        public Label LblZemljaPorekla { get => lblZemljaPorekla; set => lblZemljaPorekla = value; }
        public TextBox TxtKolicina { get => txtKolicina; set => txtKolicina = value; }
        public Label LblKolicina { get => lblKolicina; set => lblKolicina = value; }
        public Label LblRokTrajanja { get => lblRokTrajanja; set => lblRokTrajanja = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public ComboBox CmbZemljaPorekla { get => cmbZemljaPorekla; set => cmbZemljaPorekla = value; }
        public DateTimePicker DtPickerRokTrajanja { get => dtPickerRokTrajanja; set => dtPickerRokTrajanja = value; }
    }
}