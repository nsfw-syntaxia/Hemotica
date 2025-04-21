namespace Hemotica
{
	partial class AdminDashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
			pDashboard = new Panel();
			pAnalytics = new Panel();
			tlpAnalytics = new TableLayoutPanel();
			btnTAnalytics = new Button();
			btnEAnalytics = new Button();
			btnDAnalytics = new Button();
			btnBGAnalytics = new Button();
			pOxyplot = new Panel();
			pvOxyplot = new OxyPlot.WindowsForms.PlotView();
			pDonors = new Panel();
			flpDonors = new FlowLayoutPanel();
			pbxNoDonors = new PictureBox();
			lblDonors = new Label();
			pHospitals = new Panel();
			flpHospitals = new FlowLayoutPanel();
			pbxNoHospitals = new PictureBox();
			lblHospitals = new Label();
			pUsers = new Panel();
			flpUsers = new FlowLayoutPanel();
			pDUsers = new Panel();
			lblDNumber = new Label();
			lblDUsers = new Label();
			pbxDUsers = new PictureBox();
			pHUsers = new Panel();
			lblHNumber = new Label();
			lblHUsers = new Label();
			pbxHUsers = new PictureBox();
			pDashboard.SuspendLayout();
			pAnalytics.SuspendLayout();
			tlpAnalytics.SuspendLayout();
			pOxyplot.SuspendLayout();
			pDonors.SuspendLayout();
			flpDonors.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxNoDonors).BeginInit();
			pHospitals.SuspendLayout();
			flpHospitals.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxNoHospitals).BeginInit();
			pUsers.SuspendLayout();
			flpUsers.SuspendLayout();
			pDUsers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxDUsers).BeginInit();
			pHUsers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxHUsers).BeginInit();
			SuspendLayout();
			// 
			// pDashboard
			// 
			pDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pDashboard.BackColor = Color.FromArgb(216, 85, 101);
			pDashboard.Controls.Add(pAnalytics);
			pDashboard.Location = new Point(8, 8);
			pDashboard.Name = "pDashboard";
			pDashboard.Padding = new Padding(7);
			pDashboard.Size = new Size(670, 372);
			pDashboard.TabIndex = 1;
			// 
			// pAnalytics
			// 
			pAnalytics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pAnalytics.BackColor = Color.FromArgb(252, 228, 228);
			pAnalytics.Controls.Add(tlpAnalytics);
			pAnalytics.Location = new Point(10, 10);
			pAnalytics.Name = "pAnalytics";
			pAnalytics.Padding = new Padding(1);
			pAnalytics.Size = new Size(650, 352);
			pAnalytics.TabIndex = 21;
			// 
			// tlpAnalytics
			// 
			tlpAnalytics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tlpAnalytics.ColumnCount = 4;
			tlpAnalytics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tlpAnalytics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tlpAnalytics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tlpAnalytics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tlpAnalytics.Controls.Add(btnTAnalytics, 3, 0);
			tlpAnalytics.Controls.Add(btnEAnalytics, 2, 0);
			tlpAnalytics.Controls.Add(btnDAnalytics, 1, 0);
			tlpAnalytics.Controls.Add(btnBGAnalytics, 0, 0);
			tlpAnalytics.Controls.Add(pOxyplot, 0, 1);
			tlpAnalytics.Location = new Point(4, 4);
			tlpAnalytics.Name = "tlpAnalytics";
			tlpAnalytics.RowCount = 2;
			tlpAnalytics.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpAnalytics.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
			tlpAnalytics.Size = new Size(642, 344);
			tlpAnalytics.TabIndex = 0;
			// 
			// btnTAnalytics
			// 
			btnTAnalytics.Dock = DockStyle.Fill;
			btnTAnalytics.FlatAppearance.BorderSize = 0;
			btnTAnalytics.FlatStyle = FlatStyle.Flat;
			btnTAnalytics.Font = new Font("Bahnschrift", 13F, FontStyle.Bold);
			btnTAnalytics.ForeColor = Color.FromArgb(216, 85, 101);
			btnTAnalytics.Location = new Point(483, 3);
			btnTAnalytics.Name = "btnTAnalytics";
			btnTAnalytics.Size = new Size(156, 28);
			btnTAnalytics.TabIndex = 3;
			btnTAnalytics.Text = "TRANSFUSIONS";
			btnTAnalytics.UseVisualStyleBackColor = true;
			btnTAnalytics.Click += btnTAnalytics_Click;
			// 
			// btnEAnalytics
			// 
			btnEAnalytics.Dock = DockStyle.Fill;
			btnEAnalytics.FlatAppearance.BorderSize = 0;
			btnEAnalytics.FlatStyle = FlatStyle.Flat;
			btnEAnalytics.Font = new Font("Bahnschrift", 13F, FontStyle.Bold);
			btnEAnalytics.ForeColor = Color.FromArgb(216, 85, 101);
			btnEAnalytics.Location = new Point(323, 3);
			btnEAnalytics.Name = "btnEAnalytics";
			btnEAnalytics.Size = new Size(154, 28);
			btnEAnalytics.TabIndex = 2;
			btnEAnalytics.Text = "EXTRACTIONS";
			btnEAnalytics.UseVisualStyleBackColor = true;
			btnEAnalytics.Click += btnEAnalytics_Click;
			// 
			// btnDAnalytics
			// 
			btnDAnalytics.Dock = DockStyle.Fill;
			btnDAnalytics.FlatAppearance.BorderSize = 0;
			btnDAnalytics.FlatStyle = FlatStyle.Flat;
			btnDAnalytics.Font = new Font("Bahnschrift", 13F, FontStyle.Bold);
			btnDAnalytics.ForeColor = Color.FromArgb(216, 85, 101);
			btnDAnalytics.Location = new Point(163, 3);
			btnDAnalytics.Name = "btnDAnalytics";
			btnDAnalytics.Size = new Size(154, 28);
			btnDAnalytics.TabIndex = 1;
			btnDAnalytics.Text = "DONORS";
			btnDAnalytics.UseVisualStyleBackColor = true;
			btnDAnalytics.Click += btnPAnalytics_Click;
			// 
			// btnBGAnalytics
			// 
			btnBGAnalytics.Dock = DockStyle.Fill;
			btnBGAnalytics.FlatAppearance.BorderSize = 0;
			btnBGAnalytics.FlatAppearance.MouseDownBackColor = Color.FromArgb(216, 85, 101);
			btnBGAnalytics.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 85, 101);
			btnBGAnalytics.FlatStyle = FlatStyle.Flat;
			btnBGAnalytics.Font = new Font("Bahnschrift", 13F, FontStyle.Bold);
			btnBGAnalytics.ForeColor = Color.FromArgb(216, 85, 101);
			btnBGAnalytics.Location = new Point(3, 3);
			btnBGAnalytics.Name = "btnBGAnalytics";
			btnBGAnalytics.Size = new Size(154, 28);
			btnBGAnalytics.TabIndex = 0;
			btnBGAnalytics.Text = "BLOOD GROUPS";
			btnBGAnalytics.UseVisualStyleBackColor = true;
			btnBGAnalytics.Click += btnBGAnalytics_Click;
			// 
			// pOxyplot
			// 
			tlpAnalytics.SetColumnSpan(pOxyplot, 4);
			pOxyplot.Controls.Add(pvOxyplot);
			pOxyplot.Dock = DockStyle.Fill;
			pOxyplot.Location = new Point(3, 37);
			pOxyplot.Name = "pOxyplot";
			pOxyplot.Size = new Size(636, 304);
			pOxyplot.TabIndex = 4;
			// 
			// pvOxyplot
			// 
			pvOxyplot.Dock = DockStyle.Fill;
			pvOxyplot.Font = new Font("Bahnschrift", 13F, FontStyle.Bold);
			pvOxyplot.ForeColor = Color.FromArgb(216, 85, 101);
			pvOxyplot.Location = new Point(0, 0);
			pvOxyplot.Name = "pvOxyplot";
			pvOxyplot.PanCursor = Cursors.Hand;
			pvOxyplot.Size = new Size(636, 304);
			pvOxyplot.TabIndex = 0;
			pvOxyplot.ZoomHorizontalCursor = Cursors.SizeWE;
			pvOxyplot.ZoomRectangleCursor = Cursors.SizeNWSE;
			pvOxyplot.ZoomVerticalCursor = Cursors.SizeNS;
			// 
			// pDonors
			// 
			pDonors.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pDonors.BackColor = Color.FromArgb(216, 85, 101);
			pDonors.Controls.Add(flpDonors);
			pDonors.Controls.Add(lblDonors);
			pDonors.Location = new Point(8, 386);
			pDonors.Name = "pDonors";
			pDonors.Padding = new Padding(7);
			pDonors.Size = new Size(670, 247);
			pDonors.TabIndex = 2;
			// 
			// flpDonors
			// 
			flpDonors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpDonors.AutoScroll = true;
			flpDonors.BackColor = Color.FromArgb(252, 228, 228);
			flpDonors.Controls.Add(pbxNoDonors);
			flpDonors.Location = new Point(10, 48);
			flpDonors.Name = "flpDonors";
			flpDonors.Size = new Size(650, 189);
			flpDonors.TabIndex = 14;
			flpDonors.WrapContents = false;
			// 
			// pbxNoDonors
			// 
			pbxNoDonors.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			pbxNoDonors.Image = (Image)resources.GetObject("pbxNoDonors.Image");
			pbxNoDonors.Location = new Point(3, 3);
			pbxNoDonors.Name = "pbxNoDonors";
			pbxNoDonors.Size = new Size(642, 181);
			pbxNoDonors.SizeMode = PictureBoxSizeMode.Zoom;
			pbxNoDonors.TabIndex = 0;
			pbxNoDonors.TabStop = false;
			// 
			// lblDonors
			// 
			lblDonors.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblDonors.AutoSize = true;
			lblDonors.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblDonors.ForeColor = Color.FromArgb(253, 211, 211);
			lblDonors.Location = new Point(0, 7);
			lblDonors.Name = "lblDonors";
			lblDonors.Padding = new Padding(5, 0, 0, 5);
			lblDonors.Size = new Size(109, 38);
			lblDonors.TabIndex = 13;
			lblDonors.Text = "Donors";
			// 
			// pHospitals
			// 
			pHospitals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			pHospitals.BackColor = Color.FromArgb(216, 85, 101);
			pHospitals.Controls.Add(flpHospitals);
			pHospitals.Controls.Add(lblHospitals);
			pHospitals.Location = new Point(684, 8);
			pHospitals.Name = "pHospitals";
			pHospitals.Padding = new Padding(7);
			pHospitals.Size = new Size(328, 310);
			pHospitals.TabIndex = 3;
			// 
			// flpHospitals
			// 
			flpHospitals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpHospitals.AutoScroll = true;
			flpHospitals.BackColor = Color.FromArgb(252, 228, 228);
			flpHospitals.Controls.Add(pbxNoHospitals);
			flpHospitals.FlowDirection = FlowDirection.TopDown;
			flpHospitals.Location = new Point(10, 48);
			flpHospitals.Name = "flpHospitals";
			flpHospitals.Size = new Size(308, 252);
			flpHospitals.TabIndex = 15;
			flpHospitals.WrapContents = false;
			// 
			// pbxNoHospitals
			// 
			pbxNoHospitals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			pbxNoHospitals.Image = (Image)resources.GetObject("pbxNoHospitals.Image");
			pbxNoHospitals.Location = new Point(3, 3);
			pbxNoHospitals.Name = "pbxNoHospitals";
			pbxNoHospitals.Size = new Size(300, 244);
			pbxNoHospitals.SizeMode = PictureBoxSizeMode.Zoom;
			pbxNoHospitals.TabIndex = 0;
			pbxNoHospitals.TabStop = false;
			// 
			// lblHospitals
			// 
			lblHospitals.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblHospitals.AutoSize = true;
			lblHospitals.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblHospitals.ForeColor = Color.FromArgb(253, 211, 211);
			lblHospitals.Location = new Point(0, 7);
			lblHospitals.Name = "lblHospitals";
			lblHospitals.Padding = new Padding(5, 0, 0, 5);
			lblHospitals.Size = new Size(134, 38);
			lblHospitals.TabIndex = 15;
			lblHospitals.Text = "Hospitals";
			// 
			// pUsers
			// 
			pUsers.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			pUsers.BackColor = Color.FromArgb(216, 85, 101);
			pUsers.Controls.Add(flpUsers);
			pUsers.Location = new Point(684, 324);
			pUsers.Name = "pUsers";
			pUsers.Padding = new Padding(7);
			pUsers.Size = new Size(328, 309);
			pUsers.TabIndex = 4;
			// 
			// flpUsers
			// 
			flpUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpUsers.AutoScroll = true;
			flpUsers.BackColor = Color.FromArgb(252, 228, 228);
			flpUsers.Controls.Add(pDUsers);
			flpUsers.Controls.Add(pHUsers);
			flpUsers.FlowDirection = FlowDirection.TopDown;
			flpUsers.Location = new Point(10, 10);
			flpUsers.Name = "flpUsers";
			flpUsers.Padding = new Padding(3);
			flpUsers.Size = new Size(308, 289);
			flpUsers.TabIndex = 16;
			flpUsers.WrapContents = false;
			// 
			// pDUsers
			// 
			pDUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			pDUsers.BackColor = Color.FromArgb(244, 180, 180);
			pDUsers.Controls.Add(lblDNumber);
			pDUsers.Controls.Add(lblDUsers);
			pDUsers.Controls.Add(pbxDUsers);
			pDUsers.Location = new Point(6, 6);
			pDUsers.Name = "pDUsers";
			pDUsers.Padding = new Padding(5);
			pDUsers.Size = new Size(296, 136);
			pDUsers.TabIndex = 0;
			// 
			// lblDNumber
			// 
			lblDNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblDNumber.AutoSize = true;
			lblDNumber.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblDNumber.ForeColor = Color.FromArgb(216, 85, 101);
			lblDNumber.Location = new Point(193, 67);
			lblDNumber.Name = "lblDNumber";
			lblDNumber.Size = new Size(37, 41);
			lblDNumber.TabIndex = 20;
			lblDNumber.Text = "0";
			// 
			// lblDUsers
			// 
			lblDUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblDUsers.AutoSize = true;
			lblDUsers.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
			lblDUsers.ForeColor = Color.FromArgb(216, 85, 101);
			lblDUsers.Location = new Point(174, 28);
			lblDUsers.Name = "lblDUsers";
			lblDUsers.Padding = new Padding(0, 3, 0, 0);
			lblDUsers.Size = new Size(75, 27);
			lblDUsers.TabIndex = 19;
			lblDUsers.Text = "Donors";
			lblDUsers.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pbxDUsers
			// 
			pbxDUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			pbxDUsers.Image = (Image)resources.GetObject("pbxDUsers.Image");
			pbxDUsers.Location = new Point(8, 8);
			pbxDUsers.Name = "pbxDUsers";
			pbxDUsers.Size = new Size(120, 120);
			pbxDUsers.TabIndex = 0;
			pbxDUsers.TabStop = false;
			// 
			// pHUsers
			// 
			pHUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			pHUsers.BackColor = Color.FromArgb(244, 180, 180);
			pHUsers.Controls.Add(lblHNumber);
			pHUsers.Controls.Add(lblHUsers);
			pHUsers.Controls.Add(pbxHUsers);
			pHUsers.Location = new Point(6, 148);
			pHUsers.Name = "pHUsers";
			pHUsers.Padding = new Padding(5);
			pHUsers.Size = new Size(296, 136);
			pHUsers.TabIndex = 1;
			// 
			// lblHNumber
			// 
			lblHNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblHNumber.AutoSize = true;
			lblHNumber.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblHNumber.ForeColor = Color.FromArgb(216, 85, 101);
			lblHNumber.Location = new Point(193, 67);
			lblHNumber.Name = "lblHNumber";
			lblHNumber.Size = new Size(37, 41);
			lblHNumber.TabIndex = 21;
			lblHNumber.Text = "0";
			// 
			// lblHUsers
			// 
			lblHUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblHUsers.AutoSize = true;
			lblHUsers.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
			lblHUsers.ForeColor = Color.FromArgb(216, 85, 101);
			lblHUsers.Location = new Point(164, 28);
			lblHUsers.Name = "lblHUsers";
			lblHUsers.Padding = new Padding(0, 3, 0, 0);
			lblHUsers.Size = new Size(95, 27);
			lblHUsers.TabIndex = 20;
			lblHUsers.Text = "Hospitals";
			lblHUsers.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pbxHUsers
			// 
			pbxHUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			pbxHUsers.Image = (Image)resources.GetObject("pbxHUsers.Image");
			pbxHUsers.Location = new Point(8, 8);
			pbxHUsers.Name = "pbxHUsers";
			pbxHUsers.Size = new Size(120, 120);
			pbxHUsers.TabIndex = 1;
			pbxHUsers.TabStop = false;
			// 
			// AdminDashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(pUsers);
			Controls.Add(pHospitals);
			Controls.Add(pDonors);
			Controls.Add(pDashboard);
			Name = "AdminDashboard";
			Padding = new Padding(5);
			Size = new Size(1020, 641);
			Load += HospitalDashboard_Load;
			Resize += HospitalDashboard_Resize;
			pDashboard.ResumeLayout(false);
			pAnalytics.ResumeLayout(false);
			tlpAnalytics.ResumeLayout(false);
			pOxyplot.ResumeLayout(false);
			pDonors.ResumeLayout(false);
			pDonors.PerformLayout();
			flpDonors.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxNoDonors).EndInit();
			pHospitals.ResumeLayout(false);
			pHospitals.PerformLayout();
			flpHospitals.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxNoHospitals).EndInit();
			pUsers.ResumeLayout(false);
			flpUsers.ResumeLayout(false);
			pDUsers.ResumeLayout(false);
			pDUsers.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbxDUsers).EndInit();
			pHUsers.ResumeLayout(false);
			pHUsers.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbxHUsers).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Panel pDashboard;
		private Panel pDonors;
		private Panel pHospitals;
		private Panel pUsers;
		private Label lblDonors;
		private FlowLayoutPanel flpDonors;
		private Label lblHospitals;
		private FlowLayoutPanel flpHospitals;
		private FlowLayoutPanel flpUsers;
		private PictureBox pbxNoDonors;
		private PictureBox pbxNoHospitals;
		private Panel pDUsers;
		private Panel pHUsers;
		private Label lblDUsers;
		private PictureBox pbxDUsers;
		private PictureBox pbxHUsers;
		private Label lblHUsers;
		private Label lblDNumber;
		private Label lblHNumber;
		private TableLayoutPanel tlpAnalytics;
		private Button btnBGAnalytics;
		private Button btnDAnalytics;
		private Button btnEAnalytics;
		private Button btnTAnalytics;
		private Panel pAnalytics;
		private Panel pOxyplot;
		private OxyPlot.WindowsForms.PlotView pvOxyplot;
	}
}
