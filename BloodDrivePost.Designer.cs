namespace Hemotica
{
	partial class BloodDrivePost
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
			SuspendLayout();
			// 
			// btnPost
			// 
			btnPost.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnPost.DefaultBack = Color.FromArgb(236, 124, 132);
			btnPost.Font = new Font("Bahnschrift", 14F);
			btnPost.ForeColor = Color.FromArgb(252, 228, 228);
			btnPost.Location = new Point(158, 276);
			btnPost.Name = "btnPost";
			btnPost.Size = new Size(290, 45);
			btnPost.TabIndex = 17;
			btnPost.Text = "Post a Blood Donation Drive";
			// 
			// BloodDrivePost
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(btnPost);
			Name = "BloodDrivePost";
			Size = new Size(606, 597);
			ResumeLayout(false);
		}

		#endregion

		private AntdUI.Button btnPost;
	}
}
