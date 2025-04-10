namespace Hemotica
{
	partial class BloodDrivePicture
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
			btnPost = new AntdUI.Button();
			tlpPost = new TableLayoutPanel();
			lblPhoto = new Label();
			tlpPost.SuspendLayout();
			SuspendLayout();
			// 
			// btnPost
			// 
			btnPost.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnPost.DefaultBack = Color.FromArgb(236, 124, 132);
			btnPost.Font = new Font("Bahnschrift", 14F);
			btnPost.ForeColor = Color.FromArgb(252, 228, 228);
			btnPost.Location = new Point(447, 538);
			btnPost.Name = "btnPost";
			btnPost.Size = new Size(145, 45);
			btnPost.TabIndex = 17;
			btnPost.Text = "Post";
			// 
			// tlpPost
			// 
			tlpPost.ColumnCount = 2;
			tlpPost.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPost.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpPost.Controls.Add(lblPhoto, 0, 0);
			tlpPost.Controls.Add(btnPost, 1, 9);
			tlpPost.Location = new Point(3, 3);
			tlpPost.Name = "tlpPost";
			tlpPost.Padding = new Padding(5);
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
			tlpPost.Size = new Size(600, 591);
			tlpPost.TabIndex = 18;
			// 
			// lblPhoto
			// 
			lblPhoto.AutoSize = true;
			tlpPost.SetColumnSpan(lblPhoto, 2);
			lblPhoto.Dock = DockStyle.Fill;
			lblPhoto.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblPhoto.ForeColor = Color.FromArgb(216, 85, 101);
			lblPhoto.Location = new Point(8, 5);
			lblPhoto.Name = "lblPhoto";
			lblPhoto.Padding = new Padding(5, 0, 0, 5);
			lblPhoto.Size = new Size(584, 58);
			lblPhoto.TabIndex = 76;
			lblPhoto.Text = "Attach Image";
			lblPhoto.TextAlign = ContentAlignment.BottomLeft;
			// 
			// BloodDrivePicture
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(252, 196, 196);
			Controls.Add(tlpPost);
			Name = "BloodDrivePicture";
			Size = new Size(606, 597);
			tlpPost.ResumeLayout(false);
			tlpPost.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private AntdUI.Button btnPost;
		private TableLayoutPanel tlpPost;
		private Label lblPhoto;
		private Label lblDescription;
		private DateTimePicker dtpAppointments;
	}
}
