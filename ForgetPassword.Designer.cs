namespace Hemotica
{
    partial class ForgetPassword
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
			tEffect = new System.Windows.Forms.Timer(components);
			pbxLogo = new PictureBox();
			btnClose = new Button();
			flpForgetPassword = new FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
			SuspendLayout();
			// 
			// tEffect
			// 
			tEffect.Enabled = true;
			tEffect.Interval = 1;
			tEffect.Tick += tEffect_Tick;
			// 
			// pbxLogo
			// 
			pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
			pbxLogo.Location = new Point(147, 17);
			pbxLogo.Name = "pbxLogo";
			pbxLogo.Size = new Size(125, 125);
			pbxLogo.TabIndex = 2;
			pbxLogo.TabStop = false;
			// 
			// btnClose
			// 
			btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnClose.FlatAppearance.BorderColor = Color.FromArgb(253, 211, 211);
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.Image = (Image)resources.GetObject("btnClose.Image");
			btnClose.Location = new Point(383, 12);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(25, 25);
			btnClose.TabIndex = 4;
			btnClose.TabStop = false;
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// flpForgetPassword
			// 
			flpForgetPassword.Location = new Point(12, 158);
			flpForgetPassword.Name = "flpForgetPassword";
			flpForgetPassword.Size = new Size(396, 266);
			flpForgetPassword.TabIndex = 69;
			// 
			// ForgetPassword
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			ClientSize = new Size(420, 436);
			ControlBox = false;
			Controls.Add(flpForgetPassword);
			Controls.Add(btnClose);
			Controls.Add(pbxLogo);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.None;
			Name = "ForgetPassword";
			Opacity = 0D;
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Load += ForgetPassword_Load;
			((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.Timer tEffect;
        private PictureBox pbxLogo;
        private Button btnClose;
		private FlowLayoutPanel flpForgetPassword;
	}
}