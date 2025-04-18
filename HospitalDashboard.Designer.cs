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
			lblAppointments = new Label();
			pOperations = new Panel();
			flpOperations = new FlowLayoutPanel();
			pbxNoAppointments = new PictureBox();
			pBloods.SuspendLayout();
			pPatients.SuspendLayout();
			flpPatients.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxNoPatients).BeginInit();
			pAppointments.SuspendLayout();
			flpAppointments.SuspendLayout();
			pOperations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxNoAppointments).BeginInit();
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
			pAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
			pOperations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
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
			flpOperations.FlowDirection = FlowDirection.TopDown;
			flpOperations.Location = new Point(10, 10);
			flpOperations.Name = "flpOperations";
			flpOperations.Size = new Size(308, 289);
			flpOperations.TabIndex = 16;
			flpOperations.WrapContents = false;
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
			pOperations.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxNoAppointments).EndInit();
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
	}
}
