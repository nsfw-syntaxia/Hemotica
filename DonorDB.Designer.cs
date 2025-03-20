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
            pHospital = new Panel();
            tblpHospitals = new TableLayoutPanel();
            pHospital1 = new Panel();
            btnView1 = new AntdUI.Button();
            pbxHospital1 = new PictureBox();
            lblHospital1 = new Label();
            pHospital2 = new Panel();
            lblHospitals = new Label();
            pHistory = new Panel();
            pbxChart = new PictureBox();
            tblpHistory = new TableLayoutPanel();
            pDH3 = new Panel();
            lblH3 = new Label();
            btnDH3 = new AntdUI.Button();
            pDH1 = new Panel();
            lblH1 = new Label();
            btnDH1 = new AntdUI.Button();
            pDH2 = new Panel();
            lblH2 = new Label();
            btnDH2 = new AntdUI.Button();
            lblHistory = new Label();
            tblpDashboard.SuspendLayout();
            pHospital.SuspendLayout();
            tblpHospitals.SuspendLayout();
            pHospital1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxHospital1).BeginInit();
            pHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxChart).BeginInit();
            tblpHistory.SuspendLayout();
            pDH3.SuspendLayout();
            pDH1.SuspendLayout();
            pDH2.SuspendLayout();
            SuspendLayout();
            // 
            // tblpDashboard
            // 
            tblpDashboard.ColumnCount = 3;
            tblpDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblpDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblpDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblpDashboard.Controls.Add(pDonation, 0, 0);
            tblpDashboard.Controls.Add(pHospital, 2, 0);
            tblpDashboard.Controls.Add(pHistory, 2, 0);
            tblpDashboard.Dock = DockStyle.Fill;
            tblpDashboard.Location = new Point(0, 0);
            tblpDashboard.Name = "tblpDashboard";
            tblpDashboard.Padding = new Padding(1);
            tblpDashboard.RowCount = 3;
            tblpDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblpDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblpDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblpDashboard.Size = new Size(1020, 641);
            tblpDashboard.TabIndex = 0;
            // 
            // pDonation
            // 
            pDonation.BackColor = Color.FromArgb(252, 228, 228);
            tblpDashboard.SetColumnSpan(pDonation, 2);
            pDonation.Dock = DockStyle.Fill;
            pDonation.Location = new Point(4, 4);
            pDonation.Name = "pDonation";
            tblpDashboard.SetRowSpan(pDonation, 2);
            pDonation.Size = new Size(672, 420);
            pDonation.TabIndex = 0;
            // 
            // pHospital
            // 
            pHospital.BackColor = Color.FromArgb(252, 228, 228);
            tblpDashboard.SetColumnSpan(pHospital, 2);
            pHospital.Controls.Add(tblpHospitals);
            pHospital.Controls.Add(lblHospitals);
            pHospital.Dock = DockStyle.Fill;
            pHospital.Location = new Point(4, 430);
            pHospital.Name = "pHospital";
            pHospital.Size = new Size(672, 207);
            pHospital.TabIndex = 1;
            // 
            // tblpHospitals
            // 
            tblpHospitals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblpHospitals.ColumnCount = 2;
            tblpHospitals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblpHospitals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblpHospitals.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblpHospitals.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblpHospitals.Controls.Add(pHospital1, 0, 0);
            tblpHospitals.Controls.Add(pHospital2, 1, 0);
            tblpHospitals.Location = new Point(3, 46);
            tblpHospitals.Name = "tblpHospitals";
            tblpHospitals.RowCount = 1;
            tblpHospitals.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblpHospitals.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblpHospitals.Size = new Size(666, 158);
            tblpHospitals.TabIndex = 10;
            // 
            // pHospital1
            // 
            pHospital1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pHospital1.Controls.Add(btnView1);
            pHospital1.Controls.Add(pbxHospital1);
            pHospital1.Controls.Add(lblHospital1);
            pHospital1.Location = new Point(3, 3);
            pHospital1.Name = "pHospital1";
            pHospital1.Size = new Size(327, 152);
            pHospital1.TabIndex = 0;
            // 
            // btnView1
            // 
            btnView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnView1.DefaultBack = Color.FromArgb(244, 148, 156);
            btnView1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnView1.ForeColor = Color.FromArgb(252, 228, 228);
            btnView1.Location = new Point(32, 75);
            btnView1.Name = "btnView1";
            btnView1.Size = new Size(114, 45);
            btnView1.TabIndex = 13;
            btnView1.Text = "View Details";
            // 
            // pbxHospital1
            // 
            pbxHospital1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pbxHospital1.BackColor = Color.FromArgb(244, 148, 156);
            pbxHospital1.Image = (Image)resources.GetObject("pbxHospital1.Image");
            pbxHospital1.Location = new Point(181, 0);
            pbxHospital1.Name = "pbxHospital1";
            pbxHospital1.Size = new Size(146, 152);
            pbxHospital1.TabIndex = 1;
            pbxHospital1.TabStop = false;
            // 
            // lblHospital1
            // 
            lblHospital1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblHospital1.AutoSize = true;
            lblHospital1.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            lblHospital1.ForeColor = Color.FromArgb(244, 148, 156);
            lblHospital1.Location = new Point(32, 38);
            lblHospital1.Name = "lblHospital1";
            lblHospital1.Padding = new Padding(5, 5, 0, 5);
            lblHospital1.Size = new Size(114, 34);
            lblHospital1.TabIndex = 11;
            lblHospital1.Text = "Hospital #1";
            // 
            // pHospital2
            // 
            pHospital2.Dock = DockStyle.Fill;
            pHospital2.Location = new Point(336, 3);
            pHospital2.Name = "pHospital2";
            pHospital2.Size = new Size(327, 152);
            pHospital2.TabIndex = 1;
            // 
            // lblHospitals
            // 
            lblHospitals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblHospitals.AutoSize = true;
            lblHospitals.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
            lblHospitals.ForeColor = Color.FromArgb(244, 148, 156);
            lblHospitals.Location = new Point(3, 0);
            lblHospitals.Name = "lblHospitals";
            lblHospitals.Padding = new Padding(5, 5, 0, 5);
            lblHospitals.Size = new Size(319, 43);
            lblHospitals.TabIndex = 9;
            lblHospitals.Text = "Recommended Hospitals";
            // 
            // pHistory
            // 
            pHistory.BackColor = Color.FromArgb(252, 228, 228);
            pHistory.Controls.Add(pbxChart);
            pHistory.Controls.Add(tblpHistory);
            pHistory.Controls.Add(lblHistory);
            pHistory.Dock = DockStyle.Fill;
            pHistory.Location = new Point(682, 4);
            pHistory.Name = "pHistory";
            tblpDashboard.SetRowSpan(pHistory, 3);
            pHistory.Size = new Size(334, 633);
            pHistory.TabIndex = 2;
            // 
            // pbxChart
            // 
            pbxChart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbxChart.Image = (Image)resources.GetObject("pbxChart.Image");
            pbxChart.Location = new Point(3, 426);
            pbxChart.Name = "pbxChart";
            pbxChart.Size = new Size(328, 204);
            pbxChart.TabIndex = 12;
            pbxChart.TabStop = false;
            // 
            // tblpHistory
            // 
            tblpHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblpHistory.ColumnCount = 1;
            tblpHistory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpHistory.Controls.Add(pDH3, 0, 2);
            tblpHistory.Controls.Add(pDH1, 0, 0);
            tblpHistory.Controls.Add(pDH2, 0, 1);
            tblpHistory.Location = new Point(3, 46);
            tblpHistory.Name = "tblpHistory";
            tblpHistory.RowCount = 4;
            tblpHistory.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblpHistory.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblpHistory.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblpHistory.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblpHistory.Size = new Size(328, 374);
            tblpHistory.TabIndex = 11;
            // 
            // pDH3
            // 
            pDH3.Controls.Add(lblH3);
            pDH3.Controls.Add(btnDH3);
            pDH3.Dock = DockStyle.Fill;
            pDH3.Location = new Point(3, 189);
            pDH3.Name = "pDH3";
            pDH3.Size = new Size(322, 87);
            pDH3.TabIndex = 1;
            // 
            // lblH3
            // 
            lblH3.Anchor = AnchorStyles.Right;
            lblH3.AutoSize = true;
            lblH3.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            lblH3.ForeColor = Color.FromArgb(244, 148, 156);
            lblH3.Location = new Point(157, 28);
            lblH3.Name = "lblH3";
            lblH3.Padding = new Padding(5, 5, 0, 5);
            lblH3.Size = new Size(141, 34);
            lblH3.TabIndex = 19;
            lblH3.Text = "@ Hospital #3";
            // 
            // btnDH3
            // 
            btnDH3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDH3.DefaultBack = Color.FromArgb(244, 148, 156);
            btnDH3.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnDH3.ForeColor = Color.FromArgb(252, 228, 228);
            btnDH3.Location = new Point(0, 0);
            btnDH3.Name = "btnDH3";
            btnDH3.Size = new Size(136, 87);
            btnDH3.TabIndex = 19;
            btnDH3.Text = "14 AUG 2024";
            // 
            // pDH1
            // 
            pDH1.Controls.Add(lblH1);
            pDH1.Controls.Add(btnDH1);
            pDH1.Dock = DockStyle.Fill;
            pDH1.Location = new Point(3, 3);
            pDH1.Name = "pDH1";
            pDH1.Size = new Size(322, 87);
            pDH1.TabIndex = 0;
            // 
            // lblH1
            // 
            lblH1.Anchor = AnchorStyles.Right;
            lblH1.AutoSize = true;
            lblH1.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            lblH1.ForeColor = Color.FromArgb(244, 148, 156);
            lblH1.Location = new Point(157, 25);
            lblH1.Name = "lblH1";
            lblH1.Padding = new Padding(5, 5, 0, 5);
            lblH1.Size = new Size(137, 34);
            lblH1.TabIndex = 19;
            lblH1.Text = "@ Hospital #1";
            // 
            // btnDH1
            // 
            btnDH1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDH1.DefaultBack = Color.FromArgb(244, 148, 156);
            btnDH1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnDH1.ForeColor = Color.FromArgb(252, 228, 228);
            btnDH1.Location = new Point(0, 0);
            btnDH1.Name = "btnDH1";
            btnDH1.Size = new Size(136, 87);
            btnDH1.TabIndex = 17;
            btnDH1.Text = "28 FEB 2025";
            // 
            // pDH2
            // 
            pDH2.Controls.Add(lblH2);
            pDH2.Controls.Add(btnDH2);
            pDH2.Dock = DockStyle.Fill;
            pDH2.Location = new Point(3, 96);
            pDH2.Name = "pDH2";
            pDH2.Size = new Size(322, 87);
            pDH2.TabIndex = 1;
            // 
            // lblH2
            // 
            lblH2.Anchor = AnchorStyles.Right;
            lblH2.AutoSize = true;
            lblH2.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            lblH2.ForeColor = Color.FromArgb(244, 148, 156);
            lblH2.Location = new Point(157, 26);
            lblH2.Name = "lblH2";
            lblH2.Padding = new Padding(5, 5, 0, 5);
            lblH2.Size = new Size(140, 34);
            lblH2.TabIndex = 17;
            lblH2.Text = "@ Hospital #2";
            // 
            // btnDH2
            // 
            btnDH2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDH2.DefaultBack = Color.FromArgb(244, 148, 156);
            btnDH2.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnDH2.ForeColor = Color.FromArgb(252, 228, 228);
            btnDH2.Location = new Point(0, 0);
            btnDH2.Name = "btnDH2";
            btnDH2.Size = new Size(136, 87);
            btnDH2.TabIndex = 18;
            btnDH2.Text = "3 NOV 2024";
            // 
            // lblHistory
            // 
            lblHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
            lblHistory.ForeColor = Color.FromArgb(244, 148, 156);
            lblHistory.Location = new Point(3, 0);
            lblHistory.Name = "lblHistory";
            lblHistory.Padding = new Padding(5, 5, 0, 5);
            lblHistory.Size = new Size(223, 43);
            lblHistory.TabIndex = 10;
            lblHistory.Text = "Donation History";
            // 
            // DonorDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 211, 211);
            Controls.Add(tblpDashboard);
            Name = "DonorDB";
            Size = new Size(1020, 641);
            tblpDashboard.ResumeLayout(false);
            pHospital.ResumeLayout(false);
            pHospital.PerformLayout();
            tblpHospitals.ResumeLayout(false);
            pHospital1.ResumeLayout(false);
            pHospital1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxHospital1).EndInit();
            pHistory.ResumeLayout(false);
            pHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxChart).EndInit();
            tblpHistory.ResumeLayout(false);
            pDH3.ResumeLayout(false);
            pDH3.PerformLayout();
            pDH1.ResumeLayout(false);
            pDH1.PerformLayout();
            pDH2.ResumeLayout(false);
            pDH2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblpDashboard;
        private Panel pDonation;
        private Panel pHospital;
        private Panel pHistory;
        private Label lblHospitals;
        private Label lblHistory;
        private TableLayoutPanel tblpHistory;
        private TableLayoutPanel tblpHospitals;
        private Panel pHospital1;
        private Label lblHospital1;
        private AntdUI.Button btnView1;
        private PictureBox pbxHospital1;
        private Panel pHospital2;
        private AntdUI.Button btnDH1;
        private AntdUI.Button btnDH3;
        private AntdUI.Button btnDH2;
        private Panel pDH3;
        private Panel pDH1;
        private Panel pDH2;
        private Label lblH1;
        private Label lblH2;
        private Label lblH3;
        private PictureBox pbxChart;
    }
}
