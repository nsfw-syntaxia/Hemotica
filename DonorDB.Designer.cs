namespace Hemotica
{
    partial class DonorDB
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorDB));
			tblpDashboard = new TableLayoutPanel();
			pDonation = new Panel();
			pbxDonation = new PictureBox();
			pCharts = new Panel();
			pbxCharts = new PictureBox();
			pHistory = new Panel();
			tblpDonationHistory = new TableLayoutPanel();
			btnYear1 = new AntdUI.Button();
			btnDH1 = new AntdUI.Button();
			btnYear2 = new AntdUI.Button();
			btnDH2 = new AntdUI.Button();
			lblDH1 = new Label();
			lblDH2 = new Label();
			lblDonationHistory = new Label();
			pHospitals = new Panel();
			tblpHospitals = new TableLayoutPanel();
			pH1 = new Panel();
			btnDonate = new AntdUI.Button();
			lblH1 = new Label();
			pbxH1 = new PictureBox();
			pNext = new Panel();
			btnSeeMore = new AntdUI.Button();
			lblHospitals = new Label();
			tblpDashboard.SuspendLayout();
			pDonation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxDonation).BeginInit();
			pCharts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxCharts).BeginInit();
			pHistory.SuspendLayout();
			tblpDonationHistory.SuspendLayout();
			pHospitals.SuspendLayout();
			tblpHospitals.SuspendLayout();
			pH1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxH1).BeginInit();
			pNext.SuspendLayout();
			SuspendLayout();
			// 
			// tblpDashboard
			// 
			tblpDashboard.ColumnCount = 5;
			tblpDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpDashboard.Controls.Add(pDonation, 0, 0);
			tblpDashboard.Controls.Add(pCharts, 3, 0);
			tblpDashboard.Controls.Add(pHistory, 3, 2);
			tblpDashboard.Controls.Add(pHospitals, 0, 3);
			tblpDashboard.Dock = DockStyle.Fill;
			tblpDashboard.Location = new Point(0, 0);
			tblpDashboard.Name = "tblpDashboard";
			tblpDashboard.Padding = new Padding(5);
			tblpDashboard.RowCount = 5;
			tblpDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tblpDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tblpDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tblpDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tblpDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tblpDashboard.Size = new Size(1020, 641);
			tblpDashboard.TabIndex = 0;
			// 
			// pDonation
			// 
			pDonation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pDonation.BackColor = Color.FromArgb(216, 85, 101);
			tblpDashboard.SetColumnSpan(pDonation, 3);
			pDonation.Controls.Add(pbxDonation);
			pDonation.Location = new Point(8, 8);
			pDonation.Name = "pDonation";
			pDonation.Padding = new Padding(7);
			tblpDashboard.SetRowSpan(pDonation, 3);
			pDonation.Size = new Size(600, 372);
			pDonation.TabIndex = 0;
			// 
			// pbxDonation
			// 
			pbxDonation.Dock = DockStyle.Fill;
			pbxDonation.Image = (Image)resources.GetObject("pbxDonation.Image");
			pbxDonation.Location = new Point(7, 7);
			pbxDonation.Name = "pbxDonation";
			pbxDonation.Size = new Size(586, 358);
			pbxDonation.TabIndex = 0;
			pbxDonation.TabStop = false;
			// 
			// pCharts
			// 
			pCharts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pCharts.BackColor = Color.FromArgb(216, 85, 101);
			tblpDashboard.SetColumnSpan(pCharts, 2);
			pCharts.Controls.Add(pbxCharts);
			pCharts.Location = new Point(614, 8);
			pCharts.Name = "pCharts";
			pCharts.Padding = new Padding(7);
			tblpDashboard.SetRowSpan(pCharts, 2);
			pCharts.Size = new Size(398, 246);
			pCharts.TabIndex = 1;
			// 
			// pbxCharts
			// 
			pbxCharts.Dock = DockStyle.Fill;
			pbxCharts.Image = (Image)resources.GetObject("pbxCharts.Image");
			pbxCharts.Location = new Point(7, 7);
			pbxCharts.Name = "pbxCharts";
			pbxCharts.Size = new Size(384, 232);
			pbxCharts.TabIndex = 0;
			pbxCharts.TabStop = false;
			// 
			// pHistory
			// 
			pHistory.BackColor = Color.FromArgb(216, 85, 101);
			tblpDashboard.SetColumnSpan(pHistory, 2);
			pHistory.Controls.Add(tblpDonationHistory);
			pHistory.Controls.Add(lblDonationHistory);
			pHistory.Dock = DockStyle.Fill;
			pHistory.Location = new Point(614, 260);
			pHistory.Name = "pHistory";
			pHistory.Padding = new Padding(7);
			tblpDashboard.SetRowSpan(pHistory, 3);
			pHistory.Size = new Size(398, 373);
			pHistory.TabIndex = 2;
			// 
			// tblpDonationHistory
			// 
			tblpDonationHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			tblpDonationHistory.ColumnCount = 2;
			tblpDonationHistory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tblpDonationHistory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			tblpDonationHistory.Controls.Add(btnYear1, 0, 0);
			tblpDonationHistory.Controls.Add(btnDH1, 0, 1);
			tblpDonationHistory.Controls.Add(btnYear2, 0, 3);
			tblpDonationHistory.Controls.Add(btnDH2, 0, 4);
			tblpDonationHistory.Controls.Add(lblDH1, 1, 1);
			tblpDonationHistory.Controls.Add(lblDH2, 1, 4);
			tblpDonationHistory.Location = new Point(7, 43);
			tblpDonationHistory.Name = "tblpDonationHistory";
			tblpDonationHistory.RowCount = 7;
			tblpDonationHistory.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tblpDonationHistory.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tblpDonationHistory.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tblpDonationHistory.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tblpDonationHistory.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tblpDonationHistory.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tblpDonationHistory.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tblpDonationHistory.Size = new Size(384, 320);
			tblpDonationHistory.TabIndex = 10;
			// 
			// btnYear1
			// 
			btnYear1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tblpDonationHistory.SetColumnSpan(btnYear1, 2);
			btnYear1.DefaultBack = Color.FromArgb(253, 211, 211);
			btnYear1.Font = new Font("Bahnschrift", 14F);
			btnYear1.Location = new Point(3, 3);
			btnYear1.Name = "btnYear1";
			btnYear1.Size = new Size(378, 39);
			btnYear1.TabIndex = 0;
			btnYear1.Text = "2025";
			// 
			// btnDH1
			// 
			btnDH1.DefaultBack = Color.FromArgb(244, 180, 180);
			btnDH1.Dock = DockStyle.Fill;
			btnDH1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDH1.Location = new Point(3, 48);
			btnDH1.Name = "btnDH1";
			tblpDonationHistory.SetRowSpan(btnDH1, 2);
			btnDH1.Size = new Size(147, 84);
			btnDH1.TabIndex = 1;
			btnDH1.Text = "MARCH 19";
			// 
			// btnYear2
			// 
			tblpDonationHistory.SetColumnSpan(btnYear2, 2);
			btnYear2.DefaultBack = Color.FromArgb(253, 211, 211);
			btnYear2.Dock = DockStyle.Fill;
			btnYear2.Font = new Font("Bahnschrift", 14F);
			btnYear2.Location = new Point(3, 138);
			btnYear2.Name = "btnYear2";
			btnYear2.Size = new Size(378, 39);
			btnYear2.TabIndex = 2;
			btnYear2.Text = "2024";
			// 
			// btnDH2
			// 
			btnDH2.DefaultBack = Color.FromArgb(244, 180, 180);
			btnDH2.Dock = DockStyle.Fill;
			btnDH2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDH2.Location = new Point(3, 183);
			btnDH2.Name = "btnDH2";
			tblpDonationHistory.SetRowSpan(btnDH2, 2);
			btnDH2.Size = new Size(147, 84);
			btnDH2.TabIndex = 3;
			btnDH2.Text = "NOVEMBER 3";
			// 
			// lblDH1
			// 
			lblDH1.AutoSize = true;
			lblDH1.BackColor = Color.FromArgb(244, 180, 180);
			lblDH1.Dock = DockStyle.Fill;
			lblDH1.Font = new Font("Bahnschrift", 14F);
			lblDH1.ForeColor = Color.FromArgb(54, 40, 40);
			lblDH1.Location = new Point(156, 45);
			lblDH1.Name = "lblDH1";
			lblDH1.Padding = new Padding(5, 0, 0, 0);
			tblpDonationHistory.SetRowSpan(lblDH1, 2);
			lblDH1.Size = new Size(225, 90);
			lblDH1.TabIndex = 11;
			lblDH1.Text = "@ Hospital 1, HH:MM";
			lblDH1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblDH2
			// 
			lblDH2.AutoSize = true;
			lblDH2.BackColor = Color.FromArgb(244, 180, 180);
			lblDH2.Dock = DockStyle.Fill;
			lblDH2.Font = new Font("Bahnschrift", 14F);
			lblDH2.ForeColor = Color.FromArgb(54, 40, 40);
			lblDH2.Location = new Point(156, 180);
			lblDH2.Name = "lblDH2";
			lblDH2.Padding = new Padding(5, 0, 0, 0);
			tblpDonationHistory.SetRowSpan(lblDH2, 2);
			lblDH2.Size = new Size(225, 90);
			lblDH2.TabIndex = 12;
			lblDH2.Text = "@ Hospital 2, HH:MM";
			lblDH2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblDonationHistory
			// 
			lblDonationHistory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblDonationHistory.AutoSize = true;
			lblDonationHistory.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblDonationHistory.ForeColor = Color.FromArgb(253, 211, 211);
			lblDonationHistory.Location = new Point(7, 7);
			lblDonationHistory.Name = "lblDonationHistory";
			lblDonationHistory.Padding = new Padding(5, 0, 0, 0);
			lblDonationHistory.Size = new Size(223, 33);
			lblDonationHistory.TabIndex = 9;
			lblDonationHistory.Text = "Donation History";
			// 
			// pHospitals
			// 
			pHospitals.BackColor = Color.FromArgb(216, 85, 101);
			tblpDashboard.SetColumnSpan(pHospitals, 3);
			pHospitals.Controls.Add(tblpHospitals);
			pHospitals.Controls.Add(lblHospitals);
			pHospitals.Dock = DockStyle.Fill;
			pHospitals.Location = new Point(8, 386);
			pHospitals.Name = "pHospitals";
			pHospitals.Padding = new Padding(7);
			tblpDashboard.SetRowSpan(pHospitals, 2);
			pHospitals.Size = new Size(600, 247);
			pHospitals.TabIndex = 3;
			// 
			// tblpHospitals
			// 
			tblpHospitals.Anchor = AnchorStyles.Left;
			tblpHospitals.ColumnCount = 4;
			tblpHospitals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tblpHospitals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tblpHospitals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tblpHospitals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tblpHospitals.Controls.Add(pH1, 0, 0);
			tblpHospitals.Controls.Add(pNext, 3, 0);
			tblpHospitals.Location = new Point(10, 43);
			tblpHospitals.Name = "tblpHospitals";
			tblpHospitals.RowCount = 1;
			tblpHospitals.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tblpHospitals.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tblpHospitals.Size = new Size(583, 194);
			tblpHospitals.TabIndex = 12;
			// 
			// pH1
			// 
			pH1.BackColor = Color.FromArgb(253, 211, 211);
			tblpHospitals.SetColumnSpan(pH1, 3);
			pH1.Controls.Add(btnDonate);
			pH1.Controls.Add(lblH1);
			pH1.Controls.Add(pbxH1);
			pH1.Dock = DockStyle.Fill;
			pH1.Location = new Point(3, 3);
			pH1.Name = "pH1";
			pH1.Padding = new Padding(7);
			pH1.Size = new Size(429, 188);
			pH1.TabIndex = 0;
			// 
			// btnDonate
			// 
			btnDonate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			btnDonate.DefaultBack = Color.FromArgb(244, 180, 180);
			btnDonate.Font = new Font("Bahnschrift", 14F);
			btnDonate.ForeColor = Color.FromArgb(54, 40, 40);
			btnDonate.Location = new Point(34, 94);
			btnDonate.Name = "btnDonate";
			btnDonate.Size = new Size(108, 44);
			btnDonate.TabIndex = 2;
			btnDonate.Text = "Donate";
			btnDonate.Click += btnDonate_Click;
			// 
			// lblH1
			// 
			lblH1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblH1.AutoSize = true;
			lblH1.Font = new Font("Bahnschrift", 14F);
			lblH1.ForeColor = Color.FromArgb(54, 40, 40);
			lblH1.Location = new Point(34, 68);
			lblH1.Name = "lblH1";
			lblH1.Size = new Size(108, 23);
			lblH1.TabIndex = 1;
			lblH1.Text = "HOSPITAL 1";
			// 
			// pbxH1
			// 
			pbxH1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			pbxH1.Image = (Image)resources.GetObject("pbxH1.Image");
			pbxH1.Location = new Point(179, 10);
			pbxH1.Name = "pbxH1";
			pbxH1.Size = new Size(240, 168);
			pbxH1.TabIndex = 0;
			pbxH1.TabStop = false;
			// 
			// pNext
			// 
			pNext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pNext.BackColor = Color.FromArgb(253, 211, 211);
			pNext.Controls.Add(btnSeeMore);
			pNext.Location = new Point(438, 3);
			pNext.Name = "pNext";
			pNext.Size = new Size(142, 188);
			pNext.TabIndex = 1;
			// 
			// btnSeeMore
			// 
			btnSeeMore.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnSeeMore.DefaultBack = Color.FromArgb(244, 180, 180);
			btnSeeMore.Font = new Font("Bahnschrift", 14F);
			btnSeeMore.ForeColor = Color.FromArgb(54, 40, 40);
			btnSeeMore.Location = new Point(17, 68);
			btnSeeMore.Name = "btnSeeMore";
			btnSeeMore.Size = new Size(108, 44);
			btnSeeMore.TabIndex = 3;
			btnSeeMore.Text = "See More";
			// 
			// lblHospitals
			// 
			lblHospitals.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblHospitals.AutoSize = true;
			lblHospitals.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblHospitals.ForeColor = Color.FromArgb(253, 211, 211);
			lblHospitals.Location = new Point(7, 7);
			lblHospitals.Name = "lblHospitals";
			lblHospitals.Padding = new Padding(5, 0, 0, 0);
			lblHospitals.Size = new Size(134, 33);
			lblHospitals.TabIndex = 11;
			lblHospitals.Text = "Hospitals";
			// 
			// DonorDB
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(tblpDashboard);
			Name = "DonorDB";
			Size = new Size(1020, 641);
			Load += DonorDB_Load;
			tblpDashboard.ResumeLayout(false);
			pDonation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxDonation).EndInit();
			pCharts.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxCharts).EndInit();
			pHistory.ResumeLayout(false);
			pHistory.PerformLayout();
			tblpDonationHistory.ResumeLayout(false);
			tblpDonationHistory.PerformLayout();
			pHospitals.ResumeLayout(false);
			pHospitals.PerformLayout();
			tblpHospitals.ResumeLayout(false);
			pH1.ResumeLayout(false);
			pH1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbxH1).EndInit();
			pNext.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tblpDashboard;
		private Panel pDonation;
		private PictureBox pbxDonation;
		private Panel pCharts;
		private PictureBox pbxCharts;
		private Panel pHistory;
		private Label lblDonationHistory;
		private TableLayoutPanel tblpDonationHistory;
		private AntdUI.Button btnYear1;
		private AntdUI.Button btnDH1;
		private AntdUI.Button btnYear2;
		private AntdUI.Button btnDH2;
		private Label lblDH1;
		private Label lblDH2;
		private Panel pHospitals;
		private Label lblHospitals;
		private TableLayoutPanel tblpHospitals;
		private Panel pH1;
		private PictureBox pbxH1;
		private Label lblH1;
		private AntdUI.Button btnDonate;
		private Panel pNext;
		private AntdUI.Button btnSeeMore;
	}
}
