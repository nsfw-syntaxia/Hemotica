namespace Hemotica
{
	partial class HospitalStock
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
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalStock));
			dgvStock = new DataGridView();
			pWarning = new Panel();
			lblNote = new Label();
			lblWarning = new Label();
			pPost = new Panel();
			tlpPost = new TableLayoutPanel();
			btnNext = new AntdUI.Button();
			cmbxBarangay = new ReaLTaiizor.Controls.DungeonComboBox();
			cmbxCity = new ReaLTaiizor.Controls.DungeonComboBox();
			tbxTime = new ReaLTaiizor.Controls.HopeTextBox();
			tbxDate = new ReaLTaiizor.Controls.HopeTextBox();
			lblLocation = new Label();
			lblTime = new Label();
			lblDate = new Label();
			tbxDescription = new ReaLTaiizor.Controls.HopeTextBox();
			tbxTitle = new ReaLTaiizor.Controls.HopeTextBox();
			lblTitle = new Label();
			pImage = new Panel();
			tlpPhoto = new TableLayoutPanel();
			btnRemove = new AntdUI.Button();
			btnAttach = new AntdUI.Button();
			btnBack = new AntdUI.Button();
			pPhoto = new Panel();
			pbxPhoto = new PictureBox();
			btnPost = new AntdUI.Button();
			lblPhoto = new Label();
			((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
			pWarning.SuspendLayout();
			pPost.SuspendLayout();
			tlpPost.SuspendLayout();
			pImage.SuspendLayout();
			tlpPhoto.SuspendLayout();
			pPhoto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxPhoto).BeginInit();
			SuspendLayout();
			// 
			// dgvStock
			// 
			dgvStock.AllowUserToAddRows = false;
			dgvStock.AllowUserToDeleteRows = false;
			dgvStock.AllowUserToResizeColumns = false;
			dgvStock.AllowUserToResizeRows = false;
			dgvStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvStock.BackgroundColor = Color.FromArgb(253, 211, 211);
			dgvStock.BorderStyle = BorderStyle.None;
			dgvStock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			dgvStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle7.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold);
			dataGridViewCellStyle7.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle7.Padding = new Padding(15, 5, 15, 5);
			dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			dgvStock.ColumnHeadersHeight = 50;
			dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvStock.EnableHeadersVisualStyles = false;
			dgvStock.GridColor = Color.FromArgb(253, 211, 211);
			dgvStock.Location = new Point(13, 18);
			dgvStock.MultiSelect = false;
			dgvStock.Name = "dgvStock";
			dgvStock.ReadOnly = true;
			dgvStock.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = SystemColors.Control;
			dataGridViewCellStyle8.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
			dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			dgvStock.RowHeadersVisible = false;
			dgvStock.RowHeadersWidth = 40;
			dataGridViewCellStyle9.BackColor = Color.FromArgb(244, 180, 180);
			dataGridViewCellStyle9.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle9.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle9.Padding = new Padding(20, 5, 20, 5);
			dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dataGridViewCellStyle9.SelectionForeColor = Color.White;
			dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle9;
			dgvStock.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(252, 196, 196);
			dgvStock.RowTemplate.DefaultCellStyle.Font = new Font("Bahnschrift", 13F);
			dgvStock.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(216, 85, 101);
			dgvStock.RowTemplate.DefaultCellStyle.Padding = new Padding(20, 5, 20, 5);
			dgvStock.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dgvStock.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
			dgvStock.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
			dgvStock.RowTemplate.DividerHeight = 3;
			dgvStock.RowTemplate.Height = 40;
			dgvStock.RowTemplate.Resizable = DataGridViewTriState.False;
			dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvStock.Size = new Size(494, 385);
			dgvStock.TabIndex = 18;
			// 
			// pWarning
			// 
			pWarning.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			pWarning.Controls.Add(lblNote);
			pWarning.Controls.Add(lblWarning);
			pWarning.Location = new Point(13, 409);
			pWarning.Name = "pWarning";
			pWarning.Padding = new Padding(10);
			pWarning.Size = new Size(494, 214);
			pWarning.TabIndex = 19;
			// 
			// lblNote
			// 
			lblNote.AutoSize = true;
			lblNote.Font = new Font("Bahnschrift", 15F);
			lblNote.ForeColor = Color.FromArgb(216, 85, 101);
			lblNote.Location = new Point(13, 59);
			lblNote.Name = "lblNote";
			lblNote.Size = new Size(119, 24);
			lblNote.TabIndex = 1;
			lblNote.Text = "ATTENTION:";
			// 
			// lblWarning
			// 
			lblWarning.AutoSize = true;
			lblWarning.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblWarning.ForeColor = Color.FromArgb(216, 85, 101);
			lblWarning.Location = new Point(13, 10);
			lblWarning.Name = "lblWarning";
			lblWarning.Size = new Size(148, 33);
			lblWarning.TabIndex = 0;
			lblWarning.Text = "WARNING !";
			// 
			// pPost
			// 
			pPost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pPost.BackColor = Color.FromArgb(252, 196, 196);
			pPost.Controls.Add(pImage);
			pPost.Controls.Add(tlpPost);
			pPost.Location = new Point(513, 18);
			pPost.Name = "pPost";
			pPost.Padding = new Padding(10);
			pPost.Size = new Size(494, 605);
			pPost.TabIndex = 20;
			// 
			// tlpPost
			// 
			tlpPost.ColumnCount = 2;
			tlpPost.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPost.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPost.Controls.Add(btnNext, 1, 9);
			tlpPost.Controls.Add(cmbxBarangay, 1, 7);
			tlpPost.Controls.Add(cmbxCity, 0, 7);
			tlpPost.Controls.Add(tbxTime, 1, 5);
			tlpPost.Controls.Add(tbxDate, 0, 5);
			tlpPost.Controls.Add(lblLocation, 0, 6);
			tlpPost.Controls.Add(lblTime, 1, 4);
			tlpPost.Controls.Add(lblDate, 0, 4);
			tlpPost.Controls.Add(tbxDescription, 0, 2);
			tlpPost.Controls.Add(tbxTitle, 0, 1);
			tlpPost.Controls.Add(lblTitle, 0, 0);
			tlpPost.Dock = DockStyle.Fill;
			tlpPost.Location = new Point(10, 10);
			tlpPost.Name = "tlpPost";
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
			tlpPost.Size = new Size(474, 585);
			tlpPost.TabIndex = 0;
			// 
			// btnNext
			// 
			btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnNext.DefaultBack = Color.FromArgb(236, 124, 132);
			btnNext.Font = new Font("Bahnschrift", 14F);
			btnNext.ForeColor = Color.FromArgb(252, 228, 228);
			btnNext.Location = new Point(326, 525);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(145, 45);
			btnNext.TabIndex = 109;
			btnNext.Text = "Next";
			btnNext.Click += btnNext_Click;
			// 
			// cmbxBarangay
			// 
			cmbxBarangay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
			cmbxBarangay.Location = new Point(240, 409);
			cmbxBarangay.Name = "cmbxBarangay";
			cmbxBarangay.Size = new Size(231, 41);
			cmbxBarangay.StartIndex = 0;
			cmbxBarangay.TabIndex = 99;
			// 
			// cmbxCity
			// 
			cmbxCity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
			cmbxCity.Location = new Point(3, 409);
			cmbxCity.Name = "cmbxCity";
			cmbxCity.Size = new Size(231, 41);
			cmbxCity.StartIndex = 0;
			cmbxCity.TabIndex = 98;
			// 
			// tbxTime
			// 
			tbxTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbxTime.BackColor = Color.White;
			tbxTime.BaseColor = Color.FromArgb(252, 228, 228);
			tbxTime.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxTime.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxTime.Enabled = false;
			tbxTime.Font = new Font("Bahnschrift", 15F);
			tbxTime.ForeColor = Color.FromArgb(216, 85, 101);
			tbxTime.Hint = "";
			tbxTime.Location = new Point(240, 293);
			tbxTime.MaxLength = 32767;
			tbxTime.Multiline = false;
			tbxTime.Name = "tbxTime";
			tbxTime.PasswordChar = '\0';
			tbxTime.ScrollBars = ScrollBars.None;
			tbxTime.SelectedText = "";
			tbxTime.SelectionLength = 0;
			tbxTime.SelectionStart = 0;
			tbxTime.Size = new Size(231, 41);
			tbxTime.TabIndex = 108;
			tbxTime.TabStop = false;
			tbxTime.Text = "HH:MM (24H FORMAT)";
			tbxTime.UseSystemPasswordChar = false;
			// 
			// tbxDate
			// 
			tbxDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbxDate.BackColor = Color.White;
			tbxDate.BaseColor = Color.FromArgb(252, 228, 228);
			tbxDate.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxDate.BorderColorB = Color.FromArgb(216, 85, 101);
			tbxDate.Enabled = false;
			tbxDate.Font = new Font("Bahnschrift", 15F);
			tbxDate.ForeColor = Color.FromArgb(216, 85, 101);
			tbxDate.Hint = "";
			tbxDate.Location = new Point(3, 293);
			tbxDate.MaxLength = 32767;
			tbxDate.Multiline = false;
			tbxDate.Name = "tbxDate";
			tbxDate.PasswordChar = '\0';
			tbxDate.ScrollBars = ScrollBars.None;
			tbxDate.SelectedText = "";
			tbxDate.SelectionLength = 0;
			tbxDate.SelectionStart = 0;
			tbxDate.Size = new Size(231, 41);
			tbxDate.TabIndex = 107;
			tbxDate.TabStop = false;
			tbxDate.Text = "MM/DD/YYYY";
			tbxDate.UseSystemPasswordChar = false;
			// 
			// lblLocation
			// 
			lblLocation.AutoSize = true;
			tlpPost.SetColumnSpan(lblLocation, 2);
			lblLocation.Dock = DockStyle.Fill;
			lblLocation.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblLocation.ForeColor = Color.FromArgb(216, 85, 101);
			lblLocation.Location = new Point(3, 348);
			lblLocation.Name = "lblLocation";
			lblLocation.Padding = new Padding(5, 0, 0, 5);
			lblLocation.Size = new Size(468, 58);
			lblLocation.TabIndex = 103;
			lblLocation.Text = "Location";
			lblLocation.TextAlign = ContentAlignment.BottomLeft;
			// 
			// lblTime
			// 
			lblTime.AutoSize = true;
			lblTime.Dock = DockStyle.Fill;
			lblTime.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblTime.ForeColor = Color.FromArgb(216, 85, 101);
			lblTime.Location = new Point(240, 232);
			lblTime.Name = "lblTime";
			lblTime.Padding = new Padding(5, 0, 0, 5);
			lblTime.Size = new Size(231, 58);
			lblTime.TabIndex = 104;
			lblTime.Text = "Time";
			lblTime.TextAlign = ContentAlignment.BottomLeft;
			// 
			// lblDate
			// 
			lblDate.AutoSize = true;
			lblDate.Dock = DockStyle.Fill;
			lblDate.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblDate.ForeColor = Color.FromArgb(216, 85, 101);
			lblDate.Location = new Point(3, 232);
			lblDate.Name = "lblDate";
			lblDate.Padding = new Padding(5, 0, 0, 5);
			lblDate.Size = new Size(231, 58);
			lblDate.TabIndex = 102;
			lblDate.Text = "Date";
			lblDate.TextAlign = ContentAlignment.BottomLeft;
			// 
			// tbxDescription
			// 
			tbxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbxDescription.BackColor = Color.White;
			tbxDescription.BaseColor = Color.FromArgb(252, 228, 228);
			tbxDescription.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxDescription.BorderColorB = Color.FromArgb(216, 85, 101);
			tlpPost.SetColumnSpan(tbxDescription, 2);
			tbxDescription.Enabled = false;
			tbxDescription.Font = new Font("Bahnschrift", 15F);
			tbxDescription.ForeColor = Color.FromArgb(216, 85, 101);
			tbxDescription.Hint = "";
			tbxDescription.Location = new Point(3, 119);
			tbxDescription.MaxLength = 32767;
			tbxDescription.Multiline = true;
			tbxDescription.Name = "tbxDescription";
			tbxDescription.PasswordChar = '\0';
			tlpPost.SetRowSpan(tbxDescription, 2);
			tbxDescription.ScrollBars = ScrollBars.None;
			tbxDescription.SelectedText = "";
			tbxDescription.SelectionLength = 0;
			tbxDescription.SelectionStart = 0;
			tbxDescription.Size = new Size(468, 110);
			tbxDescription.TabIndex = 106;
			tbxDescription.TabStop = false;
			tbxDescription.Text = "Description";
			tbxDescription.UseSystemPasswordChar = false;
			// 
			// tbxTitle
			// 
			tbxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbxTitle.BackColor = Color.White;
			tbxTitle.BaseColor = Color.FromArgb(252, 228, 228);
			tbxTitle.BorderColorA = Color.FromArgb(216, 85, 101);
			tbxTitle.BorderColorB = Color.FromArgb(216, 85, 101);
			tlpPost.SetColumnSpan(tbxTitle, 2);
			tbxTitle.Enabled = false;
			tbxTitle.Font = new Font("Bahnschrift", 15F);
			tbxTitle.ForeColor = Color.FromArgb(216, 85, 101);
			tbxTitle.Hint = "";
			tbxTitle.Location = new Point(3, 61);
			tbxTitle.MaxLength = 32767;
			tbxTitle.Multiline = false;
			tbxTitle.Name = "tbxTitle";
			tbxTitle.PasswordChar = '\0';
			tbxTitle.ScrollBars = ScrollBars.None;
			tbxTitle.SelectedText = "";
			tbxTitle.SelectionLength = 0;
			tbxTitle.SelectionStart = 0;
			tbxTitle.Size = new Size(468, 41);
			tbxTitle.TabIndex = 105;
			tbxTitle.TabStop = false;
			tbxTitle.UseSystemPasswordChar = false;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			tlpPost.SetColumnSpan(lblTitle, 2);
			lblTitle.Dock = DockStyle.Fill;
			lblTitle.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblTitle.ForeColor = Color.FromArgb(216, 85, 101);
			lblTitle.Location = new Point(3, 0);
			lblTitle.Name = "lblTitle";
			lblTitle.Padding = new Padding(5, 0, 0, 5);
			lblTitle.Size = new Size(468, 58);
			lblTitle.TabIndex = 77;
			lblTitle.Text = "Title";
			lblTitle.TextAlign = ContentAlignment.BottomLeft;
			// 
			// pImage
			// 
			pImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pImage.BackColor = Color.FromArgb(252, 196, 196);
			pImage.Controls.Add(tlpPhoto);
			pImage.Location = new Point(0, 0);
			pImage.Name = "pImage";
			pImage.Padding = new Padding(10);
			pImage.Size = new Size(494, 605);
			pImage.TabIndex = 21;
			// 
			// tlpPhoto
			// 
			tlpPhoto.ColumnCount = 2;
			tlpPhoto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPhoto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPhoto.Controls.Add(btnRemove, 1, 7);
			tlpPhoto.Controls.Add(btnAttach, 0, 7);
			tlpPhoto.Controls.Add(btnBack, 0, 9);
			tlpPhoto.Controls.Add(pPhoto, 0, 1);
			tlpPhoto.Controls.Add(btnPost, 1, 9);
			tlpPhoto.Controls.Add(lblPhoto, 0, 0);
			tlpPhoto.Dock = DockStyle.Fill;
			tlpPhoto.Location = new Point(10, 10);
			tlpPhoto.Name = "tlpPhoto";
			tlpPhoto.RowCount = 10;
			tlpPhoto.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPhoto.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPhoto.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPhoto.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPhoto.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPhoto.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPhoto.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPhoto.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPhoto.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPhoto.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPhoto.Size = new Size(474, 585);
			tlpPhoto.TabIndex = 0;
			// 
			// btnRemove
			// 
			btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnRemove.DefaultBack = Color.FromArgb(236, 124, 132);
			btnRemove.Font = new Font("Bahnschrift", 14F);
			btnRemove.ForeColor = Color.FromArgb(252, 228, 228);
			btnRemove.Location = new Point(240, 416);
			btnRemove.Name = "btnRemove";
			btnRemove.Size = new Size(185, 45);
			btnRemove.TabIndex = 80;
			btnRemove.Text = "Remove Photo";
			// 
			// btnAttach
			// 
			btnAttach.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnAttach.DefaultBack = Color.FromArgb(236, 124, 132);
			btnAttach.Font = new Font("Bahnschrift", 14F);
			btnAttach.ForeColor = Color.FromArgb(252, 228, 228);
			btnAttach.Location = new Point(49, 416);
			btnAttach.Name = "btnAttach";
			btnAttach.Size = new Size(185, 45);
			btnAttach.TabIndex = 79;
			btnAttach.Text = "Attach Photo";
			// 
			// btnBack
			// 
			btnBack.DefaultBack = Color.FromArgb(236, 124, 132);
			btnBack.Font = new Font("Bahnschrift", 14F);
			btnBack.ForeColor = Color.FromArgb(252, 228, 228);
			btnBack.Location = new Point(3, 525);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(145, 45);
			btnBack.TabIndex = 110;
			btnBack.Text = "Back";
			btnBack.Click += btnBack_Click;
			// 
			// pPhoto
			// 
			pPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pPhoto.BackColor = Color.FromArgb(216, 85, 101);
			tlpPhoto.SetColumnSpan(pPhoto, 2);
			pPhoto.Controls.Add(pbxPhoto);
			pPhoto.Location = new Point(3, 61);
			pPhoto.Name = "pPhoto";
			pPhoto.Padding = new Padding(5);
			tlpPhoto.SetRowSpan(pPhoto, 6);
			pPhoto.Size = new Size(468, 342);
			pPhoto.TabIndex = 78;
			// 
			// pbxPhoto
			// 
			pbxPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pbxPhoto.BackColor = Color.FromArgb(252, 228, 228);
			pbxPhoto.Image = (Image)resources.GetObject("pbxPhoto.Image");
			pbxPhoto.Location = new Point(8, 8);
			pbxPhoto.Name = "pbxPhoto";
			pbxPhoto.Size = new Size(452, 326);
			pbxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxPhoto.TabIndex = 22;
			pbxPhoto.TabStop = false;
			// 
			// btnPost
			// 
			btnPost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnPost.DefaultBack = Color.FromArgb(236, 124, 132);
			btnPost.Font = new Font("Bahnschrift", 14F);
			btnPost.ForeColor = Color.FromArgb(252, 228, 228);
			btnPost.Location = new Point(326, 525);
			btnPost.Name = "btnPost";
			btnPost.Size = new Size(145, 45);
			btnPost.TabIndex = 109;
			btnPost.Text = "Post";
			btnPost.Click += btnPost_Click;
			// 
			// lblPhoto
			// 
			lblPhoto.AutoSize = true;
			tlpPhoto.SetColumnSpan(lblPhoto, 2);
			lblPhoto.Dock = DockStyle.Fill;
			lblPhoto.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblPhoto.ForeColor = Color.FromArgb(216, 85, 101);
			lblPhoto.Location = new Point(3, 0);
			lblPhoto.Name = "lblPhoto";
			lblPhoto.Padding = new Padding(5, 0, 0, 5);
			lblPhoto.Size = new Size(468, 58);
			lblPhoto.TabIndex = 77;
			lblPhoto.Text = "Blood Donation Drive";
			lblPhoto.TextAlign = ContentAlignment.BottomLeft;
			// 
			// HospitalStock
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(pPost);
			Controls.Add(pWarning);
			Controls.Add(dgvStock);
			Name = "HospitalStock";
			Padding = new Padding(10, 15, 10, 15);
			Size = new Size(1020, 641);
			Load += HospitalStock_Load;
			Resize += HospitalStock_Resize;
			((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
			pWarning.ResumeLayout(false);
			pWarning.PerformLayout();
			pPost.ResumeLayout(false);
			tlpPost.ResumeLayout(false);
			tlpPost.PerformLayout();
			pImage.ResumeLayout(false);
			tlpPhoto.ResumeLayout(false);
			tlpPhoto.PerformLayout();
			pPhoto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxPhoto).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvStock;
		private Panel pWarning;
		private Label lblWarning;
		private Label lblNote;
		private Panel pPost;
		private TableLayoutPanel tlpPost;
		private Label lblTitle;
		private ReaLTaiizor.Controls.HopeTextBox tbxTitle;
		private ReaLTaiizor.Controls.HopeTextBox tbxDescription;
		private Label lblDate;
		private Label lblTime;
		private Label lblLocation;
		private ReaLTaiizor.Controls.HopeTextBox tbxDate;
		private ReaLTaiizor.Controls.HopeTextBox tbxTime;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxCity;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxBarangay;
		private AntdUI.Button btnNext;
		private Panel pImage;
		private TableLayoutPanel tlpPhoto;
		private AntdUI.Button btnPost;
		private Label lblPhoto;
		private Panel pPhoto;
		private AntdUI.Button btnBack;
		private PictureBox pbxPhoto;
		private AntdUI.Button btnAttach;
		private AntdUI.Button btnRemove;
	}
}
