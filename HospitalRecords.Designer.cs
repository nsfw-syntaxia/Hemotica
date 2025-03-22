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
			mstrpRecords = new ReaLTaiizor.Controls.ParrotToolStrip();
			tstrpFile = new ToolStripDropDownButton();
			load = new ToolStripMenuItem();
			lTable = new ToolStripMenuItem();
			lDonors = new ToolStripMenuItem();
			lPatients = new ToolStripMenuItem();
			lAppointments = new ToolStripMenuItem();
			lQuery = new ToolStripMenuItem();
			lExtraction = new ToolStripMenuItem();
			lTransfusion = new ToolStripMenuItem();
			print = new ToolStripMenuItem();
			pTable = new ToolStripMenuItem();
			pDonors = new ToolStripMenuItem();
			pPatients = new ToolStripMenuItem();
			pQuery = new ToolStripMenuItem();
			pExtraction = new ToolStripMenuItem();
			pTransfusion = new ToolStripMenuItem();
			dgvData = new DataGridView();
			btnConnection = new AntdUI.Button();
			flpInputs = new FlowLayoutPanel();
			btnInsert = new AntdUI.Button();
			btnUpdate = new AntdUI.Button();
			btnDelete = new AntdUI.Button();
			mstrpRecords.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
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
			load.Size = new Size(180, 24);
			load.Text = "LOAD";
			// 
			// lTable
			// 
			lTable.DropDownItems.AddRange(new ToolStripItem[] { lDonors, lPatients, lAppointments });
			lTable.Font = new Font("Bahnschrift", 12F);
			lTable.ForeColor = Color.FromArgb(54, 40, 40);
			lTable.Name = "lTable";
			lTable.Size = new Size(180, 24);
			lTable.Text = "TABLE";
			// 
			// lDonors
			// 
			lDonors.ForeColor = Color.FromArgb(54, 40, 40);
			lDonors.Name = "lDonors";
			lDonors.Size = new Size(194, 24);
			lDonors.Text = "DONORS";
			lDonors.Click += lDonors_Click;
			// 
			// lPatients
			// 
			lPatients.ForeColor = Color.FromArgb(54, 40, 40);
			lPatients.Name = "lPatients";
			lPatients.Size = new Size(194, 24);
			lPatients.Text = "PATIENTS";
			lPatients.Click += lPatients_Click;
			// 
			// lAppointments
			// 
			lAppointments.Name = "lAppointments";
			lAppointments.Size = new Size(194, 24);
			lAppointments.Text = "APPOINTMENTS";
			lAppointments.Click += lAppointments_Click;
			// 
			// lQuery
			// 
			lQuery.DropDownItems.AddRange(new ToolStripItem[] { lExtraction, lTransfusion });
			lQuery.ForeColor = Color.FromArgb(54, 40, 40);
			lQuery.Name = "lQuery";
			lQuery.Size = new Size(180, 24);
			lQuery.Text = "QUERY";
			// 
			// lExtraction
			// 
			lExtraction.ForeColor = Color.FromArgb(54, 40, 40);
			lExtraction.Name = "lExtraction";
			lExtraction.Size = new Size(235, 24);
			lExtraction.Text = "BLOOD EXTRACTION";
			// 
			// lTransfusion
			// 
			lTransfusion.ForeColor = Color.FromArgb(54, 40, 40);
			lTransfusion.Name = "lTransfusion";
			lTransfusion.Size = new Size(235, 24);
			lTransfusion.Text = "BLOOD TRANSFUSION";
			// 
			// print
			// 
			print.DropDownItems.AddRange(new ToolStripItem[] { pTable, pQuery });
			print.Font = new Font("Bahnschrift", 12F);
			print.ForeColor = Color.FromArgb(54, 40, 40);
			print.Name = "print";
			print.Size = new Size(180, 24);
			print.Text = "PRINT";
			// 
			// pTable
			// 
			pTable.DropDownItems.AddRange(new ToolStripItem[] { pDonors, pPatients });
			pTable.ForeColor = Color.FromArgb(54, 40, 40);
			pTable.Name = "pTable";
			pTable.Size = new Size(127, 24);
			pTable.Text = "TABLE";
			// 
			// pDonors
			// 
			pDonors.ForeColor = Color.FromArgb(54, 40, 40);
			pDonors.Name = "pDonors";
			pDonors.Size = new Size(149, 24);
			pDonors.Text = "DONORS";
			// 
			// pPatients
			// 
			pPatients.ForeColor = Color.FromArgb(54, 40, 40);
			pPatients.Name = "pPatients";
			pPatients.Size = new Size(149, 24);
			pPatients.Text = "PATIENTS";
			// 
			// pQuery
			// 
			pQuery.DropDownItems.AddRange(new ToolStripItem[] { pExtraction, pTransfusion });
			pQuery.ForeColor = Color.FromArgb(54, 40, 40);
			pQuery.Name = "pQuery";
			pQuery.Size = new Size(127, 24);
			pQuery.Text = "QUERY";
			// 
			// pExtraction
			// 
			pExtraction.ForeColor = Color.FromArgb(54, 40, 40);
			pExtraction.Name = "pExtraction";
			pExtraction.Size = new Size(235, 24);
			pExtraction.Text = "BLOOD EXTRACTION";
			// 
			// pTransfusion
			// 
			pTransfusion.ForeColor = Color.FromArgb(54, 40, 40);
			pTransfusion.Name = "pTransfusion";
			pTransfusion.Size = new Size(235, 24);
			pTransfusion.Text = "BLOOD TRANSFUSION";
			// 
			// dgvData
			// 
			dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvData.BackgroundColor = Color.FromArgb(244, 180, 180);
			dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvData.GridColor = Color.FromArgb(244, 180, 180);
			dgvData.Location = new Point(456, 42);
			dgvData.Name = "dgvData";
			dgvData.ReadOnly = true;
			dgvData.Size = new Size(561, 545);
			dgvData.TabIndex = 2;
			// 
			// btnConnection
			// 
			btnConnection.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnConnection.DefaultBack = Color.FromArgb(236, 124, 132);
			btnConnection.Font = new Font("Bahnschrift", 14F);
			btnConnection.ForeColor = Color.FromArgb(252, 228, 228);
			btnConnection.Location = new Point(456, 593);
			btnConnection.Name = "btnConnection";
			btnConnection.Size = new Size(561, 45);
			btnConnection.TabIndex = 12;
			btnConnection.Text = "Connection Test";
			// 
			// flpInputs
			// 
			flpInputs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			flpInputs.Location = new Point(3, 42);
			flpInputs.Name = "flpInputs";
			flpInputs.Size = new Size(447, 545);
			flpInputs.TabIndex = 13;
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
			// 
			// HospitalRecords
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(btnDelete);
			Controls.Add(btnUpdate);
			Controls.Add(btnInsert);
			Controls.Add(flpInputs);
			Controls.Add(btnConnection);
			Controls.Add(dgvData);
			Controls.Add(mstrpRecords);
			Name = "HospitalRecords";
			Size = new Size(1020, 641);
			mstrpRecords.ResumeLayout(false);
			mstrpRecords.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
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
		private DataGridView dgvData;
		private AntdUI.Button btnConnection;
		private FlowLayoutPanel flpInputs;
		private AntdUI.Button btnInsert;
		private AntdUI.Button btnUpdate;
		private AntdUI.Button btnDelete;
		private ToolStripMenuItem lAppointments;
	}
}
