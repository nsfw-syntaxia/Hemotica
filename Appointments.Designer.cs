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
			dpAppointment = new AntdUI.DatePicker();
			lblHeader = new Label();
			pbxLogo = new PictureBox();
			lblL1Instruction = new Label();
			lblL2Instruction = new Label();
			btnBack = new ReaLTaiizor.Controls.FoxButton();
			btnSubmit = new ReaLTaiizor.Controls.FoxButton();
			pEligibility = new Panel();
			((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
			SuspendLayout();
			// 
			// dpAppointment
			// 
			dpAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			dpAppointment.Font = new Font("Bahnschrift SemiLight", 10F);
			dpAppointment.ForeColor = Color.FromArgb(144, 144, 144);
			dpAppointment.Format = "MM-dd-yyyy";
			dpAppointment.Location = new Point(12, 290);
			dpAppointment.Name = "dpAppointment";
			dpAppointment.SelectionColor = Color.FromArgb(216, 85, 101);
			dpAppointment.Size = new Size(390, 48);
			dpAppointment.TabIndex = 0;
			dpAppointment.Text = "Date";
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
			// lblL1Instruction
			// 
			lblL1Instruction.AutoSize = true;
			lblL1Instruction.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblL1Instruction.ForeColor = Color.FromArgb(236, 124, 132);
			lblL1Instruction.Location = new Point(49, 211);
			lblL1Instruction.Name = "lblL1Instruction";
			lblL1Instruction.Size = new Size(322, 22);
			lblL1Instruction.TabIndex = 4;
			lblL1Instruction.Text = "Please fill out the eligibility form and request\r\n";
			// 
			// lblL2Instruction
			// 
			lblL2Instruction.AutoSize = true;
			lblL2Instruction.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblL2Instruction.ForeColor = Color.FromArgb(236, 124, 132);
			lblL2Instruction.Location = new Point(64, 238);
			lblL2Instruction.Name = "lblL2Instruction";
			lblL2Instruction.Size = new Size(293, 22);
			lblL2Instruction.TabIndex = 82;
			lblL2Instruction.Text = "an appointment for your blood donation.";
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.Transparent;
			btnBack.BaseColor = Color.FromArgb(216, 85, 101);
			btnBack.BorderColor = Color.FromArgb(216, 85, 101);
			btnBack.DisabledBaseColor = Color.FromArgb(244, 148, 156);
			btnBack.DisabledBorderColor = Color.FromArgb(244, 148, 156);
			btnBack.DisabledTextColor = Color.FromArgb(244, 148, 156);
			btnBack.DownColor = Color.FromArgb(236, 124, 132);
			btnBack.EnabledCalc = true;
			btnBack.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			btnBack.ForeColor = Color.FromArgb(241, 241, 241);
			btnBack.Location = new Point(82, 657);
			btnBack.Name = "btnBack";
			btnBack.OverColor = Color.FromArgb(216, 85, 101);
			btnBack.Size = new Size(120, 40);
			btnBack.TabIndex = 84;
			btnBack.Text = "BACK";
			// 
			// btnSubmit
			// 
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
			btnSubmit.Location = new Point(213, 657);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.OverColor = Color.FromArgb(216, 85, 101);
			btnSubmit.Size = new Size(120, 40);
			btnSubmit.TabIndex = 83;
			btnSubmit.Text = "SUBMIT";
			// 
			// pEligibility
			// 
			pEligibility.Location = new Point(12, 344);
			pEligibility.Name = "pEligibility";
			pEligibility.Size = new Size(390, 307);
			pEligibility.TabIndex = 85;
			// 
			// Appointments
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			ClientSize = new Size(414, 714);
			ControlBox = false;
			Controls.Add(pEligibility);
			Controls.Add(btnBack);
			Controls.Add(btnSubmit);
			Controls.Add(lblL2Instruction);
			Controls.Add(lblL1Instruction);
			Controls.Add(pbxLogo);
			Controls.Add(lblHeader);
			Controls.Add(dpAppointment);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "Appointments";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private AntdUI.DatePicker dpAppointment;
		private Label lblHeader;
		private PictureBox pbxLogo;
		private Label lblL1Instruction;
		private Label lblL2Instruction;
		private ReaLTaiizor.Controls.FoxButton btnBack;
		private ReaLTaiizor.Controls.FoxButton btnSubmit;
		private Panel pEligibility;
	}
}