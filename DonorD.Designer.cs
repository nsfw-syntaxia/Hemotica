namespace Hemotica
{
	partial class DonorD
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorD));
			tblpDonate = new TableLayoutPanel();
			flpCalendar = new FlowLayoutPanel();
			pDays = new Panel();
			tblpDays = new TableLayoutPanel();
			lblSun = new Label();
			lblSat = new Label();
			lblFri = new Label();
			lblThu = new Label();
			lblWed = new Label();
			lblTue = new Label();
			lblMon = new Label();
			pHeader = new Panel();
			tblpHeader = new TableLayoutPanel();
			btnAdd = new AntdUI.Button();
			lblMonth = new Label();
			pBtns = new Panel();
			tblpBtns = new TableLayoutPanel();
			btnToday = new AntdUI.Button();
			btnNext = new AntdUI.Button();
			btnBack = new AntdUI.Button();
			btnCalendar = new AntdUI.Button();
			btnList = new AntdUI.Button();
			tblpDonate.SuspendLayout();
			pDays.SuspendLayout();
			tblpDays.SuspendLayout();
			pHeader.SuspendLayout();
			tblpHeader.SuspendLayout();
			pBtns.SuspendLayout();
			tblpBtns.SuspendLayout();
			SuspendLayout();
			// 
			// tblpDonate
			// 
			tblpDonate.ColumnCount = 5;
			tblpDonate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpDonate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpDonate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpDonate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpDonate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpDonate.Controls.Add(flpCalendar, 0, 2);
			tblpDonate.Controls.Add(pDays, 0, 1);
			tblpDonate.Controls.Add(pHeader, 0, 0);
			tblpDonate.Dock = DockStyle.Fill;
			tblpDonate.Location = new Point(0, 0);
			tblpDonate.Name = "tblpDonate";
			tblpDonate.RowCount = 10;
			tblpDonate.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpDonate.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpDonate.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpDonate.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpDonate.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpDonate.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpDonate.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpDonate.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpDonate.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpDonate.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpDonate.Size = new Size(1020, 641);
			tblpDonate.TabIndex = 0;
			// 
			// flpCalendar
			// 
			tblpDonate.SetColumnSpan(flpCalendar, 5);
			flpCalendar.Dock = DockStyle.Fill;
			flpCalendar.Location = new Point(3, 131);
			flpCalendar.Name = "flpCalendar";
			tblpDonate.SetRowSpan(flpCalendar, 8);
			flpCalendar.Size = new Size(1014, 507);
			flpCalendar.TabIndex = 0;
			// 
			// pDays
			// 
			tblpDonate.SetColumnSpan(pDays, 5);
			pDays.Controls.Add(tblpDays);
			pDays.Dock = DockStyle.Fill;
			pDays.Location = new Point(3, 67);
			pDays.Name = "pDays";
			pDays.Size = new Size(1014, 58);
			pDays.TabIndex = 1;
			// 
			// tblpDays
			// 
			tblpDays.ColumnCount = 7;
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.Controls.Add(lblSun, 6, 0);
			tblpDays.Controls.Add(lblSat, 5, 0);
			tblpDays.Controls.Add(lblFri, 4, 0);
			tblpDays.Controls.Add(lblThu, 3, 0);
			tblpDays.Controls.Add(lblWed, 2, 0);
			tblpDays.Controls.Add(lblTue, 1, 0);
			tblpDays.Controls.Add(lblMon, 0, 0);
			tblpDays.Dock = DockStyle.Fill;
			tblpDays.Location = new Point(0, 0);
			tblpDays.Name = "tblpDays";
			tblpDays.RowCount = 1;
			tblpDays.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tblpDays.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tblpDays.Size = new Size(1014, 58);
			tblpDays.TabIndex = 0;
			// 
			// lblSun
			// 
			lblSun.AutoSize = true;
			lblSun.Dock = DockStyle.Fill;
			lblSun.Font = new Font("Bahnschrift", 15F);
			lblSun.ForeColor = Color.FromArgb(236, 124, 132);
			lblSun.Location = new Point(867, 0);
			lblSun.Name = "lblSun";
			lblSun.Size = new Size(144, 58);
			lblSun.TabIndex = 6;
			lblSun.Text = "SUN";
			lblSun.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblSat
			// 
			lblSat.AutoSize = true;
			lblSat.Dock = DockStyle.Fill;
			lblSat.Font = new Font("Bahnschrift", 15F);
			lblSat.ForeColor = Color.FromArgb(236, 124, 132);
			lblSat.Location = new Point(723, 0);
			lblSat.Name = "lblSat";
			lblSat.Size = new Size(138, 58);
			lblSat.TabIndex = 5;
			lblSat.Text = "SAT";
			lblSat.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblFri
			// 
			lblFri.AutoSize = true;
			lblFri.Dock = DockStyle.Fill;
			lblFri.Font = new Font("Bahnschrift", 15F);
			lblFri.ForeColor = Color.FromArgb(236, 124, 132);
			lblFri.Location = new Point(579, 0);
			lblFri.Name = "lblFri";
			lblFri.Size = new Size(138, 58);
			lblFri.TabIndex = 4;
			lblFri.Text = "FRI";
			lblFri.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblThu
			// 
			lblThu.AutoSize = true;
			lblThu.Dock = DockStyle.Fill;
			lblThu.Font = new Font("Bahnschrift", 15F);
			lblThu.ForeColor = Color.FromArgb(236, 124, 132);
			lblThu.Location = new Point(435, 0);
			lblThu.Name = "lblThu";
			lblThu.Size = new Size(138, 58);
			lblThu.TabIndex = 3;
			lblThu.Text = "THU";
			lblThu.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblWed
			// 
			lblWed.AutoSize = true;
			lblWed.Dock = DockStyle.Fill;
			lblWed.Font = new Font("Bahnschrift", 15F);
			lblWed.ForeColor = Color.FromArgb(236, 124, 132);
			lblWed.Location = new Point(291, 0);
			lblWed.Name = "lblWed";
			lblWed.Size = new Size(138, 58);
			lblWed.TabIndex = 2;
			lblWed.Text = "WED";
			lblWed.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblTue
			// 
			lblTue.AutoSize = true;
			lblTue.Dock = DockStyle.Fill;
			lblTue.Font = new Font("Bahnschrift", 15F);
			lblTue.ForeColor = Color.FromArgb(236, 124, 132);
			lblTue.Location = new Point(147, 0);
			lblTue.Name = "lblTue";
			lblTue.Size = new Size(138, 58);
			lblTue.TabIndex = 1;
			lblTue.Text = "TUE";
			lblTue.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblMon
			// 
			lblMon.AutoSize = true;
			lblMon.Dock = DockStyle.Fill;
			lblMon.Font = new Font("Bahnschrift", 15F);
			lblMon.ForeColor = Color.FromArgb(236, 124, 132);
			lblMon.Location = new Point(3, 0);
			lblMon.Name = "lblMon";
			lblMon.Size = new Size(138, 58);
			lblMon.TabIndex = 0;
			lblMon.Text = "MON";
			lblMon.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pHeader
			// 
			tblpDonate.SetColumnSpan(pHeader, 5);
			pHeader.Controls.Add(tblpHeader);
			pHeader.Dock = DockStyle.Fill;
			pHeader.Location = new Point(3, 3);
			pHeader.Name = "pHeader";
			pHeader.Size = new Size(1014, 58);
			pHeader.TabIndex = 2;
			// 
			// tblpHeader
			// 
			tblpHeader.ColumnCount = 15;
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
			tblpHeader.Controls.Add(btnAdd, 14, 0);
			tblpHeader.Controls.Add(lblMonth, 0, 0);
			tblpHeader.Controls.Add(pBtns, 5, 0);
			tblpHeader.Controls.Add(btnCalendar, 10, 0);
			tblpHeader.Controls.Add(btnList, 12, 0);
			tblpHeader.Dock = DockStyle.Fill;
			tblpHeader.Location = new Point(0, 0);
			tblpHeader.Name = "tblpHeader";
			tblpHeader.RowCount = 1;
			tblpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tblpHeader.Size = new Size(1014, 58);
			tblpHeader.TabIndex = 0;
			// 
			// btnAdd
			// 
			btnAdd.DefaultBack = Color.FromArgb(236, 124, 132);
			btnAdd.Dock = DockStyle.Fill;
			btnAdd.Font = new Font("Bahnschrift", 14F);
			btnAdd.ForeColor = Color.FromArgb(252, 228, 228);
			btnAdd.Icon = (Image)resources.GetObject("btnAdd.Icon");
			btnAdd.Location = new Point(941, 3);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(70, 52);
			btnAdd.TabIndex = 4;
			// 
			// lblMonth
			// 
			lblMonth.AutoSize = true;
			tblpHeader.SetColumnSpan(lblMonth, 5);
			lblMonth.Dock = DockStyle.Fill;
			lblMonth.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblMonth.ForeColor = Color.FromArgb(216, 85, 101);
			lblMonth.Location = new Point(3, 0);
			lblMonth.Name = "lblMonth";
			lblMonth.Size = new Size(329, 58);
			lblMonth.TabIndex = 0;
			lblMonth.Text = "Calendar Date";
			lblMonth.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// pBtns
			// 
			tblpHeader.SetColumnSpan(pBtns, 5);
			pBtns.Controls.Add(tblpBtns);
			pBtns.Dock = DockStyle.Fill;
			pBtns.Location = new Point(338, 3);
			pBtns.Name = "pBtns";
			pBtns.Size = new Size(329, 52);
			pBtns.TabIndex = 1;
			// 
			// tblpBtns
			// 
			tblpBtns.ColumnCount = 10;
			tblpBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tblpBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tblpBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tblpBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tblpBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tblpBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tblpBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tblpBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tblpBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tblpBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tblpBtns.Controls.Add(btnToday, 3, 0);
			tblpBtns.Controls.Add(btnNext, 7, 0);
			tblpBtns.Controls.Add(btnBack, 1, 0);
			tblpBtns.Dock = DockStyle.Fill;
			tblpBtns.Location = new Point(0, 0);
			tblpBtns.Name = "tblpBtns";
			tblpBtns.RowCount = 1;
			tblpBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tblpBtns.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tblpBtns.Size = new Size(329, 52);
			tblpBtns.TabIndex = 0;
			// 
			// btnToday
			// 
			tblpBtns.SetColumnSpan(btnToday, 4);
			btnToday.DefaultBack = Color.FromArgb(236, 124, 132);
			btnToday.Dock = DockStyle.Fill;
			btnToday.Font = new Font("Bahnschrift", 14F);
			btnToday.ForeColor = Color.FromArgb(252, 228, 228);
			btnToday.Location = new Point(99, 3);
			btnToday.Name = "btnToday";
			btnToday.Size = new Size(122, 46);
			btnToday.TabIndex = 0;
			btnToday.Text = "TODAY";
			// 
			// btnNext
			// 
			tblpBtns.SetColumnSpan(btnNext, 2);
			btnNext.DefaultBack = Color.FromArgb(236, 124, 132);
			btnNext.Dock = DockStyle.Fill;
			btnNext.Font = new Font("Bahnschrift", 14F);
			btnNext.ForeColor = Color.FromArgb(252, 228, 228);
			btnNext.Icon = (Image)resources.GetObject("btnNext.Icon");
			btnNext.Location = new Point(227, 3);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(58, 46);
			btnNext.TabIndex = 3;
			// 
			// btnBack
			// 
			tblpBtns.SetColumnSpan(btnBack, 2);
			btnBack.DefaultBack = Color.FromArgb(236, 124, 132);
			btnBack.Dock = DockStyle.Fill;
			btnBack.Font = new Font("Bahnschrift", 14F);
			btnBack.ForeColor = Color.FromArgb(252, 228, 228);
			btnBack.Icon = (Image)resources.GetObject("btnBack.Icon");
			btnBack.Location = new Point(35, 3);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(58, 46);
			btnBack.TabIndex = 1;
			// 
			// btnCalendar
			// 
			tblpHeader.SetColumnSpan(btnCalendar, 2);
			btnCalendar.DefaultBack = Color.FromArgb(216, 85, 101);
			btnCalendar.Dock = DockStyle.Fill;
			btnCalendar.Font = new Font("Bahnschrift", 14F);
			btnCalendar.ForeColor = Color.FromArgb(252, 228, 228);
			btnCalendar.Location = new Point(673, 3);
			btnCalendar.Name = "btnCalendar";
			btnCalendar.Size = new Size(128, 52);
			btnCalendar.TabIndex = 2;
			btnCalendar.Text = "CALENDAR";
			btnCalendar.Click += btnCalendar_Click;
			// 
			// btnList
			// 
			tblpHeader.SetColumnSpan(btnList, 2);
			btnList.DefaultBack = Color.FromArgb(236, 124, 132);
			btnList.Dock = DockStyle.Fill;
			btnList.Font = new Font("Bahnschrift", 14F);
			btnList.ForeColor = Color.FromArgb(252, 228, 228);
			btnList.Location = new Point(807, 3);
			btnList.Name = "btnList";
			btnList.Size = new Size(128, 52);
			btnList.TabIndex = 3;
			btnList.Text = "LIST";
			btnList.Click += btnList_Click;
			// 
			// DonorD
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(tblpDonate);
			Name = "DonorD";
			Size = new Size(1020, 641);
			Load += DonorD_Load;
			tblpDonate.ResumeLayout(false);
			pDays.ResumeLayout(false);
			tblpDays.ResumeLayout(false);
			tblpDays.PerformLayout();
			pHeader.ResumeLayout(false);
			tblpHeader.ResumeLayout(false);
			tblpHeader.PerformLayout();
			pBtns.ResumeLayout(false);
			tblpBtns.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tblpDonate;
		private FlowLayoutPanel flpCalendar;
		private Panel pDays;
		private TableLayoutPanel tblpDays;
		private Label lblMon;
		private Label lblTue;
		private Label lblWed;
		private Label lblThu;
		private Label lblFri;
		private Label lblSat;
		private Label lblSun;
		private Panel pHeader;
		private TableLayoutPanel tblpHeader;
		private Label lblMonth;
		private Panel pBtns;
		private TableLayoutPanel tblpBtns;
		private AntdUI.Button btnToday;
		private AntdUI.Button btnBack;
		private AntdUI.Button btnCalendar;
		private AntdUI.Button btnNext;
		private AntdUI.Button btnList;
		private AntdUI.Button btnAdd;
	}
}
