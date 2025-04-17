namespace Hemotica
{
	partial class HospitalRecords
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalRecords));
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			mstrpRecords = new ReaLTaiizor.Controls.ParrotToolStrip();
			tstrpFile = new ToolStripDropDownButton();
			load = new ToolStripMenuItem();
			lTable = new ToolStripMenuItem();
			lDonors = new ToolStripMenuItem();
			lPatients = new ToolStripMenuItem();
			lPhysicians = new ToolStripMenuItem();
			lQuery = new ToolStripMenuItem();
			lAppointments = new ToolStripMenuItem();
			lExtraction = new ToolStripMenuItem();
			lTransfusion = new ToolStripMenuItem();
			print = new ToolStripMenuItem();
			pTable = new ToolStripMenuItem();
			pDonors = new ToolStripMenuItem();
			pPatients = new ToolStripMenuItem();
			pPhysicians = new ToolStripMenuItem();
			pQuery = new ToolStripMenuItem();
			pAppointments = new ToolStripMenuItem();
			pExtraction = new ToolStripMenuItem();
			pTransfusion = new ToolStripMenuItem();
			dgvDataMax = new DataGridView();
			btnConnection = new AntdUI.Button();
			btnInsert = new AntdUI.Button();
			btnUpdate = new AntdUI.Button();
			btnDelete = new AntdUI.Button();
			dgvDataMin = new DataGridView();
			flpInputs = new FlowLayoutPanel();
			mstrpRecords.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDataMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvDataMin).BeginInit();
			SuspendLayout();
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
			mstrpRecords.TabIndex = 1;
			// 
			// tstrpFile
			// 
			tstrpFile.DropDownItems.AddRange(new ToolStripItem[] { load, print });
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
			load.DropDownItems.AddRange(new ToolStripItem[] { lTable, lQuery });
			load.Font = new Font("Bahnschrift", 12F);
			load.ForeColor = Color.FromArgb(54, 40, 40);
			load.Name = "load";
			load.Size = new Size(123, 24);
			load.Text = "LOAD";
			// 
			// lTable
			// 
			lTable.DropDownItems.AddRange(new ToolStripItem[] { lDonors, lPatients, lPhysicians });
			lTable.Font = new Font("Bahnschrift", 12F);
			lTable.ForeColor = Color.FromArgb(54, 40, 40);
			lTable.Name = "lTable";
			lTable.Size = new Size(127, 24);
			lTable.Text = "TABLE";
			// 
			// lDonors
			// 
			lDonors.ForeColor = Color.FromArgb(54, 40, 40);
			lDonors.Name = "lDonors";
			lDonors.Size = new Size(166, 24);
			lDonors.Text = "DONORS";
			lDonors.Click += lDonors_Click;
			// 
			// lPatients
			// 
			lPatients.ForeColor = Color.FromArgb(54, 40, 40);
			lPatients.Name = "lPatients";
			lPatients.Size = new Size(166, 24);
			lPatients.Text = "PATIENTS";
			lPatients.Click += lPatients_Click;
			// 
			// lPhysicians
			// 
			lPhysicians.Name = "lPhysicians";
			lPhysicians.Size = new Size(166, 24);
			lPhysicians.Text = "PHYSICIANS";
			lPhysicians.Click += lPhysicians_Click;
			// 
			// lQuery
			// 
			lQuery.DropDownItems.AddRange(new ToolStripItem[] { lAppointments, lExtraction, lTransfusion });
			lQuery.ForeColor = Color.FromArgb(54, 40, 40);
			lQuery.Name = "lQuery";
			lQuery.Size = new Size(127, 24);
			lQuery.Text = "QUERY";
			// 
			// lAppointments
			// 
			lAppointments.Name = "lAppointments";
			lAppointments.Size = new Size(235, 24);
			lAppointments.Text = "APPOINTMENTS";
			lAppointments.Click += lAppointments_Click;
			// 
			// lExtraction
			// 
			lExtraction.ForeColor = Color.FromArgb(54, 40, 40);
			lExtraction.Name = "lExtraction";
			lExtraction.Size = new Size(235, 24);
			lExtraction.Text = "BLOOD EXTRACTION";
			lExtraction.Click += lExtraction_Click;
			// 
			// lTransfusion
			// 
			lTransfusion.ForeColor = Color.FromArgb(54, 40, 40);
			lTransfusion.Name = "lTransfusion";
			lTransfusion.Size = new Size(235, 24);
			lTransfusion.Text = "BLOOD TRANSFUSION";
			lTransfusion.Click += lTransfusion_Click;
			// 
			// print
			// 
			print.DropDownItems.AddRange(new ToolStripItem[] { pTable, pQuery });
			print.Font = new Font("Bahnschrift", 12F);
			print.ForeColor = Color.FromArgb(54, 40, 40);
			print.Name = "print";
			print.Size = new Size(123, 24);
			print.Text = "PRINT";
			// 
			// pTable
			// 
			pTable.DropDownItems.AddRange(new ToolStripItem[] { pDonors, pPatients, pPhysicians });
			pTable.ForeColor = Color.FromArgb(54, 40, 40);
			pTable.Name = "pTable";
			pTable.Size = new Size(127, 24);
			pTable.Text = "TABLE";
			// 
			// pDonors
			// 
			pDonors.ForeColor = Color.FromArgb(54, 40, 40);
			pDonors.Name = "pDonors";
			pDonors.Size = new Size(166, 24);
			pDonors.Text = "DONORS";
			pDonors.Click += pDonors_Click;
			// 
			// pPatients
			// 
			pPatients.ForeColor = Color.FromArgb(54, 40, 40);
			pPatients.Name = "pPatients";
			pPatients.Size = new Size(166, 24);
			pPatients.Text = "PATIENTS";
			pPatients.Click += pPatients_Click;
			// 
			// pPhysicians
			// 
			pPhysicians.Name = "pPhysicians";
			pPhysicians.Size = new Size(166, 24);
			pPhysicians.Text = "PHYSICIANS";
			pPhysicians.Click += pPhysicians_Click;
			// 
			// pQuery
			// 
			pQuery.DropDownItems.AddRange(new ToolStripItem[] { pAppointments, pExtraction, pTransfusion });
			pQuery.ForeColor = Color.FromArgb(54, 40, 40);
			pQuery.Name = "pQuery";
			pQuery.Size = new Size(127, 24);
			pQuery.Text = "QUERY";
			// 
			// pAppointments
			// 
			pAppointments.Name = "pAppointments";
			pAppointments.Size = new Size(235, 24);
			pAppointments.Text = "APPOINTMENTS";
			pAppointments.Click += pAppointments_Click;
			// 
			// pExtraction
			// 
			pExtraction.ForeColor = Color.FromArgb(54, 40, 40);
			pExtraction.Name = "pExtraction";
			pExtraction.Size = new Size(235, 24);
			pExtraction.Text = "BLOOD EXTRACTION";
			pExtraction.Click += pExtraction_Click;
			// 
			// pTransfusion
			// 
			pTransfusion.ForeColor = Color.FromArgb(54, 40, 40);
			pTransfusion.Name = "pTransfusion";
			pTransfusion.Size = new Size(235, 24);
			pTransfusion.Text = "BLOOD TRANSFUSION";
			pTransfusion.Click += pTransfusion_Click;
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
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle1.Padding = new Padding(15, 5, 15, 5);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvDataMax.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgvDataMax.ColumnHeadersHeight = 50;
			dgvDataMax.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvDataMax.EnableHeadersVisualStyles = false;
			dgvDataMax.GridColor = Color.FromArgb(253, 211, 211);
			dgvDataMax.Location = new Point(3, 42);
			dgvDataMax.MultiSelect = false;
			dgvDataMax.Name = "dgvDataMax";
			dgvDataMax.ReadOnly = true;
			dgvDataMax.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Control;
			dataGridViewCellStyle2.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dgvDataMax.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dgvDataMax.RowHeadersVisible = false;
			dgvDataMax.RowHeadersWidth = 40;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 180, 180);
			dataGridViewCellStyle3.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle3.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle3.Padding = new Padding(20, 5, 20, 5);
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dataGridViewCellStyle3.SelectionForeColor = Color.White;
			dgvDataMax.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
			dgvDataMax.Size = new Size(1014, 596);
			dgvDataMax.TabIndex = 2;
			dgvDataMax.Visible = false;
			// 
			// btnConnection
			// 
			btnConnection.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnConnection.DefaultBack = Color.FromArgb(236, 124, 132);
			btnConnection.Font = new Font("Bahnschrift", 14F);
			btnConnection.ForeColor = Color.FromArgb(252, 228, 228);
			btnConnection.Location = new Point(727, 593);
			btnConnection.Name = "btnConnection";
			btnConnection.Size = new Size(290, 45);
			btnConnection.TabIndex = 12;
			btnConnection.Text = "Connection Test";
			btnConnection.Click += btnConnection_Click;
			// 
			// btnInsert
			// 
			btnInsert.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnInsert.DefaultBack = Color.FromArgb(236, 124, 132);
			btnInsert.Font = new Font("Bahnschrift", 14F);
			btnInsert.ForeColor = Color.FromArgb(252, 228, 228);
			btnInsert.Location = new Point(3, 593);
			btnInsert.Name = "btnInsert";
			btnInsert.Size = new Size(145, 45);
			btnInsert.TabIndex = 14;
			btnInsert.Text = "Insert";
			btnInsert.Visible = false;
			btnInsert.Click += btnInsert_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnUpdate.DefaultBack = Color.FromArgb(236, 124, 132);
			btnUpdate.Font = new Font("Bahnschrift", 14F);
			btnUpdate.ForeColor = Color.FromArgb(252, 228, 228);
			btnUpdate.Location = new Point(154, 593);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(145, 45);
			btnUpdate.TabIndex = 15;
			btnUpdate.Text = "Update";
			btnUpdate.Visible = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnDelete
			// 
			btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnDelete.DefaultBack = Color.FromArgb(236, 124, 132);
			btnDelete.Font = new Font("Bahnschrift", 14F);
			btnDelete.ForeColor = Color.FromArgb(252, 228, 228);
			btnDelete.Location = new Point(305, 593);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(145, 45);
			btnDelete.TabIndex = 16;
			btnDelete.Text = "Delete";
			btnDelete.Visible = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// dgvDataMin
			// 
			dgvDataMin.AllowUserToAddRows = false;
			dgvDataMin.AllowUserToResizeColumns = false;
			dgvDataMin.AllowUserToResizeRows = false;
			dgvDataMin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvDataMin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgvDataMin.BackgroundColor = Color.FromArgb(253, 211, 211);
			dgvDataMin.BorderStyle = BorderStyle.None;
			dgvDataMin.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			dgvDataMin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold);
			dataGridViewCellStyle4.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle4.Padding = new Padding(15, 5, 15, 5);
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dgvDataMin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dgvDataMin.ColumnHeadersHeight = 50;
			dgvDataMin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvDataMin.EnableHeadersVisualStyles = false;
			dgvDataMin.GridColor = Color.FromArgb(253, 211, 211);
			dgvDataMin.Location = new Point(3, 42);
			dgvDataMin.MultiSelect = false;
			dgvDataMin.Name = "dgvDataMin";
			dgvDataMin.ReadOnly = true;
			dgvDataMin.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = SystemColors.Control;
			dataGridViewCellStyle5.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			dgvDataMin.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			dgvDataMin.RowHeadersVisible = false;
			dgvDataMin.RowHeadersWidth = 40;
			dataGridViewCellStyle6.BackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle6.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle6.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle6.Padding = new Padding(20, 5, 20, 5);
			dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dataGridViewCellStyle6.SelectionForeColor = Color.White;
			dgvDataMin.RowsDefaultCellStyle = dataGridViewCellStyle6;
			dgvDataMin.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(252, 196, 196);
			dgvDataMin.RowTemplate.DefaultCellStyle.Font = new Font("Bahnschrift", 13F);
			dgvDataMin.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(216, 85, 101);
			dgvDataMin.RowTemplate.DefaultCellStyle.Padding = new Padding(20, 5, 20, 5);
			dgvDataMin.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dgvDataMin.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
			dgvDataMin.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
			dgvDataMin.RowTemplate.DividerHeight = 3;
			dgvDataMin.RowTemplate.Height = 40;
			dgvDataMin.RowTemplate.Resizable = DataGridViewTriState.False;
			dgvDataMin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDataMin.Size = new Size(1014, 272);
			dgvDataMin.TabIndex = 18;
			dgvDataMin.Visible = false;
			dgvDataMin.CellClick += dgvDataMin_CellClick;
			// 
			// flpInputs
			// 
			flpInputs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpInputs.Location = new Point(3, 320);
			flpInputs.Name = "flpInputs";
			flpInputs.Size = new Size(1014, 267);
			flpInputs.TabIndex = 19;
			flpInputs.Visible = false;
			// 
			// HospitalRecords
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(flpInputs);
			Controls.Add(dgvDataMin);
			Controls.Add(btnDelete);
			Controls.Add(btnUpdate);
			Controls.Add(btnConnection);
			Controls.Add(mstrpRecords);
			Controls.Add(btnInsert);
			Controls.Add(dgvDataMax);
			Name = "HospitalRecords";
			Size = new Size(1020, 641);
			Load += HospitalRecords_Load;
			mstrpRecords.ResumeLayout(false);
			mstrpRecords.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvDataMax).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvDataMin).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ReaLTaiizor.Controls.ParrotToolStrip mstrpRecords;
		private ToolStripDropDownButton tstrpFile;
		private ToolStripMenuItem load;
		private ToolStripMenuItem lTable;
		private ToolStripMenuItem lQuery;
		private ToolStripMenuItem lDonors;
		private ToolStripMenuItem lPatients;
		private ToolStripMenuItem lExtraction;
		private ToolStripMenuItem lTransfusion;
		private ToolStripMenuItem print;
		private ToolStripMenuItem pTable;
		private ToolStripMenuItem pQuery;
		private ToolStripMenuItem pExtraction;
		private ToolStripMenuItem pTransfusion;
		private ToolStripMenuItem pDonors;
		private ToolStripMenuItem pPatients;
		private DataGridView dgvDataMax;
		private AntdUI.Button btnConnection;
		private AntdUI.Button btnInsert;
		private AntdUI.Button btnUpdate;
		private AntdUI.Button btnDelete;
		private ToolStripMenuItem lPhysicians;
		private ToolStripMenuItem lAppointments;
		private DataGridView dgvDataMin;
		private FlowLayoutPanel flpInputs;
		private ToolStripMenuItem pPhysicians;
		private ToolStripMenuItem pAppointments;
	}
}
