namespace Hemotica
{
	partial class DonorAppointments
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorAppointments));
			lblAppointments = new Label();
			btnAdd = new AntdUI.Button();
			btnCalendar = new AntdUI.Button();
			btnList = new AntdUI.Button();
			flpAppointments = new FlowLayoutPanel();
			SuspendLayout();
			// 
			// lblAppointments
			// 
			lblAppointments.AutoSize = true;
			lblAppointments.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblAppointments.ForeColor = Color.FromArgb(216, 85, 101);
			lblAppointments.Location = new Point(0, 0);
			lblAppointments.Name = "lblAppointments";
			lblAppointments.Padding = new Padding(5, 0, 0, 5);
			lblAppointments.Size = new Size(234, 46);
			lblAppointments.TabIndex = 6;
			lblAppointments.Text = "Appointments";
			lblAppointments.TextAlign = ContentAlignment.MiddleLeft;
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
			btnAdd.TabIndex = 14;
			// 
			// btnCalendar
			// 
			btnCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnCalendar.DefaultBack = Color.FromArgb(236, 124, 132);
			btnCalendar.Font = new Font("Bahnschrift", 14F);
			btnCalendar.ForeColor = Color.FromArgb(252, 228, 228);
			btnCalendar.Location = new Point(730, 3);
			btnCalendar.Name = "btnCalendar";
			btnCalendar.Size = new Size(125, 45);
			btnCalendar.TabIndex = 12;
			btnCalendar.Text = "Calendar";
			btnCalendar.Click += btnCalendar_Click;
			// 
			// btnList
			// 
			btnList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnList.DefaultBack = Color.FromArgb(216, 85, 101);
			btnList.Font = new Font("Bahnschrift", 14F);
			btnList.ForeColor = Color.FromArgb(252, 228, 228);
			btnList.Location = new Point(861, 3);
			btnList.Name = "btnList";
			btnList.Size = new Size(100, 45);
			btnList.TabIndex = 13;
			btnList.Text = "List";
			btnList.Click += btnList_Click;
			// 
			// flpAppointments
			// 
			flpAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpAppointments.BackColor = Color.FromArgb(236, 124, 132);
			flpAppointments.Location = new Point(3, 54);
			flpAppointments.Name = "flpAppointments";
			flpAppointments.Size = new Size(1014, 584);
			flpAppointments.TabIndex = 15;
			// 
			// DonorAppointments
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(flpAppointments);
			Controls.Add(btnAdd);
			Controls.Add(btnCalendar);
			Controls.Add(btnList);
			Controls.Add(lblAppointments);
			Name = "DonorAppointments";
			Size = new Size(1020, 641);
			Load += DonorAppointments_Load;
			Resize += DonorAppointments_Resize;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblAppointments;
		private AntdUI.Button btnAdd;
		private AntdUI.Button btnCalendar;
		private AntdUI.Button btnList;
		private FlowLayoutPanel flpAppointments;
	}
}
