namespace Hemotica
{
	partial class DonorQR
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
			btnSave = new ReaLTaiizor.Controls.FoxButton();
			pQRCode = new Panel();
			pbxQRCode = new PictureBox();
			pQRCode.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxQRCode).BeginInit();
			SuspendLayout();
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.Transparent;
			btnSave.BaseColor = Color.FromArgb(216, 85, 101);
			btnSave.BorderColor = Color.FromArgb(216, 85, 101);
			btnSave.DisabledBaseColor = Color.FromArgb(244, 148, 156);
			btnSave.DisabledBorderColor = Color.FromArgb(244, 148, 156);
			btnSave.DisabledTextColor = Color.FromArgb(244, 148, 156);
			btnSave.DownColor = Color.FromArgb(236, 124, 132);
			btnSave.EnabledCalc = true;
			btnSave.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			btnSave.ForeColor = Color.FromArgb(241, 241, 241);
			btnSave.Location = new Point(150, 363);
			btnSave.Name = "btnSave";
			btnSave.OverColor = Color.FromArgb(216, 85, 101);
			btnSave.Size = new Size(120, 40);
			btnSave.TabIndex = 76;
			btnSave.Text = "SAVE";
			// 
			// pQRCode
			// 
			pQRCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pQRCode.BackColor = Color.FromArgb(216, 85, 101);
			pQRCode.Controls.Add(pbxQRCode);
			pQRCode.Location = new Point(43, 16);
			pQRCode.Name = "pQRCode";
			pQRCode.Padding = new Padding(7);
			pQRCode.Size = new Size(335, 335);
			pQRCode.TabIndex = 75;
			// 
			// pbxQRCode
			// 
			pbxQRCode.BackColor = Color.FromArgb(252, 228, 228);
			pbxQRCode.Dock = DockStyle.Fill;
			pbxQRCode.Location = new Point(7, 7);
			pbxQRCode.Name = "pbxQRCode";
			pbxQRCode.Size = new Size(321, 321);
			pbxQRCode.SizeMode = PictureBoxSizeMode.Zoom;
			pbxQRCode.TabIndex = 0;
			pbxQRCode.TabStop = false;
			// 
			// DonorQR
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(244, 180, 180);
			Controls.Add(btnSave);
			Controls.Add(pQRCode);
			Name = "DonorQR";
			Size = new Size(420, 420);
			Load += DonorQR_Load;
			pQRCode.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxQRCode).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private ReaLTaiizor.Controls.FoxButton btnSave;
		private Panel pQRCode;
		private PictureBox pbxQRCode;
	}
}
