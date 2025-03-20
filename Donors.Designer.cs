namespace Hemotica
{
	partial class Donors
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
			lblDonor = new Label();
			SuspendLayout();
			// 
			// lblDonor
			// 
			lblDonor.AutoSize = true;
			lblDonor.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblDonor.ForeColor = Color.FromArgb(216, 85, 101);
			lblDonor.Location = new Point(3, 0);
			lblDonor.Name = "lblDonor";
			lblDonor.Padding = new Padding(5, 0, 0, 5);
			lblDonor.Size = new Size(117, 46);
			lblDonor.TabIndex = 11;
			lblDonor.Text = "Donor";
			// 
			// Donors
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(lblDonor);
			Name = "Donors";
			Size = new Size(447, 538);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblDonor;
	}
}
