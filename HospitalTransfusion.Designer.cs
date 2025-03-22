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
			tbxAddress = new ReaLTaiizor.Controls.BigTextBox();
			lblQuantity = new Label();
			tbxBType = new ReaLTaiizor.Controls.BigTextBox();
			tbxPatientName = new ReaLTaiizor.Controls.BigTextBox();
			lblPatientName = new Label();
			tbxPhysician = new ReaLTaiizor.Controls.BigTextBox();
			tbxPatientID = new ReaLTaiizor.Controls.BigTextBox();
			dPatientID = new Label();
			lblBType = new Label();
			lblPhysician = new Label();
			lblUnit = new Label();
			lblResult = new Label();
			SuspendLayout();
			// 
			// btnAvailability
			// 
			btnAvailability.DefaultBack = Color.FromArgb(236, 124, 132);
			btnAvailability.Font = new Font("Bahnschrift", 14F);
			btnAvailability.ForeColor = Color.FromArgb(252, 228, 228);
			btnAvailability.Location = new Point(321, 409);
			btnAvailability.Name = "btnAvailability";
			btnAvailability.Size = new Size(187, 52);
			btnAvailability.TabIndex = 68;
			btnAvailability.Text = "Check Availability";
			// 
			// btnTransfusion
			// 
			btnTransfusion.DefaultBack = Color.FromArgb(236, 124, 132);
			btnTransfusion.Font = new Font("Bahnschrift", 14F);
			btnTransfusion.ForeColor = Color.FromArgb(252, 228, 228);
			btnTransfusion.Location = new Point(514, 409);
			btnTransfusion.Name = "btnTransfusion";
			btnTransfusion.Size = new Size(187, 52);
			btnTransfusion.TabIndex = 67;
			btnTransfusion.Text = "Blood Transfer";
			// 
			// tbxAddress
			// 
			tbxAddress.BackColor = Color.Transparent;
			tbxAddress.Font = new Font("Tahoma", 11F);
			tbxAddress.ForeColor = Color.DimGray;
			tbxAddress.Image = null;
			tbxAddress.Location = new Point(430, 312);
			tbxAddress.MaxLength = 32767;
			tbxAddress.Multiline = false;
			tbxAddress.Name = "tbxAddress";
			tbxAddress.ReadOnly = false;
			tbxAddress.Size = new Size(180, 41);
			tbxAddress.TabIndex = 60;
			tbxAddress.TextAlignment = HorizontalAlignment.Left;
			tbxAddress.UseSystemPasswordChar = false;
			// 
			// lblQuantity
			// 
			lblQuantity.AutoSize = true;
			lblQuantity.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblQuantity.ForeColor = Color.FromArgb(216, 85, 101);
			lblQuantity.Location = new Point(304, 315);
			lblQuantity.Name = "lblQuantity";
			lblQuantity.Padding = new Padding(5, 0, 0, 5);
			lblQuantity.Size = new Size(120, 38);
			lblQuantity.TabIndex = 59;
			lblQuantity.Text = "Quantity";
			// 
			// tbxBType
			// 
			tbxBType.BackColor = Color.Transparent;
			tbxBType.Font = new Font("Tahoma", 11F);
			tbxBType.ForeColor = Color.DimGray;
			tbxBType.Image = null;
			tbxBType.Location = new Point(430, 265);
			tbxBType.MaxLength = 32767;
			tbxBType.Multiline = false;
			tbxBType.Name = "tbxBType";
			tbxBType.ReadOnly = false;
			tbxBType.Size = new Size(349, 41);
			tbxBType.TabIndex = 58;
			tbxBType.TextAlignment = HorizontalAlignment.Left;
			tbxBType.UseSystemPasswordChar = false;
			// 
			// tbxPatientName
			// 
			tbxPatientName.BackColor = Color.Transparent;
			tbxPatientName.Font = new Font("Tahoma", 11F);
			tbxPatientName.ForeColor = Color.DimGray;
			tbxPatientName.Image = null;
			tbxPatientName.Location = new Point(430, 218);
			tbxPatientName.MaxLength = 32767;
			tbxPatientName.Multiline = false;
			tbxPatientName.Name = "tbxPatientName";
			tbxPatientName.ReadOnly = false;
			tbxPatientName.Size = new Size(349, 41);
			tbxPatientName.TabIndex = 56;
			tbxPatientName.TextAlignment = HorizontalAlignment.Left;
			tbxPatientName.UseSystemPasswordChar = false;
			// 
			// lblPatientName
			// 
			lblPatientName.AutoSize = true;
			lblPatientName.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblPatientName.ForeColor = Color.FromArgb(216, 85, 101);
			lblPatientName.Location = new Point(243, 221);
			lblPatientName.Name = "lblPatientName";
			lblPatientName.Padding = new Padding(5, 0, 0, 5);
			lblPatientName.Size = new Size(181, 38);
			lblPatientName.TabIndex = 55;
			lblPatientName.Text = "Patient Name";
			// 
			// tbxPhysician
			// 
			tbxPhysician.BackColor = Color.Transparent;
			tbxPhysician.Font = new Font("Tahoma", 11F);
			tbxPhysician.ForeColor = Color.DimGray;
			tbxPhysician.Image = null;
			tbxPhysician.Location = new Point(430, 100);
			tbxPhysician.MaxLength = 32767;
			tbxPhysician.Multiline = false;
			tbxPhysician.Name = "tbxPhysician";
			tbxPhysician.ReadOnly = false;
			tbxPhysician.Size = new Size(349, 41);
			tbxPhysician.TabIndex = 54;
			tbxPhysician.TextAlignment = HorizontalAlignment.Left;
			tbxPhysician.UseSystemPasswordChar = false;
			// 
			// tbxPatientID
			// 
			tbxPatientID.BackColor = Color.Transparent;
			tbxPatientID.Font = new Font("Tahoma", 11F);
			tbxPatientID.ForeColor = Color.DimGray;
			tbxPatientID.Image = null;
			tbxPatientID.Location = new Point(430, 171);
			tbxPatientID.MaxLength = 32767;
			tbxPatientID.Multiline = false;
			tbxPatientID.Name = "tbxPatientID";
			tbxPatientID.ReadOnly = false;
			tbxPatientID.Size = new Size(349, 41);
			tbxPatientID.TabIndex = 52;
			tbxPatientID.TextAlignment = HorizontalAlignment.Left;
			tbxPatientID.UseSystemPasswordChar = false;
			// 
			// dPatientID
			// 
			dPatientID.AutoSize = true;
			dPatientID.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			dPatientID.ForeColor = Color.FromArgb(216, 85, 101);
			dPatientID.Location = new Point(288, 174);
			dPatientID.Name = "dPatientID";
			dPatientID.Padding = new Padding(5, 0, 0, 5);
			dPatientID.Size = new Size(136, 38);
			dPatientID.TabIndex = 51;
			dPatientID.Text = "Patient ID";
			// 
			// lblBType
			// 
			lblBType.AutoSize = true;
			lblBType.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblBType.ForeColor = Color.FromArgb(216, 85, 101);
			lblBType.Location = new Point(273, 268);
			lblBType.Name = "lblBType";
			lblBType.Padding = new Padding(5, 0, 0, 5);
			lblBType.Size = new Size(151, 38);
			lblBType.TabIndex = 57;
			lblBType.Text = "Blood Type";
			// 
			// lblPhysician
			// 
			lblPhysician.AutoSize = true;
			lblPhysician.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblPhysician.ForeColor = Color.FromArgb(216, 85, 101);
			lblPhysician.Location = new Point(289, 103);
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
			lblUnit.Location = new Point(616, 315);
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
			lblResult.Location = new Point(445, 511);
			lblResult.Name = "lblResult";
			lblResult.Padding = new Padding(5, 0, 0, 5);
			lblResult.Size = new Size(129, 38);
			lblResult.TabIndex = 70;
			lblResult.Text = "<results>";
			// 
			// HospitalTransfusion
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(lblResult);
			Controls.Add(lblUnit);
			Controls.Add(btnAvailability);
			Controls.Add(btnTransfusion);
			Controls.Add(tbxAddress);
			Controls.Add(lblQuantity);
			Controls.Add(tbxBType);
			Controls.Add(tbxPatientName);
			Controls.Add(lblPatientName);
			Controls.Add(tbxPatientID);
			Controls.Add(dPatientID);
			Controls.Add(lblBType);
			Controls.Add(tbxPhysician);
			Controls.Add(lblPhysician);
			Name = "HospitalTransfusion";
			Size = new Size(1020, 641);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private AntdUI.Button btnAvailability;
		private AntdUI.Button btnTransfusion;
		private ReaLTaiizor.Controls.BigTextBox tbxAddress;
		private Label lblQuantity;
		private ReaLTaiizor.Controls.BigTextBox tbxBType;
		private ReaLTaiizor.Controls.BigTextBox tbxPatientName;
		private Label lblPatientName;
		private ReaLTaiizor.Controls.BigTextBox tbxPhysician;
		private ReaLTaiizor.Controls.BigTextBox tbxPatientID;
		private Label dPatientID;
		private Label lblBType;
		private Label lblPhysician;
		private Label lblUnit;
		private Label lblResult;
	}
}
