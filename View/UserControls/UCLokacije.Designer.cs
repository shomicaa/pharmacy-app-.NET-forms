namespace View.UserControls
{
    partial class UCLokacije
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
            btnPrikaziSpisakLokacija = new Button();
            dgvLokacije = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLokacije).BeginInit();
            SuspendLayout();
            // 
            // btnPrikaziSpisakLokacija
            // 
            btnPrikaziSpisakLokacija.ForeColor = SystemColors.ControlText;
            btnPrikaziSpisakLokacija.Location = new Point(15, 31);
            btnPrikaziSpisakLokacija.Name = "btnPrikaziSpisakLokacija";
            btnPrikaziSpisakLokacija.Size = new Size(350, 37);
            btnPrikaziSpisakLokacija.TabIndex = 17;
            btnPrikaziSpisakLokacija.Text = "Prikaži spisak Lokacija";
            btnPrikaziSpisakLokacija.UseVisualStyleBackColor = true;
            btnPrikaziSpisakLokacija.Click += btnPrikaziSpisakLokacija_Click;
            // 
            // dgvLokacije
            // 
            dgvLokacije.AllowUserToAddRows = false;
            dgvLokacije.AllowUserToDeleteRows = false;
            dgvLokacije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLokacije.Location = new Point(15, 89);
            dgvLokacije.Name = "dgvLokacije";
            dgvLokacije.ReadOnly = true;
            dgvLokacije.Size = new Size(611, 491);
            dgvLokacije.TabIndex = 16;
            // 
            // UCLokacije
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPrikaziSpisakLokacija);
            Controls.Add(dgvLokacije);
            Font = new Font("Constantia", 12F);
            Margin = new Padding(4);
            Name = "UCLokacije";
            Size = new Size(1091, 605);
            ((System.ComponentModel.ISupportInitialize)dgvLokacije).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrikaziSpisakLokacija;
        private DataGridView dgvLokacije;

        public Button BtnPrikaziSpisakLokacija { get => btnPrikaziSpisakLokacija; set => btnPrikaziSpisakLokacija = value; }
        public DataGridView DgvLokacije { get => dgvLokacije; set => dgvLokacije = value; }
    }
}
