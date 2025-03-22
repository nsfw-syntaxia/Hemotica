namespace Hemotica
{
	partial class RecordsPhysician
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
			lblPhysician = new Label();
			SuspendLayout();
			// 
			// lblPhysician
			// 
			lblPhysician.AutoSize = true;
			lblPhysician.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
			lblPhysician.ForeColor = Color.FromArgb(216, 85, 101);
			lblPhysician.Location = new Point(0, 0);
			lblPhysician.Name = "lblPhysician";
			lblPhysician.Padding = new Padding(5, 0, 0, 5);
			lblPhysician.Size = new Size(169, 46);
			lblPhysician.TabIndex = 13;
			lblPhysician.Text = "Physician";
			// 
			// RecordsPhysician
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(lblPhysician);
			Name = "RecordsPhysician";
			Size = new Size(447, 545);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblPhysician;
	}
}
