namespace Hemotica
{
	partial class HospitalE
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalE));
			tblpExtraction = new TableLayoutPanel();
			flpBar = new FlowLayoutPanel();
			pbxBar = new PictureBox();
			btnBar = new AntdUI.Button();
			pQR = new Panel();
			btnQr = new AntdUI.Button();
			pbxQR = new PictureBox();
			tblpExtraction.SuspendLayout();
			flpBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxBar).BeginInit();
			pQR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxQR).BeginInit();
			SuspendLayout();
			// 
			// tblpExtraction
			// 
			tblpExtraction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tblpExtraction.ColumnCount = 2;
			tblpExtraction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tblpExtraction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tblpExtraction.Controls.Add(flpBar, 1, 0);
			tblpExtraction.Controls.Add(pQR, 0, 0);
			tblpExtraction.Location = new Point(0, 0);
			tblpExtraction.Name = "tblpExtraction";
			tblpExtraction.Padding = new Padding(5);
			tblpExtraction.RowCount = 1;
			tblpExtraction.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tblpExtraction.Size = new Size(1020, 641);
			tblpExtraction.TabIndex = 0;
			// 
			// flpBar
			// 
			flpBar.BackColor = Color.FromArgb(216, 85, 101);
			flpBar.Controls.Add(pbxBar);
			flpBar.Controls.Add(btnBar);
			flpBar.Dock = DockStyle.Fill;
			flpBar.Location = new Point(513, 8);
			flpBar.Name = "flpBar";
			flpBar.Size = new Size(499, 625);
			flpBar.TabIndex = 1;
			// 
			// pbxBar
			// 
			pbxBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			pbxBar.Image = (Image)resources.GetObject("pbxBar.Image");
			pbxBar.Location = new Point(3, 3);
			pbxBar.Name = "pbxBar";
			pbxBar.Size = new Size(493, 516);
			pbxBar.TabIndex = 1;
			pbxBar.TabStop = false;
			// 
			// btnBar
			// 
			btnBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnBar.DefaultBack = Color.FromArgb(252, 228, 228);
			btnBar.Font = new Font("Bahnschrift", 20F);
			btnBar.ForeColor = Color.FromArgb(216, 85, 101);
			btnBar.Location = new Point(3, 525);
			btnBar.Name = "btnBar";
			btnBar.Size = new Size(493, 97);
			btnBar.TabIndex = 2;
			btnBar.Text = "Scan Blood Bag Barcode";
			// 
			// pQR
			// 
			pQR.BackColor = Color.FromArgb(216, 85, 101);
			pQR.Controls.Add(btnQr);
			pQR.Controls.Add(pbxQR);
			pQR.Dock = DockStyle.Fill;
			pQR.Location = new Point(8, 8);
			pQR.Name = "pQR";
			pQR.Size = new Size(499, 625);
			pQR.TabIndex = 2;
			// 
			// btnQr
			// 
			btnQr.DefaultBack = Color.FromArgb(252, 228, 228);
			btnQr.Font = new Font("Bahnschrift", 20F);
			btnQr.ForeColor = Color.FromArgb(216, 85, 101);
			btnQr.Location = new Point(3, 525);
			btnQr.Name = "btnQr";
			btnQr.Size = new Size(493, 97);
			btnQr.TabIndex = 19;
			btnQr.Text = "Scan Donor QR Code";
			// 
			// pbxQR
			// 
			pbxQR.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			pbxQR.Image = (Image)resources.GetObject("pbxQR.Image");
			pbxQR.Location = new Point(3, 3);
			pbxQR.Name = "pbxQR";
			pbxQR.Size = new Size(493, 516);
			pbxQR.TabIndex = 0;
			pbxQR.TabStop = false;
			// 
			// HospitalE
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(tblpExtraction);
			Name = "HospitalE";
			Size = new Size(1020, 641);
			Load += HospitalE_Load;
			tblpExtraction.ResumeLayout(false);
			flpBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxBar).EndInit();
			pQR.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxQR).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tblpExtraction;
		private FlowLayoutPanel flpBar;
		private Panel pQR;
		private PictureBox pbxBar;
		private AntdUI.Button btnQr;
		private AntdUI.Button btnBar;
		private PictureBox pbxQR;
	}
}
