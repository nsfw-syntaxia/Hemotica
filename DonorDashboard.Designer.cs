namespace Hemotica
{
	partial class DonorDashboard
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
			pBloodDrives = new Panel();
			pBDrives = new Panel();
			pbxBloodDrives = new PictureBox();
			pAnalytics = new Panel();
			flpAnalytics = new FlowLayoutPanel();
			pHospitals = new Panel();
			flpHospitals = new FlowLayoutPanel();
			lblHospitals = new Label();
			pLogs = new Panel();
			flpLogs = new FlowLayoutPanel();
			lblLogs = new Label();
			pBloodDrives.SuspendLayout();
			pBDrives.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxBloodDrives).BeginInit();
			pAnalytics.SuspendLayout();
			pHospitals.SuspendLayout();
			pLogs.SuspendLayout();
			SuspendLayout();
			// 
			// pBloodDrives
			// 
			pBloodDrives.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pBloodDrives.BackColor = Color.FromArgb(216, 85, 101);
			pBloodDrives.Controls.Add(pBDrives);
			pBloodDrives.Location = new Point(8, 8);
			pBloodDrives.Name = "pBloodDrives";
			pBloodDrives.Padding = new Padding(7);
			pBloodDrives.Size = new Size(600, 372);
			pBloodDrives.TabIndex = 0;
			// 
			// pBDrives
			// 
			pBDrives.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pBDrives.BackColor = Color.FromArgb(216, 85, 101);
			pBDrives.Controls.Add(pbxBloodDrives);
			pBDrives.Location = new Point(10, 10);
			pBDrives.Name = "pBDrives";
			pBDrives.Size = new Size(580, 352);
			pBDrives.TabIndex = 0;
			// 
			// pbxBloodDrives
			// 
			pbxBloodDrives.BackColor = Color.FromArgb(252, 228, 228);
			pbxBloodDrives.Dock = DockStyle.Fill;
			pbxBloodDrives.Location = new Point(0, 0);
			pbxBloodDrives.Name = "pbxBloodDrives";
			pbxBloodDrives.Size = new Size(580, 352);
			pbxBloodDrives.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxBloodDrives.TabIndex = 0;
			pbxBloodDrives.TabStop = false;
			// 
			// pAnalytics
			// 
			pAnalytics.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			pAnalytics.BackColor = Color.FromArgb(216, 85, 101);
			pAnalytics.Controls.Add(flpAnalytics);
			pAnalytics.Location = new Point(614, 8);
			pAnalytics.Name = "pAnalytics";
			pAnalytics.Padding = new Padding(7);
			pAnalytics.Size = new Size(398, 246);
			pAnalytics.TabIndex = 1;
			// 
			// flpAnalytics
			// 
			flpAnalytics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpAnalytics.BackColor = Color.FromArgb(252, 228, 228);
			flpAnalytics.Location = new Point(10, 10);
			flpAnalytics.Name = "flpAnalytics";
			flpAnalytics.Size = new Size(378, 226);
			flpAnalytics.TabIndex = 0;
			// 
			// pHospitals
			// 
			pHospitals.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pHospitals.BackColor = Color.FromArgb(216, 85, 101);
			pHospitals.Controls.Add(flpHospitals);
			pHospitals.Controls.Add(lblHospitals);
			pHospitals.Location = new Point(8, 386);
			pHospitals.Name = "pHospitals";
			pHospitals.Padding = new Padding(7);
			pHospitals.Size = new Size(600, 247);
			pHospitals.TabIndex = 1;
			// 
			// flpHospitals
			// 
			flpHospitals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpHospitals.AutoScroll = true;
			flpHospitals.BackColor = Color.FromArgb(252, 228, 228);
			flpHospitals.Location = new Point(10, 48);
			flpHospitals.Name = "flpHospitals";
			flpHospitals.Size = new Size(580, 189);
			flpHospitals.TabIndex = 13;
			flpHospitals.WrapContents = false;
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
			lblHospitals.Size = new Size(153, 38);
			lblHospitals.TabIndex = 12;
			lblHospitals.Text = "Hospitals >";
			// 
			// pLogs
			// 
			pLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			pLogs.BackColor = Color.FromArgb(216, 85, 101);
			pLogs.Controls.Add(flpLogs);
			pLogs.Controls.Add(lblLogs);
			pLogs.Location = new Point(614, 260);
			pLogs.Name = "pLogs";
			pLogs.Padding = new Padding(7);
			pLogs.Size = new Size(398, 373);
			pLogs.TabIndex = 2;
			// 
			// flpLogs
			// 
			flpLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpLogs.AutoScroll = true;
			flpLogs.BackColor = Color.FromArgb(252, 228, 228);
			flpLogs.FlowDirection = FlowDirection.TopDown;
			flpLogs.Location = new Point(10, 48);
			flpLogs.Name = "flpLogs";
			flpLogs.Size = new Size(378, 315);
			flpLogs.TabIndex = 14;
			flpLogs.WrapContents = false;
			// 
			// lblLogs
			// 
			lblLogs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblLogs.AutoSize = true;
			lblLogs.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblLogs.ForeColor = Color.FromArgb(253, 211, 211);
			lblLogs.Location = new Point(0, 7);
			lblLogs.Name = "lblLogs";
			lblLogs.Padding = new Padding(5, 0, 0, 5);
			lblLogs.Size = new Size(242, 38);
			lblLogs.TabIndex = 10;
			lblLogs.Text = "Donation History >";
			// 
			// DonorDashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(pLogs);
			Controls.Add(pHospitals);
			Controls.Add(pAnalytics);
			Controls.Add(pBloodDrives);
			DoubleBuffered = true;
			Name = "DonorDashboard";
			Padding = new Padding(5);
			Size = new Size(1020, 641);
			Load += DonorDashboard_Load;
			Resize += DonorDashboard_Resize;
			pBloodDrives.ResumeLayout(false);
			pBDrives.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxBloodDrives).EndInit();
			pAnalytics.ResumeLayout(false);
			pHospitals.ResumeLayout(false);
			pHospitals.PerformLayout();
			pLogs.ResumeLayout(false);
			pLogs.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel pBloodDrives;
		private Panel pAnalytics;
		private Panel pHospitals;
		private Panel pLogs;
		private Label lblHospitals;
		private FlowLayoutPanel flpHospitals;
		private Label lblLogs;
		private FlowLayoutPanel flpLogs;
		private FlowLayoutPanel flpAnalytics;
		private PictureBox pbxBloodDrives;
		private Panel pBDrives;
	}
}
