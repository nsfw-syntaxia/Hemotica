namespace Hemotica
{
    partial class UserLog
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLog));
            pbxLogo = new PictureBox();
            flpLogin = new FlowLayoutPanel();
            tEffect = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // pbxLogo
            // 
            pbxLogo.BackColor = Color.Transparent;
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(152, 25);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(145, 145);
            pbxLogo.TabIndex = 0;
            pbxLogo.TabStop = false;
            // 
            // flpLogin
            // 
            flpLogin.BackColor = Color.FromArgb(244, 180, 180);
            flpLogin.Location = new Point(25, 97);
            flpLogin.Name = "flpLogin";
            flpLogin.Size = new Size(400, 440);
            flpLogin.TabIndex = 1;
            // 
            // tEffect
            // 
            tEffect.Interval = 1;
            tEffect.Tick += tEffect_Tick;
            // 
            // UserLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 211, 211);
            ClientSize = new Size(440, 555);
            ControlBox = false;
            Controls.Add(pbxLogo);
            Controls.Add(flpLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserLog";
            Opacity = 0D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += UserLog_Load;
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxLogo;
        private FlowLayoutPanel flpLogin;
        private System.Windows.Forms.Timer tEffect;
    }
}