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
			pBloods = new Panel();
			flpBloods = new FlowLayoutPanel();
			pPatients = new Panel();
			flpPatients = new FlowLayoutPanel();
			pbxNoPatients = new PictureBox();
			lblPatients = new Label();
			pAppointments = new Panel();
			flpAppointments = new FlowLayoutPanel();
			pbxNoAppointments = new PictureBox();
			lblAppointments = new Label();
			pOperations = new Panel();
			flpOperations = new FlowLayoutPanel();
			pExtraction = new Panel();
			pTransfusion = new Panel();
			lblExtractions = new Label();
			pbxExtraction = new PictureBox();
			pbxTransfusion = new PictureBox();
			lblTransfusions = new Label();
			pBloods.SuspendLayout();
			pPatients.SuspendLayout();
			flpPatients.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxNoPatients).BeginInit();
			pAppointments.SuspendLayout();
			flpAppointments.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxNoAppointments).BeginInit();
			pOperations.SuspendLayout();
			flpOperations.SuspendLayout();
			pExtraction.SuspendLayout();
			pTransfusion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxExtraction).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbxTransfusion).BeginInit();
			SuspendLayout();
			// 
			// pBloods
			// 
			pBloods.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pBloods.BackColor = Color.FromArgb(216, 85, 101);
			pBloods.Controls.Add(flpBloods);
			pBloods.Location = new Point(8, 8);
			pBloods.Name = "pBloods";
			pBloods.Padding = new Padding(7);
			pBloods.Size = new Size(670, 372);
			pBloods.TabIndex = 1;
			// 
			// flpBloods
			// 
			flpBloods.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpBloods.BackColor = Color.FromArgb(252, 228, 228);
			flpBloods.Location = new Point(10, 10);
			flpBloods.Name = "flpBloods";
			flpBloods.Size = new Size(650, 352);
			flpBloods.TabIndex = 17;
			flpBloods.WrapContents = false;
			// 
			// pPatients
			// 
			pPatients.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pPatients.BackColor = Color.FromArgb(216, 85, 101);
			pPatients.Controls.Add(flpPatients);
			pPatients.Controls.Add(lblPatients);
			pPatients.Location = new Point(8, 386);
			pPatients.Name = "pPatients";
			pPatients.Padding = new Padding(7);
			pPatients.Size = new Size(670, 247);
			pPatients.TabIndex = 2;
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
			lblPatients.Size = new Size(137, 38);
			lblPatients.TabIndex = 13;
			lblPatients.Text = "Patients >";
			// 
			// pAppointments
			// 
			pAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			pAppointments.BackColor = Color.FromArgb(216, 85, 101);
			pAppointments.Controls.Add(flpAppointments);
			pAppointments.Controls.Add(lblAppointments);
			pAppointments.Location = new Point(684, 8);
			pAppointments.Name = "pAppointments";
			pAppointments.Padding = new Padding(7);
			pAppointments.Size = new Size(328, 310);
			pAppointments.TabIndex = 3;
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
			lblAppointments.Size = new Size(207, 38);
			lblAppointments.TabIndex = 15;
			lblAppointments.Text = "Appointments >";
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
			pExtraction.Controls.Add(lblExtractions);
			pExtraction.Controls.Add(pbxExtraction);
			pExtraction.Location = new Point(6, 6);
			pExtraction.Name = "pExtraction";
			pExtraction.Padding = new Padding(5);
			pExtraction.Size = new Size(296, 136);
			pExtraction.TabIndex = 0;
			// 
			// pTransfusion
			// 
			pTransfusion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			pTransfusion.BackColor = Color.FromArgb(244, 180, 180);
			pTransfusion.Controls.Add(lblTransfusions);
			pTransfusion.Controls.Add(pbxTransfusion);
			pTransfusion.Location = new Point(6, 148);
			pTransfusion.Name = "pTransfusion";
			pTransfusion.Padding = new Padding(5);
			pTransfusion.Size = new Size(296, 136);
			pTransfusion.TabIndex = 1;
			// 
			// lblExtractions
			// 
			lblExtractions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblExtractions.AutoSize = true;
			lblExtractions.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
			lblExtractions.ForeColor = Color.FromArgb(216, 85, 101);
			lblExtractions.Location = new Point(155, 8);
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
			// 
			// lblTransfusions
			// 
			lblTransfusions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblTransfusions.AutoSize = true;
			lblTransfusions.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
			lblTransfusions.ForeColor = Color.FromArgb(216, 85, 101);
			lblTransfusions.Location = new Point(150, 8);
			lblTransfusions.Name = "lblTransfusions";
			lblTransfusions.Padding = new Padding(0, 3, 0, 0);
			lblTransfusions.Size = new Size(124, 51);
			lblTransfusions.TabIndex = 20;
			lblTransfusions.Text = "Blood\r\nTransfusions";
			lblTransfusions.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// HospitalDashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(pOperations);
			Controls.Add(pAppointments);
			Controls.Add(pPatients);
			Controls.Add(pBloods);
			Name = "HospitalDashboard";
			Padding = new Padding(5);
			Size = new Size(1020, 641);
			Load += HospitalDashboard_Load;
			Resize += HospitalDashboard_Resize;
			pBloods.ResumeLayout(false);
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
			pTransfusion.ResumeLayout(false);
			pTransfusion.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbxExtraction).EndInit();
			((System.ComponentModel.ISupportInitialize)pbxTransfusion).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Panel pBloods;
		private Panel pPatients;
		private Panel pAppointments;
		private Panel pOperations;
		private Label lblPatients;
		private FlowLayoutPanel flpPatients;
		private Label lblAppointments;
		private FlowLayoutPanel flpAppointments;
		private FlowLayoutPanel flpOperations;
		private FlowLayoutPanel flpBloods;
		private PictureBox pbxNoPatients;
		private PictureBox pbxNoAppointments;
		private Panel pExtraction;
		private Panel pTransfusion;
		private Label lblExtractions;
		private PictureBox pbxExtraction;
		private PictureBox pbxTransfusion;
		private Label lblTransfusions;
	}
}
