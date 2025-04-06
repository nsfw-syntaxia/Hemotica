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
			lblEmail = new Label();
			lblGender = new Label();
			lblAge = new Label();
			lblHomeAddress = new Label();
			lblBType = new Label();
			lblNumber = new Label();
			lblPassword = new Label();
			btnSave = new AntdUI.Button();
			btnProfile = new AntdUI.Button();
			btnEdit = new AntdUI.Button();
			tbxEmail = new ReaLTaiizor.Controls.HopeTextBox();
			tbxPassword = new ReaLTaiizor.Controls.HopeTextBox();
			tbxName = new ReaLTaiizor.Controls.HopeTextBox();
			tbxGender = new ReaLTaiizor.Controls.HopeTextBox();
			tbxAge = new ReaLTaiizor.Controls.HopeTextBox();
			tbxHomeAddress = new ReaLTaiizor.Controls.HopeTextBox();
			tbxNumber = new ReaLTaiizor.Controls.HopeTextBox();
			tbxBType = new ReaLTaiizor.Controls.HopeTextBox();
			btnDelete = new AntdUI.Button();
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
			btnSave.Enabled = false;
			btnSave.Font = new Font("Bahnschrift", 14F);
			btnSave.ForeColor = Color.FromArgb(252, 228, 228);
			btnSave.Location = new Point(326, 529);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(187, 52);
			btnSave.TabIndex = 28;
			btnSave.Text = "Save Changes";
			btnSave.Click += btnSave_Click;
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
			btnProfile.Click += btnProfile_Click;
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
			btnEdit.Click += btnEdit_Click;
			// 
			// tbxEmail
			// 
			tbxEmail.BackColor = Color.White;
			tbxEmail.BaseColor = Color.FromArgb(253, 211, 211);
			tbxEmail.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxEmail.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxEmail.Enabled = false;
			tbxEmail.Font = new Font("Bahnschrift", 15F);
			tbxEmail.ForeColor = Color.FromArgb(216, 85, 101);
			tbxEmail.Hint = "";
			tbxEmail.Location = new Point(260, 60);
			tbxEmail.MaxLength = 32767;
			tbxEmail.Multiline = false;
			tbxEmail.Name = "tbxEmail";
			tbxEmail.PasswordChar = '\0';
			tbxEmail.ScrollBars = ScrollBars.None;
			tbxEmail.SelectedText = "";
			tbxEmail.SelectionLength = 0;
			tbxEmail.SelectionStart = 0;
			tbxEmail.Size = new Size(349, 41);
			tbxEmail.TabIndex = 31;
			tbxEmail.TabStop = false;
			tbxEmail.UseSystemPasswordChar = false;
			tbxEmail.TextChanged += tbxEmail_TextChanged;
			// 
			// tbxPassword
			// 
			tbxPassword.BackColor = Color.White;
			tbxPassword.BaseColor = Color.FromArgb(253, 211, 211);
			tbxPassword.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxPassword.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxPassword.Enabled = false;
			tbxPassword.Font = new Font("Bahnschrift", 15F);
			tbxPassword.ForeColor = Color.FromArgb(216, 85, 101);
			tbxPassword.Hint = "";
			tbxPassword.Location = new Point(260, 107);
			tbxPassword.MaxLength = 32767;
			tbxPassword.Multiline = false;
			tbxPassword.Name = "tbxPassword";
			tbxPassword.PasswordChar = '●';
			tbxPassword.ScrollBars = ScrollBars.None;
			tbxPassword.SelectedText = "";
			tbxPassword.SelectionLength = 0;
			tbxPassword.SelectionStart = 0;
			tbxPassword.Size = new Size(349, 41);
			tbxPassword.TabIndex = 32;
			tbxPassword.TabStop = false;
			tbxPassword.UseSystemPasswordChar = false;
			tbxPassword.TextChanged += tbxPassword_TextChanged;
			// 
			// tbxName
			// 
			tbxName.BackColor = Color.White;
			tbxName.BaseColor = Color.FromArgb(253, 211, 211);
			tbxName.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxName.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxName.Enabled = false;
			tbxName.Font = new Font("Bahnschrift", 15F);
			tbxName.ForeColor = Color.FromArgb(216, 85, 101);
			tbxName.Hint = "";
			tbxName.Location = new Point(260, 178);
			tbxName.MaxLength = 32767;
			tbxName.Multiline = false;
			tbxName.Name = "tbxName";
			tbxName.PasswordChar = '\0';
			tbxName.ScrollBars = ScrollBars.None;
			tbxName.SelectedText = "";
			tbxName.SelectionLength = 0;
			tbxName.SelectionStart = 0;
			tbxName.Size = new Size(349, 41);
			tbxName.TabIndex = 33;
			tbxName.TabStop = false;
			tbxName.UseSystemPasswordChar = false;
			// 
			// tbxGender
			// 
			tbxGender.BackColor = Color.White;
			tbxGender.BaseColor = Color.FromArgb(253, 211, 211);
			tbxGender.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxGender.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxGender.Enabled = false;
			tbxGender.Font = new Font("Bahnschrift", 15F);
			tbxGender.ForeColor = Color.FromArgb(216, 85, 101);
			tbxGender.Hint = "";
			tbxGender.Location = new Point(260, 225);
			tbxGender.MaxLength = 32767;
			tbxGender.Multiline = false;
			tbxGender.Name = "tbxGender";
			tbxGender.PasswordChar = '\0';
			tbxGender.ScrollBars = ScrollBars.None;
			tbxGender.SelectedText = "";
			tbxGender.SelectionLength = 0;
			tbxGender.SelectionStart = 0;
			tbxGender.Size = new Size(349, 41);
			tbxGender.TabIndex = 34;
			tbxGender.TabStop = false;
			tbxGender.UseSystemPasswordChar = false;
			tbxGender.TextChanged += tbxGender_TextChanged;
			// 
			// tbxAge
			// 
			tbxAge.BackColor = Color.White;
			tbxAge.BaseColor = Color.FromArgb(253, 211, 211);
			tbxAge.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxAge.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxAge.Enabled = false;
			tbxAge.Font = new Font("Bahnschrift", 15F);
			tbxAge.ForeColor = Color.FromArgb(216, 85, 101);
			tbxAge.Hint = "";
			tbxAge.Location = new Point(260, 272);
			tbxAge.MaxLength = 32767;
			tbxAge.Multiline = false;
			tbxAge.Name = "tbxAge";
			tbxAge.PasswordChar = '\0';
			tbxAge.ScrollBars = ScrollBars.None;
			tbxAge.SelectedText = "";
			tbxAge.SelectionLength = 0;
			tbxAge.SelectionStart = 0;
			tbxAge.Size = new Size(349, 41);
			tbxAge.TabIndex = 35;
			tbxAge.TabStop = false;
			tbxAge.UseSystemPasswordChar = false;
			tbxAge.TextChanged += tbxAge_TextChanged;
			// 
			// tbxHomeAddress
			// 
			tbxHomeAddress.BackColor = Color.White;
			tbxHomeAddress.BaseColor = Color.FromArgb(253, 211, 211);
			tbxHomeAddress.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxHomeAddress.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxHomeAddress.Enabled = false;
			tbxHomeAddress.Font = new Font("Bahnschrift", 15F);
			tbxHomeAddress.ForeColor = Color.FromArgb(216, 85, 101);
			tbxHomeAddress.Hint = "";
			tbxHomeAddress.Location = new Point(260, 343);
			tbxHomeAddress.MaxLength = 32767;
			tbxHomeAddress.Multiline = false;
			tbxHomeAddress.Name = "tbxHomeAddress";
			tbxHomeAddress.PasswordChar = '\0';
			tbxHomeAddress.ScrollBars = ScrollBars.None;
			tbxHomeAddress.SelectedText = "";
			tbxHomeAddress.SelectionLength = 0;
			tbxHomeAddress.SelectionStart = 0;
			tbxHomeAddress.Size = new Size(349, 41);
			tbxHomeAddress.TabIndex = 36;
			tbxHomeAddress.TabStop = false;
			tbxHomeAddress.UseSystemPasswordChar = false;
			tbxHomeAddress.TextChanged += tbxHomeAddress_TextChanged;
			// 
			// tbxNumber
			// 
			tbxNumber.BackColor = Color.White;
			tbxNumber.BaseColor = Color.FromArgb(253, 211, 211);
			tbxNumber.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxNumber.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxNumber.Enabled = false;
			tbxNumber.Font = new Font("Bahnschrift", 15F);
			tbxNumber.ForeColor = Color.FromArgb(216, 85, 101);
			tbxNumber.Hint = "";
			tbxNumber.Location = new Point(260, 390);
			tbxNumber.MaxLength = 32767;
			tbxNumber.Multiline = false;
			tbxNumber.Name = "tbxNumber";
			tbxNumber.PasswordChar = '\0';
			tbxNumber.ScrollBars = ScrollBars.None;
			tbxNumber.SelectedText = "";
			tbxNumber.SelectionLength = 0;
			tbxNumber.SelectionStart = 0;
			tbxNumber.Size = new Size(349, 41);
			tbxNumber.TabIndex = 37;
			tbxNumber.TabStop = false;
			tbxNumber.UseSystemPasswordChar = false;
			tbxNumber.TextChanged += tbxNumber_TextChanged;
			// 
			// tbxBType
			// 
			tbxBType.BackColor = Color.White;
			tbxBType.BaseColor = Color.FromArgb(253, 211, 211);
			tbxBType.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxBType.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxBType.Enabled = false;
			tbxBType.Font = new Font("Bahnschrift", 15F);
			tbxBType.ForeColor = Color.FromArgb(216, 85, 101);
			tbxBType.Hint = "";
			tbxBType.Location = new Point(260, 437);
			tbxBType.MaxLength = 32767;
			tbxBType.Multiline = false;
			tbxBType.Name = "tbxBType";
			tbxBType.PasswordChar = '\0';
			tbxBType.ScrollBars = ScrollBars.None;
			tbxBType.SelectedText = "";
			tbxBType.SelectionLength = 0;
			tbxBType.SelectionStart = 0;
			tbxBType.Size = new Size(349, 41);
			tbxBType.TabIndex = 38;
			tbxBType.TabStop = false;
			tbxBType.UseSystemPasswordChar = false;
			// 
			// btnDelete
			// 
			btnDelete.DefaultBack = Color.FromArgb(216, 85, 101);
			btnDelete.Font = new Font("Bahnschrift", 14F);
			btnDelete.ForeColor = Color.FromArgb(252, 228, 228);
			btnDelete.Location = new Point(727, 529);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(187, 52);
			btnDelete.TabIndex = 39;
			btnDelete.Text = "Delete Account";
			btnDelete.Click += btnDelete_Click;
			// 
			// DonorProfile
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Controls.Add(btnProfile);
			Controls.Add(btnSave);
			Controls.Add(lblPassword);
			Controls.Add(lblBType);
			Controls.Add(lblNumber);
			Controls.Add(lblHomeAddress);
			Controls.Add(lblAge);
			Controls.Add(lblGender);
			Controls.Add(lblEmail);
			Controls.Add(dName);
			Controls.Add(pProfile);
			Controls.Add(tbxPassword);
			Controls.Add(tbxEmail);
			Controls.Add(tbxName);
			Controls.Add(tbxGender);
			Controls.Add(tbxAge);
			Controls.Add(tbxHomeAddress);
			Controls.Add(tbxNumber);
			Controls.Add(tbxBType);
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
		private Label lblEmail;
		private Label lblGender;
		private Label lblAge;
		private Label lblHomeAddress;
		private Label lblBType;
		private Label lblNumber;
		private Label lblPassword;
		private AntdUI.Button btnSave;
		private AntdUI.Button btnProfile;
		private AntdUI.Button btnEdit;
		private PictureBox pbxProfile;
		private ReaLTaiizor.Controls.HopeTextBox tbxEmail;
		private ReaLTaiizor.Controls.HopeTextBox tbxPassword;
		private ReaLTaiizor.Controls.HopeTextBox tbxName;
		private ReaLTaiizor.Controls.HopeTextBox tbxGender;
		private ReaLTaiizor.Controls.HopeTextBox tbxAge;
		private ReaLTaiizor.Controls.HopeTextBox tbxHomeAddress;
		private ReaLTaiizor.Controls.HopeTextBox tbxNumber;
		private ReaLTaiizor.Controls.HopeTextBox tbxBType;
		private AntdUI.Button btnDelete;
	}
}
