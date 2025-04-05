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
			pExtraction = new Panel();
			btnDonate = new AntdUI.Button();
			pDonate = new Panel();
			tbxAddress = new ReaLTaiizor.Controls.HopeTextBox();
			lblAddress = new Label();
			lblCNumber = new Label();
			tbxBloodType = new ReaLTaiizor.Controls.HopeTextBox();
			lblBType = new Label();
			tbxCNumber = new ReaLTaiizor.Controls.HopeTextBox();
			lblGender = new Label();
			tbxAge = new ReaLTaiizor.Controls.HopeTextBox();
			lblAge = new Label();
			lblName = new Label();
			lblBloodExtraction = new Label();
			cmbxDonor = new ReaLTaiizor.Controls.DungeonComboBox();
			tbxGender = new ReaLTaiizor.Controls.HopeTextBox();
			tlpBloodExtraction.SuspendLayout();
			pBarCode.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxBarCode).BeginInit();
			pExtraction.SuspendLayout();
			pDonate.SuspendLayout();
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
			btnBarCode.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold);
			btnBarCode.ForeColor = Color.FromArgb(216, 85, 101);
			btnBarCode.Location = new Point(13, 492);
			btnBarCode.Name = "btnBarCode";
			btnBarCode.Size = new Size(468, 60);
			btnBarCode.TabIndex = 22;
			btnBarCode.Text = "Blood Bag Barcodes";
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
			// pExtraction
			// 
			pExtraction.BackColor = Color.FromArgb(216, 85, 101);
			pExtraction.Controls.Add(btnDonate);
			pExtraction.Controls.Add(pDonate);
			pExtraction.Dock = DockStyle.Fill;
			pExtraction.Location = new Point(3, 3);
			pExtraction.Name = "pExtraction";
			pExtraction.Padding = new Padding(10);
			pExtraction.Size = new Size(494, 565);
			pExtraction.TabIndex = 3;
			// 
			// btnDonate
			// 
			btnDonate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnDonate.DefaultBack = Color.FromArgb(252, 228, 228);
			btnDonate.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold);
			btnDonate.ForeColor = Color.FromArgb(216, 85, 101);
			btnDonate.Location = new Point(13, 492);
			btnDonate.Name = "btnDonate";
			btnDonate.Size = new Size(468, 60);
			btnDonate.TabIndex = 23;
			btnDonate.Text = "Donate";
			// 
			// pDonate
			// 
			pDonate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pDonate.BackColor = Color.FromArgb(252, 228, 228);
			pDonate.Controls.Add(tbxAddress);
			pDonate.Controls.Add(lblAddress);
			pDonate.Controls.Add(lblCNumber);
			pDonate.Controls.Add(tbxBloodType);
			pDonate.Controls.Add(lblBType);
			pDonate.Controls.Add(tbxCNumber);
			pDonate.Controls.Add(lblGender);
			pDonate.Controls.Add(tbxAge);
			pDonate.Controls.Add(lblAge);
			pDonate.Controls.Add(lblName);
			pDonate.Controls.Add(lblBloodExtraction);
			pDonate.Controls.Add(cmbxDonor);
			pDonate.Controls.Add(tbxGender);
			pDonate.Location = new Point(13, 13);
			pDonate.Name = "pDonate";
			pDonate.Padding = new Padding(10);
			pDonate.Size = new Size(468, 468);
			pDonate.TabIndex = 0;
			// 
			// tbxAddress
			// 
			tbxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbxAddress.BackColor = Color.White;
			tbxAddress.BaseColor = Color.FromArgb(252, 228, 228);
			tbxAddress.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxAddress.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxAddress.Enabled = false;
			tbxAddress.Font = new Font("Bahnschrift", 15F);
			tbxAddress.ForeColor = Color.FromArgb(216, 85, 101);
			tbxAddress.Hint = "";
			tbxAddress.Location = new Point(13, 357);
			tbxAddress.MaxLength = 32767;
			tbxAddress.Multiline = false;
			tbxAddress.Name = "tbxAddress";
			tbxAddress.PasswordChar = '\0';
			tbxAddress.ScrollBars = ScrollBars.None;
			tbxAddress.SelectedText = "";
			tbxAddress.SelectionLength = 0;
			tbxAddress.SelectionStart = 0;
			tbxAddress.Size = new Size(442, 41);
			tbxAddress.TabIndex = 88;
			tbxAddress.TabStop = false;
			tbxAddress.UseSystemPasswordChar = false;
			// 
			// lblAddress
			// 
			lblAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblAddress.AutoSize = true;
			lblAddress.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblAddress.ForeColor = Color.FromArgb(216, 85, 101);
			lblAddress.Location = new Point(13, 330);
			lblAddress.Name = "lblAddress";
			lblAddress.Size = new Size(74, 24);
			lblAddress.TabIndex = 87;
			lblAddress.Text = "Address";
			// 
			// lblCNumber
			// 
			lblCNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblCNumber.AutoSize = true;
			lblCNumber.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblCNumber.ForeColor = Color.FromArgb(216, 85, 101);
			lblCNumber.Location = new Point(237, 255);
			lblCNumber.Name = "lblCNumber";
			lblCNumber.Size = new Size(136, 24);
			lblCNumber.TabIndex = 86;
			lblCNumber.Text = "Contact Number";
			// 
			// tbxBloodType
			// 
			tbxBloodType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbxBloodType.BackColor = Color.White;
			tbxBloodType.BaseColor = Color.FromArgb(252, 228, 228);
			tbxBloodType.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxBloodType.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxBloodType.Enabled = false;
			tbxBloodType.Font = new Font("Bahnschrift", 15F);
			tbxBloodType.ForeColor = Color.FromArgb(216, 85, 101);
			tbxBloodType.Hint = "";
			tbxBloodType.Location = new Point(13, 282);
			tbxBloodType.MaxLength = 32767;
			tbxBloodType.Multiline = false;
			tbxBloodType.Name = "tbxBloodType";
			tbxBloodType.PasswordChar = '\0';
			tbxBloodType.ScrollBars = ScrollBars.None;
			tbxBloodType.SelectedText = "";
			tbxBloodType.SelectionLength = 0;
			tbxBloodType.SelectionStart = 0;
			tbxBloodType.Size = new Size(218, 41);
			tbxBloodType.TabIndex = 84;
			tbxBloodType.TabStop = false;
			tbxBloodType.UseSystemPasswordChar = false;
			// 
			// lblBType
			// 
			lblBType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblBType.AutoSize = true;
			lblBType.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblBType.ForeColor = Color.FromArgb(216, 85, 101);
			lblBType.Location = new Point(13, 255);
			lblBType.Name = "lblBType";
			lblBType.Size = new Size(99, 24);
			lblBType.TabIndex = 83;
			lblBType.Text = "Blood Type";
			// 
			// tbxCNumber
			// 
			tbxCNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbxCNumber.BackColor = Color.White;
			tbxCNumber.BaseColor = Color.FromArgb(252, 228, 228);
			tbxCNumber.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxCNumber.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxCNumber.Enabled = false;
			tbxCNumber.Font = new Font("Bahnschrift", 15F);
			tbxCNumber.ForeColor = Color.FromArgb(216, 85, 101);
			tbxCNumber.Hint = "";
			tbxCNumber.Location = new Point(237, 282);
			tbxCNumber.MaxLength = 32767;
			tbxCNumber.Multiline = false;
			tbxCNumber.Name = "tbxCNumber";
			tbxCNumber.PasswordChar = '\0';
			tbxCNumber.ScrollBars = ScrollBars.None;
			tbxCNumber.SelectedText = "";
			tbxCNumber.SelectionLength = 0;
			tbxCNumber.SelectionStart = 0;
			tbxCNumber.Size = new Size(218, 41);
			tbxCNumber.TabIndex = 85;
			tbxCNumber.TabStop = false;
			tbxCNumber.UseSystemPasswordChar = false;
			// 
			// lblGender
			// 
			lblGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblGender.AutoSize = true;
			lblGender.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblGender.ForeColor = Color.FromArgb(216, 85, 101);
			lblGender.Location = new Point(237, 180);
			lblGender.Name = "lblGender";
			lblGender.Size = new Size(67, 24);
			lblGender.TabIndex = 82;
			lblGender.Text = "Gender";
			// 
			// tbxAge
			// 
			tbxAge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbxAge.BackColor = Color.White;
			tbxAge.BaseColor = Color.FromArgb(252, 228, 228);
			tbxAge.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxAge.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxAge.Enabled = false;
			tbxAge.Font = new Font("Bahnschrift", 15F);
			tbxAge.ForeColor = Color.FromArgb(216, 85, 101);
			tbxAge.Hint = "";
			tbxAge.Location = new Point(13, 207);
			tbxAge.MaxLength = 32767;
			tbxAge.Multiline = false;
			tbxAge.Name = "tbxAge";
			tbxAge.PasswordChar = '\0';
			tbxAge.ScrollBars = ScrollBars.None;
			tbxAge.SelectedText = "";
			tbxAge.SelectionLength = 0;
			tbxAge.SelectionStart = 0;
			tbxAge.Size = new Size(218, 41);
			tbxAge.TabIndex = 79;
			tbxAge.TabStop = false;
			tbxAge.UseSystemPasswordChar = false;
			// 
			// lblAge
			// 
			lblAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblAge.AutoSize = true;
			lblAge.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblAge.ForeColor = Color.FromArgb(216, 85, 101);
			lblAge.Location = new Point(13, 180);
			lblAge.Name = "lblAge";
			lblAge.Size = new Size(40, 24);
			lblAge.TabIndex = 77;
			lblAge.Text = "Age";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblName.ForeColor = Color.FromArgb(216, 85, 101);
			lblName.Location = new Point(13, 105);
			lblName.Name = "lblName";
			lblName.Size = new Size(54, 24);
			lblName.TabIndex = 76;
			lblName.Text = "Name";
			// 
			// lblBloodExtraction
			// 
			lblBloodExtraction.AutoSize = true;
			lblBloodExtraction.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblBloodExtraction.ForeColor = Color.FromArgb(216, 85, 101);
			lblBloodExtraction.Location = new Point(96, 30);
			lblBloodExtraction.Name = "lblBloodExtraction";
			lblBloodExtraction.Padding = new Padding(5, 0, 0, 5);
			lblBloodExtraction.Size = new Size(277, 46);
			lblBloodExtraction.TabIndex = 74;
			lblBloodExtraction.Text = "Blood Extraction";
			lblBloodExtraction.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// cmbxDonor
			// 
			cmbxDonor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cmbxDonor.BackColor = Color.FromArgb(241, 241, 241);
			cmbxDonor.ColorA = Color.FromArgb(236, 124, 132);
			cmbxDonor.ColorB = Color.FromArgb(236, 124, 132);
			cmbxDonor.ColorC = Color.FromArgb(242, 241, 240);
			cmbxDonor.ColorD = Color.FromArgb(253, 252, 252);
			cmbxDonor.ColorE = Color.FromArgb(239, 237, 236);
			cmbxDonor.ColorF = Color.FromArgb(216, 85, 101);
			cmbxDonor.ColorG = Color.FromArgb(216, 85, 101);
			cmbxDonor.ColorH = Color.FromArgb(244, 180, 180);
			cmbxDonor.ColorI = Color.FromArgb(250, 249, 249);
			cmbxDonor.DrawMode = DrawMode.OwnerDrawFixed;
			cmbxDonor.DropDownHeight = 100;
			cmbxDonor.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbxDonor.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			cmbxDonor.ForeColor = Color.FromArgb(216, 85, 101);
			cmbxDonor.FormattingEnabled = true;
			cmbxDonor.HoverSelectionColor = Color.Empty;
			cmbxDonor.IntegralHeight = false;
			cmbxDonor.ItemHeight = 35;
			cmbxDonor.Items.AddRange(new object[] { "Select donor" });
			cmbxDonor.Location = new Point(13, 132);
			cmbxDonor.Name = "cmbxDonor";
			cmbxDonor.Size = new Size(442, 41);
			cmbxDonor.StartIndex = 0;
			cmbxDonor.TabIndex = 73;
			// 
			// tbxGender
			// 
			tbxGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbxGender.BackColor = Color.White;
			tbxGender.BaseColor = Color.FromArgb(252, 228, 228);
			tbxGender.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxGender.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxGender.Enabled = false;
			tbxGender.Font = new Font("Bahnschrift", 15F);
			tbxGender.ForeColor = Color.FromArgb(216, 85, 101);
			tbxGender.Hint = "";
			tbxGender.Location = new Point(237, 207);
			tbxGender.MaxLength = 32767;
			tbxGender.Multiline = false;
			tbxGender.Name = "tbxGender";
			tbxGender.PasswordChar = '\0';
			tbxGender.ScrollBars = ScrollBars.None;
			tbxGender.SelectedText = "";
			tbxGender.SelectionLength = 0;
			tbxGender.SelectionStart = 0;
			tbxGender.Size = new Size(218, 41);
			tbxGender.TabIndex = 81;
			tbxGender.TabStop = false;
			tbxGender.UseSystemPasswordChar = false;
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
			pDonate.ResumeLayout(false);
			pDonate.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tlpBloodExtraction;
		private Panel pExtraction;
		private Panel pBarCode;
		private PictureBox pbxBarCode;
		private AntdUI.Button btnBarCode;
		private Panel pDonate;
		private Label lblAddress;
		private Label lblCNumber;
		private ReaLTaiizor.Controls.HopeTextBox tbxBloodType;
		private Label lblBType;
		private ReaLTaiizor.Controls.HopeTextBox tbxCNumber;
		private Label lblGender;
		private ReaLTaiizor.Controls.HopeTextBox tbxAge;
		private Label lblAge;
		private Label lblName;
		private Label lblBloodExtraction;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxDonor;
		private ReaLTaiizor.Controls.HopeTextBox tbxGender;
		private ReaLTaiizor.Controls.HopeTextBox tbxAddress;
		private AntdUI.Button btnDonate;
	}
}
