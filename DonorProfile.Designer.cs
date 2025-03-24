namespace Hemotica
{
	partial class DonorProfile
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorProfile));
			pProfile = new Panel();
			pbxProfile = new PictureBox();
			dName = new Label();
			tbxPatientID = new ReaLTaiizor.Controls.BigTextBox();
			tbxEmail = new ReaLTaiizor.Controls.BigTextBox();
			lblEmail = new Label();
			tbxGender = new ReaLTaiizor.Controls.BigTextBox();
			lblGender = new Label();
			tbxAge = new ReaLTaiizor.Controls.BigTextBox();
			lblAge = new Label();
			tbxHomeAddress = new ReaLTaiizor.Controls.BigTextBox();
			lblHomeAddress = new Label();
			tbxBType = new ReaLTaiizor.Controls.BigTextBox();
			lblBType = new Label();
			tbxNumber = new ReaLTaiizor.Controls.BigTextBox();
			lblNumber = new Label();
			tbxPassword = new ReaLTaiizor.Controls.BigTextBox();
			lblPassword = new Label();
			btnSave = new AntdUI.Button();
			btnProfile = new AntdUI.Button();
			btnEdit = new AntdUI.Button();
			pProfile.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxProfile).BeginInit();
			SuspendLayout();
			// 
			// pProfile
			// 
			pProfile.BackColor = Color.FromArgb(216, 85, 101);
			pProfile.Controls.Add(pbxProfile);
			pProfile.Location = new Point(658, 70);
			pProfile.Name = "pProfile";
			pProfile.Padding = new Padding(5);
			pProfile.Size = new Size(325, 325);
			pProfile.TabIndex = 0;
			// 
			// pbxProfile
			// 
			pbxProfile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pbxProfile.Image = (Image)resources.GetObject("pbxProfile.Image");
			pbxProfile.Location = new Point(8, 8);
			pbxProfile.Name = "pbxProfile";
			pbxProfile.Size = new Size(309, 309);
			pbxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxProfile.TabIndex = 0;
			pbxProfile.TabStop = false;
			// 
			// dName
			// 
			dName.AutoSize = true;
			dName.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			dName.ForeColor = Color.FromArgb(216, 85, 101);
			dName.Location = new Point(164, 181);
			dName.Name = "dName";
			dName.Padding = new Padding(5, 0, 0, 5);
			dName.Size = new Size(90, 38);
			dName.TabIndex = 11;
			dName.Text = "Name";
			// 
			// tbxPatientID
			// 
			tbxPatientID.BackColor = Color.Transparent;
			tbxPatientID.Font = new Font("Tahoma", 11F);
			tbxPatientID.ForeColor = Color.DimGray;
			tbxPatientID.Image = null;
			tbxPatientID.Location = new Point(260, 178);
			tbxPatientID.MaxLength = 32767;
			tbxPatientID.Multiline = false;
			tbxPatientID.Name = "tbxPatientID";
			tbxPatientID.ReadOnly = false;
			tbxPatientID.Size = new Size(349, 41);
			tbxPatientID.TabIndex = 13;
			tbxPatientID.TextAlignment = HorizontalAlignment.Left;
			tbxPatientID.UseSystemPasswordChar = false;
			// 
			// tbxEmail
			// 
			tbxEmail.BackColor = Color.Transparent;
			tbxEmail.Font = new Font("Tahoma", 11F);
			tbxEmail.ForeColor = Color.DimGray;
			tbxEmail.Image = null;
			tbxEmail.Location = new Point(260, 60);
			tbxEmail.MaxLength = 32767;
			tbxEmail.Multiline = false;
			tbxEmail.Name = "tbxEmail";
			tbxEmail.ReadOnly = false;
			tbxEmail.Size = new Size(349, 41);
			tbxEmail.TabIndex = 15;
			tbxEmail.TextAlignment = HorizontalAlignment.Left;
			tbxEmail.UseSystemPasswordChar = false;
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblEmail.ForeColor = Color.FromArgb(216, 85, 101);
			lblEmail.Location = new Point(58, 63);
			lblEmail.Name = "lblEmail";
			lblEmail.Padding = new Padding(5, 0, 0, 5);
			lblEmail.Size = new Size(196, 38);
			lblEmail.TabIndex = 14;
			lblEmail.Text = "Email Address";
			// 
			// tbxGender
			// 
			tbxGender.BackColor = Color.Transparent;
			tbxGender.Font = new Font("Tahoma", 11F);
			tbxGender.ForeColor = Color.DimGray;
			tbxGender.Image = null;
			tbxGender.Location = new Point(260, 225);
			tbxGender.MaxLength = 32767;
			tbxGender.Multiline = false;
			tbxGender.Name = "tbxGender";
			tbxGender.ReadOnly = false;
			tbxGender.Size = new Size(349, 41);
			tbxGender.TabIndex = 17;
			tbxGender.TextAlignment = HorizontalAlignment.Left;
			tbxGender.UseSystemPasswordChar = false;
			// 
			// lblGender
			// 
			lblGender.AutoSize = true;
			lblGender.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblGender.ForeColor = Color.FromArgb(216, 85, 101);
			lblGender.Location = new Point(147, 228);
			lblGender.Name = "lblGender";
			lblGender.Padding = new Padding(5, 0, 0, 5);
			lblGender.Size = new Size(107, 38);
			lblGender.TabIndex = 16;
			lblGender.Text = "Gender";
			// 
			// tbxAge
			// 
			tbxAge.BackColor = Color.Transparent;
			tbxAge.Font = new Font("Tahoma", 11F);
			tbxAge.ForeColor = Color.DimGray;
			tbxAge.Image = null;
			tbxAge.Location = new Point(260, 272);
			tbxAge.MaxLength = 32767;
			tbxAge.Multiline = false;
			tbxAge.Name = "tbxAge";
			tbxAge.ReadOnly = false;
			tbxAge.Size = new Size(349, 41);
			tbxAge.TabIndex = 19;
			tbxAge.TextAlignment = HorizontalAlignment.Left;
			tbxAge.UseSystemPasswordChar = false;
			// 
			// lblAge
			// 
			lblAge.AutoSize = true;
			lblAge.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblAge.ForeColor = Color.FromArgb(216, 85, 101);
			lblAge.Location = new Point(188, 275);
			lblAge.Name = "lblAge";
			lblAge.Padding = new Padding(5, 0, 0, 5);
			lblAge.Size = new Size(66, 38);
			lblAge.TabIndex = 18;
			lblAge.Text = "Age";
			// 
			// tbxHomeAddress
			// 
			tbxHomeAddress.BackColor = Color.Transparent;
			tbxHomeAddress.Font = new Font("Tahoma", 11F);
			tbxHomeAddress.ForeColor = Color.DimGray;
			tbxHomeAddress.Image = null;
			tbxHomeAddress.Location = new Point(260, 343);
			tbxHomeAddress.MaxLength = 32767;
			tbxHomeAddress.Multiline = false;
			tbxHomeAddress.Name = "tbxHomeAddress";
			tbxHomeAddress.ReadOnly = false;
			tbxHomeAddress.Size = new Size(349, 41);
			tbxHomeAddress.TabIndex = 21;
			tbxHomeAddress.TextAlignment = HorizontalAlignment.Left;
			tbxHomeAddress.UseSystemPasswordChar = false;
			// 
			// lblHomeAddress
			// 
			lblHomeAddress.AutoSize = true;
			lblHomeAddress.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblHomeAddress.ForeColor = Color.FromArgb(216, 85, 101);
			lblHomeAddress.Location = new Point(56, 346);
			lblHomeAddress.Name = "lblHomeAddress";
			lblHomeAddress.Padding = new Padding(5, 0, 0, 5);
			lblHomeAddress.Size = new Size(198, 38);
			lblHomeAddress.TabIndex = 20;
			lblHomeAddress.Text = "Home Address";
			// 
			// tbxBType
			// 
			tbxBType.BackColor = Color.Transparent;
			tbxBType.Font = new Font("Tahoma", 11F);
			tbxBType.ForeColor = Color.DimGray;
			tbxBType.Image = null;
			tbxBType.Location = new Point(260, 437);
			tbxBType.MaxLength = 32767;
			tbxBType.Multiline = false;
			tbxBType.Name = "tbxBType";
			tbxBType.ReadOnly = false;
			tbxBType.Size = new Size(349, 41);
			tbxBType.TabIndex = 25;
			tbxBType.TextAlignment = HorizontalAlignment.Left;
			tbxBType.UseSystemPasswordChar = false;
			// 
			// lblBType
			// 
			lblBType.AutoSize = true;
			lblBType.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblBType.ForeColor = Color.FromArgb(216, 85, 101);
			lblBType.Location = new Point(103, 440);
			lblBType.Name = "lblBType";
			lblBType.Padding = new Padding(5, 0, 0, 5);
			lblBType.Size = new Size(151, 38);
			lblBType.TabIndex = 24;
			lblBType.Text = "Blood Type";
			// 
			// tbxNumber
			// 
			tbxNumber.BackColor = Color.Transparent;
			tbxNumber.Font = new Font("Tahoma", 11F);
			tbxNumber.ForeColor = Color.DimGray;
			tbxNumber.Image = null;
			tbxNumber.Location = new Point(260, 390);
			tbxNumber.MaxLength = 32767;
			tbxNumber.Multiline = false;
			tbxNumber.Name = "tbxNumber";
			tbxNumber.ReadOnly = false;
			tbxNumber.Size = new Size(349, 41);
			tbxNumber.TabIndex = 23;
			tbxNumber.TextAlignment = HorizontalAlignment.Left;
			tbxNumber.UseSystemPasswordChar = false;
			// 
			// lblNumber
			// 
			lblNumber.AutoSize = true;
			lblNumber.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblNumber.ForeColor = Color.FromArgb(216, 85, 101);
			lblNumber.Location = new Point(37, 393);
			lblNumber.Name = "lblNumber";
			lblNumber.Padding = new Padding(5, 0, 0, 5);
			lblNumber.Size = new Size(217, 38);
			lblNumber.TabIndex = 22;
			lblNumber.Text = "Contact Number";
			// 
			// tbxPassword
			// 
			tbxPassword.BackColor = Color.Transparent;
			tbxPassword.Font = new Font("Tahoma", 11F);
			tbxPassword.ForeColor = Color.DimGray;
			tbxPassword.Image = null;
			tbxPassword.Location = new Point(260, 107);
			tbxPassword.MaxLength = 32767;
			tbxPassword.Multiline = false;
			tbxPassword.Name = "tbxPassword";
			tbxPassword.ReadOnly = false;
			tbxPassword.Size = new Size(349, 41);
			tbxPassword.TabIndex = 27;
			tbxPassword.TextAlignment = HorizontalAlignment.Left;
			tbxPassword.UseSystemPasswordChar = false;
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblPassword.ForeColor = Color.FromArgb(216, 85, 101);
			lblPassword.Location = new Point(113, 110);
			lblPassword.Name = "lblPassword";
			lblPassword.Padding = new Padding(5, 0, 0, 5);
			lblPassword.Size = new Size(141, 38);
			lblPassword.TabIndex = 26;
			lblPassword.Text = "Password";
			// 
			// btnSave
			// 
			btnSave.DefaultBack = Color.FromArgb(236, 124, 132);
			btnSave.Font = new Font("Bahnschrift", 14F);
			btnSave.ForeColor = Color.FromArgb(252, 228, 228);
			btnSave.Location = new Point(326, 529);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(187, 52);
			btnSave.TabIndex = 28;
			btnSave.Text = "Save Changes";
			// 
			// btnProfile
			// 
			btnProfile.DefaultBack = Color.FromArgb(236, 124, 132);
			btnProfile.Font = new Font("Bahnschrift", 14F);
			btnProfile.ForeColor = Color.FromArgb(252, 228, 228);
			btnProfile.Location = new Point(727, 422);
			btnProfile.Name = "btnProfile";
			btnProfile.Size = new Size(187, 52);
			btnProfile.TabIndex = 29;
			btnProfile.Text = "Change Photo";
			// 
			// btnEdit
			// 
			btnEdit.DefaultBack = Color.FromArgb(236, 124, 132);
			btnEdit.Font = new Font("Bahnschrift", 14F);
			btnEdit.ForeColor = Color.FromArgb(252, 228, 228);
			btnEdit.Location = new Point(133, 529);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(187, 52);
			btnEdit.TabIndex = 30;
			btnEdit.Text = "Edit Details";
			// 
			// DonorProfile
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(btnEdit);
			Controls.Add(btnProfile);
			Controls.Add(btnSave);
			Controls.Add(tbxPassword);
			Controls.Add(lblPassword);
			Controls.Add(tbxBType);
			Controls.Add(lblBType);
			Controls.Add(tbxNumber);
			Controls.Add(lblNumber);
			Controls.Add(tbxHomeAddress);
			Controls.Add(lblHomeAddress);
			Controls.Add(tbxAge);
			Controls.Add(lblAge);
			Controls.Add(tbxGender);
			Controls.Add(lblGender);
			Controls.Add(tbxEmail);
			Controls.Add(lblEmail);
			Controls.Add(tbxPatientID);
			Controls.Add(dName);
			Controls.Add(pProfile);
			Name = "DonorProfile";
			Size = new Size(1020, 641);
			Load += DonorP_Load;
			Resize += DonorProfile_Resize;
			pProfile.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxProfile).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel pProfile;
		private Label dName;
		private ReaLTaiizor.Controls.BigTextBox tbxPatientID;
		private ReaLTaiizor.Controls.BigTextBox tbxEmail;
		private Label lblEmail;
		private ReaLTaiizor.Controls.BigTextBox tbxGender;
		private Label lblGender;
		private ReaLTaiizor.Controls.BigTextBox tbxAge;
		private Label lblAge;
		private ReaLTaiizor.Controls.BigTextBox tbxHomeAddress;
		private Label lblHomeAddress;
		private ReaLTaiizor.Controls.BigTextBox tbxBType;
		private Label lblBType;
		private ReaLTaiizor.Controls.BigTextBox tbxNumber;
		private Label lblNumber;
		private ReaLTaiizor.Controls.BigTextBox tbxPassword;
		private Label lblPassword;
		private AntdUI.Button btnSave;
		private AntdUI.Button btnProfile;
		private AntdUI.Button btnEdit;
		private PictureBox pbxProfile;
	}
}
