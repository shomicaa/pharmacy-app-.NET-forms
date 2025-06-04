namespace View.UserControls
{
    partial class FrmUnosKorisnika
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
            btnSacuvajKorisnika = new Button();
            lblUnosNovogKorisnika = new Label();
            txtKontaktTelefon = new TextBox();
            lblKontaktTelefon = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPrezime = new TextBox();
            lblPrezime = new Label();
            txtIme = new TextBox();
            lblIme = new Label();
            btnOtkazi = new Button();
            SuspendLayout();
            // 
            // btnSacuvajKorisnika
            // 
            btnSacuvajKorisnika.Font = new Font("Constantia", 13F);
            btnSacuvajKorisnika.Location = new Point(201, 365);
            btnSacuvajKorisnika.Name = "btnSacuvajKorisnika";
            btnSacuvajKorisnika.Size = new Size(162, 39);
            btnSacuvajKorisnika.TabIndex = 27;
            btnSacuvajKorisnika.Text = "Sačuvaj Korisnika";
            btnSacuvajKorisnika.UseVisualStyleBackColor = true;
            btnSacuvajKorisnika.Click += btnSacuvajKorisnika_Click;
            // 
            // lblUnosNovogKorisnika
            // 
            lblUnosNovogKorisnika.AutoSize = true;
            lblUnosNovogKorisnika.Font = new Font("Constantia", 14F);
            lblUnosNovogKorisnika.Location = new Point(109, 66);
            lblUnosNovogKorisnika.Name = "lblUnosNovogKorisnika";
            lblUnosNovogKorisnika.Size = new Size(194, 23);
            lblUnosNovogKorisnika.TabIndex = 26;
            lblUnosNovogKorisnika.Text = "Unos Novog Korisnika";
            // 
            // txtKontaktTelefon
            // 
            txtKontaktTelefon.Location = new Point(306, 296);
            txtKontaktTelefon.Name = "txtKontaktTelefon";
            txtKontaktTelefon.Size = new Size(309, 29);
            txtKontaktTelefon.TabIndex = 25;
            // 
            // lblKontaktTelefon
            // 
            lblKontaktTelefon.AutoSize = true;
            lblKontaktTelefon.Font = new Font("Constantia", 13F);
            lblKontaktTelefon.Location = new Point(146, 299);
            lblKontaktTelefon.Name = "lblKontaktTelefon";
            lblKontaktTelefon.Size = new Size(141, 22);
            lblKontaktTelefon.TabIndex = 24;
            lblKontaktTelefon.Text = "Kontakt Telefon:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(306, 244);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 29);
            txtEmail.TabIndex = 23;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Constantia", 13F);
            lblEmail.Location = new Point(146, 247);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(66, 22);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "E-mail:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(306, 192);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(309, 29);
            txtPrezime.TabIndex = 21;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Font = new Font("Constantia", 13F);
            lblPrezime.Location = new Point(146, 195);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(80, 22);
            lblPrezime.TabIndex = 20;
            lblPrezime.Text = "Prezime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(306, 141);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(309, 29);
            txtIme.TabIndex = 19;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Constantia", 13F);
            lblIme.Location = new Point(146, 144);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(46, 22);
            lblIme.TabIndex = 18;
            lblIme.Text = "Ime:";
            // 
            // btnOtkazi
            // 
            btnOtkazi.Font = new Font("Constantia", 13F);
            btnOtkazi.Location = new Point(390, 365);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(162, 39);
            btnOtkazi.TabIndex = 28;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // FrmUnosKorisnika
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 497);
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvajKorisnika);
            Controls.Add(lblUnosNovogKorisnika);
            Controls.Add(txtKontaktTelefon);
            Controls.Add(lblKontaktTelefon);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPrezime);
            Controls.Add(lblPrezime);
            Controls.Add(txtIme);
            Controls.Add(lblIme);
            Font = new Font("Constantia", 13F);
            Margin = new Padding(4);
            Name = "FrmUnosKorisnika";
            Text = "Novi korisnik";
            FormClosing += FrmUnosKorisnika_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacuvajKorisnika;
        private Label lblUnosNovogKorisnika;
        private TextBox txtKontaktTelefon;
        private Label lblKontaktTelefon;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPrezime;
        private Label lblPrezime;
        private TextBox txtIme;
        private Label lblIme;
        private Button btnOtkazi;

        public Button BtnSacuvajKorisnika { get => btnSacuvajKorisnika; set => btnSacuvajKorisnika = value; }
        public Label LblUnosNovogKorisnika { get => lblUnosNovogKorisnika; set => lblUnosNovogKorisnika = value; }
        public TextBox TxtKontaktTelefon { get => txtKontaktTelefon; set => txtKontaktTelefon = value; }
        public Label LblKontaktTelefon { get => lblKontaktTelefon; set => lblKontaktTelefon = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public Button BtnOtkazi { get => btnOtkazi; set => btnOtkazi = value; }
    }
}