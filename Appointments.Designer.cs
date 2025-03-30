namespace Hemotica
{
	partial class Appointments
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments));
			lblHeader = new Label();
			pbxLogo = new PictureBox();
			btnCancel = new ReaLTaiizor.Controls.FoxButton();
			btnSubmit = new ReaLTaiizor.Controls.FoxButton();
			pAge = new Panel();
			rbtnNo1 = new ReaLTaiizor.Controls.HopeRadioButton();
			rbtnYes1 = new ReaLTaiizor.Controls.HopeRadioButton();
			lblAge = new Label();
			pWeight = new Panel();
			lblWeight = new Label();
			rbtnNo2 = new ReaLTaiizor.Controls.HopeRadioButton();
			rbtnYes2 = new ReaLTaiizor.Controls.HopeRadioButton();
			pHealth = new Panel();
			lblHealth = new Label();
			rbtnNo3 = new ReaLTaiizor.Controls.HopeRadioButton();
			rbtnYes3 = new ReaLTaiizor.Controls.HopeRadioButton();
			pDonation = new Panel();
			lblDonation = new Label();
			rbtnNo4 = new ReaLTaiizor.Controls.HopeRadioButton();
			rbtnYes4 = new ReaLTaiizor.Controls.HopeRadioButton();
			pMedication = new Panel();
			lblMedication = new Label();
			rbtnNo5 = new ReaLTaiizor.Controls.HopeRadioButton();
			rbtnYes5 = new ReaLTaiizor.Controls.HopeRadioButton();
			pHistory = new Panel();
			lblHistory = new Label();
			rbtnNo6 = new ReaLTaiizor.Controls.HopeRadioButton();
			rbtnYes6 = new ReaLTaiizor.Controls.HopeRadioButton();
			lblInformation = new Label();
			dtpAppointments = new DateTimePicker();
			cmbxHospitals = new ReaLTaiizor.Controls.DungeonComboBox();
			((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
			pAge.SuspendLayout();
			pWeight.SuspendLayout();
			pHealth.SuspendLayout();
			pDonation.SuspendLayout();
			pMedication.SuspendLayout();
			pHistory.SuspendLayout();
			SuspendLayout();
			// 
			// lblHeader
			// 
			lblHeader.AutoSize = true;
			lblHeader.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblHeader.ForeColor = Color.FromArgb(216, 85, 101);
			lblHeader.Location = new Point(108, 162);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(204, 24);
			lblHeader.TabIndex = 2;
			lblHeader.Text = "SET AN APPOINTMENT !";
			// 
			// pbxLogo
			// 
			pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
			pbxLogo.Location = new Point(147, 17);
			pbxLogo.Name = "pbxLogo";
			pbxLogo.Size = new Size(125, 125);
			pbxLogo.TabIndex = 3;
			pbxLogo.TabStop = false;
			// 
			// btnCancel
			// 
			btnCancel.Anchor = AnchorStyles.Top;
			btnCancel.BackColor = Color.Transparent;
			btnCancel.BaseColor = Color.FromArgb(216, 85, 101);
			btnCancel.BorderColor = Color.FromArgb(216, 85, 101);
			btnCancel.DisabledBaseColor = Color.FromArgb(244, 148, 156);
			btnCancel.DisabledBorderColor = Color.FromArgb(244, 148, 156);
			btnCancel.DisabledTextColor = Color.FromArgb(244, 148, 156);
			btnCancel.DownColor = Color.FromArgb(236, 124, 132);
			btnCancel.EnabledCalc = true;
			btnCancel.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			btnCancel.ForeColor = Color.FromArgb(241, 241, 241);
			btnCancel.Location = new Point(85, 702);
			btnCancel.Name = "btnCancel";
			btnCancel.OverColor = Color.FromArgb(216, 85, 101);
			btnCancel.Size = new Size(120, 40);
			btnCancel.TabIndex = 84;
			btnCancel.Text = "CANCEL";
			btnCancel.Click += btnCancel_Click;
			// 
			// btnSubmit
			// 
			btnSubmit.Anchor = AnchorStyles.Top;
			btnSubmit.BackColor = Color.Transparent;
			btnSubmit.BaseColor = Color.FromArgb(216, 85, 101);
			btnSubmit.BorderColor = Color.FromArgb(216, 85, 101);
			btnSubmit.DisabledBaseColor = Color.FromArgb(244, 148, 156);
			btnSubmit.DisabledBorderColor = Color.FromArgb(244, 148, 156);
			btnSubmit.DisabledTextColor = Color.FromArgb(244, 148, 156);
			btnSubmit.DownColor = Color.FromArgb(236, 124, 132);
			btnSubmit.EnabledCalc = true;
			btnSubmit.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			btnSubmit.ForeColor = Color.FromArgb(241, 241, 241);
			btnSubmit.Location = new Point(216, 702);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.OverColor = Color.FromArgb(216, 85, 101);
			btnSubmit.Size = new Size(120, 40);
			btnSubmit.TabIndex = 83;
			btnSubmit.Text = "SUBMIT";
			btnSubmit.Click += btnSubmit_Click;
			// 
			// pAge
			// 
			pAge.Controls.Add(rbtnNo1);
			pAge.Controls.Add(rbtnYes1);
			pAge.Controls.Add(lblAge);
			pAge.Location = new Point(12, 266);
			pAge.Name = "pAge";
			pAge.Size = new Size(390, 58);
			pAge.TabIndex = 85;
			// 
			// rbtnNo1
			// 
			rbtnNo1.AutoSize = true;
			rbtnNo1.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnNo1.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnNo1.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnNo1.Enable = true;
			rbtnNo1.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnNo1.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnNo1.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnNo1.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnNo1.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnNo1.Location = new Point(233, 35);
			rbtnNo1.Name = "rbtnNo1";
			rbtnNo1.Size = new Size(55, 20);
			rbtnNo1.TabIndex = 89;
			rbtnNo1.TabStop = true;
			rbtnNo1.Text = "No";
			rbtnNo1.UseVisualStyleBackColor = true;
			// 
			// rbtnYes1
			// 
			rbtnYes1.AutoSize = true;
			rbtnYes1.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnYes1.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnYes1.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnYes1.Enable = true;
			rbtnYes1.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnYes1.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnYes1.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnYes1.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnYes1.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnYes1.Location = new Point(112, 35);
			rbtnYes1.Name = "rbtnYes1";
			rbtnYes1.Size = new Size(61, 20);
			rbtnYes1.TabIndex = 88;
			rbtnYes1.TabStop = true;
			rbtnYes1.Text = "Yes";
			rbtnYes1.UseVisualStyleBackColor = true;
			// 
			// lblAge
			// 
			lblAge.AutoSize = true;
			lblAge.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblAge.ForeColor = Color.FromArgb(216, 85, 101);
			lblAge.Location = new Point(3, 3);
			lblAge.Name = "lblAge";
			lblAge.Size = new Size(301, 24);
			lblAge.TabIndex = 86;
			lblAge.Text = "Do you age between 18-65 years old?";
			// 
			// pWeight
			// 
			pWeight.Controls.Add(lblWeight);
			pWeight.Controls.Add(rbtnNo2);
			pWeight.Controls.Add(rbtnYes2);
			pWeight.Location = new Point(12, 330);
			pWeight.Name = "pWeight";
			pWeight.Size = new Size(390, 58);
			pWeight.TabIndex = 90;
			// 
			// lblWeight
			// 
			lblWeight.AutoSize = true;
			lblWeight.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblWeight.ForeColor = Color.FromArgb(216, 85, 101);
			lblWeight.Location = new Point(3, 3);
			lblWeight.Name = "lblWeight";
			lblWeight.Size = new Size(304, 24);
			lblWeight.TabIndex = 86;
			lblWeight.Text = "Do you weigh at least 50 kg (110 lbs)?";
			// 
			// rbtnNo2
			// 
			rbtnNo2.AutoSize = true;
			rbtnNo2.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnNo2.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnNo2.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnNo2.Enable = true;
			rbtnNo2.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnNo2.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnNo2.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnNo2.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnNo2.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnNo2.Location = new Point(233, 35);
			rbtnNo2.Name = "rbtnNo2";
			rbtnNo2.Size = new Size(55, 20);
			rbtnNo2.TabIndex = 89;
			rbtnNo2.TabStop = true;
			rbtnNo2.Text = "No";
			rbtnNo2.UseVisualStyleBackColor = true;
			// 
			// rbtnYes2
			// 
			rbtnYes2.AutoSize = true;
			rbtnYes2.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnYes2.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnYes2.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnYes2.Enable = true;
			rbtnYes2.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnYes2.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnYes2.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnYes2.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnYes2.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnYes2.Location = new Point(112, 35);
			rbtnYes2.Name = "rbtnYes2";
			rbtnYes2.Size = new Size(61, 20);
			rbtnYes2.TabIndex = 88;
			rbtnYes2.TabStop = true;
			rbtnYes2.Text = "Yes";
			rbtnYes2.UseVisualStyleBackColor = true;
			// 
			// pHealth
			// 
			pHealth.Controls.Add(lblHealth);
			pHealth.Controls.Add(rbtnNo3);
			pHealth.Controls.Add(rbtnYes3);
			pHealth.Location = new Point(12, 394);
			pHealth.Name = "pHealth";
			pHealth.Size = new Size(390, 58);
			pHealth.TabIndex = 91;
			// 
			// lblHealth
			// 
			lblHealth.AutoSize = true;
			lblHealth.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblHealth.ForeColor = Color.FromArgb(216, 85, 101);
			lblHealth.Location = new Point(3, 3);
			lblHealth.Name = "lblHealth";
			lblHealth.Size = new Size(369, 24);
			lblHealth.TabIndex = 86;
			lblHealth.Text = "Do you have no recent illnesses or infections?";
			// 
			// rbtnNo3
			// 
			rbtnNo3.AutoSize = true;
			rbtnNo3.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnNo3.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnNo3.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnNo3.Enable = true;
			rbtnNo3.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnNo3.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnNo3.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnNo3.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnNo3.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnNo3.Location = new Point(233, 35);
			rbtnNo3.Name = "rbtnNo3";
			rbtnNo3.Size = new Size(55, 20);
			rbtnNo3.TabIndex = 89;
			rbtnNo3.TabStop = true;
			rbtnNo3.Text = "No";
			rbtnNo3.UseVisualStyleBackColor = true;
			// 
			// rbtnYes3
			// 
			rbtnYes3.AutoSize = true;
			rbtnYes3.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnYes3.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnYes3.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnYes3.Enable = true;
			rbtnYes3.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnYes3.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnYes3.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnYes3.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnYes3.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnYes3.Location = new Point(112, 35);
			rbtnYes3.Name = "rbtnYes3";
			rbtnYes3.Size = new Size(61, 20);
			rbtnYes3.TabIndex = 88;
			rbtnYes3.TabStop = true;
			rbtnYes3.Text = "Yes";
			rbtnYes3.UseVisualStyleBackColor = true;
			// 
			// pDonation
			// 
			pDonation.Controls.Add(lblDonation);
			pDonation.Controls.Add(rbtnNo4);
			pDonation.Controls.Add(rbtnYes4);
			pDonation.Location = new Point(12, 458);
			pDonation.Name = "pDonation";
			pDonation.Size = new Size(390, 58);
			pDonation.TabIndex = 92;
			// 
			// lblDonation
			// 
			lblDonation.AutoSize = true;
			lblDonation.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblDonation.ForeColor = Color.FromArgb(216, 85, 101);
			lblDonation.Location = new Point(3, 3);
			lblDonation.Name = "lblDonation";
			lblDonation.Size = new Size(363, 24);
			lblDonation.TabIndex = 86;
			lblDonation.Text = "Is it at least 56 days since your last donation?";
			// 
			// rbtnNo4
			// 
			rbtnNo4.AutoSize = true;
			rbtnNo4.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnNo4.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnNo4.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnNo4.Enable = true;
			rbtnNo4.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnNo4.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnNo4.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnNo4.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnNo4.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnNo4.Location = new Point(233, 35);
			rbtnNo4.Name = "rbtnNo4";
			rbtnNo4.Size = new Size(55, 20);
			rbtnNo4.TabIndex = 89;
			rbtnNo4.TabStop = true;
			rbtnNo4.Text = "No";
			rbtnNo4.UseVisualStyleBackColor = true;
			// 
			// rbtnYes4
			// 
			rbtnYes4.AutoSize = true;
			rbtnYes4.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnYes4.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnYes4.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnYes4.Enable = true;
			rbtnYes4.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnYes4.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnYes4.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnYes4.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnYes4.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnYes4.Location = new Point(112, 35);
			rbtnYes4.Name = "rbtnYes4";
			rbtnYes4.Size = new Size(61, 20);
			rbtnYes4.TabIndex = 88;
			rbtnYes4.TabStop = true;
			rbtnYes4.Text = "Yes";
			rbtnYes4.UseVisualStyleBackColor = true;
			// 
			// pMedication
			// 
			pMedication.Controls.Add(lblMedication);
			pMedication.Controls.Add(rbtnNo5);
			pMedication.Controls.Add(rbtnYes5);
			pMedication.Location = new Point(12, 522);
			pMedication.Name = "pMedication";
			pMedication.Size = new Size(390, 58);
			pMedication.TabIndex = 93;
			// 
			// lblMedication
			// 
			lblMedication.AutoSize = true;
			lblMedication.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblMedication.ForeColor = Color.FromArgb(216, 85, 101);
			lblMedication.Location = new Point(3, 3);
			lblMedication.Name = "lblMedication";
			lblMedication.Size = new Size(285, 24);
			lblMedication.TabIndex = 86;
			lblMedication.Text = "Are you free from any medications?";
			// 
			// rbtnNo5
			// 
			rbtnNo5.AutoSize = true;
			rbtnNo5.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnNo5.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnNo5.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnNo5.Enable = true;
			rbtnNo5.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnNo5.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnNo5.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnNo5.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnNo5.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnNo5.Location = new Point(233, 35);
			rbtnNo5.Name = "rbtnNo5";
			rbtnNo5.Size = new Size(55, 20);
			rbtnNo5.TabIndex = 89;
			rbtnNo5.TabStop = true;
			rbtnNo5.Text = "No";
			rbtnNo5.UseVisualStyleBackColor = true;
			// 
			// rbtnYes5
			// 
			rbtnYes5.AutoSize = true;
			rbtnYes5.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnYes5.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnYes5.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnYes5.Enable = true;
			rbtnYes5.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnYes5.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnYes5.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnYes5.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnYes5.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnYes5.Location = new Point(112, 35);
			rbtnYes5.Name = "rbtnYes5";
			rbtnYes5.Size = new Size(61, 20);
			rbtnYes5.TabIndex = 88;
			rbtnYes5.TabStop = true;
			rbtnYes5.Text = "Yes";
			rbtnYes5.UseVisualStyleBackColor = true;
			// 
			// pHistory
			// 
			pHistory.Controls.Add(lblHistory);
			pHistory.Controls.Add(rbtnNo6);
			pHistory.Controls.Add(rbtnYes6);
			pHistory.Location = new Point(12, 586);
			pHistory.Name = "pHistory";
			pHistory.Size = new Size(390, 58);
			pHistory.TabIndex = 94;
			// 
			// lblHistory
			// 
			lblHistory.AutoSize = true;
			lblHistory.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblHistory.ForeColor = Color.FromArgb(216, 85, 101);
			lblHistory.Location = new Point(3, 3);
			lblHistory.Name = "lblHistory";
			lblHistory.Size = new Size(356, 24);
			lblHistory.TabIndex = 86;
			lblHistory.Text = "Do you have no chronic medical conditions?";
			// 
			// rbtnNo6
			// 
			rbtnNo6.AutoSize = true;
			rbtnNo6.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnNo6.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnNo6.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnNo6.Enable = true;
			rbtnNo6.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnNo6.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnNo6.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnNo6.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnNo6.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnNo6.Location = new Point(233, 35);
			rbtnNo6.Name = "rbtnNo6";
			rbtnNo6.Size = new Size(55, 20);
			rbtnNo6.TabIndex = 89;
			rbtnNo6.TabStop = true;
			rbtnNo6.Text = "No";
			rbtnNo6.UseVisualStyleBackColor = true;
			// 
			// rbtnYes6
			// 
			rbtnYes6.AutoSize = true;
			rbtnYes6.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnYes6.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnYes6.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnYes6.Enable = true;
			rbtnYes6.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnYes6.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnYes6.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnYes6.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnYes6.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnYes6.Location = new Point(112, 35);
			rbtnYes6.Name = "rbtnYes6";
			rbtnYes6.Size = new Size(61, 20);
			rbtnYes6.TabIndex = 88;
			rbtnYes6.TabStop = true;
			rbtnYes6.Text = "Yes";
			rbtnYes6.UseVisualStyleBackColor = true;
			// 
			// lblInformation
			// 
			lblInformation.AutoSize = true;
			lblInformation.Cursor = Cursors.Hand;
			lblInformation.Font = new Font("Arial Narrow", 11F, FontStyle.Bold | FontStyle.Italic);
			lblInformation.ForeColor = Color.FromArgb(236, 124, 132);
			lblInformation.Location = new Point(7, 663);
			lblInformation.Name = "lblInformation";
			lblInformation.Size = new Size(401, 20);
			lblInformation.TabIndex = 90;
			lblInformation.Text = "For more details, visit Red Cross Blood Donation Eligibility Guide.";
			lblInformation.Click += lblInformation_Click;
			// 
			// dtpAppointments
			// 
			dtpAppointments.CalendarForeColor = Color.FromArgb(216, 85, 101);
			dtpAppointments.CalendarMonthBackground = Color.FromArgb(241, 241, 241);
			dtpAppointments.CalendarTitleForeColor = Color.FromArgb(216, 85, 101);
			dtpAppointments.CalendarTrailingForeColor = Color.FromArgb(216, 85, 101);
			dtpAppointments.Font = new Font("Arial Narrow", 13F);
			dtpAppointments.Location = new Point(12, 202);
			dtpAppointments.Name = "dtpAppointments";
			dtpAppointments.Size = new Size(390, 27);
			dtpAppointments.TabIndex = 95;
			// 
			// cmbxHospitals
			// 
			cmbxHospitals.BackColor = Color.FromArgb(241, 241, 241);
			cmbxHospitals.ColorA = Color.FromArgb(236, 124, 132);
			cmbxHospitals.ColorB = Color.FromArgb(236, 124, 132);
			cmbxHospitals.ColorC = Color.FromArgb(242, 241, 240);
			cmbxHospitals.ColorD = Color.FromArgb(253, 252, 252);
			cmbxHospitals.ColorE = Color.FromArgb(239, 237, 236);
			cmbxHospitals.ColorF = Color.FromArgb(180, 180, 180);
			cmbxHospitals.ColorG = Color.FromArgb(119, 119, 118);
			cmbxHospitals.ColorH = Color.FromArgb(224, 222, 220);
			cmbxHospitals.ColorI = Color.FromArgb(250, 249, 249);
			cmbxHospitals.DrawMode = DrawMode.OwnerDrawFixed;
			cmbxHospitals.DropDownHeight = 100;
			cmbxHospitals.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbxHospitals.Font = new Font("Arial Narrow", 13F);
			cmbxHospitals.ForeColor = SystemColors.ControlText;
			cmbxHospitals.FormattingEnabled = true;
			cmbxHospitals.HoverSelectionColor = Color.Empty;
			cmbxHospitals.IntegralHeight = false;
			cmbxHospitals.ItemHeight = 20;
			cmbxHospitals.Location = new Point(12, 234);
			cmbxHospitals.Margin = new Padding(5, 3, 3, 3);
			cmbxHospitals.Name = "cmbxHospitals";
			cmbxHospitals.Size = new Size(390, 26);
			cmbxHospitals.StartIndex = 0;
			cmbxHospitals.TabIndex = 96;
			// 
			// Appointments
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = Color.FromArgb(253, 211, 211);
			ClientSize = new Size(414, 759);
			ControlBox = false;
			Controls.Add(cmbxHospitals);
			Controls.Add(dtpAppointments);
			Controls.Add(lblInformation);
			Controls.Add(pHistory);
			Controls.Add(pMedication);
			Controls.Add(pDonation);
			Controls.Add(pHealth);
			Controls.Add(pWeight);
			Controls.Add(pAge);
			Controls.Add(btnCancel);
			Controls.Add(btnSubmit);
			Controls.Add(pbxLogo);
			Controls.Add(lblHeader);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "Appointments";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Load += Appointments_Load;
			((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
			pAge.ResumeLayout(false);
			pAge.PerformLayout();
			pWeight.ResumeLayout(false);
			pWeight.PerformLayout();
			pHealth.ResumeLayout(false);
			pHealth.PerformLayout();
			pDonation.ResumeLayout(false);
			pDonation.PerformLayout();
			pMedication.ResumeLayout(false);
			pMedication.PerformLayout();
			pHistory.ResumeLayout(false);
			pHistory.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblHeader;
		private PictureBox pbxLogo;
		private ReaLTaiizor.Controls.FoxButton btnCancel;
		private ReaLTaiizor.Controls.FoxButton btnSubmit;
		private Panel pAge;
		private Label lblAge;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnNo1;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnYes1;
		private Panel pWeight;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnNo2;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnYes2;
		private Label lblWeight;
		private Panel pHealth;
		private Label lblHealth;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnNo3;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnYes3;
		private Panel pDonation;
		private Label lblDonation;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnNo4;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnYes4;
		private Panel pMedication;
		private Label lblMedication;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnNo5;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnYes5;
		private Panel pHistory;
		private Label lblHistory;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnNo6;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnYes6;
		private Label lblInformation;
		private DateTimePicker dtpAppointments;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxHospitals;
	}
}