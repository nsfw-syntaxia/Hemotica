namespace Hemotica
{
	partial class HospitalN
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
			btnRead = new AntdUI.Button();
			tblpList = new TableLayoutPanel();
			SuspendLayout();
			// 
			// btnRead
			// 
			btnRead.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			btnRead.DefaultBack = Color.FromArgb(236, 124, 132);
			btnRead.Font = new Font("Bahnschrift", 14F);
			btnRead.ForeColor = Color.FromArgb(252, 228, 228);
			btnRead.Location = new Point(818, 4);
			btnRead.Name = "btnRead";
			btnRead.Size = new Size(196, 52);
			btnRead.TabIndex = 18;
			btnRead.Text = "Mark All as Read";
			// 
			// tblpList
			// 
			tblpList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tblpList.ColumnCount = 1;
			tblpList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tblpList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tblpList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tblpList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tblpList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tblpList.Location = new Point(3, 59);
			tblpList.Name = "tblpList";
			tblpList.RowCount = 10;
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpList.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tblpList.Size = new Size(1014, 577);
			tblpList.TabIndex = 17;
			// 
			// HospitalN
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(btnRead);
			Controls.Add(tblpList);
			Name = "HospitalN";
			Size = new Size(1020, 641);
			ResumeLayout(false);
		}

		#endregion

		private AntdUI.Button btnRead;
		private TableLayoutPanel tblpList;
	}
}
