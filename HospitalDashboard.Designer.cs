namespace Hemotica
{
	partial class HospitalDashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalDashboard));
			pDashboard = new Panel();
			pAnalytics = new Panel();
			tlpAnalytics = new TableLayoutPanel();
			btnTAnalytics = new Button();
			btnEAnalytics = new Button();
			btnPAnalytics = new Button();
			btnBGAnalytics = new Button();
			pOxyplot = new Panel();
			pvOxyplot = new OxyPlot.WindowsForms.PlotView();
			pPatients = new Panel();
			lblVAP = new Label();
			flpPatients = new FlowLayoutPanel();
			pbxNoPatients = new PictureBox();
			lblPatients = new Label();
			pAppointments = new Panel();
			lblVAA = new Label();
			flpAppointments = new FlowLayoutPanel();
			pbxNoAppointments = new PictureBox();
			lblAppointments = new Label();
			pOperations = new Panel();
			flpOperations = new FlowLayoutPanel();
			pExtraction = new Panel();
			lblENumber = new Label();
			lblExtractions = new Label();
			pbxExtraction = new PictureBox();
			pTransfusion = new Panel();
			lblTNumber = new Label();
			lblTransfusions = new Label();
			pbxTransfusion = new PictureBox();
			pDashboard.SuspendLayout();
			pAnalytics.SuspendLayout();
			tlpAnalytics.SuspendLayout();
			pOxyplot.SuspendLayout();
			pPatients.SuspendLayout();
			flpPatients.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxNoPatients).BeginInit();
			pAppointments.SuspendLayout();
			flpAppointments.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxNoAppointments).BeginInit();
			pOperations.SuspendLayout();
			flpOperations.SuspendLayout();
			pExtraction.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxExtraction).BeginInit();
			pTransfusion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxTransfusion).BeginInit();
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
			tlpAnalytics.Controls.Add(btnPAnalytics, 1, 0);
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
			btnTAnalytics.FlatAppearance.MouseDownBackColor = Color.FromArgb(216, 85, 101);
			btnTAnalytics.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 85, 101);
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
			btnEAnalytics.FlatAppearance.MouseDownBackColor = Color.FromArgb(216, 85, 101);
			btnEAnalytics.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 85, 101);
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
			// btnPAnalytics
			// 
			btnPAnalytics.Dock = DockStyle.Fill;
			btnPAnalytics.FlatAppearance.BorderSize = 0;
			btnPAnalytics.FlatAppearance.MouseDownBackColor = Color.FromArgb(216, 85, 101);
			btnPAnalytics.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 85, 101);
			btnPAnalytics.FlatStyle = FlatStyle.Flat;
			btnPAnalytics.Font = new Font("Bahnschrift", 13F, FontStyle.Bold);
			btnPAnalytics.ForeColor = Color.FromArgb(216, 85, 101);
			btnPAnalytics.Location = new Point(163, 3);
			btnPAnalytics.Name = "btnPAnalytics";
			btnPAnalytics.Size = new Size(154, 28);
			btnPAnalytics.TabIndex = 1;
			btnPAnalytics.Text = "PATIENTS";
			btnPAnalytics.UseVisualStyleBackColor = true;
			btnPAnalytics.Click += btnPAnalytics_Click;
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
			// pPatients
			// 
			pPatients.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pPatients.BackColor = Color.FromArgb(216, 85, 101);
			pPatients.Controls.Add(lblVAP);
			pPatients.Controls.Add(flpPatients);
			pPatients.Controls.Add(lblPatients);
			pPatients.Location = new Point(8, 386);
			pPatients.Name = "pPatients";
			pPatients.Padding = new Padding(7);
			pPatients.Size = new Size(670, 247);
			pPatients.TabIndex = 2;
			// 
			// lblVAP
			// 
			lblVAP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblVAP.AutoSize = true;
			lblVAP.Cursor = Cursors.Hand;
			lblVAP.Font = new Font("Bahnschrift", 12F, FontStyle.Bold | FontStyle.Underline);
			lblVAP.ForeColor = Color.FromArgb(253, 211, 211);
			lblVAP.Location = new Point(593, 18);
			lblVAP.Name = "lblVAP";
			lblVAP.Padding = new Padding(0, 0, 0, 5);
			lblVAP.Size = new Size(67, 24);
			lblVAP.TabIndex = 15;
			lblVAP.Text = "View All";
			lblVAP.Click += lblVAP_Click;
			// 
			// flpPatients
			// 
			flpPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpPatients.AutoScroll = true;
			flpPatients.BackColor = Color.FromArgb(252, 228, 228);
			flpPatients.Controls.Add(pbxNoPatients);
			flpPatients.Location = new Point(10, 48);
			flpPatients.Name = "flpPatients";
			flpPatients.Size = new Size(650, 189);
			flpPatients.TabIndex = 14;
			flpPatients.WrapContents = false;
			// 
			// pbxNoPatients
			// 
			pbxNoPatients.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			pbxNoPatients.Image = (Image)resources.GetObject("pbxNoPatients.Image");
			pbxNoPatients.Location = new Point(3, 3);
			pbxNoPatients.Name = "pbxNoPatients";
			pbxNoPatients.Size = new Size(642, 181);
			pbxNoPatients.SizeMode = PictureBoxSizeMode.Zoom;
			pbxNoPatients.TabIndex = 0;
			pbxNoPatients.TabStop = false;
			// 
			// lblPatients
			// 
			lblPatients.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblPatients.AutoSize = true;
			lblPatients.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblPatients.ForeColor = Color.FromArgb(253, 211, 211);
			lblPatients.Location = new Point(0, 7);
			lblPatients.Name = "lblPatients";
			lblPatients.Padding = new Padding(5, 0, 0, 5);
			lblPatients.Size = new Size(118, 38);
			lblPatients.TabIndex = 13;
			lblPatients.Text = "Patients";
			// 
			// pAppointments
			// 
			pAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			pAppointments.BackColor = Color.FromArgb(216, 85, 101);
			pAppointments.Controls.Add(lblVAA);
			pAppointments.Controls.Add(flpAppointments);
			pAppointments.Controls.Add(lblAppointments);
			pAppointments.Location = new Point(684, 8);
			pAppointments.Name = "pAppointments";
			pAppointments.Padding = new Padding(7);
			pAppointments.Size = new Size(328, 310);
			pAppointments.TabIndex = 3;
			// 
			// lblVAA
			// 
			lblVAA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblVAA.AutoSize = true;
			lblVAA.Cursor = Cursors.Hand;
			lblVAA.Font = new Font("Bahnschrift", 12F, FontStyle.Bold | FontStyle.Underline);
			lblVAA.ForeColor = Color.FromArgb(253, 211, 211);
			lblVAA.Location = new Point(251, 18);
			lblVAA.Name = "lblVAA";
			lblVAA.Padding = new Padding(0, 0, 0, 5);
			lblVAA.Size = new Size(67, 24);
			lblVAA.TabIndex = 16;
			lblVAA.Text = "View All";
			lblVAA.Click += lblVAA_Click;
			// 
			// flpAppointments
			// 
			flpAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpAppointments.AutoScroll = true;
			flpAppointments.BackColor = Color.FromArgb(252, 228, 228);
			flpAppointments.Controls.Add(pbxNoAppointments);
			flpAppointments.FlowDirection = FlowDirection.TopDown;
			flpAppointments.Location = new Point(10, 48);
			flpAppointments.Name = "flpAppointments";
			flpAppointments.Size = new Size(308, 252);
			flpAppointments.TabIndex = 15;
			flpAppointments.WrapContents = false;
			// 
			// pbxNoAppointments
			// 
			pbxNoAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			pbxNoAppointments.Image = (Image)resources.GetObject("pbxNoAppointments.Image");
			pbxNoAppointments.Location = new Point(3, 3);
			pbxNoAppointments.Name = "pbxNoAppointments";
			pbxNoAppointments.Size = new Size(300, 244);
			pbxNoAppointments.SizeMode = PictureBoxSizeMode.Zoom;
			pbxNoAppointments.TabIndex = 0;
			pbxNoAppointments.TabStop = false;
			// 
			// lblAppointments
			// 
			lblAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblAppointments.AutoSize = true;
			lblAppointments.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblAppointments.ForeColor = Color.FromArgb(253, 211, 211);
			lblAppointments.Location = new Point(0, 7);
			lblAppointments.Name = "lblAppointments";
			lblAppointments.Padding = new Padding(5, 0, 0, 5);
			lblAppointments.Size = new Size(188, 38);
			lblAppointments.TabIndex = 15;
			lblAppointments.Text = "Appointments";
			// 
			// pOperations
			// 
			pOperations.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			pOperations.BackColor = Color.FromArgb(216, 85, 101);
			pOperations.Controls.Add(flpOperations);
			pOperations.Location = new Point(684, 324);
			pOperations.Name = "pOperations";
			pOperations.Padding = new Padding(7);
			pOperations.Size = new Size(328, 309);
			pOperations.TabIndex = 4;
			// 
			// flpOperations
			// 
			flpOperations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpOperations.AutoScroll = true;
			flpOperations.BackColor = Color.FromArgb(252, 228, 228);
			flpOperations.Controls.Add(pExtraction);
			flpOperations.Controls.Add(pTransfusion);
			flpOperations.FlowDirection = FlowDirection.TopDown;
			flpOperations.Location = new Point(10, 10);
			flpOperations.Name = "flpOperations";
			flpOperations.Padding = new Padding(3);
			flpOperations.Size = new Size(308, 289);
			flpOperations.TabIndex = 16;
			flpOperations.WrapContents = false;
			// 
			// pExtraction
			// 
			pExtraction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			pExtraction.BackColor = Color.FromArgb(244, 180, 180);
			pExtraction.Controls.Add(lblENumber);
			pExtraction.Controls.Add(lblExtractions);
			pExtraction.Controls.Add(pbxExtraction);
			pExtraction.Cursor = Cursors.Hand;
			pExtraction.Location = new Point(6, 6);
			pExtraction.Name = "pExtraction";
			pExtraction.Padding = new Padding(5);
			pExtraction.Size = new Size(296, 136);
			pExtraction.TabIndex = 0;
			pExtraction.Click += pExtraction_Click;
			// 
			// lblENumber
			// 
			lblENumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblENumber.AutoSize = true;
			lblENumber.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblENumber.ForeColor = Color.FromArgb(216, 85, 101);
			lblENumber.Location = new Point(193, 77);
			lblENumber.Name = "lblENumber";
			lblENumber.Size = new Size(37, 41);
			lblENumber.TabIndex = 20;
			lblENumber.Text = "0";
			// 
			// lblExtractions
			// 
			lblExtractions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblExtractions.AutoSize = true;
			lblExtractions.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
			lblExtractions.ForeColor = Color.FromArgb(216, 85, 101);
			lblExtractions.Location = new Point(155, 13);
			lblExtractions.Name = "lblExtractions";
			lblExtractions.Padding = new Padding(0, 3, 0, 0);
			lblExtractions.Size = new Size(113, 51);
			lblExtractions.TabIndex = 19;
			lblExtractions.Text = "Blood\r\nExtractions";
			lblExtractions.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pbxExtraction
			// 
			pbxExtraction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			pbxExtraction.Image = (Image)resources.GetObject("pbxExtraction.Image");
			pbxExtraction.Location = new Point(8, 8);
			pbxExtraction.Name = "pbxExtraction";
			pbxExtraction.Size = new Size(120, 120);
			pbxExtraction.TabIndex = 0;
			pbxExtraction.TabStop = false;
			pbxExtraction.Click += pbxExtraction_Click;
			// 
			// pTransfusion
			// 
			pTransfusion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			pTransfusion.BackColor = Color.FromArgb(244, 180, 180);
			pTransfusion.Controls.Add(lblTNumber);
			pTransfusion.Controls.Add(lblTransfusions);
			pTransfusion.Controls.Add(pbxTransfusion);
			pTransfusion.Cursor = Cursors.Hand;
			pTransfusion.Location = new Point(6, 148);
			pTransfusion.Name = "pTransfusion";
			pTransfusion.Padding = new Padding(5);
			pTransfusion.Size = new Size(296, 136);
			pTransfusion.TabIndex = 1;
			pTransfusion.Click += pTransfusion_Click;
			// 
			// lblTNumber
			// 
			lblTNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblTNumber.AutoSize = true;
			lblTNumber.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblTNumber.ForeColor = Color.FromArgb(216, 85, 101);
			lblTNumber.Location = new Point(193, 77);
			lblTNumber.Name = "lblTNumber";
			lblTNumber.Size = new Size(37, 41);
			lblTNumber.TabIndex = 21;
			lblTNumber.Text = "0";
			// 
			// lblTransfusions
			// 
			lblTransfusions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblTransfusions.AutoSize = true;
			lblTransfusions.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
			lblTransfusions.ForeColor = Color.FromArgb(216, 85, 101);
			lblTransfusions.Location = new Point(149, 13);
			lblTransfusions.Name = "lblTransfusions";
			lblTransfusions.Padding = new Padding(0, 3, 0, 0);
			lblTransfusions.Size = new Size(124, 51);
			lblTransfusions.TabIndex = 20;
			lblTransfusions.Text = "Blood\r\nTransfusions";
			lblTransfusions.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pbxTransfusion
			// 
			pbxTransfusion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			pbxTransfusion.Image = (Image)resources.GetObject("pbxTransfusion.Image");
			pbxTransfusion.Location = new Point(8, 8);
			pbxTransfusion.Name = "pbxTransfusion";
			pbxTransfusion.Size = new Size(120, 120);
			pbxTransfusion.TabIndex = 1;
			pbxTransfusion.TabStop = false;
			pbxTransfusion.Click += pbxTransfusion_Click;
			// 
			// HospitalDashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(pOperations);
			Controls.Add(pAppointments);
			Controls.Add(pPatients);
			Controls.Add(pDashboard);
			Name = "HospitalDashboard";
			Padding = new Padding(5);
			Size = new Size(1020, 641);
			Load += HospitalDashboard_Load;
			Resize += HospitalDashboard_Resize;
			pDashboard.ResumeLayout(false);
			pAnalytics.ResumeLayout(false);
			tlpAnalytics.ResumeLayout(false);
			pOxyplot.ResumeLayout(false);
			pPatients.ResumeLayout(false);
			pPatients.PerformLayout();
			flpPatients.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxNoPatients).EndInit();
			pAppointments.ResumeLayout(false);
			pAppointments.PerformLayout();
			flpAppointments.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxNoAppointments).EndInit();
			pOperations.ResumeLayout(false);
			flpOperations.ResumeLayout(false);
			pExtraction.ResumeLayout(false);
			pExtraction.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbxExtraction).EndInit();
			pTransfusion.ResumeLayout(false);
			pTransfusion.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbxTransfusion).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Panel pDashboard;
		private Panel pPatients;
		private Panel pAppointments;
		private Panel pOperations;
		private Label lblPatients;
		private FlowLayoutPanel flpPatients;
		private Label lblAppointments;
		private FlowLayoutPanel flpAppointments;
		private FlowLayoutPanel flpOperations;
		private PictureBox pbxNoPatients;
		private PictureBox pbxNoAppointments;
		private Panel pExtraction;
		private Panel pTransfusion;
		private Label lblExtractions;
		private PictureBox pbxExtraction;
		private PictureBox pbxTransfusion;
		private Label lblTransfusions;
		private Label lblENumber;
		private Label lblTNumber;
		private TableLayoutPanel tlpAnalytics;
		private Button btnBGAnalytics;
		private Button btnPAnalytics;
		private Button btnEAnalytics;
		private Button btnTAnalytics;
		private Panel pAnalytics;
		private Panel pOxyplot;
		private OxyPlot.WindowsForms.PlotView pvOxyplot;
		private Label lblVAP;
		private Label lblVAA;
	}
}
