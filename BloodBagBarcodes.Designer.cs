namespace Hemotica
{
	partial class BloodBagBarcodes
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodBagBarcodes));
			dgvBarcodes = new DataGridView();
			btnBack = new AntdUI.Button();
			((System.ComponentModel.ISupportInitialize)dgvBarcodes).BeginInit();
			SuspendLayout();
			// 
			// dgvBarcodes
			// 
			dgvBarcodes.AllowUserToAddRows = false;
			dgvBarcodes.AllowUserToDeleteRows = false;
			dgvBarcodes.AllowUserToResizeColumns = false;
			dgvBarcodes.AllowUserToResizeRows = false;
			dgvBarcodes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvBarcodes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgvBarcodes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvBarcodes.BackgroundColor = Color.FromArgb(253, 211, 211);
			dgvBarcodes.BorderStyle = BorderStyle.None;
			dgvBarcodes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			dgvBarcodes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle1.Padding = new Padding(15, 5, 15, 5);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvBarcodes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgvBarcodes.ColumnHeadersHeight = 50;
			dgvBarcodes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvBarcodes.EnableHeadersVisualStyles = false;
			dgvBarcodes.GridColor = Color.FromArgb(253, 211, 211);
			dgvBarcodes.Location = new Point(13, 89);
			dgvBarcodes.MultiSelect = false;
			dgvBarcodes.Name = "dgvBarcodes";
			dgvBarcodes.ReadOnly = true;
			dgvBarcodes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Control;
			dataGridViewCellStyle2.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dgvBarcodes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dgvBarcodes.RowHeadersVisible = false;
			dgvBarcodes.RowHeadersWidth = 40;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 180, 180);
			dataGridViewCellStyle3.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle3.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle3.Padding = new Padding(20, 5, 20, 5);
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dataGridViewCellStyle3.SelectionForeColor = Color.White;
			dgvBarcodes.RowsDefaultCellStyle = dataGridViewCellStyle3;
			dgvBarcodes.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(252, 196, 196);
			dgvBarcodes.RowTemplate.DefaultCellStyle.Font = new Font("Bahnschrift", 13F);
			dgvBarcodes.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(216, 85, 101);
			dgvBarcodes.RowTemplate.DefaultCellStyle.Padding = new Padding(20, 5, 20, 5);
			dgvBarcodes.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dgvBarcodes.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
			dgvBarcodes.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
			dgvBarcodes.RowTemplate.DividerHeight = 3;
			dgvBarcodes.RowTemplate.Height = 40;
			dgvBarcodes.RowTemplate.Resizable = DataGridViewTriState.False;
			dgvBarcodes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvBarcodes.Size = new Size(994, 514);
			dgvBarcodes.TabIndex = 3;
			// 
			// btnBack
			// 
			btnBack.DefaultBack = Color.FromArgb(236, 124, 132);
			btnBack.Font = new Font("Bahnschrift", 14F);
			btnBack.ForeColor = Color.FromArgb(252, 228, 228);
			btnBack.Icon = (Image)resources.GetObject("btnBack.Icon");
			btnBack.Location = new Point(13, 38);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(130, 45);
			btnBack.TabIndex = 15;
			btnBack.Text = "Back";
			btnBack.Click += btnBack_Click;
			// 
			// BloodBagBarcodes
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(btnBack);
			Controls.Add(dgvBarcodes);
			Name = "BloodBagBarcodes";
			Padding = new Padding(10, 35, 10, 35);
			Size = new Size(1020, 641);
			Load += BloodBagBarcodes_Load;
			((System.ComponentModel.ISupportInitialize)dgvBarcodes).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvBarcodes;
		private AntdUI.Button btnBack;
	}
}
