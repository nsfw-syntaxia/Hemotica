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
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			dgvStock = new DataGridView();
			pWarning = new Panel();
			lblNote = new Label();
			lblWarning = new Label();
			pPost = new Panel();
			pImage = new Panel();
			tableLayoutPanel1 = new TableLayoutPanel();
			button1 = new AntdUI.Button();
			dungeonComboBox1 = new ReaLTaiizor.Controls.DungeonComboBox();
			dungeonComboBox2 = new ReaLTaiizor.Controls.DungeonComboBox();
			hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
			hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			hopeTextBox3 = new ReaLTaiizor.Controls.HopeTextBox();
			hopeTextBox4 = new ReaLTaiizor.Controls.HopeTextBox();
			label4 = new Label();
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
			((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
			pWarning.SuspendLayout();
			pPost.SuspendLayout();
			pImage.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tlpPost.SuspendLayout();
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
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold);
			dataGridViewCellStyle4.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle4.Padding = new Padding(15, 5, 15, 5);
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dgvStock.ColumnHeadersHeight = 50;
			dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvStock.EnableHeadersVisualStyles = false;
			dgvStock.GridColor = Color.FromArgb(253, 211, 211);
			dgvStock.Location = new Point(13, 18);
			dgvStock.MultiSelect = false;
			dgvStock.Name = "dgvStock";
			dgvStock.ReadOnly = true;
			dgvStock.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = SystemColors.Control;
			dataGridViewCellStyle5.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			dgvStock.RowHeadersVisible = false;
			dgvStock.RowHeadersWidth = 40;
			dataGridViewCellStyle6.BackColor = Color.FromArgb(244, 180, 180);
			dataGridViewCellStyle6.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle6.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle6.Padding = new Padding(20, 5, 20, 5);
			dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dataGridViewCellStyle6.SelectionForeColor = Color.White;
			dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
			// pImage
			// 
			pImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pImage.BackColor = Color.FromArgb(252, 196, 196);
			pImage.Controls.Add(tableLayoutPanel1);
			pImage.Location = new Point(0, 0);
			pImage.Name = "pImage";
			pImage.Padding = new Padding(10);
			pImage.Size = new Size(494, 605);
			pImage.TabIndex = 21;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(button1, 1, 9);
			tableLayoutPanel1.Controls.Add(dungeonComboBox1, 1, 7);
			tableLayoutPanel1.Controls.Add(dungeonComboBox2, 0, 7);
			tableLayoutPanel1.Controls.Add(hopeTextBox1, 1, 5);
			tableLayoutPanel1.Controls.Add(hopeTextBox2, 0, 5);
			tableLayoutPanel1.Controls.Add(label1, 0, 6);
			tableLayoutPanel1.Controls.Add(label2, 1, 4);
			tableLayoutPanel1.Controls.Add(label3, 0, 4);
			tableLayoutPanel1.Controls.Add(hopeTextBox3, 0, 2);
			tableLayoutPanel1.Controls.Add(hopeTextBox4, 0, 1);
			tableLayoutPanel1.Controls.Add(label4, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(10, 10);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 10;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.Size = new Size(474, 585);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button1.DefaultBack = Color.FromArgb(236, 124, 132);
			button1.Font = new Font("Bahnschrift", 14F);
			button1.ForeColor = Color.FromArgb(252, 228, 228);
			button1.Location = new Point(326, 537);
			button1.Name = "button1";
			button1.Size = new Size(145, 45);
			button1.TabIndex = 109;
			button1.Text = "Next";
			// 
			// dungeonComboBox1
			// 
			dungeonComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			dungeonComboBox1.BackColor = Color.White;
			dungeonComboBox1.ColorA = Color.FromArgb(236, 124, 132);
			dungeonComboBox1.ColorB = Color.FromArgb(236, 124, 132);
			dungeonComboBox1.ColorC = Color.FromArgb(242, 241, 240);
			dungeonComboBox1.ColorD = Color.FromArgb(253, 252, 252);
			dungeonComboBox1.ColorE = Color.FromArgb(239, 237, 236);
			dungeonComboBox1.ColorF = Color.FromArgb(216, 85, 101);
			dungeonComboBox1.ColorG = Color.FromArgb(216, 85, 101);
			dungeonComboBox1.ColorH = Color.FromArgb(244, 180, 180);
			dungeonComboBox1.ColorI = Color.FromArgb(250, 249, 249);
			dungeonComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
			dungeonComboBox1.DropDownHeight = 100;
			dungeonComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			dungeonComboBox1.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			dungeonComboBox1.ForeColor = Color.FromArgb(216, 85, 101);
			dungeonComboBox1.FormattingEnabled = true;
			dungeonComboBox1.HoverSelectionColor = Color.Empty;
			dungeonComboBox1.IntegralHeight = false;
			dungeonComboBox1.ItemHeight = 35;
			dungeonComboBox1.Location = new Point(240, 409);
			dungeonComboBox1.Name = "dungeonComboBox1";
			dungeonComboBox1.Size = new Size(231, 41);
			dungeonComboBox1.StartIndex = 0;
			dungeonComboBox1.TabIndex = 99;
			// 
			// dungeonComboBox2
			// 
			dungeonComboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			dungeonComboBox2.BackColor = Color.White;
			dungeonComboBox2.ColorA = Color.FromArgb(236, 124, 132);
			dungeonComboBox2.ColorB = Color.FromArgb(236, 124, 132);
			dungeonComboBox2.ColorC = Color.FromArgb(242, 241, 240);
			dungeonComboBox2.ColorD = Color.FromArgb(253, 252, 252);
			dungeonComboBox2.ColorE = Color.FromArgb(239, 237, 236);
			dungeonComboBox2.ColorF = Color.FromArgb(216, 85, 101);
			dungeonComboBox2.ColorG = Color.FromArgb(216, 85, 101);
			dungeonComboBox2.ColorH = Color.FromArgb(244, 180, 180);
			dungeonComboBox2.ColorI = Color.FromArgb(250, 249, 249);
			dungeonComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
			dungeonComboBox2.DropDownHeight = 100;
			dungeonComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			dungeonComboBox2.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			dungeonComboBox2.ForeColor = Color.FromArgb(216, 85, 101);
			dungeonComboBox2.FormattingEnabled = true;
			dungeonComboBox2.HoverSelectionColor = Color.Empty;
			dungeonComboBox2.IntegralHeight = false;
			dungeonComboBox2.ItemHeight = 35;
			dungeonComboBox2.Items.AddRange(new object[] { "Select city", "Alcantara", "Alcoy", "Alegria", "Aloguinsan", "Argao", "Asturias", "Badian", "Balamban", "Bantayan", "Barili", "Bogo City", "Boljoon", "Borbon", "Carcar City", "Carmen", "Catmon", "Cebu City", "Compostela", "Consolacion", "Cordova", "Daanbantayan", "Dalaguete", "Danao City", "Dumanjug", "Ginatilan", "Lapu-Lapu City", "Liloan", "Madridejos", "Malabuyoc", "Mandaue City", "Medellin", "Minglanilla", "Moalboal", "Naga City", "Oslob", "Pilar", "Pinamungahan", "Poro", "Ronda", "Samboan", "San Fernando", "San Francisco", "San Remigio", "Santa Fe", "Santander", "Sibonga", "Sogod", "Tabogon", "Tabuelan", "Talisay City", "Toledo City", "Tuburan", "Tudela" });
			dungeonComboBox2.Location = new Point(3, 409);
			dungeonComboBox2.Name = "dungeonComboBox2";
			dungeonComboBox2.Size = new Size(231, 41);
			dungeonComboBox2.StartIndex = 0;
			dungeonComboBox2.TabIndex = 98;
			// 
			// hopeTextBox1
			// 
			hopeTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			hopeTextBox1.BackColor = Color.White;
			hopeTextBox1.BaseColor = Color.FromArgb(252, 228, 228);
			hopeTextBox1.BorderColorA = Color.FromArgb(216, 85, 101);
			hopeTextBox1.BorderColorB = Color.FromArgb(216, 85, 101);
			hopeTextBox1.Enabled = false;
			hopeTextBox1.Font = new Font("Bahnschrift", 15F);
			hopeTextBox1.ForeColor = Color.FromArgb(216, 85, 101);
			hopeTextBox1.Hint = "";
			hopeTextBox1.Location = new Point(240, 293);
			hopeTextBox1.MaxLength = 32767;
			hopeTextBox1.Multiline = false;
			hopeTextBox1.Name = "hopeTextBox1";
			hopeTextBox1.PasswordChar = '\0';
			hopeTextBox1.ScrollBars = ScrollBars.None;
			hopeTextBox1.SelectedText = "";
			hopeTextBox1.SelectionLength = 0;
			hopeTextBox1.SelectionStart = 0;
			hopeTextBox1.Size = new Size(231, 41);
			hopeTextBox1.TabIndex = 108;
			hopeTextBox1.TabStop = false;
			hopeTextBox1.Text = "HH:MM (24H FORMAT)";
			hopeTextBox1.UseSystemPasswordChar = false;
			// 
			// hopeTextBox2
			// 
			hopeTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			hopeTextBox2.BackColor = Color.White;
			hopeTextBox2.BaseColor = Color.FromArgb(252, 228, 228);
			hopeTextBox2.BorderColorA = Color.FromArgb(216, 85, 101);
			hopeTextBox2.BorderColorB = Color.FromArgb(216, 85, 101);
			hopeTextBox2.Enabled = false;
			hopeTextBox2.Font = new Font("Bahnschrift", 15F);
			hopeTextBox2.ForeColor = Color.FromArgb(216, 85, 101);
			hopeTextBox2.Hint = "";
			hopeTextBox2.Location = new Point(3, 293);
			hopeTextBox2.MaxLength = 32767;
			hopeTextBox2.Multiline = false;
			hopeTextBox2.Name = "hopeTextBox2";
			hopeTextBox2.PasswordChar = '\0';
			hopeTextBox2.ScrollBars = ScrollBars.None;
			hopeTextBox2.SelectedText = "";
			hopeTextBox2.SelectionLength = 0;
			hopeTextBox2.SelectionStart = 0;
			hopeTextBox2.Size = new Size(231, 41);
			hopeTextBox2.TabIndex = 107;
			hopeTextBox2.TabStop = false;
			hopeTextBox2.Text = "MM/DD/YYYY";
			hopeTextBox2.UseSystemPasswordChar = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			tableLayoutPanel1.SetColumnSpan(label1, 2);
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(216, 85, 101);
			label1.Location = new Point(3, 348);
			label1.Name = "label1";
			label1.Padding = new Padding(5, 0, 0, 5);
			label1.Size = new Size(468, 58);
			label1.TabIndex = 103;
			label1.Text = "Location";
			label1.TextAlign = ContentAlignment.BottomLeft;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Fill;
			label2.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(216, 85, 101);
			label2.Location = new Point(240, 232);
			label2.Name = "label2";
			label2.Padding = new Padding(5, 0, 0, 5);
			label2.Size = new Size(231, 58);
			label2.TabIndex = 104;
			label2.Text = "Time";
			label2.TextAlign = ContentAlignment.BottomLeft;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Fill;
			label3.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			label3.ForeColor = Color.FromArgb(216, 85, 101);
			label3.Location = new Point(3, 232);
			label3.Name = "label3";
			label3.Padding = new Padding(5, 0, 0, 5);
			label3.Size = new Size(231, 58);
			label3.TabIndex = 102;
			label3.Text = "Date";
			label3.TextAlign = ContentAlignment.BottomLeft;
			// 
			// hopeTextBox3
			// 
			hopeTextBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			hopeTextBox3.BackColor = Color.White;
			hopeTextBox3.BaseColor = Color.FromArgb(252, 228, 228);
			hopeTextBox3.BorderColorA = Color.FromArgb(216, 85, 101);
			hopeTextBox3.BorderColorB = Color.FromArgb(216, 85, 101);
			tableLayoutPanel1.SetColumnSpan(hopeTextBox3, 2);
			hopeTextBox3.Enabled = false;
			hopeTextBox3.Font = new Font("Bahnschrift", 15F);
			hopeTextBox3.ForeColor = Color.FromArgb(216, 85, 101);
			hopeTextBox3.Hint = "";
			hopeTextBox3.Location = new Point(3, 119);
			hopeTextBox3.MaxLength = 32767;
			hopeTextBox3.Multiline = true;
			hopeTextBox3.Name = "hopeTextBox3";
			hopeTextBox3.PasswordChar = '\0';
			tableLayoutPanel1.SetRowSpan(hopeTextBox3, 2);
			hopeTextBox3.ScrollBars = ScrollBars.None;
			hopeTextBox3.SelectedText = "";
			hopeTextBox3.SelectionLength = 0;
			hopeTextBox3.SelectionStart = 0;
			hopeTextBox3.Size = new Size(468, 110);
			hopeTextBox3.TabIndex = 106;
			hopeTextBox3.TabStop = false;
			hopeTextBox3.Text = "Description";
			hopeTextBox3.UseSystemPasswordChar = false;
			// 
			// hopeTextBox4
			// 
			hopeTextBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			hopeTextBox4.BackColor = Color.White;
			hopeTextBox4.BaseColor = Color.FromArgb(252, 228, 228);
			hopeTextBox4.BorderColorA = Color.FromArgb(216, 85, 101);
			hopeTextBox4.BorderColorB = Color.FromArgb(216, 85, 101);
			tableLayoutPanel1.SetColumnSpan(hopeTextBox4, 2);
			hopeTextBox4.Enabled = false;
			hopeTextBox4.Font = new Font("Bahnschrift", 15F);
			hopeTextBox4.ForeColor = Color.FromArgb(216, 85, 101);
			hopeTextBox4.Hint = "";
			hopeTextBox4.Location = new Point(3, 61);
			hopeTextBox4.MaxLength = 32767;
			hopeTextBox4.Multiline = false;
			hopeTextBox4.Name = "hopeTextBox4";
			hopeTextBox4.PasswordChar = '\0';
			hopeTextBox4.ScrollBars = ScrollBars.None;
			hopeTextBox4.SelectedText = "";
			hopeTextBox4.SelectionLength = 0;
			hopeTextBox4.SelectionStart = 0;
			hopeTextBox4.Size = new Size(468, 41);
			hopeTextBox4.TabIndex = 105;
			hopeTextBox4.TabStop = false;
			hopeTextBox4.UseSystemPasswordChar = false;
			// 
			// label4
			// 
			label4.AutoSize = true;
			tableLayoutPanel1.SetColumnSpan(label4, 2);
			label4.Dock = DockStyle.Fill;
			label4.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			label4.ForeColor = Color.FromArgb(216, 85, 101);
			label4.Location = new Point(3, 0);
			label4.Name = "label4";
			label4.Padding = new Padding(5, 0, 0, 5);
			label4.Size = new Size(468, 58);
			label4.TabIndex = 77;
			label4.Text = "Title";
			label4.TextAlign = ContentAlignment.BottomLeft;
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
			btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnNext.DefaultBack = Color.FromArgb(236, 124, 132);
			btnNext.Font = new Font("Bahnschrift", 14F);
			btnNext.ForeColor = Color.FromArgb(252, 228, 228);
			btnNext.Location = new Point(326, 537);
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
			pImage.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tlpPost.ResumeLayout(false);
			tlpPost.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvStock;
		private Panel pWarning;
		private Label lblWarning;
		private Label lblNote;
		private TableLayoutPanel tlpBloodDrive;
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
		private TableLayoutPanel tableLayoutPanel1;
		private AntdUI.Button button1;
		private ReaLTaiizor.Controls.DungeonComboBox dungeonComboBox1;
		private ReaLTaiizor.Controls.DungeonComboBox dungeonComboBox2;
		private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
		private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
		private Label label1;
		private Label label2;
		private Label label3;
		private ReaLTaiizor.Controls.HopeTextBox hopeTextBox3;
		private ReaLTaiizor.Controls.HopeTextBox hopeTextBox4;
		private Label label4;
	}
}
