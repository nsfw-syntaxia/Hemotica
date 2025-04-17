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
			btnAvailability = new AntdUI.Button();
			btnTransfusion = new AntdUI.Button();
			lblQuantity = new Label();
			lblPatient = new Label();
			lblBlood = new Label();
			lblPhysician = new Label();
			lblUnit = new Label();
			lblResult = new Label();
			cmbxPhysician = new ReaLTaiizor.Controls.DungeonComboBox();
			tbxBlood = new ReaLTaiizor.Controls.HopeTextBox();
			tbxPriority = new ReaLTaiizor.Controls.HopeTextBox();
			tbxQuantity = new ReaLTaiizor.Controls.HopeTextBox();
			lblPriority = new Label();
			cmbxPatient = new ReaLTaiizor.Controls.DungeonComboBox();
			tbxBirthdate = new ReaLTaiizor.Controls.HopeTextBox();
			SuspendLayout();
			// 
			// btnAvailability
			// 
			btnAvailability.DefaultBack = Color.FromArgb(236, 124, 132);
			btnAvailability.Font = new Font("Bahnschrift", 14F);
			btnAvailability.ForeColor = Color.FromArgb(252, 228, 228);
			btnAvailability.Location = new Point(321, 447);
			btnAvailability.Name = "btnAvailability";
			btnAvailability.Size = new Size(187, 52);
			btnAvailability.TabIndex = 68;
			btnAvailability.Text = "Check Availability";
			btnAvailability.Click += btnAvailability_Click;
			// 
			// btnTransfusion
			// 
			btnTransfusion.DefaultBack = Color.FromArgb(236, 124, 132);
			btnTransfusion.Font = new Font("Bahnschrift", 14F);
			btnTransfusion.ForeColor = Color.FromArgb(252, 228, 228);
			btnTransfusion.Location = new Point(514, 447);
			btnTransfusion.Name = "btnTransfusion";
			btnTransfusion.Size = new Size(187, 52);
			btnTransfusion.TabIndex = 67;
			btnTransfusion.Text = "Blood Transfer";
			btnTransfusion.Click += btnTransfusion_Click;
			// 
			// lblQuantity
			// 
			lblQuantity.AutoSize = true;
			lblQuantity.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblQuantity.ForeColor = Color.FromArgb(216, 85, 101);
			lblQuantity.Location = new Point(282, 353);
			lblQuantity.Name = "lblQuantity";
			lblQuantity.Padding = new Padding(5, 0, 0, 5);
			lblQuantity.Size = new Size(120, 38);
			lblQuantity.TabIndex = 59;
			lblQuantity.Text = "Quantity";
			// 
			// lblPatient
			// 
			lblPatient.AutoSize = true;
			lblPatient.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblPatient.ForeColor = Color.FromArgb(216, 85, 101);
			lblPatient.Location = new Point(298, 151);
			lblPatient.Name = "lblPatient";
			lblPatient.Padding = new Padding(5, 0, 0, 5);
			lblPatient.Size = new Size(104, 38);
			lblPatient.TabIndex = 55;
			lblPatient.Text = "Patient";
			// 
			// lblBlood
			// 
			lblBlood.AutoSize = true;
			lblBlood.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblBlood.ForeColor = Color.FromArgb(216, 85, 101);
			lblBlood.Location = new Point(251, 259);
			lblBlood.Name = "lblBlood";
			lblBlood.Padding = new Padding(5, 0, 0, 5);
			lblBlood.Size = new Size(151, 38);
			lblBlood.TabIndex = 57;
			lblBlood.Text = "Blood Type";
			// 
			// lblPhysician
			// 
			lblPhysician.AutoSize = true;
			lblPhysician.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblPhysician.ForeColor = Color.FromArgb(216, 85, 101);
			lblPhysician.Location = new Point(267, 80);
			lblPhysician.Name = "lblPhysician";
			lblPhysician.Padding = new Padding(5, 0, 0, 5);
			lblPhysician.Size = new Size(135, 38);
			lblPhysician.TabIndex = 53;
			lblPhysician.Text = "Physician";
			// 
			// lblUnit
			// 
			lblUnit.AutoSize = true;
			lblUnit.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblUnit.ForeColor = Color.FromArgb(216, 85, 101);
			lblUnit.Location = new Point(594, 353);
			lblUnit.Name = "lblUnit";
			lblUnit.Padding = new Padding(5, 0, 0, 5);
			lblUnit.Size = new Size(163, 38);
			lblUnit.TabIndex = 69;
			lblUnit.Text = "blood bag/s";
			// 
			// lblResult
			// 
			lblResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblResult.AutoSize = true;
			lblResult.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblResult.ForeColor = Color.FromArgb(216, 85, 101);
			lblResult.Location = new Point(445, 549);
			lblResult.Name = "lblResult";
			lblResult.Padding = new Padding(5, 0, 0, 5);
			lblResult.Size = new Size(129, 38);
			lblResult.TabIndex = 70;
			lblResult.Text = "<results>";
			lblResult.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// cmbxPhysician
			// 
			cmbxPhysician.BackColor = Color.White;
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
			cmbxPhysician.Location = new Point(408, 77);
			cmbxPhysician.Name = "cmbxPhysician";
			cmbxPhysician.Size = new Size(349, 41);
			cmbxPhysician.StartIndex = 0;
			cmbxPhysician.TabIndex = 86;
			// 
			// tbxBlood
			// 
			tbxBlood.BackColor = Color.White;
			tbxBlood.BaseColor = Color.FromArgb(253, 211, 211);
			tbxBlood.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxBlood.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxBlood.Enabled = false;
			tbxBlood.Font = new Font("Bahnschrift", 15F);
			tbxBlood.ForeColor = Color.FromArgb(216, 85, 101);
			tbxBlood.Hint = "";
			tbxBlood.Location = new Point(408, 256);
			tbxBlood.MaxLength = 32767;
			tbxBlood.Multiline = false;
			tbxBlood.Name = "tbxBlood";
			tbxBlood.PasswordChar = '\0';
			tbxBlood.ScrollBars = ScrollBars.None;
			tbxBlood.SelectedText = "";
			tbxBlood.SelectionLength = 0;
			tbxBlood.SelectionStart = 0;
			tbxBlood.Size = new Size(349, 41);
			tbxBlood.TabIndex = 88;
			tbxBlood.TabStop = false;
			tbxBlood.UseSystemPasswordChar = false;
			// 
			// tbxPriority
			// 
			tbxPriority.BackColor = Color.White;
			tbxPriority.BaseColor = Color.FromArgb(253, 211, 211);
			tbxPriority.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxPriority.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxPriority.Enabled = false;
			tbxPriority.Font = new Font("Bahnschrift", 15F);
			tbxPriority.ForeColor = Color.FromArgb(216, 85, 101);
			tbxPriority.Hint = "";
			tbxPriority.Location = new Point(408, 303);
			tbxPriority.MaxLength = 32767;
			tbxPriority.Multiline = false;
			tbxPriority.Name = "tbxPriority";
			tbxPriority.PasswordChar = '\0';
			tbxPriority.ScrollBars = ScrollBars.None;
			tbxPriority.SelectedText = "";
			tbxPriority.SelectionLength = 0;
			tbxPriority.SelectionStart = 0;
			tbxPriority.Size = new Size(349, 41);
			tbxPriority.TabIndex = 89;
			tbxPriority.TabStop = false;
			tbxPriority.UseSystemPasswordChar = false;
			// 
			// tbxQuantity
			// 
			tbxQuantity.BackColor = Color.White;
			tbxQuantity.BaseColor = Color.FromArgb(253, 211, 211);
			tbxQuantity.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxQuantity.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxQuantity.Enabled = false;
			tbxQuantity.Font = new Font("Bahnschrift", 15F);
			tbxQuantity.ForeColor = Color.FromArgb(216, 85, 101);
			tbxQuantity.Hint = "";
			tbxQuantity.Location = new Point(408, 350);
			tbxQuantity.MaxLength = 32767;
			tbxQuantity.Multiline = false;
			tbxQuantity.Name = "tbxQuantity";
			tbxQuantity.PasswordChar = '\0';
			tbxQuantity.ScrollBars = ScrollBars.None;
			tbxQuantity.SelectedText = "";
			tbxQuantity.SelectionLength = 0;
			tbxQuantity.SelectionStart = 0;
			tbxQuantity.Size = new Size(180, 41);
			tbxQuantity.TabIndex = 90;
			tbxQuantity.TabStop = false;
			tbxQuantity.UseSystemPasswordChar = false;
			// 
			// lblPriority
			// 
			lblPriority.AutoSize = true;
			lblPriority.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblPriority.ForeColor = Color.FromArgb(216, 85, 101);
			lblPriority.Location = new Point(291, 306);
			lblPriority.Name = "lblPriority";
			lblPriority.Padding = new Padding(5, 0, 0, 5);
			lblPriority.Size = new Size(111, 38);
			lblPriority.TabIndex = 91;
			lblPriority.Text = "Priority";
			// 
			// cmbxPatient
			// 
			cmbxPatient.BackColor = Color.White;
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
			cmbxPatient.Location = new Point(408, 148);
			cmbxPatient.Name = "cmbxPatient";
			cmbxPatient.Size = new Size(349, 41);
			cmbxPatient.StartIndex = 0;
			cmbxPatient.TabIndex = 92;
			cmbxPatient.SelectedIndexChanged += cmbxPatient_SelectedIndexChanged;
			// 
			// tbxBirthdate
			// 
			tbxBirthdate.BackColor = Color.White;
			tbxBirthdate.BaseColor = Color.FromArgb(253, 211, 211);
			tbxBirthdate.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxBirthdate.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxBirthdate.Enabled = false;
			tbxBirthdate.Font = new Font("Bahnschrift", 15F);
			tbxBirthdate.ForeColor = Color.FromArgb(216, 85, 101);
			tbxBirthdate.Hint = "";
			tbxBirthdate.Location = new Point(408, 195);
			tbxBirthdate.MaxLength = 32767;
			tbxBirthdate.Multiline = false;
			tbxBirthdate.Name = "tbxBirthdate";
			tbxBirthdate.PasswordChar = '\0';
			tbxBirthdate.ScrollBars = ScrollBars.None;
			tbxBirthdate.SelectedText = "";
			tbxBirthdate.SelectionLength = 0;
			tbxBirthdate.SelectionStart = 0;
			tbxBirthdate.Size = new Size(349, 41);
			tbxBirthdate.TabIndex = 93;
			tbxBirthdate.TabStop = false;
			tbxBirthdate.UseSystemPasswordChar = false;
			// 
			// HospitalTransfusion
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(tbxBirthdate);
			Controls.Add(lblPriority);
			Controls.Add(lblResult);
			Controls.Add(lblUnit);
			Controls.Add(btnAvailability);
			Controls.Add(btnTransfusion);
			Controls.Add(lblQuantity);
			Controls.Add(lblPatient);
			Controls.Add(lblBlood);
			Controls.Add(lblPhysician);
			Controls.Add(cmbxPhysician);
			Controls.Add(tbxBlood);
			Controls.Add(tbxPriority);
			Controls.Add(tbxQuantity);
			Controls.Add(cmbxPatient);
			Name = "HospitalTransfusion";
			Size = new Size(1020, 641);
			Load += HospitalTransfusion_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private AntdUI.Button btnAvailability;
		private AntdUI.Button btnTransfusion;
		private Label lblQuantity;
		private Label lblPatient;
		private ReaLTaiizor.Controls.BigTextBox tbxPhysician;
		private Label lblBlood;
		private Label lblPhysician;
		private Label lblUnit;
		private Label lblResult;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxPhysician;
		private ReaLTaiizor.Controls.HopeTextBox tbxBlood;
		private ReaLTaiizor.Controls.HopeTextBox tbxPriority;
		private ReaLTaiizor.Controls.HopeTextBox tbxQuantity;
		private Label lblPriority;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxPatient;
		private ReaLTaiizor.Controls.HopeTextBox tbxBirthdate;
	}
}
