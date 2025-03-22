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
			pBloods = new Panel();
			flpBloods = new FlowLayoutPanel();
			pUrgent = new Panel();
			flpUrgent = new FlowLayoutPanel();
			lblUrgent = new Label();
			pAppointments = new Panel();
			flpAppointments = new FlowLayoutPanel();
			lblAppointments = new Label();
			pOperations = new Panel();
			flpOperations = new FlowLayoutPanel();
			pBloods.SuspendLayout();
			pUrgent.SuspendLayout();
			pAppointments.SuspendLayout();
			pOperations.SuspendLayout();
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
			// pUrgent
			// 
			pUrgent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pUrgent.BackColor = Color.FromArgb(216, 85, 101);
			pUrgent.Controls.Add(flpUrgent);
			pUrgent.Controls.Add(lblUrgent);
			pUrgent.Location = new Point(8, 386);
			pUrgent.Name = "pUrgent";
			pUrgent.Padding = new Padding(7);
			pUrgent.Size = new Size(670, 247);
			pUrgent.TabIndex = 2;
			// 
			// flpUrgent
			// 
			flpUrgent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpUrgent.AutoScroll = true;
			flpUrgent.BackColor = Color.FromArgb(252, 228, 228);
			flpUrgent.Location = new Point(10, 48);
			flpUrgent.Name = "flpUrgent";
			flpUrgent.Size = new Size(650, 189);
			flpUrgent.TabIndex = 14;
			flpUrgent.WrapContents = false;
			// 
			// lblUrgent
			// 
			lblUrgent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblUrgent.AutoSize = true;
			lblUrgent.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblUrgent.ForeColor = Color.FromArgb(253, 211, 211);
			lblUrgent.Location = new Point(0, 7);
			lblUrgent.Name = "lblUrgent";
			lblUrgent.Padding = new Padding(5, 0, 0, 5);
			lblUrgent.Size = new Size(122, 38);
			lblUrgent.TabIndex = 13;
			lblUrgent.Text = "Urgent >";
			lblUrgent.Click += lblUrgent_Click;
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
			lblAppointments.Click += lblAppointments_Click;
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
			// HospitalDashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(pOperations);
			Controls.Add(pAppointments);
			Controls.Add(pUrgent);
			Controls.Add(pBloods);
			Name = "HospitalDashboard";
			Padding = new Padding(5);
			Size = new Size(1020, 641);
			Load += HospitalDashboard_Load;
			Resize += HospitalDashboard_Resize;
			pBloods.ResumeLayout(false);
			pUrgent.ResumeLayout(false);
			pUrgent.PerformLayout();
			pAppointments.ResumeLayout(false);
			pAppointments.PerformLayout();
			pOperations.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Panel pBloods;
		private Panel pUrgent;
		private Panel pAppointments;
		private Panel pOperations;
		private Label lblUrgent;
		private FlowLayoutPanel flpUrgent;
		private Label lblAppointments;
		private FlowLayoutPanel flpAppointments;
		private FlowLayoutPanel flpOperations;
		private FlowLayoutPanel flpBloods;
	}
}
