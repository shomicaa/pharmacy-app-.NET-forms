namespace Server
{
    partial class FrmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            btnStart = new Button();
            btnStop = new Button();
            lblServerStatus = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(87, 125, 181);
            btnStart.Location = new Point(63, 144);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(109, 42);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(87, 125, 181);
            btnStop.Location = new Point(188, 144);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(109, 42);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // lblServerStatus
            // 
            lblServerStatus.AutoSize = true;
            lblServerStatus.Location = new Point(129, 203);
            lblServerStatus.Name = "lblServerStatus";
            lblServerStatus.Size = new Size(52, 21);
            lblServerStatus.TabIndex = 2;
            lblServerStatus.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(129, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 108);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(358, 266);
            Controls.Add(pictureBox1);
            Controls.Add(lblServerStatus);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmServer";
            Text = "FrmServer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Label lblServerStatus;
        private PictureBox pictureBox1;

        public Button BtnStart { get => btnStart; set => btnStart = value; }
        public Button BtnStop { get => btnStop; set => btnStop = value; }
        public Label LblServerStatus { get => lblServerStatus; set => lblServerStatus = value; }
    }
}
