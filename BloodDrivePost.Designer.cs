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
			btnPost = new AntdUI.Button();
			tlpPost = new TableLayoutPanel();
			lblTitle = new Label();
			tbxTitle = new ReaLTaiizor.Controls.HopeTextBox();
			tbxDescription = new ReaLTaiizor.Controls.HopeTextBox();
			cmbxCity = new ReaLTaiizor.Controls.DungeonComboBox();
			cmbxBarangay = new ReaLTaiizor.Controls.DungeonComboBox();
			tlpPost.SuspendLayout();
			SuspendLayout();
			// 
			// btnPost
			// 
			btnPost.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnPost.DefaultBack = Color.FromArgb(236, 124, 132);
			btnPost.Font = new Font("Bahnschrift", 14F);
			btnPost.ForeColor = Color.FromArgb(252, 228, 228);
			btnPost.Location = new Point(303, 538);
			btnPost.Name = "btnPost";
			btnPost.Size = new Size(289, 45);
			btnPost.TabIndex = 17;
			btnPost.Text = "Post a Blood Donation Drive";
			// 
			// tlpPost
			// 
			tlpPost.ColumnCount = 2;
			tlpPost.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPost.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPost.Controls.Add(lblTitle, 0, 0);
			tlpPost.Controls.Add(btnPost, 1, 9);
			tlpPost.Controls.Add(tbxTitle, 0, 1);
			tlpPost.Controls.Add(tbxDescription, 0, 2);
			tlpPost.Controls.Add(cmbxCity, 0, 7);
			tlpPost.Controls.Add(cmbxBarangay, 1, 7);
			tlpPost.Location = new Point(3, 3);
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
			tlpPost.Size = new Size(600, 591);
			tlpPost.TabIndex = 18;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Dock = DockStyle.Fill;
			lblTitle.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblTitle.ForeColor = Color.FromArgb(216, 85, 101);
			lblTitle.Location = new Point(8, 5);
			lblTitle.Name = "lblTitle";
			lblTitle.Padding = new Padding(5, 0, 0, 5);
			lblTitle.Size = new Size(289, 58);
			lblTitle.TabIndex = 76;
			lblTitle.Text = "Title";
			lblTitle.TextAlign = ContentAlignment.BottomLeft;
			// 
			// tbxTitle
			// 
			tbxTitle.BackColor = Color.White;
			tbxTitle.BaseColor = Color.FromArgb(252, 228, 228);
			tbxTitle.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxTitle.BorderColorB = Color.FromArgb(216, 85, 101);
			tlpPost.SetColumnSpan(tbxTitle, 2);
			tbxTitle.Dock = DockStyle.Fill;
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
			tbxTitle.Size = new Size(584, 52);
			tbxTitle.TabIndex = 93;
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
			tbxDescription.Dock = DockStyle.Fill;
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
			tbxDescription.Size = new Size(584, 110);
			tbxDescription.TabIndex = 95;
			tbxDescription.TabStop = false;
			tbxDescription.Text = "Description";
			tbxDescription.UseSystemPasswordChar = false;
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
			cmbxBarangay.Location = new Point(303, 414);
			cmbxBarangay.Name = "cmbxBarangay";
			cmbxBarangay.Size = new Size(289, 41);
			cmbxBarangay.StartIndex = 0;
			cmbxBarangay.TabIndex = 98;
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

		private AntdUI.Button btnPost;
		private TableLayoutPanel tlpPost;
		private Label lblTitle;
		private ReaLTaiizor.Controls.HopeTextBox tbxTitle;
		private Label lblDescription;
		private ReaLTaiizor.Controls.HopeTextBox tbxDescription;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxCity;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxBarangay;
	}
}
