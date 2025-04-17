namespace Hemotica
{
	partial class HospitalTransfusion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalTransfusion));
			tplTransfusion = new TableLayoutPanel();
			pBlood = new Panel();
			pCompatibility = new Panel();
			pbxCompatibility = new PictureBox();
			pPatient = new Panel();
			btnTransfusion = new AntdUI.Button();
			btnPhysician = new AntdUI.Button();
			btnCrossmatch = new AntdUI.Button();
			pTransfusion = new Panel();
			tlpPatient = new TableLayoutPanel();
			lblBloodTransfusion = new Label();
			pTranfusion = new Panel();
			lblUnit = new Label();
			tbxQuantity = new ReaLTaiizor.Controls.HopeTextBox();
			lblRequest = new Label();
			tbxBloodType = new ReaLTaiizor.Controls.HopeTextBox();
			lblPriority = new Label();
			lblBType = new Label();
			tbxBirthdate = new ReaLTaiizor.Controls.HopeTextBox();
			lblBirthdate = new Label();
			lblPatient = new Label();
			cmbxPatient = new ReaLTaiizor.Controls.DungeonComboBox();
			tbxPriority = new ReaLTaiizor.Controls.HopeTextBox();
			pTransfer = new Panel();
			lblPhysician = new Label();
			cmbxPhysician = new ReaLTaiizor.Controls.DungeonComboBox();
			lblResult = new Label();
			tplTransfusion.SuspendLayout();
			pBlood.SuspendLayout();
			pCompatibility.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxCompatibility).BeginInit();
			pPatient.SuspendLayout();
			pTransfusion.SuspendLayout();
			tlpPatient.SuspendLayout();
			pTranfusion.SuspendLayout();
			pTransfer.SuspendLayout();
			SuspendLayout();
			// 
			// tplTransfusion
			// 
			tplTransfusion.ColumnCount = 2;
			tplTransfusion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tplTransfusion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tplTransfusion.Controls.Add(pBlood, 1, 0);
			tplTransfusion.Controls.Add(pPatient, 0, 0);
			tplTransfusion.Dock = DockStyle.Fill;
			tplTransfusion.Location = new Point(10, 35);
			tplTransfusion.Name = "tplTransfusion";
			tplTransfusion.RowCount = 1;
			tplTransfusion.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tplTransfusion.Size = new Size(1000, 571);
			tplTransfusion.TabIndex = 0;
			// 
			// pBlood
			// 
			pBlood.BackColor = Color.FromArgb(216, 85, 101);
			pBlood.Controls.Add(pCompatibility);
			pBlood.Dock = DockStyle.Fill;
			pBlood.Location = new Point(503, 3);
			pBlood.Name = "pBlood";
			pBlood.Padding = new Padding(10);
			pBlood.Size = new Size(494, 565);
			pBlood.TabIndex = 1;
			// 
			// pCompatibility
			// 
			pCompatibility.BackColor = Color.FromArgb(255, 239, 242);
			pCompatibility.Controls.Add(pbxCompatibility);
			pCompatibility.Dock = DockStyle.Fill;
			pCompatibility.Location = new Point(10, 10);
			pCompatibility.Name = "pCompatibility";
			pCompatibility.Padding = new Padding(3);
			pCompatibility.Size = new Size(474, 545);
			pCompatibility.TabIndex = 0;
			// 
			// pbxCompatibility
			// 
			pbxCompatibility.Dock = DockStyle.Fill;
			pbxCompatibility.Image = (Image)resources.GetObject("pbxCompatibility.Image");
			pbxCompatibility.Location = new Point(3, 3);
			pbxCompatibility.Name = "pbxCompatibility";
			pbxCompatibility.Size = new Size(468, 539);
			pbxCompatibility.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxCompatibility.TabIndex = 0;
			pbxCompatibility.TabStop = false;
			// 
			// pPatient
			// 
			pPatient.BackColor = Color.FromArgb(216, 85, 101);
			pPatient.Controls.Add(btnTransfusion);
			pPatient.Controls.Add(btnPhysician);
			pPatient.Controls.Add(btnCrossmatch);
			pPatient.Controls.Add(pTransfusion);
			pPatient.Dock = DockStyle.Fill;
			pPatient.Location = new Point(3, 3);
			pPatient.Name = "pPatient";
			pPatient.Padding = new Padding(10);
			pPatient.Size = new Size(494, 565);
			pPatient.TabIndex = 0;
			// 
			// btnTransfusion
			// 
			btnTransfusion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnTransfusion.DefaultBack = Color.FromArgb(252, 228, 228);
			btnTransfusion.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold);
			btnTransfusion.ForeColor = Color.FromArgb(216, 85, 101);
			btnTransfusion.Location = new Point(13, 492);
			btnTransfusion.Name = "btnTransfusion";
			btnTransfusion.Size = new Size(468, 60);
			btnTransfusion.TabIndex = 26;
			btnTransfusion.Text = "Blood Transfer";
			btnTransfusion.Visible = false;
			btnTransfusion.Click += btnTransfusion_Click;
			// 
			// btnPhysician
			// 
			btnPhysician.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnPhysician.DefaultBack = Color.FromArgb(252, 228, 228);
			btnPhysician.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold);
			btnPhysician.ForeColor = Color.FromArgb(216, 85, 101);
			btnPhysician.Location = new Point(13, 492);
			btnPhysician.Name = "btnPhysician";
			btnPhysician.Size = new Size(468, 60);
			btnPhysician.TabIndex = 25;
			btnPhysician.Text = "Designate Operating Physician";
			btnPhysician.Visible = false;
			btnPhysician.Click += btnPhysician_Click;
			// 
			// btnCrossmatch
			// 
			btnCrossmatch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnCrossmatch.DefaultBack = Color.FromArgb(252, 228, 228);
			btnCrossmatch.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold);
			btnCrossmatch.ForeColor = Color.FromArgb(216, 85, 101);
			btnCrossmatch.Location = new Point(13, 492);
			btnCrossmatch.Name = "btnCrossmatch";
			btnCrossmatch.Size = new Size(468, 60);
			btnCrossmatch.TabIndex = 24;
			btnCrossmatch.Text = "Crossmatch";
			btnCrossmatch.Click += btnCrossmatch_Click;
			// 
			// pTransfusion
			// 
			pTransfusion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pTransfusion.BackColor = Color.FromArgb(252, 228, 228);
			pTransfusion.Controls.Add(tlpPatient);
			pTransfusion.Location = new Point(13, 13);
			pTransfusion.Name = "pTransfusion";
			pTransfusion.Padding = new Padding(5);
			pTransfusion.Size = new Size(468, 468);
			pTransfusion.TabIndex = 0;
			// 
			// tlpPatient
			// 
			tlpPatient.ColumnCount = 2;
			tlpPatient.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPatient.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPatient.Controls.Add(lblBloodTransfusion, 0, 0);
			tlpPatient.Controls.Add(pTranfusion, 0, 2);
			tlpPatient.Controls.Add(pTransfer, 0, 8);
			tlpPatient.Dock = DockStyle.Fill;
			tlpPatient.Location = new Point(5, 5);
			tlpPatient.Name = "tlpPatient";
			tlpPatient.RowCount = 10;
			tlpPatient.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPatient.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPatient.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPatient.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPatient.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPatient.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPatient.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPatient.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPatient.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPatient.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPatient.Size = new Size(458, 458);
			tlpPatient.TabIndex = 0;
			// 
			// lblBloodTransfusion
			// 
			lblBloodTransfusion.AutoSize = true;
			tlpPatient.SetColumnSpan(lblBloodTransfusion, 2);
			lblBloodTransfusion.Dock = DockStyle.Fill;
			lblBloodTransfusion.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblBloodTransfusion.ForeColor = Color.FromArgb(216, 85, 101);
			lblBloodTransfusion.Location = new Point(3, 0);
			lblBloodTransfusion.Name = "lblBloodTransfusion";
			lblBloodTransfusion.Padding = new Padding(5, 0, 0, 5);
			tlpPatient.SetRowSpan(lblBloodTransfusion, 2);
			lblBloodTransfusion.Size = new Size(452, 90);
			lblBloodTransfusion.TabIndex = 76;
			lblBloodTransfusion.Text = "Blood Transfusion";
			lblBloodTransfusion.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pTranfusion
			// 
			tlpPatient.SetColumnSpan(pTranfusion, 2);
			pTranfusion.Controls.Add(lblUnit);
			pTranfusion.Controls.Add(tbxQuantity);
			pTranfusion.Controls.Add(lblRequest);
			pTranfusion.Controls.Add(tbxBloodType);
			pTranfusion.Controls.Add(lblPriority);
			pTranfusion.Controls.Add(lblBType);
			pTranfusion.Controls.Add(tbxBirthdate);
			pTranfusion.Controls.Add(lblBirthdate);
			pTranfusion.Controls.Add(lblPatient);
			pTranfusion.Controls.Add(cmbxPatient);
			pTranfusion.Controls.Add(tbxPriority);
			pTranfusion.Dock = DockStyle.Fill;
			pTranfusion.Location = new Point(3, 93);
			pTranfusion.Name = "pTranfusion";
			tlpPatient.SetRowSpan(pTranfusion, 6);
			pTranfusion.Size = new Size(452, 264);
			pTranfusion.TabIndex = 77;
			// 
			// lblUnit
			// 
			lblUnit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lblUnit.AutoSize = true;
			lblUnit.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblUnit.ForeColor = Color.FromArgb(216, 85, 101);
			lblUnit.Location = new Point(342, 225);
			lblUnit.Name = "lblUnit";
			lblUnit.Size = new Size(107, 24);
			lblUnit.TabIndex = 105;
			lblUnit.Text = "blood bag(s)";
			// 
			// tbxQuantity
			// 
			tbxQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbxQuantity.BackColor = Color.White;
			tbxQuantity.BaseColor = Color.FromArgb(252, 228, 228);
			tbxQuantity.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxQuantity.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxQuantity.Enabled = false;
			tbxQuantity.Font = new Font("Bahnschrift", 15F);
			tbxQuantity.ForeColor = Color.FromArgb(216, 85, 101);
			tbxQuantity.Hint = "";
			tbxQuantity.Location = new Point(229, 216);
			tbxQuantity.MaxLength = 32767;
			tbxQuantity.Multiline = false;
			tbxQuantity.Name = "tbxQuantity";
			tbxQuantity.PasswordChar = '\0';
			tbxQuantity.ScrollBars = ScrollBars.None;
			tbxQuantity.SelectedText = "";
			tbxQuantity.SelectionLength = 0;
			tbxQuantity.SelectionStart = 0;
			tbxQuantity.Size = new Size(109, 41);
			tbxQuantity.TabIndex = 104;
			tbxQuantity.TabStop = false;
			tbxQuantity.UseSystemPasswordChar = false;
			// 
			// lblRequest
			// 
			lblRequest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblRequest.AutoSize = true;
			lblRequest.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblRequest.ForeColor = Color.FromArgb(216, 85, 101);
			lblRequest.Location = new Point(229, 189);
			lblRequest.Name = "lblRequest";
			lblRequest.Size = new Size(74, 24);
			lblRequest.TabIndex = 103;
			lblRequest.Text = "Request";
			// 
			// tbxBloodType
			// 
			tbxBloodType.BackColor = Color.White;
			tbxBloodType.BaseColor = Color.FromArgb(252, 228, 228);
			tbxBloodType.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxBloodType.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxBloodType.Enabled = false;
			tbxBloodType.Font = new Font("Bahnschrift", 15F);
			tbxBloodType.ForeColor = Color.FromArgb(216, 85, 101);
			tbxBloodType.Hint = "";
			tbxBloodType.Location = new Point(5, 216);
			tbxBloodType.MaxLength = 32767;
			tbxBloodType.Multiline = false;
			tbxBloodType.Name = "tbxBloodType";
			tbxBloodType.PasswordChar = '\0';
			tbxBloodType.ScrollBars = ScrollBars.None;
			tbxBloodType.SelectedText = "";
			tbxBloodType.SelectionLength = 0;
			tbxBloodType.SelectionStart = 0;
			tbxBloodType.Size = new Size(218, 41);
			tbxBloodType.TabIndex = 100;
			tbxBloodType.TabStop = false;
			tbxBloodType.UseSystemPasswordChar = false;
			// 
			// lblPriority
			// 
			lblPriority.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblPriority.AutoSize = true;
			lblPriority.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblPriority.ForeColor = Color.FromArgb(216, 85, 101);
			lblPriority.Location = new Point(229, 104);
			lblPriority.Name = "lblPriority";
			lblPriority.Size = new Size(65, 24);
			lblPriority.TabIndex = 102;
			lblPriority.Text = "Priority";
			// 
			// lblBType
			// 
			lblBType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblBType.AutoSize = true;
			lblBType.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblBType.ForeColor = Color.FromArgb(216, 85, 101);
			lblBType.Location = new Point(5, 189);
			lblBType.Name = "lblBType";
			lblBType.Size = new Size(99, 24);
			lblBType.TabIndex = 99;
			lblBType.Text = "Blood Type";
			// 
			// tbxBirthdate
			// 
			tbxBirthdate.BackColor = Color.White;
			tbxBirthdate.BaseColor = Color.FromArgb(252, 228, 228);
			tbxBirthdate.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxBirthdate.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxBirthdate.Enabled = false;
			tbxBirthdate.Font = new Font("Bahnschrift", 15F);
			tbxBirthdate.ForeColor = Color.FromArgb(216, 85, 101);
			tbxBirthdate.Hint = "";
			tbxBirthdate.Location = new Point(5, 131);
			tbxBirthdate.MaxLength = 32767;
			tbxBirthdate.Multiline = false;
			tbxBirthdate.Name = "tbxBirthdate";
			tbxBirthdate.PasswordChar = '\0';
			tbxBirthdate.ScrollBars = ScrollBars.None;
			tbxBirthdate.SelectedText = "";
			tbxBirthdate.SelectionLength = 0;
			tbxBirthdate.SelectionStart = 0;
			tbxBirthdate.Size = new Size(218, 41);
			tbxBirthdate.TabIndex = 96;
			tbxBirthdate.TabStop = false;
			tbxBirthdate.UseSystemPasswordChar = false;
			// 
			// lblBirthdate
			// 
			lblBirthdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblBirthdate.AutoSize = true;
			lblBirthdate.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblBirthdate.ForeColor = Color.FromArgb(216, 85, 101);
			lblBirthdate.Location = new Point(5, 104);
			lblBirthdate.Name = "lblBirthdate";
			lblBirthdate.Size = new Size(80, 24);
			lblBirthdate.TabIndex = 95;
			lblBirthdate.Text = "Birthdate";
			// 
			// lblPatient
			// 
			lblPatient.AutoSize = true;
			lblPatient.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblPatient.ForeColor = Color.FromArgb(216, 85, 101);
			lblPatient.Location = new Point(5, 19);
			lblPatient.Name = "lblPatient";
			lblPatient.Size = new Size(112, 24);
			lblPatient.TabIndex = 92;
			lblPatient.Text = "Patient Name";
			// 
			// cmbxPatient
			// 
			cmbxPatient.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cmbxPatient.BackColor = Color.FromArgb(241, 241, 241);
			cmbxPatient.ColorA = Color.FromArgb(236, 124, 132);
			cmbxPatient.ColorB = Color.FromArgb(236, 124, 132);
			cmbxPatient.ColorC = Color.FromArgb(242, 241, 240);
			cmbxPatient.ColorD = Color.FromArgb(253, 252, 252);
			cmbxPatient.ColorE = Color.FromArgb(239, 237, 236);
			cmbxPatient.ColorF = Color.FromArgb(216, 85, 101);
			cmbxPatient.ColorG = Color.FromArgb(216, 85, 101);
			cmbxPatient.ColorH = Color.FromArgb(244, 180, 180);
			cmbxPatient.ColorI = Color.FromArgb(250, 249, 249);
			cmbxPatient.DrawMode = DrawMode.OwnerDrawFixed;
			cmbxPatient.DropDownHeight = 100;
			cmbxPatient.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbxPatient.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			cmbxPatient.ForeColor = Color.FromArgb(216, 85, 101);
			cmbxPatient.FormattingEnabled = true;
			cmbxPatient.HoverSelectionColor = Color.Empty;
			cmbxPatient.IntegralHeight = false;
			cmbxPatient.ItemHeight = 35;
			cmbxPatient.Items.AddRange(new object[] { "Select patient" });
			cmbxPatient.Location = new Point(5, 46);
			cmbxPatient.Name = "cmbxPatient";
			cmbxPatient.Size = new Size(442, 41);
			cmbxPatient.StartIndex = 0;
			cmbxPatient.TabIndex = 91;
			cmbxPatient.SelectedIndexChanged += cmbxPatient_SelectedIndexChanged;
			// 
			// tbxPriority
			// 
			tbxPriority.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbxPriority.BackColor = Color.White;
			tbxPriority.BaseColor = Color.FromArgb(252, 228, 228);
			tbxPriority.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxPriority.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxPriority.Enabled = false;
			tbxPriority.Font = new Font("Bahnschrift", 15F);
			tbxPriority.ForeColor = Color.FromArgb(216, 85, 101);
			tbxPriority.Hint = "";
			tbxPriority.Location = new Point(229, 131);
			tbxPriority.MaxLength = 32767;
			tbxPriority.Multiline = false;
			tbxPriority.Name = "tbxPriority";
			tbxPriority.PasswordChar = '\0';
			tbxPriority.ScrollBars = ScrollBars.None;
			tbxPriority.SelectedText = "";
			tbxPriority.SelectionLength = 0;
			tbxPriority.SelectionStart = 0;
			tbxPriority.Size = new Size(218, 41);
			tbxPriority.TabIndex = 101;
			tbxPriority.TabStop = false;
			tbxPriority.UseSystemPasswordChar = false;
			// 
			// pTransfer
			// 
			tlpPatient.SetColumnSpan(pTransfer, 2);
			pTransfer.Controls.Add(lblPhysician);
			pTransfer.Controls.Add(cmbxPhysician);
			pTransfer.Controls.Add(lblResult);
			pTransfer.Dock = DockStyle.Fill;
			pTransfer.Location = new Point(3, 363);
			pTransfer.Name = "pTransfer";
			tlpPatient.SetRowSpan(pTransfer, 2);
			pTransfer.Size = new Size(452, 92);
			pTransfer.TabIndex = 78;
			// 
			// lblPhysician
			// 
			lblPhysician.AutoSize = true;
			lblPhysician.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblPhysician.ForeColor = Color.FromArgb(216, 85, 101);
			lblPhysician.Location = new Point(5, 4);
			lblPhysician.Name = "lblPhysician";
			lblPhysician.Size = new Size(134, 24);
			lblPhysician.TabIndex = 108;
			lblPhysician.Text = "Physician Name";
			lblPhysician.Visible = false;
			// 
			// cmbxPhysician
			// 
			cmbxPhysician.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cmbxPhysician.BackColor = Color.FromArgb(241, 241, 241);
			cmbxPhysician.ColorA = Color.FromArgb(236, 124, 132);
			cmbxPhysician.ColorB = Color.FromArgb(236, 124, 132);
			cmbxPhysician.ColorC = Color.FromArgb(242, 241, 240);
			cmbxPhysician.ColorD = Color.FromArgb(253, 252, 252);
			cmbxPhysician.ColorE = Color.FromArgb(239, 237, 236);
			cmbxPhysician.ColorF = Color.FromArgb(216, 85, 101);
			cmbxPhysician.ColorG = Color.FromArgb(216, 85, 101);
			cmbxPhysician.ColorH = Color.FromArgb(244, 180, 180);
			cmbxPhysician.ColorI = Color.FromArgb(250, 249, 249);
			cmbxPhysician.DrawMode = DrawMode.OwnerDrawFixed;
			cmbxPhysician.DropDownHeight = 100;
			cmbxPhysician.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbxPhysician.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			cmbxPhysician.ForeColor = Color.FromArgb(216, 85, 101);
			cmbxPhysician.FormattingEnabled = true;
			cmbxPhysician.HoverSelectionColor = Color.Empty;
			cmbxPhysician.IntegralHeight = false;
			cmbxPhysician.ItemHeight = 35;
			cmbxPhysician.Items.AddRange(new object[] { "Select physician" });
			cmbxPhysician.Location = new Point(5, 31);
			cmbxPhysician.Name = "cmbxPhysician";
			cmbxPhysician.Size = new Size(442, 41);
			cmbxPhysician.StartIndex = 0;
			cmbxPhysician.TabIndex = 107;
			cmbxPhysician.Visible = false;
			// 
			// lblResult
			// 
			lblResult.AutoSize = true;
			lblResult.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblResult.ForeColor = Color.FromArgb(216, 85, 101);
			lblResult.Location = new Point(185, 34);
			lblResult.Name = "lblResult";
			lblResult.Size = new Size(83, 24);
			lblResult.TabIndex = 106;
			lblResult.Text = "< result >";
			lblResult.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// HospitalTransfusion
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(tplTransfusion);
			Name = "HospitalTransfusion";
			Padding = new Padding(10, 35, 10, 35);
			Size = new Size(1020, 641);
			Load += HospitalTransfusion_Load;
			Resize += HospitalTransfusion_Resize;
			tplTransfusion.ResumeLayout(false);
			pBlood.ResumeLayout(false);
			pCompatibility.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxCompatibility).EndInit();
			pPatient.ResumeLayout(false);
			pTransfusion.ResumeLayout(false);
			tlpPatient.ResumeLayout(false);
			tlpPatient.PerformLayout();
			pTranfusion.ResumeLayout(false);
			pTranfusion.PerformLayout();
			pTransfer.ResumeLayout(false);
			pTransfer.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private ReaLTaiizor.Controls.BigTextBox tbxPhysician;
		private TableLayoutPanel tplTransfusion;
		private Panel pPatient;
		private Panel pTransfusion;
		private Panel pBlood;
		private Panel pCompatibility;
		private PictureBox pbxCompatibility;
		private TableLayoutPanel tlpPatient;
		private Label lblBloodTransfusion;
		private Panel pTranfusion;
		private Label lblPatient;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxPatient;
		private ReaLTaiizor.Controls.HopeTextBox tbxBirthdate;
		private Label lblBirthdate;
		private ReaLTaiizor.Controls.HopeTextBox tbxPriority;
		private ReaLTaiizor.Controls.HopeTextBox tbxBloodType;
		private Label lblPriority;
		private Label lblBType;
		private Label lblRequest;
		private ReaLTaiizor.Controls.HopeTextBox tbxQuantity;
		private Label lblUnit;
		private Panel pTransfer;
		private AntdUI.Button btnCrossmatch;
		private Label lblResult;
		private AntdUI.Button btnPhysician;
		private AntdUI.Button btnTransfusion;
		private Label lblPhysician;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxPhysician;
	}
}
