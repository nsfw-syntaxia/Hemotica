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
			dgvStock = new DataGridView();
			btnPost = new AntdUI.Button();
			flpStock = new FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
			SuspendLayout();
			// 
			// dgvStock
			// 
			dgvStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvStock.BackgroundColor = Color.FromArgb(244, 180, 180);
			dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvStock.GridColor = Color.FromArgb(244, 180, 180);
			dgvStock.Location = new Point(3, 3);
			dgvStock.Name = "dgvStock";
			dgvStock.Size = new Size(740, 584);
			dgvStock.TabIndex = 1;
			// 
			// btnPost
			// 
			btnPost.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnPost.DefaultBack = Color.FromArgb(236, 124, 132);
			btnPost.Font = new Font("Bahnschrift", 14F);
			btnPost.ForeColor = Color.FromArgb(252, 228, 228);
			btnPost.Location = new Point(3, 593);
			btnPost.Name = "btnPost";
			btnPost.Size = new Size(290, 45);
			btnPost.TabIndex = 16;
			btnPost.Text = "Post a Blood Donation Drive";
			// 
			// flpStock
			// 
			flpStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			flpStock.AutoScroll = true;
			flpStock.BackColor = Color.FromArgb(253, 211, 211);
			flpStock.FlowDirection = FlowDirection.TopDown;
			flpStock.Location = new Point(749, 3);
			flpStock.Name = "flpStock";
			flpStock.Size = new Size(268, 584);
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
			Size = new Size(1020, 641);
			((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvStock;
		private AntdUI.Button btnPost;
		private FlowLayoutPanel flpStock;
	}
}
