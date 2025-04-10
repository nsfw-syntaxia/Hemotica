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
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			dgvStock = new DataGridView();
			pWarning = new Panel();
			lblNote = new Label();
			lblWarning = new Label();
			pPost = new Panel();
			tlpPost = new TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
			pWarning.SuspendLayout();
			pPost.SuspendLayout();
			SuspendLayout();
			// 
			// dgvStock
			// 
			dgvStock.AllowUserToAddRows = false;
			dgvStock.AllowUserToDeleteRows = false;
			dgvStock.AllowUserToResizeColumns = false;
			dgvStock.AllowUserToResizeRows = false;
			dgvStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvStock.BackgroundColor = Color.FromArgb(253, 211, 211);
			dgvStock.BorderStyle = BorderStyle.None;
			dgvStock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			dgvStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold);
			dataGridViewCellStyle4.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle4.Padding = new Padding(15, 5, 15, 5);
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(253, 211, 211);
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dgvStock.ColumnHeadersHeight = 50;
			dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvStock.EnableHeadersVisualStyles = false;
			dgvStock.GridColor = Color.FromArgb(253, 211, 211);
			dgvStock.Location = new Point(13, 18);
			dgvStock.MultiSelect = false;
			dgvStock.Name = "dgvStock";
			dgvStock.ReadOnly = true;
			dgvStock.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = SystemColors.Control;
			dataGridViewCellStyle5.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			dgvStock.RowHeadersVisible = false;
			dgvStock.RowHeadersWidth = 40;
			dataGridViewCellStyle6.BackColor = Color.FromArgb(244, 180, 180);
			dataGridViewCellStyle6.Font = new Font("Bahnschrift", 13F);
			dataGridViewCellStyle6.ForeColor = Color.FromArgb(216, 85, 101);
			dataGridViewCellStyle6.Padding = new Padding(20, 5, 20, 5);
			dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(236, 124, 132);
			dataGridViewCellStyle6.SelectionForeColor = Color.White;
			dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
			dgvStock.Size = new Size(494, 385);
			dgvStock.TabIndex = 18;
			// 
			// pWarning
			// 
			pWarning.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			pWarning.Controls.Add(lblNote);
			pWarning.Controls.Add(lblWarning);
			pWarning.Location = new Point(13, 409);
			pWarning.Name = "pWarning";
			pWarning.Padding = new Padding(10);
			pWarning.Size = new Size(494, 214);
			pWarning.TabIndex = 19;
			// 
			// lblNote
			// 
			lblNote.AutoSize = true;
			lblNote.Font = new Font("Bahnschrift", 15F);
			lblNote.ForeColor = Color.FromArgb(216, 85, 101);
			lblNote.Location = new Point(13, 59);
			lblNote.Name = "lblNote";
			lblNote.Size = new Size(119, 24);
			lblNote.TabIndex = 1;
			lblNote.Text = "ATTENTION:";
			// 
			// lblWarning
			// 
			lblWarning.AutoSize = true;
			lblWarning.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblWarning.ForeColor = Color.FromArgb(216, 85, 101);
			lblWarning.Location = new Point(13, 10);
			lblWarning.Name = "lblWarning";
			lblWarning.Size = new Size(148, 33);
			lblWarning.TabIndex = 0;
			lblWarning.Text = "WARNING !";
			// 
			// pPost
			// 
			pPost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pPost.BackColor = Color.FromArgb(252, 196, 196);
			pPost.Controls.Add(tlpPost);
			pPost.Location = new Point(513, 18);
			pPost.Name = "pPost";
			pPost.Padding = new Padding(3);
			pPost.Size = new Size(494, 605);
			pPost.TabIndex = 20;
			// 
			// tlpPost
			// 
			tlpPost.ColumnCount = 2;
			tlpPost.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPost.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPost.Dock = DockStyle.Fill;
			tlpPost.Location = new Point(3, 3);
			tlpPost.Name = "tlpPost";
			tlpPost.RowCount = 10;
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tlpPost.Size = new Size(488, 599);
			tlpPost.TabIndex = 0;
			// 
			// HospitalStock
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(pPost);
			Controls.Add(pWarning);
			Controls.Add(dgvStock);
			Name = "HospitalStock";
			Padding = new Padding(10, 15, 10, 15);
			Size = new Size(1020, 641);
			Load += HospitalStock_Load;
			Resize += HospitalStock_Resize;
			((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
			pWarning.ResumeLayout(false);
			pWarning.PerformLayout();
			pPost.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvStock;
		private Panel pWarning;
		private Label lblWarning;
		private Label lblNote;
		private TableLayoutPanel tlpBloodDrive;
		private Panel pPost;
		private TableLayoutPanel tlpPost;
	}
}
