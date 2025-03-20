namespace Hemotica
{
	partial class Appointments
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments));
			tblpList = new TableLayoutPanel();
			lblAppointments = new Label();
			btnAdd = new AntdUI.Button();
			btnCalendar = new AntdUI.Button();
			btnList = new AntdUI.Button();
			SuspendLayout();
			// 
			// tblpList
			// 
			tblpList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tblpList.ColumnCount = 5;
			tblpList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tblpList.Location = new Point(3, 61);
			tblpList.Name = "tblpList";
			tblpList.RowCount = 5;
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tblpList.Size = new Size(1014, 577);
			tblpList.TabIndex = 0;
			// 
			// lblAppointments
			// 
			lblAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblAppointments.AutoSize = true;
			lblAppointments.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblAppointments.ForeColor = Color.FromArgb(216, 85, 101);
			lblAppointments.Location = new Point(3, 12);
			lblAppointments.Name = "lblAppointments";
			lblAppointments.Padding = new Padding(5, 0, 0, 5);
			lblAppointments.Size = new Size(234, 46);
			lblAppointments.TabIndex = 10;
			lblAppointments.Text = "Appointments";
			// 
			// btnAdd
			// 
			btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			btnAdd.DefaultBack = Color.FromArgb(236, 124, 132);
			btnAdd.Font = new Font("Bahnschrift", 14F);
			btnAdd.ForeColor = Color.FromArgb(252, 228, 228);
			btnAdd.Icon = (Image)resources.GetObject("btnAdd.Icon");
			btnAdd.Location = new Point(944, 6);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(70, 52);
			btnAdd.TabIndex = 13;
			// 
			// btnCalendar
			// 
			btnCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			btnCalendar.DefaultBack = Color.FromArgb(236, 124, 132);
			btnCalendar.Font = new Font("Bahnschrift", 14F);
			btnCalendar.ForeColor = Color.FromArgb(252, 228, 228);
			btnCalendar.Location = new Point(676, 6);
			btnCalendar.Name = "btnCalendar";
			btnCalendar.Size = new Size(128, 52);
			btnCalendar.TabIndex = 11;
			btnCalendar.Text = "Calendar";
			btnCalendar.Click += btnCalendar_Click;
			// 
			// btnList
			// 
			btnList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			btnList.DefaultBack = Color.FromArgb(216, 85, 101);
			btnList.Font = new Font("Bahnschrift", 14F);
			btnList.ForeColor = Color.FromArgb(252, 228, 228);
			btnList.Location = new Point(810, 6);
			btnList.Name = "btnList";
			btnList.Size = new Size(128, 52);
			btnList.TabIndex = 12;
			btnList.Text = "List";
			// 
			// Appointments
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(btnAdd);
			Controls.Add(btnCalendar);
			Controls.Add(btnList);
			Controls.Add(lblAppointments);
			Controls.Add(tblpList);
			Name = "Appointments";
			Size = new Size(1020, 641);
			Load += List_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TableLayoutPanel tblpList;
		private Label lblAppointments;
		private AntdUI.Button btnAdd;
		private AntdUI.Button btnCalendar;
		private AntdUI.Button btnList;
	}
}
