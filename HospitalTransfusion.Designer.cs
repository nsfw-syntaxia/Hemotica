namespace Hemotica
{
	partial class HospitalTransfusion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalTransfusion));
			tplTransfusion = new TableLayoutPanel();
			pPatient = new Panel();
			pTransfusion = new Panel();
			pBlood = new Panel();
			pCompatibility = new Panel();
			pbxCompatibility = new PictureBox();
			tplTransfusion.SuspendLayout();
			pPatient.SuspendLayout();
			pBlood.SuspendLayout();
			pCompatibility.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxCompatibility).BeginInit();
			SuspendLayout();
			// 
			// tplTransfusion
			// 
			tplTransfusion.ColumnCount = 2;
			tplTransfusion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tplTransfusion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tplTransfusion.Controls.Add(pBlood, 1, 0);
			tplTransfusion.Controls.Add(pPatient, 0, 0);
			tplTransfusion.Location = new Point(13, 38);
			tplTransfusion.Name = "tplTransfusion";
			tplTransfusion.RowCount = 1;
			tplTransfusion.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tplTransfusion.Size = new Size(994, 565);
			tplTransfusion.TabIndex = 0;
			// 
			// pPatient
			// 
			pPatient.BackColor = Color.FromArgb(216, 85, 101);
			pPatient.Controls.Add(pTransfusion);
			pPatient.Dock = DockStyle.Fill;
			pPatient.Location = new Point(3, 3);
			pPatient.Name = "pPatient";
			pPatient.Padding = new Padding(10);
			pPatient.Size = new Size(491, 559);
			pPatient.TabIndex = 0;
			// 
			// pTransfusion
			// 
			pTransfusion.BackColor = Color.FromArgb(252, 228, 228);
			pTransfusion.Dock = DockStyle.Fill;
			pTransfusion.Location = new Point(10, 10);
			pTransfusion.Name = "pTransfusion";
			pTransfusion.Size = new Size(471, 539);
			pTransfusion.TabIndex = 0;
			// 
			// pBlood
			// 
			pBlood.BackColor = Color.FromArgb(216, 85, 101);
			pBlood.Controls.Add(pCompatibility);
			pBlood.Dock = DockStyle.Fill;
			pBlood.Location = new Point(500, 3);
			pBlood.Name = "pBlood";
			pBlood.Padding = new Padding(10);
			pBlood.Size = new Size(491, 559);
			pBlood.TabIndex = 1;
			// 
			// pCompatibility
			// 
			pCompatibility.BackColor = Color.FromArgb(255, 239, 242);
			pCompatibility.Controls.Add(pbxCompatibility);
			pCompatibility.Dock = DockStyle.Fill;
			pCompatibility.Location = new Point(10, 10);
			pCompatibility.Name = "pCompatibility";
			pCompatibility.Padding = new Padding(3);
			pCompatibility.Size = new Size(471, 539);
			pCompatibility.TabIndex = 0;
			// 
			// pbxCompatibility
			// 
			pbxCompatibility.Dock = DockStyle.Fill;
			pbxCompatibility.Image = (Image)resources.GetObject("pbxCompatibility.Image");
			pbxCompatibility.Location = new Point(3, 3);
			pbxCompatibility.Name = "pbxCompatibility";
			pbxCompatibility.Size = new Size(465, 533);
			pbxCompatibility.TabIndex = 0;
			pbxCompatibility.TabStop = false;
			// 
			// HospitalTransfusion
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(tplTransfusion);
			Name = "HospitalTransfusion";
			Padding = new Padding(10, 35, 10, 35);
			Size = new Size(1020, 641);
			Load += HospitalTransfusion_Load;
			tplTransfusion.ResumeLayout(false);
			pPatient.ResumeLayout(false);
			pBlood.ResumeLayout(false);
			pCompatibility.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxCompatibility).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private ReaLTaiizor.Controls.BigTextBox tbxPhysician;
		private TableLayoutPanel tplTransfusion;
		private Panel pPatient;
		private Panel pTransfusion;
		private Panel pBlood;
		private Panel pCompatibility;
		private PictureBox pbxCompatibility;
	}
}
