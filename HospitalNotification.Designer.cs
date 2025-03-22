namespace Hemotica
{
	partial class HospitalNotification
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
			flpNotifications = new FlowLayoutPanel();
			btnReadAll = new AntdUI.Button();
			SuspendLayout();
			// 
			// flpNotifications
			// 
			flpNotifications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpNotifications.BackColor = Color.FromArgb(236, 124, 132);
			flpNotifications.Location = new Point(3, 54);
			flpNotifications.Name = "flpNotifications";
			flpNotifications.Size = new Size(1014, 584);
			flpNotifications.TabIndex = 19;
			// 
			// btnReadAll
			// 
			btnReadAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnReadAll.DefaultBack = Color.FromArgb(236, 124, 132);
			btnReadAll.Font = new Font("Bahnschrift", 14F);
			btnReadAll.ForeColor = Color.FromArgb(252, 228, 228);
			btnReadAll.Location = new Point(821, 3);
			btnReadAll.Name = "btnReadAll";
			btnReadAll.Size = new Size(196, 45);
			btnReadAll.TabIndex = 18;
			btnReadAll.Text = "Mark All as Read";
			// 
			// HospitalNotification
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(flpNotifications);
			Controls.Add(btnReadAll);
			Name = "HospitalNotification";
			Size = new Size(1020, 641);
			Load += HospitalNotification_Load;
			Resize += HospitalNotification_Resize;
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flpNotifications;
		private AntdUI.Button btnReadAll;
	}
}
