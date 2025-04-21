namespace Hemotica
{
	partial class AdminRecords
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
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRecords));
			dgvDataMax = new DataGridView();
			btnDelete = new AntdUI.Button();
			mstrpRecords = new ReaLTaiizor.Controls.ParrotToolStrip();
			tstrpFile = new ToolStripDropDownButton();
			load = new ToolStripMenuItem();
			lDonors = new ToolStripMenuItem();
			lHospitals = new ToolStripMenuItem();
			lRequests = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)dgvDataMax).BeginInit();
			mstrpRecords.SuspendLayout();
			SuspendLayout();
			// 
			// dgvDataMax
			// 
			dgvDataMax.AllowUserToAddRows = false;
			dgvDataMax.AllowUserToResizeColumns = false;
			dgvDataMax.AllowUserToResizeRows = false;
			dgvDataMax.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvDataMax.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgvDataMax.BackgroundColor = Color.FromArgb(253, 211, 211);
			dgvDataMax.BorderStyle = BorderStyle.None;
			dgvDataMax.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			dgvDataMax.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold);
			dataGridViewCellStyle4.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle4.Padding = new Padding(15, 5, 15, 5);
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dgvDataMax.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dgvDataMax.ColumnHeadersHeight = 50;
			dgvDataMax.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvDataMax.EnableHeadersVisualStyles = false;
			dgvDataMax.GridColor = Color.FromArgb(253, 211, 211);
			dgvDataMax.Location = new Point(3, 42);
			dgvDataMax.MultiSelect = false;
			dgvDataMax.Name = "dgvDataMax";
			dgvDataMax.ReadOnly = true;
			dgvDataMax.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = SystemColors.Control;
			dataGridViewCellStyle5.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			dgvDataMax.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			dgvDataMax.RowHeadersVisible = false;
			dgvDataMax.RowHeadersWidth = 40;
			dataGridViewCellStyle6.BackColor = Color.FromArgb(244, 180, 180);
			dataGridViewCellStyle6.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle6.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle6.Padding = new Padding(20, 5, 20, 5);
			dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dataGridViewCellStyle6.SelectionForeColor = Color.White;
			dgvDataMax.RowsDefaultCellStyle = dataGridViewCellStyle6;
			dgvDataMax.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(252, 196, 196);
			dgvDataMax.RowTemplate.DefaultCellStyle.Font = new Font("Bahnschrift", 13F);
			dgvDataMax.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(216, 85, 101);
			dgvDataMax.RowTemplate.DefaultCellStyle.Padding = new Padding(20, 5, 20, 5);
			dgvDataMax.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dgvDataMax.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
			dgvDataMax.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
			dgvDataMax.RowTemplate.DividerHeight = 3;
			dgvDataMax.RowTemplate.Height = 40;
			dgvDataMax.RowTemplate.Resizable = DataGridViewTriState.False;
			dgvDataMax.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDataMax.Size = new Size(1014, 545);
			dgvDataMax.TabIndex = 2;
			// 
			// btnDelete
			// 
			btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnDelete.DefaultBack = Color.FromArgb(236, 124, 132);
			btnDelete.Font = new Font("Bahnschrift", 14F);
			btnDelete.ForeColor = Color.FromArgb(252, 228, 228);
			btnDelete.Location = new Point(3, 593);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(145, 45);
			btnDelete.TabIndex = 16;
			btnDelete.Text = "Delete";
			btnDelete.Visible = false;
			// 
			// mstrpRecords
			// 
			mstrpRecords.BackColor = Color.FromArgb(236, 124, 132);
			mstrpRecords.BorderColor = Color.FromArgb(236, 124, 132);
			mstrpRecords.ForeColor = Color.Black;
			mstrpRecords.GripStyle = ToolStripGripStyle.Hidden;
			mstrpRecords.Items.AddRange(new ToolStripItem[] { tstrpFile });
			mstrpRecords.Location = new Point(0, 0);
			mstrpRecords.Name = "mstrpRecords";
			mstrpRecords.Padding = new Padding(10, 5, 1, 5);
			mstrpRecords.Size = new Size(1020, 39);
			mstrpRecords.TabIndex = 17;
			// 
			// tstrpFile
			// 
			tstrpFile.DropDownItems.AddRange(new ToolStripItem[] { load });
			tstrpFile.Font = new Font("Bahnschrift", 13F, FontStyle.Bold);
			tstrpFile.ForeColor = Color.FromArgb(54, 40, 40);
			tstrpFile.Image = (Image)resources.GetObject("tstrpFile.Image");
			tstrpFile.ImageTransparentColor = Color.Magenta;
			tstrpFile.Name = "tstrpFile";
			tstrpFile.Size = new Size(75, 26);
			tstrpFile.Text = "FILE";
			// 
			// load
			// 
			load.DropDownItems.AddRange(new ToolStripItem[] { lDonors, lHospitals, lRequests });
			load.Font = new Font("Bahnschrift", 12F);
			load.ForeColor = Color.FromArgb(54, 40, 40);
			load.Name = "load";
			load.Size = new Size(180, 24);
			load.Text = "LOAD";
			// 
			// lDonors
			// 
			lDonors.Name = "lDonors";
			lDonors.Size = new Size(180, 24);
			lDonors.Text = "DONORS";
			lDonors.Click += lDonors_Click;
			// 
			// lHospitals
			// 
			lHospitals.Name = "lHospitals";
			lHospitals.Size = new Size(180, 24);
			lHospitals.Text = "HOSPITALS";
			lHospitals.Click += lHospitals_Click;
			// 
			// lRequests
			// 
			lRequests.Name = "lRequests";
			lRequests.Size = new Size(180, 24);
			lRequests.Text = "REQUESTS";
			lRequests.Click += lRequests_Click;
			// 
			// AdminRecords
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(mstrpRecords);
			Controls.Add(dgvDataMax);
			Controls.Add(btnDelete);
			Name = "AdminRecords";
			Size = new Size(1020, 641);
			((System.ComponentModel.ISupportInitialize)dgvDataMax).EndInit();
			mstrpRecords.ResumeLayout(false);
			mstrpRecords.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private DataGridView dgvDataMax;
		private AntdUI.Button btnDelete;
		private ReaLTaiizor.Controls.ParrotToolStrip mstrpRecords;
		private ToolStripDropDownButton tstrpFile;
		private ToolStripMenuItem load;
		private ToolStripMenuItem lDonors;
		private ToolStripMenuItem lHospitals;
		private ToolStripMenuItem lRequests;
	}
}
