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
			lblImage = new Label();
			pImage = new Panel();
			pbxImage = new PictureBox();
			btnAttach = new AntdUI.Button();
			btnRemove = new AntdUI.Button();
			tlpPost.SuspendLayout();
			pImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxImage).BeginInit();
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
			tlpPost.Controls.Add(btnRemove, 1, 7);
			tlpPost.Controls.Add(btnAttach, 0, 7);
			tlpPost.Controls.Add(pImage, 0, 1);
			tlpPost.Controls.Add(lblImage, 0, 0);
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
			// lblImage
			// 
			lblImage.AutoSize = true;
			tlpPost.SetColumnSpan(lblImage, 2);
			lblImage.Dock = DockStyle.Fill;
			lblImage.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblImage.ForeColor = Color.FromArgb(216, 85, 101);
			lblImage.Location = new Point(8, 5);
			lblImage.Name = "lblImage";
			lblImage.Padding = new Padding(5, 0, 0, 5);
			lblImage.Size = new Size(584, 58);
			lblImage.TabIndex = 76;
			lblImage.Text = "Image";
			lblImage.TextAlign = ContentAlignment.BottomLeft;
			// 
			// pImage
			// 
			pImage.BackColor = Color.FromArgb(216, 85, 101);
			tlpPost.SetColumnSpan(pImage, 2);
			pImage.Controls.Add(pbxImage);
			pImage.Dock = DockStyle.Fill;
			pImage.Location = new Point(8, 66);
			pImage.Name = "pImage";
			pImage.Padding = new Padding(5);
			tlpPost.SetRowSpan(pImage, 6);
			pImage.Size = new Size(584, 342);
			pImage.TabIndex = 77;
			// 
			// pbxImage
			// 
			pbxImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pbxImage.BackColor = Color.FromArgb(252, 228, 228);
			pbxImage.Location = new Point(8, 8);
			pbxImage.Name = "pbxImage";
			pbxImage.Size = new Size(568, 326);
			pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxImage.TabIndex = 1;
			pbxImage.TabStop = false;
			// 
			// btnAttach
			// 
			btnAttach.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnAttach.DefaultBack = Color.FromArgb(236, 124, 132);
			btnAttach.Font = new Font("Bahnschrift", 14F);
			btnAttach.ForeColor = Color.FromArgb(252, 228, 228);
			btnAttach.Location = new Point(112, 421);
			btnAttach.Name = "btnAttach";
			btnAttach.Size = new Size(185, 45);
			btnAttach.TabIndex = 78;
			btnAttach.Text = "Attach Photo";
			// 
			// btnRemove
			// 
			btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnRemove.DefaultBack = Color.FromArgb(236, 124, 132);
			btnRemove.Font = new Font("Bahnschrift", 14F);
			btnRemove.ForeColor = Color.FromArgb(252, 228, 228);
			btnRemove.Location = new Point(303, 421);
			btnRemove.Name = "btnRemove";
			btnRemove.Size = new Size(185, 45);
			btnRemove.TabIndex = 79;
			btnRemove.Text = "Remove Photo";
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
			pImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxImage).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private AntdUI.Button btnPost;
		private TableLayoutPanel tlpPost;
		private Label lblImage;
		private Label lblDescription;
		private DateTimePicker dtpAppointments;
		private Panel pImage;
		private PictureBox pbxImage;
		private AntdUI.Button btnAttach;
		private AntdUI.Button btnRemove;
	}
}
