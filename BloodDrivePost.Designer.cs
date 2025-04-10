namespace Hemotica
{
	partial class BloodDrivePost
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
			tlpPost = new TableLayoutPanel();
			tbxTime = new ReaLTaiizor.Controls.HopeTextBox();
			tbxDate = new ReaLTaiizor.Controls.HopeTextBox();
			lblTitle = new Label();
			cmbxCity = new ReaLTaiizor.Controls.DungeonComboBox();
			cmbxBarangay = new ReaLTaiizor.Controls.DungeonComboBox();
			lblDate = new Label();
			lblLocation = new Label();
			lblTime = new Label();
			tbxTitle = new ReaLTaiizor.Controls.HopeTextBox();
			tbxDescription = new ReaLTaiizor.Controls.HopeTextBox();
			btnNext = new AntdUI.Button();
			tlpPost.SuspendLayout();
			SuspendLayout();
			// 
			// tlpPost
			// 
			tlpPost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tlpPost.ColumnCount = 2;
			tlpPost.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPost.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPost.Controls.Add(tbxTime, 1, 5);
			tlpPost.Controls.Add(tbxDate, 0, 5);
			tlpPost.Controls.Add(lblTitle, 0, 0);
			tlpPost.Controls.Add(cmbxCity, 0, 7);
			tlpPost.Controls.Add(cmbxBarangay, 1, 7);
			tlpPost.Controls.Add(lblDate, 0, 4);
			tlpPost.Controls.Add(lblLocation, 0, 6);
			tlpPost.Controls.Add(lblTime, 1, 4);
			tlpPost.Controls.Add(tbxTitle, 0, 1);
			tlpPost.Controls.Add(tbxDescription, 0, 2);
			tlpPost.Controls.Add(btnNext, 1, 9);
			tlpPost.Location = new Point(0, 0);
			tlpPost.Name = "tlpPost";
			tlpPost.Padding = new Padding(5);
			tlpPost.RowCount = 10;
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.Size = new Size(606, 597);
			tlpPost.TabIndex = 18;
			// 
			// tbxTime
			// 
			tbxTime.BackColor = Color.White;
			tbxTime.BaseColor = Color.FromArgb(252, 228, 228);
			tbxTime.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxTime.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxTime.Dock = DockStyle.Fill;
			tbxTime.Enabled = false;
			tbxTime.Font = new Font("Bahnschrift", 15F);
			tbxTime.ForeColor = Color.FromArgb(216, 85, 101);
			tbxTime.Hint = "";
			tbxTime.Location = new Point(306, 298);
			tbxTime.MaxLength = 32767;
			tbxTime.Multiline = false;
			tbxTime.Name = "tbxTime";
			tbxTime.PasswordChar = '\0';
			tbxTime.ScrollBars = ScrollBars.None;
			tbxTime.SelectedText = "";
			tbxTime.SelectionLength = 0;
			tbxTime.SelectionStart = 0;
			tbxTime.Size = new Size(292, 52);
			tbxTime.TabIndex = 107;
			tbxTime.TabStop = false;
			tbxTime.Text = "HH:MM (24-HOUR FORMAT)";
			tbxTime.UseSystemPasswordChar = false;
			// 
			// tbxDate
			// 
			tbxDate.BackColor = Color.White;
			tbxDate.BaseColor = Color.FromArgb(252, 228, 228);
			tbxDate.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxDate.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxDate.Enabled = false;
			tbxDate.Font = new Font("Bahnschrift", 15F);
			tbxDate.ForeColor = Color.FromArgb(216, 85, 101);
			tbxDate.Hint = "";
			tbxDate.Location = new Point(8, 298);
			tbxDate.MaxLength = 32767;
			tbxDate.Multiline = false;
			tbxDate.Name = "tbxDate";
			tbxDate.PasswordChar = '\0';
			tbxDate.ScrollBars = ScrollBars.None;
			tbxDate.SelectedText = "";
			tbxDate.SelectionLength = 0;
			tbxDate.SelectionStart = 0;
			tbxDate.Size = new Size(292, 41);
			tbxDate.TabIndex = 106;
			tbxDate.TabStop = false;
			tbxDate.Text = "MM/DD/YYYY";
			tbxDate.UseSystemPasswordChar = false;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			tlpPost.SetColumnSpan(lblTitle, 2);
			lblTitle.Dock = DockStyle.Fill;
			lblTitle.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblTitle.ForeColor = Color.FromArgb(216, 85, 101);
			lblTitle.Location = new Point(8, 5);
			lblTitle.Name = "lblTitle";
			lblTitle.Padding = new Padding(5, 0, 0, 5);
			lblTitle.Size = new Size(590, 58);
			lblTitle.TabIndex = 76;
			lblTitle.Text = "Title";
			lblTitle.TextAlign = ContentAlignment.BottomLeft;
			// 
			// cmbxCity
			// 
			cmbxCity.BackColor = Color.White;
			cmbxCity.ColorA = Color.FromArgb(236, 124, 132);
			cmbxCity.ColorB = Color.FromArgb(236, 124, 132);
			cmbxCity.ColorC = Color.FromArgb(242, 241, 240);
			cmbxCity.ColorD = Color.FromArgb(253, 252, 252);
			cmbxCity.ColorE = Color.FromArgb(239, 237, 236);
			cmbxCity.ColorF = Color.FromArgb(216, 85, 101);
			cmbxCity.ColorG = Color.FromArgb(216, 85, 101);
			cmbxCity.ColorH = Color.FromArgb(244, 180, 180);
			cmbxCity.ColorI = Color.FromArgb(250, 249, 249);
			cmbxCity.DrawMode = DrawMode.OwnerDrawFixed;
			cmbxCity.DropDownHeight = 100;
			cmbxCity.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbxCity.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			cmbxCity.ForeColor = Color.FromArgb(216, 85, 101);
			cmbxCity.FormattingEnabled = true;
			cmbxCity.HoverSelectionColor = Color.Empty;
			cmbxCity.IntegralHeight = false;
			cmbxCity.ItemHeight = 35;
			cmbxCity.Items.AddRange(new object[] { "Select city", "Alcantara", "Alcoy", "Alegria", "Aloguinsan", "Argao", "Asturias", "Badian", "Balamban", "Bantayan", "Barili", "Bogo City", "Boljoon", "Borbon", "Carcar City", "Carmen", "Catmon", "Cebu City", "Compostela", "Consolacion", "Cordova", "Daanbantayan", "Dalaguete", "Danao City", "Dumanjug", "Ginatilan", "Lapu-Lapu City", "Liloan", "Madridejos", "Malabuyoc", "Mandaue City", "Medellin", "Minglanilla", "Moalboal", "Naga City", "Oslob", "Pilar", "Pinamungahan", "Poro", "Ronda", "Samboan", "San Fernando", "San Francisco", "San Remigio", "Santa Fe", "Santander", "Sibonga", "Sogod", "Tabogon", "Tabuelan", "Talisay City", "Toledo City", "Tuburan", "Tudela" });
			cmbxCity.Location = new Point(8, 414);
			cmbxCity.Name = "cmbxCity";
			cmbxCity.Size = new Size(289, 41);
			cmbxCity.StartIndex = 0;
			cmbxCity.TabIndex = 97;
			// 
			// cmbxBarangay
			// 
			cmbxBarangay.BackColor = Color.White;
			cmbxBarangay.ColorA = Color.FromArgb(236, 124, 132);
			cmbxBarangay.ColorB = Color.FromArgb(236, 124, 132);
			cmbxBarangay.ColorC = Color.FromArgb(242, 241, 240);
			cmbxBarangay.ColorD = Color.FromArgb(253, 252, 252);
			cmbxBarangay.ColorE = Color.FromArgb(239, 237, 236);
			cmbxBarangay.ColorF = Color.FromArgb(216, 85, 101);
			cmbxBarangay.ColorG = Color.FromArgb(216, 85, 101);
			cmbxBarangay.ColorH = Color.FromArgb(244, 180, 180);
			cmbxBarangay.ColorI = Color.FromArgb(250, 249, 249);
			cmbxBarangay.DrawMode = DrawMode.OwnerDrawFixed;
			cmbxBarangay.DropDownHeight = 100;
			cmbxBarangay.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbxBarangay.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			cmbxBarangay.ForeColor = Color.FromArgb(216, 85, 101);
			cmbxBarangay.FormattingEnabled = true;
			cmbxBarangay.HoverSelectionColor = Color.Empty;
			cmbxBarangay.IntegralHeight = false;
			cmbxBarangay.ItemHeight = 35;
			cmbxBarangay.Location = new Point(306, 414);
			cmbxBarangay.Name = "cmbxBarangay";
			cmbxBarangay.Size = new Size(289, 41);
			cmbxBarangay.StartIndex = 0;
			cmbxBarangay.TabIndex = 98;
			// 
			// lblDate
			// 
			lblDate.AutoSize = true;
			lblDate.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblDate.ForeColor = Color.FromArgb(216, 85, 101);
			lblDate.Location = new Point(8, 237);
			lblDate.Name = "lblDate";
			lblDate.Padding = new Padding(5, 0, 0, 5);
			lblDate.Size = new Size(75, 38);
			lblDate.TabIndex = 101;
			lblDate.Text = "Date";
			lblDate.TextAlign = ContentAlignment.BottomLeft;
			// 
			// lblLocation
			// 
			lblLocation.AutoSize = true;
			tlpPost.SetColumnSpan(lblLocation, 2);
			lblLocation.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblLocation.ForeColor = Color.FromArgb(216, 85, 101);
			lblLocation.Location = new Point(8, 353);
			lblLocation.Name = "lblLocation";
			lblLocation.Padding = new Padding(5, 0, 0, 5);
			lblLocation.Size = new Size(123, 38);
			lblLocation.TabIndex = 102;
			lblLocation.Text = "Location";
			lblLocation.TextAlign = ContentAlignment.BottomLeft;
			// 
			// lblTime
			// 
			lblTime.AutoSize = true;
			lblTime.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblTime.ForeColor = Color.FromArgb(216, 85, 101);
			lblTime.Location = new Point(306, 237);
			lblTime.Name = "lblTime";
			lblTime.Padding = new Padding(5, 0, 0, 5);
			lblTime.Size = new Size(77, 38);
			lblTime.TabIndex = 103;
			lblTime.Text = "Time";
			lblTime.TextAlign = ContentAlignment.BottomLeft;
			// 
			// tbxTitle
			// 
			tbxTitle.BackColor = Color.White;
			tbxTitle.BaseColor = Color.FromArgb(252, 228, 228);
			tbxTitle.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxTitle.BorderColorB = Color.FromArgb(216, 85, 101);
			tlpPost.SetColumnSpan(tbxTitle, 2);
			tbxTitle.Enabled = false;
			tbxTitle.Font = new Font("Bahnschrift", 15F);
			tbxTitle.ForeColor = Color.FromArgb(216, 85, 101);
			tbxTitle.Hint = "";
			tbxTitle.Location = new Point(8, 66);
			tbxTitle.MaxLength = 32767;
			tbxTitle.Multiline = false;
			tbxTitle.Name = "tbxTitle";
			tbxTitle.PasswordChar = '\0';
			tbxTitle.ScrollBars = ScrollBars.None;
			tbxTitle.SelectedText = "";
			tbxTitle.SelectionLength = 0;
			tbxTitle.SelectionStart = 0;
			tbxTitle.Size = new Size(590, 41);
			tbxTitle.TabIndex = 104;
			tbxTitle.TabStop = false;
			tbxTitle.UseSystemPasswordChar = false;
			// 
			// tbxDescription
			// 
			tbxDescription.BackColor = Color.White;
			tbxDescription.BaseColor = Color.FromArgb(252, 228, 228);
			tbxDescription.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxDescription.BorderColorB = Color.FromArgb(216, 85, 101);
			tlpPost.SetColumnSpan(tbxDescription, 2);
			tbxDescription.Enabled = false;
			tbxDescription.Font = new Font("Bahnschrift", 15F);
			tbxDescription.ForeColor = Color.FromArgb(216, 85, 101);
			tbxDescription.Hint = "";
			tbxDescription.Location = new Point(8, 124);
			tbxDescription.MaxLength = 32767;
			tbxDescription.Multiline = true;
			tbxDescription.Name = "tbxDescription";
			tbxDescription.PasswordChar = '\0';
			tlpPost.SetRowSpan(tbxDescription, 2);
			tbxDescription.ScrollBars = ScrollBars.None;
			tbxDescription.SelectedText = "";
			tbxDescription.SelectionLength = 0;
			tbxDescription.SelectionStart = 0;
			tbxDescription.Size = new Size(590, 110);
			tbxDescription.TabIndex = 105;
			tbxDescription.TabStop = false;
			tbxDescription.Text = "Description";
			tbxDescription.UseSystemPasswordChar = false;
			// 
			// btnNext
			// 
			btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnNext.DefaultBack = Color.FromArgb(236, 124, 132);
			btnNext.Font = new Font("Bahnschrift", 14F);
			btnNext.ForeColor = Color.FromArgb(252, 228, 228);
			btnNext.Location = new Point(453, 544);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(145, 45);
			btnNext.TabIndex = 108;
			btnNext.Text = "Next";
			// 
			// BloodDrivePost
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(252, 196, 196);
			Controls.Add(tlpPost);
			Name = "BloodDrivePost";
			Size = new Size(606, 597);
			tlpPost.ResumeLayout(false);
			tlpPost.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private TableLayoutPanel tlpPost;
		private Label lblTitle;
		private Label lblDescription;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxCity;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxBarangay;
		private DateTimePicker dtpAppointments;
		private Label lblDate;
		private Label lblLocation;
		private Label lblTime;
		private ReaLTaiizor.Controls.HopeTextBox tbxTitle;
		private ReaLTaiizor.Controls.HopeTextBox tbxDescription;
		private ReaLTaiizor.Controls.HopeTextBox tbxDate;
		private ReaLTaiizor.Controls.HopeTextBox tbxTime;
		private AntdUI.Button btnNext;
	}
}
