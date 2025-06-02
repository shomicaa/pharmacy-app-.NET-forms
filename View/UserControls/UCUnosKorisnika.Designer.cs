namespace View.UserControls
{
    partial class UCUnosKorisnika
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
            txtKontaktTelefon = new TextBox();
            lblKontaktTelefon = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPrezime = new TextBox();
            lblPrezime = new Label();
            txtIme = new TextBox();
            lblIme = new Label();
            lblUnosNovogKorisnika = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtKontaktTelefon
            // 
            txtKontaktTelefon.Location = new Point(216, 248);
            txtKontaktTelefon.Name = "txtKontaktTelefon";
            txtKontaktTelefon.Size = new Size(309, 31);
            txtKontaktTelefon.TabIndex = 15;
            // 
            // lblKontaktTelefon
            // 
            lblKontaktTelefon.AutoSize = true;
            lblKontaktTelefon.Location = new Point(56, 251);
            lblKontaktTelefon.Name = "lblKontaktTelefon";
            lblKontaktTelefon.Size = new Size(138, 25);
            lblKontaktTelefon.TabIndex = 14;
            lblKontaktTelefon.Text = "Kontakt Telefon:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(216, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 31);
            txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(56, 199);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(65, 25);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "E-mail:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(216, 144);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(309, 31);
            txtPrezime.TabIndex = 11;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(56, 147);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(78, 25);
            lblPrezime.TabIndex = 10;
            lblPrezime.Text = "Prezime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(216, 93);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(309, 31);
            txtIme.TabIndex = 9;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(56, 96);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(46, 25);
            lblIme.TabIndex = 8;
            lblIme.Text = "Ime:";
            // 
            // lblUnosNovogKorisnika
            // 
            lblUnosNovogKorisnika.AutoSize = true;
            lblUnosNovogKorisnika.Font = new Font("Segoe UI", 14F);
            lblUnosNovogKorisnika.Location = new Point(19, 18);
            lblUnosNovogKorisnika.Name = "lblUnosNovogKorisnika";
            lblUnosNovogKorisnika.Size = new Size(198, 25);
            lblUnosNovogKorisnika.TabIndex = 16;
            lblUnosNovogKorisnika.Text = "Unos Novog Korisnika";
            // 
            // button1
            // 
            button1.Location = new Point(206, 315);
            button1.Name = "button1";
            button1.Size = new Size(162, 39);
            button1.TabIndex = 17;
            button1.Text = "Sačuvaj Korisnika";
            button1.UseVisualStyleBackColor = true;
            // 
            // UCUnosKorisnika
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(lblUnosNovogKorisnika);
            Controls.Add(txtKontaktTelefon);
            Controls.Add(lblKontaktTelefon);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPrezime);
            Controls.Add(lblPrezime);
            Controls.Add(txtIme);
            Controls.Add(lblIme);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(4);
            Name = "UCUnosKorisnika";
            Size = new Size(1091, 605);
            Leave += UCUnosKorisnika_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKontaktTelefon;
        private Label lblKontaktTelefon;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPrezime;
        private Label lblPrezime;
        private TextBox txtIme;
        private Label lblIme;
        private Label lblUnosNovogKorisnika;
        private Button button1;
    }
}
