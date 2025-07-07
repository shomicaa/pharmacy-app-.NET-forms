namespace View.UserControls
{
    partial class FrmUnosLokacije
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
            lblUnosNovogLeka = new Label();
            txtAdresa = new TextBox();
            lblAdresa = new Label();
            txtOpstina = new TextBox();
            lblOpstina = new Label();
            btnOtkazi = new Button();
            btnSacuvajLokaciju = new Button();
            SuspendLayout();
            // 
            // lblUnosNovogLeka
            // 
            lblUnosNovogLeka.AutoSize = true;
            lblUnosNovogLeka.Font = new Font("Constantia", 14F);
            lblUnosNovogLeka.Location = new Point(51, 38);
            lblUnosNovogLeka.Name = "lblUnosNovogLeka";
            lblUnosNovogLeka.Size = new Size(126, 23);
            lblUnosNovogLeka.TabIndex = 38;
            lblUnosNovogLeka.Text = "Unos Lokacije";
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(284, 121);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(309, 27);
            txtAdresa.TabIndex = 40;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Font = new Font("Constantia", 13F);
            lblAdresa.Location = new Point(124, 124);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(117, 22);
            lblAdresa.TabIndex = 39;
            lblAdresa.Text = "Adresa i Broj:";
            // 
            // txtOpstina
            // 
            txtOpstina.Location = new Point(284, 171);
            txtOpstina.Name = "txtOpstina";
            txtOpstina.Size = new Size(309, 27);
            txtOpstina.TabIndex = 42;
            // 
            // lblOpstina
            // 
            lblOpstina.AutoSize = true;
            lblOpstina.Font = new Font("Constantia", 13F);
            lblOpstina.Location = new Point(124, 174);
            lblOpstina.Name = "lblOpstina";
            lblOpstina.Size = new Size(76, 22);
            lblOpstina.TabIndex = 41;
            lblOpstina.Text = "Opština:";
            // 
            // btnOtkazi
            // 
            btnOtkazi.Font = new Font("Constantia", 13F);
            btnOtkazi.Location = new Point(395, 298);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(162, 39);
            btnOtkazi.TabIndex = 44;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // btnSacuvajLokaciju
            // 
            btnSacuvajLokaciju.Font = new Font("Constantia", 13F);
            btnSacuvajLokaciju.Location = new Point(206, 298);
            btnSacuvajLokaciju.Name = "btnSacuvajLokaciju";
            btnSacuvajLokaciju.Size = new Size(162, 39);
            btnSacuvajLokaciju.TabIndex = 43;
            btnSacuvajLokaciju.Text = "Sačuvaj Lokaciju";
            btnSacuvajLokaciju.UseVisualStyleBackColor = true;
            btnSacuvajLokaciju.Click += btnSacuvajLokaciju_Click;
            // 
            // FrmUnosLokacije
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 497);
            ControlBox = false;
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvajLokaciju);
            Controls.Add(txtOpstina);
            Controls.Add(lblOpstina);
            Controls.Add(txtAdresa);
            Controls.Add(lblAdresa);
            Controls.Add(lblUnosNovogLeka);
            Font = new Font("Constantia", 12F);
            Margin = new Padding(4);
            Name = "FrmUnosLokacije";
            Text = "FrmUnosLokacije";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUnosNovogLeka;
        private TextBox txtAdresa;
        private Label lblAdresa;
        private TextBox txtOpstina;
        private Label lblOpstina;
        private Button btnOtkazi;
        private Button btnSacuvajLokaciju;

        public Label LblUnosNovogLeka { get => lblUnosNovogLeka; set => lblUnosNovogLeka = value; }
        public TextBox TxtAdresa { get => txtAdresa; set => txtAdresa = value; }
        public Label LblAdresa { get => lblAdresa; set => lblAdresa = value; }
        public TextBox TxtOpstina { get => txtOpstina; set => txtOpstina = value; }
        public Label LblOpstina { get => lblOpstina; set => lblOpstina = value; }
        public Button BtnOtkazi { get => btnOtkazi; set => btnOtkazi = value; }
        public Button BtnSacuvajLokaciju { get => btnSacuvajLokaciju; set => btnSacuvajLokaciju = value; }
    }
}