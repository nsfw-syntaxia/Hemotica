namespace Hemotica
{
	partial class HospitalBloodExtraction
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalBloodExtraction));
			pQRCode = new Panel();
			pbxQRCode = new PictureBox();
			pBarcode = new Panel();
			pbxBarcode = new PictureBox();
			btnQRCode = new AntdUI.Button();
			btnBarCode = new AntdUI.Button();
			lblGuide = new Label();
			pQRCode.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxQRCode).BeginInit();
			pBarcode.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxBarcode).BeginInit();
			SuspendLayout();
			// 
			// pQRCode
			// 
			pQRCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pQRCode.BackColor = Color.FromArgb(216, 85, 101);
			pQRCode.Controls.Add(lblGuide);
			pQRCode.Controls.Add(btnQRCode);
			pQRCode.Controls.Add(pbxQRCode);
			pQRCode.Location = new Point(13, 13);
			pQRCode.Name = "pQRCode";
			pQRCode.Padding = new Padding(10);
			pQRCode.Size = new Size(490, 615);
			pQRCode.TabIndex = 0;
			// 
			// pbxQRCode
			// 
			pbxQRCode.BackColor = Color.FromArgb(252, 228, 228);
			pbxQRCode.Image = (Image)resources.GetObject("pbxQRCode.Image");
			pbxQRCode.Location = new Point(13, 13);
			pbxQRCode.Name = "pbxQRCode";
			pbxQRCode.Size = new Size(464, 464);
			pbxQRCode.TabIndex = 0;
			pbxQRCode.TabStop = false;
			// 
			// pBarcode
			// 
			pBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pBarcode.BackColor = Color.FromArgb(216, 85, 101);
			pBarcode.Controls.Add(btnBarCode);
			pBarcode.Controls.Add(pbxBarcode);
			pBarcode.Location = new Point(517, 13);
			pBarcode.Name = "pBarcode";
			pBarcode.Padding = new Padding(10);
			pBarcode.Size = new Size(490, 615);
			pBarcode.TabIndex = 1;
			// 
			// pbxBarcode
			// 
			pbxBarcode.BackColor = Color.FromArgb(252, 228, 228);
			pbxBarcode.Image = (Image)resources.GetObject("pbxBarcode.Image");
			pbxBarcode.Location = new Point(13, 13);
			pbxBarcode.Name = "pbxBarcode";
			pbxBarcode.Size = new Size(464, 464);
			pbxBarcode.TabIndex = 1;
			pbxBarcode.TabStop = false;
			// 
			// btnQRCode
			// 
			btnQRCode.DefaultBack = Color.FromArgb(252, 228, 228);
			btnQRCode.Font = new Font("Bahnschrift", 20F);
			btnQRCode.ForeColor = Color.FromArgb(216, 85, 101);
			btnQRCode.Location = new Point(13, 483);
			btnQRCode.Name = "btnQRCode";
			btnQRCode.Size = new Size(464, 60);
			btnQRCode.TabIndex = 20;
			btnQRCode.Text = "Scan Donor QR Code";
			// 
			// btnBarCode
			// 
			btnBarCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnBarCode.DefaultBack = Color.FromArgb(252, 228, 228);
			btnBarCode.Font = new Font("Bahnschrift", 20F);
			btnBarCode.ForeColor = Color.FromArgb(216, 85, 101);
			btnBarCode.Location = new Point(13, 483);
			btnBarCode.Name = "btnBarCode";
			btnBarCode.Size = new Size(464, 60);
			btnBarCode.TabIndex = 3;
			btnBarCode.Text = "Load Blood Bag Barcodes";
			// 
			// lblGuide
			// 
			lblGuide.AutoSize = true;
			lblGuide.Font = new Font("Bahnschrift SemiBold", 16F, FontStyle.Bold);
			lblGuide.ForeColor = Color.FromArgb(252, 228, 228);
			lblGuide.Location = new Point(97, 567);
			lblGuide.Name = "lblGuide";
			lblGuide.Size = new Size(280, 27);
			lblGuide.TabIndex = 21;
			lblGuide.Text = "click the heart to continue !";
			// 
			// HospitalBloodExtraction
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(pBarcode);
			Controls.Add(pQRCode);
			Name = "HospitalBloodExtraction";
			Padding = new Padding(10);
			Size = new Size(1020, 641);
			Load += HospitalBloodExtraction_Load;
			Resize += HospitalBloodExtraction_Resize;
			pQRCode.ResumeLayout(false);
			pQRCode.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbxQRCode).EndInit();
			pBarcode.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxBarcode).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel pQRCode;
		private Panel pBarcode;
		private PictureBox pbxQRCode;
		private PictureBox pbxBarcode;
		private AntdUI.Button btnQRCode;
		private AntdUI.Button btnBarCode;
		private Label lblGuide;
	}
}
