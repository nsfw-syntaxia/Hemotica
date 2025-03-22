namespace Hemotica
{
	partial class Calendar
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
			pDays = new Panel();
			lblDays = new Label();
			pDays.SuspendLayout();
			SuspendLayout();
			// 
			// pDays
			// 
			pDays.Controls.Add(lblDays);
			pDays.Dock = DockStyle.Fill;
			pDays.Location = new Point(0, 0);
			pDays.Name = "pDays";
			pDays.Padding = new Padding(3);
			pDays.Size = new Size(137, 74);
			pDays.TabIndex = 0;
			// 
			// lblDays
			// 
			lblDays.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lblDays.AutoSize = true;
			lblDays.Font = new Font("Bahnschrift", 15F);
			lblDays.Location = new Point(101, 3);
			lblDays.Name = "lblDays";
			lblDays.Size = new Size(32, 24);
			lblDays.TabIndex = 0;
			lblDays.Text = "00";
			lblDays.TextAlign = ContentAlignment.MiddleRight;
			// 
			// Calendar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(pDays);
			Name = "Calendar";
			Size = new Size(137, 74);
			pDays.ResumeLayout(false);
			pDays.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel pDays;
		private Label lblDays;
	}
}
