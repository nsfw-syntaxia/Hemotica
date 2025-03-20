namespace Hemotica
{
	partial class Calendar
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
			tblpCalendar = new TableLayoutPanel();
			SuspendLayout();
			// 
			// tblpCalendar
			// 
			tblpCalendar.BackColor = Color.FromArgb(253, 211, 211);
			tblpCalendar.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			tblpCalendar.ColumnCount = 7;
			tblpCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tblpCalendar.Dock = DockStyle.Fill;
			tblpCalendar.Location = new Point(0, 0);
			tblpCalendar.Name = "tblpCalendar";
			tblpCalendar.RowCount = 6;
			tblpCalendar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tblpCalendar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tblpCalendar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tblpCalendar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tblpCalendar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tblpCalendar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tblpCalendar.Size = new Size(1014, 507);
			tblpCalendar.TabIndex = 0;
			// 
			// Calendar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tblpCalendar);
			Name = "Calendar";
			Size = new Size(1014, 507);
			Load += Calendar_Load;
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tblpCalendar;
	}
}
