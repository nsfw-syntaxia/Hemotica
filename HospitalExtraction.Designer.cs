namespace Hemotica
{
	partial class HospitalExtraction
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalExtraction));
			tlpBloodExtraction = new TableLayoutPanel();
			pBarCode = new Panel();
			btnBarCode = new AntdUI.Button();
			pbxBarCode = new PictureBox();
			button2 = new AntdUI.Button();
			pExtraction = new Panel();
			flpExtraction = new FlowLayoutPanel();
			button1 = new AntdUI.Button();
			tlpBloodExtraction.SuspendLayout();
			pBarCode.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxBarCode).BeginInit();
			pExtraction.SuspendLayout();
			SuspendLayout();
			// 
			// tlpBloodExtraction
			// 
			tlpBloodExtraction.ColumnCount = 2;
			tlpBloodExtraction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpBloodExtraction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpBloodExtraction.Controls.Add(pBarCode, 1, 0);
			tlpBloodExtraction.Controls.Add(pExtraction, 0, 0);
			tlpBloodExtraction.Dock = DockStyle.Fill;
			tlpBloodExtraction.Location = new Point(10, 35);
			tlpBloodExtraction.Name = "tlpBloodExtraction";
			tlpBloodExtraction.RowCount = 1;
			tlpBloodExtraction.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tlpBloodExtraction.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tlpBloodExtraction.Size = new Size(1000, 571);
			tlpBloodExtraction.TabIndex = 0;
			// 
			// pBarCode
			// 
			pBarCode.BackColor = Color.FromArgb(216, 85, 101);
			pBarCode.Controls.Add(btnBarCode);
			pBarCode.Controls.Add(pbxBarCode);
			pBarCode.Controls.Add(button2);
			pBarCode.Dock = DockStyle.Fill;
			pBarCode.Location = new Point(503, 3);
			pBarCode.Name = "pBarCode";
			pBarCode.Padding = new Padding(10);
			pBarCode.Size = new Size(494, 565);
			pBarCode.TabIndex = 21;
			// 
			// btnBarCode
			// 
			btnBarCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnBarCode.DefaultBack = Color.FromArgb(252, 228, 228);
			btnBarCode.Font = new Font("Bahnschrift", 20F);
			btnBarCode.ForeColor = Color.FromArgb(216, 85, 101);
			btnBarCode.Location = new Point(13, 492);
			btnBarCode.Name = "btnBarCode";
			btnBarCode.Size = new Size(468, 60);
			btnBarCode.TabIndex = 22;
			btnBarCode.Text = "Load Blood Bag Barcodes";
			// 
			// pbxBarCode
			// 
			pbxBarCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pbxBarCode.BackColor = Color.FromArgb(252, 228, 228);
			pbxBarCode.Image = (Image)resources.GetObject("pbxBarCode.Image");
			pbxBarCode.Location = new Point(13, 13);
			pbxBarCode.Name = "pbxBarCode";
			pbxBarCode.Size = new Size(468, 468);
			pbxBarCode.SizeMode = PictureBoxSizeMode.Zoom;
			pbxBarCode.TabIndex = 21;
			pbxBarCode.TabStop = false;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			button2.DefaultBack = Color.FromArgb(252, 228, 228);
			button2.Font = new Font("Bahnschrift", 20F);
			button2.ForeColor = Color.FromArgb(216, 85, 101);
			button2.Location = new Point(43, 1830);
			button2.Name = "button2";
			button2.Size = new Size(1278, 60);
			button2.TabIndex = 20;
			button2.Text = "Scan Donor QR Code";
			// 
			// pExtraction
			// 
			pExtraction.BackColor = Color.FromArgb(216, 85, 101);
			pExtraction.Controls.Add(flpExtraction);
			pExtraction.Controls.Add(button1);
			pExtraction.Dock = DockStyle.Fill;
			pExtraction.Location = new Point(3, 3);
			pExtraction.Name = "pExtraction";
			pExtraction.Padding = new Padding(10);
			pExtraction.Size = new Size(494, 565);
			pExtraction.TabIndex = 3;
			// 
			// flpExtraction
			// 
			flpExtraction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpExtraction.BackColor = Color.FromArgb(252, 228, 228);
			flpExtraction.Location = new Point(13, 13);
			flpExtraction.Name = "flpExtraction";
			flpExtraction.Size = new Size(468, 539);
			flpExtraction.TabIndex = 21;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			button1.DefaultBack = Color.FromArgb(252, 228, 228);
			button1.Font = new Font("Bahnschrift", 20F);
			button1.ForeColor = Color.FromArgb(216, 85, 101);
			button1.Location = new Point(33, 1384);
			button1.Name = "button1";
			button1.Size = new Size(1008, 60);
			button1.TabIndex = 20;
			button1.Text = "Scan Donor QR Code";
			// 
			// HospitalExtraction
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(tlpBloodExtraction);
			Name = "HospitalExtraction";
			Padding = new Padding(10, 35, 10, 35);
			Size = new Size(1020, 641);
			Load += HospitalExtraction_Load;
			Resize += HospitalExtraction_Resize;
			tlpBloodExtraction.ResumeLayout(false);
			pBarCode.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxBarCode).EndInit();
			pExtraction.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tlpBloodExtraction;
		private Panel pExtraction;
		private AntdUI.Button button1;
		private Panel pBarCode;
		private AntdUI.Button button2;
		private PictureBox pbxBarCode;
		private AntdUI.Button btnBarCode;
		private FlowLayoutPanel flpExtraction;
	}
}
