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
            btnStart = new Button();
            btnStop = new Button();
            lblServerStatus = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(109, 42);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(127, 12);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(109, 42);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lblServerStatus
            // 
            lblServerStatus.AutoSize = true;
            lblServerStatus.Location = new Point(98, 70);
            lblServerStatus.Name = "lblServerStatus";
            lblServerStatus.Size = new Size(52, 21);
            lblServerStatus.TabIndex = 2;
            lblServerStatus.Text = "label1";
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 100);
            Controls.Add(lblServerStatus);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmServer";
            Text = "FrmServer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Label lblServerStatus;
    }
}
