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
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
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
			dgvDataMid = new DataGridView();
			btnApprove = new AntdUI.Button();
			btnReject = new AntdUI.Button();
			cmbxStatus = new ReaLTaiizor.Controls.DungeonComboBox();
			mstrpRecords.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDataMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvDataMin).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvDataMid).BeginInit();
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
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle10.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold);
			dataGridViewCellStyle10.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle10.Padding = new Padding(15, 5, 15, 5);
			dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
			dgvDataMax.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			dgvDataMax.ColumnHeadersHeight = 50;
			dgvDataMax.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvDataMax.EnableHeadersVisualStyles = false;
			dgvDataMax.GridColor = Color.FromArgb(253, 211, 211);
			dgvDataMax.Location = new Point(3, 42);
			dgvDataMax.MultiSelect = false;
			dgvDataMax.Name = "dgvDataMax";
			dgvDataMax.ReadOnly = true;
			dgvDataMax.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = SystemColors.Control;
			dataGridViewCellStyle11.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
			dgvDataMax.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
			dgvDataMax.RowHeadersVisible = false;
			dgvDataMax.RowHeadersWidth = 40;
			dataGridViewCellStyle12.BackColor = Color.FromArgb(244, 180, 180);
			dataGridViewCellStyle12.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle12.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle12.Padding = new Padding(20, 5, 20, 5);
			dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dataGridViewCellStyle12.SelectionForeColor = Color.White;
			dgvDataMax.RowsDefaultCellStyle = dataGridViewCellStyle12;
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
			btnConnection.Visible = false;
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
			dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle13.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold);
			dataGridViewCellStyle13.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle13.Padding = new Padding(15, 5, 15, 5);
			dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
			dgvDataMin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
			dgvDataMin.ColumnHeadersHeight = 50;
			dgvDataMin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvDataMin.EnableHeadersVisualStyles = false;
			dgvDataMin.GridColor = Color.FromArgb(253, 211, 211);
			dgvDataMin.Location = new Point(3, 42);
			dgvDataMin.MultiSelect = false;
			dgvDataMin.Name = "dgvDataMin";
			dgvDataMin.ReadOnly = true;
			dgvDataMin.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = SystemColors.Control;
			dataGridViewCellStyle14.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
			dgvDataMin.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			dgvDataMin.RowHeadersVisible = false;
			dgvDataMin.RowHeadersWidth = 40;
			dataGridViewCellStyle15.BackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle15.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle15.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle15.Padding = new Padding(20, 5, 20, 5);
			dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dataGridViewCellStyle15.SelectionForeColor = Color.White;
			dgvDataMin.RowsDefaultCellStyle = dataGridViewCellStyle15;
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
			// dgvDataMid
			// 
			dgvDataMid.AllowUserToAddRows = false;
			dgvDataMid.AllowUserToResizeColumns = false;
			dgvDataMid.AllowUserToResizeRows = false;
			dgvDataMid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvDataMid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgvDataMid.BackgroundColor = Color.FromArgb(253, 211, 211);
			dgvDataMid.BorderStyle = BorderStyle.None;
			dgvDataMid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			dgvDataMid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle16.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold);
			dataGridViewCellStyle16.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle16.Padding = new Padding(15, 5, 15, 5);
			dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
			dgvDataMid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
			dgvDataMid.ColumnHeadersHeight = 50;
			dgvDataMid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvDataMid.EnableHeadersVisualStyles = false;
			dgvDataMid.GridColor = Color.FromArgb(253, 211, 211);
			dgvDataMid.Location = new Point(3, 42);
			dgvDataMid.MultiSelect = false;
			dgvDataMid.Name = "dgvDataMid";
			dgvDataMid.ReadOnly = true;
			dgvDataMid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = SystemColors.Control;
			dataGridViewCellStyle17.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
			dgvDataMid.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
			dgvDataMid.RowHeadersVisible = false;
			dgvDataMid.RowHeadersWidth = 40;
			dataGridViewCellStyle18.BackColor = Color.FromArgb(244, 180, 180);
			dataGridViewCellStyle18.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle18.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle18.Padding = new Padding(20, 5, 20, 5);
			dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dataGridViewCellStyle18.SelectionForeColor = Color.White;
			dgvDataMid.RowsDefaultCellStyle = dataGridViewCellStyle18;
			dgvDataMid.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(252, 196, 196);
			dgvDataMid.RowTemplate.DefaultCellStyle.Font = new Font("Bahnschrift", 13F);
			dgvDataMid.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(216, 85, 101);
			dgvDataMid.RowTemplate.DefaultCellStyle.Padding = new Padding(20, 5, 20, 5);
			dgvDataMid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dgvDataMid.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
			dgvDataMid.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
			dgvDataMid.RowTemplate.DividerHeight = 3;
			dgvDataMid.RowTemplate.Height = 40;
			dgvDataMid.RowTemplate.Resizable = DataGridViewTriState.False;
			dgvDataMid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDataMid.Size = new Size(1014, 545);
			dgvDataMid.TabIndex = 20;
			dgvDataMid.Visible = false;
			// 
			// btnApprove
			// 
			btnApprove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnApprove.DefaultBack = Color.FromArgb(236, 124, 132);
			btnApprove.Font = new Font("Bahnschrift", 14F);
			btnApprove.ForeColor = Color.FromArgb(252, 228, 228);
			btnApprove.Location = new Point(3, 593);
			btnApprove.Name = "btnApprove";
			btnApprove.Size = new Size(145, 45);
			btnApprove.TabIndex = 21;
			btnApprove.Text = "Approve";
			btnApprove.Visible = false;
			btnApprove.Click += btnApprove_Click;
			// 
			// btnReject
			// 
			btnReject.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnReject.DefaultBack = Color.FromArgb(236, 124, 132);
			btnReject.Font = new Font("Bahnschrift", 14F);
			btnReject.ForeColor = Color.FromArgb(252, 228, 228);
			btnReject.Location = new Point(154, 593);
			btnReject.Name = "btnReject";
			btnReject.Size = new Size(145, 45);
			btnReject.TabIndex = 22;
			btnReject.Text = "Reject";
			btnReject.Visible = false;
			btnReject.Click += btnReject_Click;
			// 
			// cmbxStatus
			// 
			cmbxStatus.BackColor = Color.White;
			cmbxStatus.ColorA = Color.FromArgb(236, 124, 132);
			cmbxStatus.ColorB = Color.FromArgb(236, 124, 132);
			cmbxStatus.ColorC = Color.FromArgb(242, 241, 240);
			cmbxStatus.ColorD = Color.FromArgb(253, 252, 252);
			cmbxStatus.ColorE = Color.FromArgb(239, 237, 236);
			cmbxStatus.ColorF = Color.FromArgb(216, 85, 101);
			cmbxStatus.ColorG = Color.FromArgb(216, 85, 101);
			cmbxStatus.ColorH = Color.FromArgb(244, 180, 180);
			cmbxStatus.ColorI = Color.FromArgb(250, 249, 249);
			cmbxStatus.DrawMode = DrawMode.OwnerDrawFixed;
			cmbxStatus.DropDownHeight = 100;
			cmbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbxStatus.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			cmbxStatus.ForeColor = Color.FromArgb(216, 85, 101);
			cmbxStatus.FormattingEnabled = true;
			cmbxStatus.HoverSelectionColor = Color.Empty;
			cmbxStatus.IntegralHeight = false;
			cmbxStatus.ItemHeight = 31;
			cmbxStatus.Items.AddRange(new object[] { "Select appointment status", "Pending Approval", "Scheduled", "Denied", "Cancelled", "Completed" });
			cmbxStatus.Location = new Point(727, 597);
			cmbxStatus.Name = "cmbxStatus";
			cmbxStatus.Size = new Size(286, 37);
			cmbxStatus.StartIndex = 0;
			cmbxStatus.TabIndex = 86;
			cmbxStatus.Visible = false;
			cmbxStatus.SelectedIndexChanged += cmbxStatus_SelectedIndexChanged;
			// 
			// HospitalRecords
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(cmbxStatus);
			Controls.Add(btnReject);
			Controls.Add(btnApprove);
			Controls.Add(dgvDataMid);
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
			((System.ComponentModel.ISupportInitialize)dgvDataMid).EndInit();
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
		private DataGridView dgvDataMid;
		private AntdUI.Button btnApprove;
		private AntdUI.Button btnReject;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxStatus;
	}
}
