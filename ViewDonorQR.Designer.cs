namespace Hemotica
{
	partial class ViewDonorQR
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDonorQR));
			btnClose = new Button();
			pbxLogo = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
			SuspendLayout();
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
			btnClose.TabIndex = 5;
			btnClose.TabStop = false;
			btnClose.UseVisualStyleBackColor = true;
			// 
			// pbxLogo
			// 
			pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
			pbxLogo.Location = new Point(147, 17);
			pbxLogo.Name = "pbxLogo";
			pbxLogo.Size = new Size(125, 125);
			pbxLogo.TabIndex = 6;
			pbxLogo.TabStop = false;
			// 
			// ViewDonorQR
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			ClientSize = new Size(420, 505);
			ControlBox = false;
			Controls.Add(pbxLogo);
			Controls.Add(btnClose);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ViewDonorQR";
			ShowIcon = false;
			ShowInTaskbar = false;
			((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnClose;
		private PictureBox pbxLogo;
	}
}