namespace Hemotica
{
	partial class DonorDonate
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorDonate));
			lblDate = new Label();
			btnToday = new AntdUI.Button();
			btnNext = new AntdUI.Button();
			btnBack = new AntdUI.Button();
			btnAdd = new AntdUI.Button();
			btnCalendar = new AntdUI.Button();
			btnList = new AntdUI.Button();
			tblpDays = new TableLayoutPanel();
			lblSun = new Label();
			lblMon = new Label();
			lblSat = new Label();
			lblTue = new Label();
			lblFri = new Label();
			lblWed = new Label();
			lblThu = new Label();
			flpCalendar = new FlowLayoutPanel();
			tblpDays.SuspendLayout();
			SuspendLayout();
			// 
			// lblDate
			// 
			lblDate.AutoSize = true;
			lblDate.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblDate.ForeColor = Color.FromArgb(216, 85, 101);
			lblDate.Location = new Point(0, 51);
			lblDate.Name = "lblDate";
			lblDate.Padding = new Padding(5, 0, 0, 5);
			lblDate.Size = new Size(238, 46);
			lblDate.TabIndex = 5;
			lblDate.Text = "Calendar Date";
			lblDate.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnToday
			// 
			btnToday.DefaultBack = Color.FromArgb(236, 124, 132);
			btnToday.Font = new Font("Bahnschrift", 14F);
			btnToday.ForeColor = Color.FromArgb(252, 228, 228);
			btnToday.Location = new Point(59, 3);
			btnToday.Name = "btnToday";
			btnToday.Size = new Size(100, 45);
			btnToday.TabIndex = 6;
			btnToday.Text = "TODAY";
			btnToday.Click += btnToday_Click;
			// 
			// btnNext
			// 
			btnNext.DefaultBack = Color.FromArgb(236, 124, 132);
			btnNext.Font = new Font("Bahnschrift", 14F);
			btnNext.ForeColor = Color.FromArgb(252, 228, 228);
			btnNext.Icon = (Image)resources.GetObject("btnNext.Icon");
			btnNext.Location = new Point(165, 3);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(50, 45);
			btnNext.TabIndex = 9;
			btnNext.Click += btnNext_Click;
			// 
			// btnBack
			// 
			btnBack.DefaultBack = Color.FromArgb(236, 124, 132);
			btnBack.Font = new Font("Bahnschrift", 14F);
			btnBack.ForeColor = Color.FromArgb(252, 228, 228);
			btnBack.Icon = (Image)resources.GetObject("btnBack.Icon");
			btnBack.Location = new Point(3, 3);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(50, 45);
			btnBack.TabIndex = 7;
			btnBack.Click += btnBack_Click;
			// 
			// btnAdd
			// 
			btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAdd.DefaultBack = Color.FromArgb(236, 124, 132);
			btnAdd.Font = new Font("Bahnschrift", 14F);
			btnAdd.ForeColor = Color.FromArgb(252, 228, 228);
			btnAdd.Icon = (Image)resources.GetObject("btnAdd.Icon");
			btnAdd.Location = new Point(967, 3);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(50, 45);
			btnAdd.TabIndex = 11;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnCalendar
			// 
			btnCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnCalendar.DefaultBack = Color.FromArgb(216, 85, 101);
			btnCalendar.Font = new Font("Bahnschrift", 14F);
			btnCalendar.ForeColor = Color.FromArgb(252, 228, 228);
			btnCalendar.Location = new Point(730, 3);
			btnCalendar.Name = "btnCalendar";
			btnCalendar.Size = new Size(125, 45);
			btnCalendar.TabIndex = 8;
			btnCalendar.Text = "Calendar";
			btnCalendar.Click += btnCalendar_Click;
			// 
			// btnList
			// 
			btnList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnList.DefaultBack = Color.FromArgb(236, 124, 132);
			btnList.Font = new Font("Bahnschrift", 14F);
			btnList.ForeColor = Color.FromArgb(252, 228, 228);
			btnList.Location = new Point(861, 3);
			btnList.Name = "btnList";
			btnList.Size = new Size(100, 45);
			btnList.TabIndex = 10;
			btnList.Text = "List";
			btnList.Click += btnList_Click;
			// 
			// tblpDays
			// 
			tblpDays.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tblpDays.ColumnCount = 7;
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpDays.Controls.Add(lblSun, 6, 0);
			tblpDays.Controls.Add(lblMon, 0, 0);
			tblpDays.Controls.Add(lblSat, 5, 0);
			tblpDays.Controls.Add(lblTue, 1, 0);
			tblpDays.Controls.Add(lblFri, 4, 0);
			tblpDays.Controls.Add(lblWed, 2, 0);
			tblpDays.Controls.Add(lblThu, 3, 0);
			tblpDays.Location = new Point(3, 100);
			tblpDays.Name = "tblpDays";
			tblpDays.RowCount = 1;
			tblpDays.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tblpDays.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tblpDays.Size = new Size(1014, 45);
			tblpDays.TabIndex = 12;
			// 
			// lblSun
			// 
			lblSun.AutoSize = true;
			lblSun.Dock = DockStyle.Fill;
			lblSun.Font = new Font("Bahnschrift", 15F);
			lblSun.ForeColor = Color.FromArgb(236, 124, 132);
			lblSun.Location = new Point(867, 0);
			lblSun.Name = "lblSun";
			lblSun.Size = new Size(144, 45);
			lblSun.TabIndex = 19;
			lblSun.Text = "SUN";
			lblSun.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblMon
			// 
			lblMon.AutoSize = true;
			lblMon.Dock = DockStyle.Fill;
			lblMon.Font = new Font("Bahnschrift", 15F);
			lblMon.ForeColor = Color.FromArgb(236, 124, 132);
			lblMon.Location = new Point(3, 0);
			lblMon.Name = "lblMon";
			lblMon.Size = new Size(138, 45);
			lblMon.TabIndex = 13;
			lblMon.Text = "MON";
			lblMon.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblSat
			// 
			lblSat.AutoSize = true;
			lblSat.Dock = DockStyle.Fill;
			lblSat.Font = new Font("Bahnschrift", 15F);
			lblSat.ForeColor = Color.FromArgb(236, 124, 132);
			lblSat.Location = new Point(723, 0);
			lblSat.Name = "lblSat";
			lblSat.Size = new Size(138, 45);
			lblSat.TabIndex = 18;
			lblSat.Text = "SAT";
			lblSat.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblTue
			// 
			lblTue.AutoSize = true;
			lblTue.Dock = DockStyle.Fill;
			lblTue.Font = new Font("Bahnschrift", 15F);
			lblTue.ForeColor = Color.FromArgb(236, 124, 132);
			lblTue.Location = new Point(147, 0);
			lblTue.Name = "lblTue";
			lblTue.Size = new Size(138, 45);
			lblTue.TabIndex = 14;
			lblTue.Text = "TUE";
			lblTue.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblFri
			// 
			lblFri.AutoSize = true;
			lblFri.Dock = DockStyle.Fill;
			lblFri.Font = new Font("Bahnschrift", 15F);
			lblFri.ForeColor = Color.FromArgb(236, 124, 132);
			lblFri.Location = new Point(579, 0);
			lblFri.Name = "lblFri";
			lblFri.Size = new Size(138, 45);
			lblFri.TabIndex = 17;
			lblFri.Text = "FRI";
			lblFri.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblWed
			// 
			lblWed.AutoSize = true;
			lblWed.Dock = DockStyle.Fill;
			lblWed.Font = new Font("Bahnschrift", 15F);
			lblWed.ForeColor = Color.FromArgb(236, 124, 132);
			lblWed.Location = new Point(291, 0);
			lblWed.Name = "lblWed";
			lblWed.Size = new Size(138, 45);
			lblWed.TabIndex = 15;
			lblWed.Text = "WED";
			lblWed.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblThu
			// 
			lblThu.AutoSize = true;
			lblThu.Dock = DockStyle.Fill;
			lblThu.Font = new Font("Bahnschrift", 15F);
			lblThu.ForeColor = Color.FromArgb(236, 124, 132);
			lblThu.Location = new Point(435, 0);
			lblThu.Name = "lblThu";
			lblThu.Size = new Size(138, 45);
			lblThu.TabIndex = 16;
			lblThu.Text = "THU";
			lblThu.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// flpCalendar
			// 
			flpCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpCalendar.BackColor = Color.FromArgb(236, 124, 132);
			flpCalendar.Location = new Point(3, 148);
			flpCalendar.Name = "flpCalendar";
			flpCalendar.Padding = new Padding(3);
			flpCalendar.Size = new Size(1009, 487);
			flpCalendar.TabIndex = 13;
			// 
			// DonorDonate
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(flpCalendar);
			Controls.Add(tblpDays);
			Controls.Add(lblDate);
			Controls.Add(btnToday);
			Controls.Add(btnNext);
			Controls.Add(btnBack);
			Controls.Add(btnAdd);
			Controls.Add(btnCalendar);
			Controls.Add(btnList);
			Name = "DonorDonate";
			Size = new Size(1020, 641);
			Load += DonorDonate_Load;
			Resize += DonorDonate_Resize;
			tblpDays.ResumeLayout(false);
			tblpDays.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblDate;
		private AntdUI.Button btnToday;
		private AntdUI.Button btnNext;
		private AntdUI.Button btnBack;
		private AntdUI.Button btnAdd;
		private AntdUI.Button btnCalendar;
		private AntdUI.Button btnList;
		private TableLayoutPanel tblpDays;
		private Label lblMon;
		private Label lblSun;
		private Label lblSat;
		private Label lblFri;
		private Label lblThu;
		private Label lblWed;
		private Label lblTue;
		private FlowLayoutPanel flpCalendar;
	}
}
