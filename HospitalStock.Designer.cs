namespace Hemotica
{
	partial class HospitalStock
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
			btnPost = new AntdUI.Button();
			dgvStock = new DataGridView();
			flpStock = new FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
			SuspendLayout();
			// 
			// btnPost
			// 
			btnPost.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnPost.DefaultBack = Color.FromArgb(236, 124, 132);
			btnPost.Font = new Font("Bahnschrift", 14F);
			btnPost.ForeColor = Color.FromArgb(252, 228, 228);
			btnPost.Location = new Point(717, 593);
			btnPost.Name = "btnPost";
			btnPost.Size = new Size(290, 45);
			btnPost.TabIndex = 16;
			btnPost.Text = "Post a Blood Donation Drive";
			// 
			// dgvStock
			// 
			dgvStock.AllowUserToAddRows = false;
			dgvStock.AllowUserToDeleteRows = false;
			dgvStock.AllowUserToResizeColumns = false;
			dgvStock.AllowUserToResizeRows = false;
			dgvStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvStock.BackgroundColor = Color.FromArgb(253, 211, 211);
			dgvStock.BorderStyle = BorderStyle.None;
			dgvStock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			dgvStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle1.Padding = new Padding(15, 5, 15, 5);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgvStock.ColumnHeadersHeight = 50;
			dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvStock.EnableHeadersVisualStyles = false;
			dgvStock.GridColor = Color.FromArgb(253, 211, 211);
			dgvStock.Location = new Point(13, 18);
			dgvStock.MultiSelect = false;
			dgvStock.Name = "dgvStock";
			dgvStock.ReadOnly = true;
			dgvStock.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Control;
			dataGridViewCellStyle2.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dgvStock.RowHeadersVisible = false;
			dgvStock.RowHeadersWidth = 40;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 180, 180);
			dataGridViewCellStyle3.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle3.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle3.Padding = new Padding(20, 5, 20, 5);
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dataGridViewCellStyle3.SelectionForeColor = Color.White;
			dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle3;
			dgvStock.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(252, 196, 196);
			dgvStock.RowTemplate.DefaultCellStyle.Font = new Font("Bahnschrift", 13F);
			dgvStock.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(216, 85, 101);
			dgvStock.RowTemplate.DefaultCellStyle.Padding = new Padding(20, 5, 20, 5);
			dgvStock.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dgvStock.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
			dgvStock.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
			dgvStock.RowTemplate.DividerHeight = 3;
			dgvStock.RowTemplate.Height = 40;
			dgvStock.RowTemplate.Resizable = DataGridViewTriState.False;
			dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvStock.Size = new Size(494, 569);
			dgvStock.TabIndex = 18;
			// 
			// flpStock
			// 
			flpStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			flpStock.AutoScroll = true;
			flpStock.BackColor = Color.FromArgb(252, 196, 196);
			flpStock.FlowDirection = FlowDirection.TopDown;
			flpStock.Location = new Point(513, 18);
			flpStock.Name = "flpStock";
			flpStock.Size = new Size(494, 569);
			flpStock.TabIndex = 17;
			// 
			// HospitalStock
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(flpStock);
			Controls.Add(btnPost);
			Controls.Add(dgvStock);
			Name = "HospitalStock";
			Padding = new Padding(10, 15, 10, 0);
			Size = new Size(1020, 641);
			Load += HospitalStock_Load;
			Resize += HospitalStock_Resize;
			((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvStock;
		private AntdUI.Button btnPost;
		private FlowLayoutPanel flpStock;
	}
}
