namespace Hemotica
{
	partial class DonorP
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorP));
			pProfile = new Panel();
			pbxPhoto = new PictureBox();
			dName = new Label();
			tbxPatientID = new ReaLTaiizor.Controls.BigTextBox();
			tbxEmail = new ReaLTaiizor.Controls.BigTextBox();
			lblEmail = new Label();
			tbxGender = new ReaLTaiizor.Controls.BigTextBox();
			lblGender = new Label();
			tbxAge = new ReaLTaiizor.Controls.BigTextBox();
			lblAge = new Label();
			tbxHAddress = new ReaLTaiizor.Controls.BigTextBox();
			lblHomeAddress = new Label();
			tbxBType = new ReaLTaiizor.Controls.BigTextBox();
			lblBType = new Label();
			tbxNumber = new ReaLTaiizor.Controls.BigTextBox();
			lblNumber = new Label();
			tbxPassword = new ReaLTaiizor.Controls.BigTextBox();
			lblPassword = new Label();
			btnSave = new AntdUI.Button();
			btnPhoto = new AntdUI.Button();
			btnEdit = new AntdUI.Button();
			pProfile.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxPhoto).BeginInit();
			SuspendLayout();
			// 
			// pProfile
			// 
			pProfile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			pProfile.BackColor = Color.FromArgb(216, 85, 101);
			pProfile.Controls.Add(pbxPhoto);
			pProfile.Location = new Point(644, 58);
			pProfile.Name = "pProfile";
			pProfile.Padding = new Padding(5);
			pProfile.Size = new Size(325, 325);
			pProfile.TabIndex = 0;
			// 
			// pbxPhoto
			// 
			pbxPhoto.Image = (Image)resources.GetObject("pbxPhoto.Image");
			pbxPhoto.Location = new Point(8, 8);
			pbxPhoto.Name = "pbxPhoto";
			pbxPhoto.Size = new Size(309, 309);
			pbxPhoto.TabIndex = 0;
			pbxPhoto.TabStop = false;
			// 
			// dName
			// 
			dName.AutoSize = true;
			dName.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			dName.ForeColor = Color.FromArgb(216, 85, 101);
			dName.Location = new Point(150, 173);
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
			tbxPatientID.Location = new Point(246, 170);
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
			tbxEmail.Location = new Point(246, 55);
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
			lblEmail.Location = new Point(44, 58);
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
			tbxGender.Location = new Point(246, 217);
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
			lblGender.Location = new Point(133, 220);
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
			tbxAge.Location = new Point(246, 264);
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
			lblAge.Location = new Point(174, 267);
			lblAge.Name = "lblAge";
			lblAge.Padding = new Padding(5, 0, 0, 5);
			lblAge.Size = new Size(66, 38);
			lblAge.TabIndex = 18;
			lblAge.Text = "Age";
			// 
			// tbxHAddress
			// 
			tbxHAddress.BackColor = Color.Transparent;
			tbxHAddress.Font = new Font("Tahoma", 11F);
			tbxHAddress.ForeColor = Color.DimGray;
			tbxHAddress.Image = null;
			tbxHAddress.Location = new Point(246, 331);
			tbxHAddress.MaxLength = 32767;
			tbxHAddress.Multiline = false;
			tbxHAddress.Name = "tbxHAddress";
			tbxHAddress.ReadOnly = false;
			tbxHAddress.Size = new Size(349, 41);
			tbxHAddress.TabIndex = 21;
			tbxHAddress.TextAlignment = HorizontalAlignment.Left;
			tbxHAddress.UseSystemPasswordChar = false;
			// 
			// lblHomeAddress
			// 
			lblHomeAddress.AutoSize = true;
			lblHomeAddress.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblHomeAddress.ForeColor = Color.FromArgb(216, 85, 101);
			lblHomeAddress.Location = new Point(42, 334);
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
			tbxBType.Location = new Point(246, 425);
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
			lblBType.Location = new Point(89, 428);
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
			tbxNumber.Location = new Point(246, 378);
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
			lblNumber.Location = new Point(23, 381);
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
			tbxPassword.Location = new Point(246, 102);
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
			lblPassword.Location = new Point(99, 105);
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
			btnSave.Location = new Point(326, 506);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(187, 52);
			btnSave.TabIndex = 28;
			btnSave.Text = "Save Changes";
			// 
			// btnPhoto
			// 
			btnPhoto.DefaultBack = Color.FromArgb(236, 124, 132);
			btnPhoto.Font = new Font("Bahnschrift", 14F);
			btnPhoto.ForeColor = Color.FromArgb(252, 228, 228);
			btnPhoto.Location = new Point(715, 414);
			btnPhoto.Name = "btnPhoto";
			btnPhoto.Size = new Size(187, 52);
			btnPhoto.TabIndex = 29;
			btnPhoto.Text = "Change Photo";
			// 
			// btnEdit
			// 
			btnEdit.DefaultBack = Color.FromArgb(236, 124, 132);
			btnEdit.Font = new Font("Bahnschrift", 14F);
			btnEdit.ForeColor = Color.FromArgb(252, 228, 228);
			btnEdit.Location = new Point(133, 506);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(187, 52);
			btnEdit.TabIndex = 30;
			btnEdit.Text = "Edit Details";
			// 
			// DonorP
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(btnEdit);
			Controls.Add(btnPhoto);
			Controls.Add(btnSave);
			Controls.Add(tbxPassword);
			Controls.Add(lblPassword);
			Controls.Add(tbxBType);
			Controls.Add(lblBType);
			Controls.Add(tbxNumber);
			Controls.Add(lblNumber);
			Controls.Add(tbxHAddress);
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
			Name = "DonorP";
			Size = new Size(1020, 641);
			Load += DonorP_Load;
			pProfile.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxPhoto).EndInit();
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
		private ReaLTaiizor.Controls.BigTextBox tbxHAddress;
		private Label lblHomeAddress;
		private ReaLTaiizor.Controls.BigTextBox tbxBType;
		private Label lblBType;
		private ReaLTaiizor.Controls.BigTextBox tbxNumber;
		private Label lblNumber;
		private ReaLTaiizor.Controls.BigTextBox tbxPassword;
		private Label lblPassword;
		private AntdUI.Button btnSave;
		private AntdUI.Button btnPhoto;
		private AntdUI.Button btnEdit;
		private PictureBox pbxPhoto;
	}
}
