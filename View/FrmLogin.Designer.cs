namespace View
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(391, 290);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 43);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(264, 118);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(84, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(363, 115);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(261, 29);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(363, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(261, 29);
            txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(264, 168);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 512);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(btnLogin);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmLogin";
            Text = "FrmLogin";
            FormClosed += FrmLogin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;

        public Button BtnLogin { get => btnLogin; set => btnLogin = value; }
        public Label LblUsername { get => lblUsername; set => lblUsername = value; }
        public TextBox TxtUsername { get => txtUsername; set => txtUsername = value; }
        public TextBox TxtPassword { get => txtPassword; set => txtPassword = value; }
        public Label LblPassword { get => lblPassword; set => lblPassword = value; }
    }
}
