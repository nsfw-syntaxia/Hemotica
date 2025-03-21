namespace Hemotica
{
	partial class HospitalT
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
			lblPatientID = new Label();
			tbxPatientID = new ReaLTaiizor.Controls.BigTextBox();
			lblPatientName = new Label();
			tbxPatientName = new ReaLTaiizor.Controls.BigTextBox();
			tbxBloodType = new ReaLTaiizor.Controls.BigTextBox();
			lblBloodType = new Label();
			lblQuantity = new Label();
			tbxQuantity = new ReaLTaiizor.Controls.BigTextBox();
			btnSearch = new AntdUI.Button();
			lblResult = new Label();
			btnTransfer = new AntdUI.Button();
			SuspendLayout();
			// 
			// lblPatientID
			// 
			lblPatientID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblPatientID.AutoSize = true;
			lblPatientID.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblPatientID.ForeColor = Color.FromArgb(216, 85, 101);
			lblPatientID.Location = new Point(24, 33);
			lblPatientID.Name = "lblPatientID";
			lblPatientID.Padding = new Padding(5, 0, 0, 5);
			lblPatientID.Size = new Size(169, 46);
			lblPatientID.TabIndex = 11;
			lblPatientID.Text = "Patient ID";
			// 
			// tbxPatientID
			// 
			tbxPatientID.BackColor = Color.Transparent;
			tbxPatientID.Font = new Font("Tahoma", 11F);
			tbxPatientID.ForeColor = Color.DimGray;
			tbxPatientID.Image = null;
			tbxPatientID.Location = new Point(257, 33);
			tbxPatientID.MaxLength = 32767;
			tbxPatientID.Multiline = false;
			tbxPatientID.Name = "tbxPatientID";
			tbxPatientID.ReadOnly = false;
			tbxPatientID.Size = new Size(349, 41);
			tbxPatientID.TabIndex = 12;
			tbxPatientID.TextAlignment = HorizontalAlignment.Left;
			tbxPatientID.UseSystemPasswordChar = false;
			// 
			// lblPatientName
			// 
			lblPatientName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblPatientName.AutoSize = true;
			lblPatientName.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblPatientName.ForeColor = Color.FromArgb(216, 85, 101);
			lblPatientName.Location = new Point(24, 95);
			lblPatientName.Name = "lblPatientName";
			lblPatientName.Padding = new Padding(5, 0, 0, 5);
			lblPatientName.Size = new Size(227, 46);
			lblPatientName.TabIndex = 13;
			lblPatientName.Text = "Patient Name";
			// 
			// tbxPatientName
			// 
			tbxPatientName.BackColor = Color.Transparent;
			tbxPatientName.Font = new Font("Tahoma", 11F);
			tbxPatientName.ForeColor = Color.DimGray;
			tbxPatientName.Image = null;
			tbxPatientName.Location = new Point(257, 95);
			tbxPatientName.MaxLength = 32767;
			tbxPatientName.Multiline = false;
			tbxPatientName.Name = "tbxPatientName";
			tbxPatientName.ReadOnly = false;
			tbxPatientName.Size = new Size(349, 41);
			tbxPatientName.TabIndex = 14;
			tbxPatientName.TextAlignment = HorizontalAlignment.Left;
			tbxPatientName.UseSystemPasswordChar = false;
			// 
			// tbxBloodType
			// 
			tbxBloodType.BackColor = Color.Transparent;
			tbxBloodType.Font = new Font("Tahoma", 11F);
			tbxBloodType.ForeColor = Color.DimGray;
			tbxBloodType.Image = null;
			tbxBloodType.Location = new Point(257, 162);
			tbxBloodType.MaxLength = 32767;
			tbxBloodType.Multiline = false;
			tbxBloodType.Name = "tbxBloodType";
			tbxBloodType.ReadOnly = false;
			tbxBloodType.Size = new Size(349, 41);
			tbxBloodType.TabIndex = 19;
			tbxBloodType.TextAlignment = HorizontalAlignment.Left;
			tbxBloodType.UseSystemPasswordChar = false;
			// 
			// lblBloodType
			// 
			lblBloodType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblBloodType.AutoSize = true;
			lblBloodType.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblBloodType.ForeColor = Color.FromArgb(216, 85, 101);
			lblBloodType.Location = new Point(24, 162);
			lblBloodType.Name = "lblBloodType";
			lblBloodType.Padding = new Padding(5, 0, 0, 5);
			lblBloodType.Size = new Size(187, 46);
			lblBloodType.TabIndex = 18;
			lblBloodType.Text = "Blood Type";
			// 
			// lblQuantity
			// 
			lblQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblQuantity.AutoSize = true;
			lblQuantity.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblQuantity.ForeColor = Color.FromArgb(216, 85, 101);
			lblQuantity.Location = new Point(24, 229);
			lblQuantity.Name = "lblQuantity";
			lblQuantity.Padding = new Padding(5, 0, 0, 5);
			lblQuantity.Size = new Size(148, 46);
			lblQuantity.TabIndex = 21;
			lblQuantity.Text = "Quantity";
			// 
			// tbxQuantity
			// 
			tbxQuantity.BackColor = Color.Transparent;
			tbxQuantity.Font = new Font("Tahoma", 11F);
			tbxQuantity.ForeColor = Color.DimGray;
			tbxQuantity.Image = null;
			tbxQuantity.Location = new Point(257, 229);
			tbxQuantity.MaxLength = 32767;
			tbxQuantity.Multiline = false;
			tbxQuantity.Name = "tbxQuantity";
			tbxQuantity.ReadOnly = false;
			tbxQuantity.Size = new Size(349, 41);
			tbxQuantity.TabIndex = 22;
			tbxQuantity.TextAlignment = HorizontalAlignment.Left;
			tbxQuantity.UseSystemPasswordChar = false;
			// 
			// btnSearch
			// 
			btnSearch.DefaultBack = Color.FromArgb(236, 124, 132);
			btnSearch.Font = new Font("Bahnschrift", 14F);
			btnSearch.ForeColor = Color.FromArgb(252, 228, 228);
			btnSearch.Location = new Point(257, 297);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(187, 52);
			btnSearch.TabIndex = 23;
			btnSearch.Text = "Check Availability";
			// 
			// lblResult
			// 
			lblResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblResult.AutoSize = true;
			lblResult.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblResult.ForeColor = Color.FromArgb(216, 85, 101);
			lblResult.Location = new Point(358, 402);
			lblResult.Name = "lblResult";
			lblResult.Padding = new Padding(5, 0, 0, 5);
			lblResult.Size = new Size(134, 38);
			lblResult.TabIndex = 24;
			lblResult.Text = "<Results>";
			// 
			// btnTransfer
			// 
			btnTransfer.DefaultBack = Color.FromArgb(236, 124, 132);
			btnTransfer.Font = new Font("Bahnschrift", 14F);
			btnTransfer.ForeColor = Color.FromArgb(252, 228, 228);
			btnTransfer.Location = new Point(450, 297);
			btnTransfer.Name = "btnTransfer";
			btnTransfer.Size = new Size(156, 52);
			btnTransfer.TabIndex = 25;
			btnTransfer.Text = "Blood Transfer";
			// 
			// HospitalT
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(btnTransfer);
			Controls.Add(lblResult);
			Controls.Add(btnSearch);
			Controls.Add(tbxQuantity);
			Controls.Add(lblQuantity);
			Controls.Add(tbxBloodType);
			Controls.Add(lblBloodType);
			Controls.Add(tbxPatientName);
			Controls.Add(lblPatientName);
			Controls.Add(tbxPatientID);
			Controls.Add(lblPatientID);
			Name = "HospitalT";
			Size = new Size(1020, 641);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblPatientID;
		private ReaLTaiizor.Controls.BigTextBox tbxPatientID;
		private Label lblPatientName;
		private ReaLTaiizor.Controls.BigTextBox tbxPatientName;
		private ReaLTaiizor.Controls.BigTextBox tbxBloodType;
		private Label lblBloodType;
		private Label lblQuantity;
		private ReaLTaiizor.Controls.BigTextBox tbxQuantity;
		private AntdUI.Button btnSearch;
		private Label lblResult;
		private AntdUI.Button btnTransfer;
	}
}
