namespace Hemotica
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			btnClose = new Button();
			btnMaximize = new Button();
			btnMinimize = new Button();
			pbxHeart = new PictureBox();
			pbxTitle = new PictureBox();
			pbxCaption = new PictureBox();
			pbxFade = new PictureBox();
			tToggle = new System.Windows.Forms.Timer(components);
			lblGuide = new Label();
			((System.ComponentModel.ISupportInitialize)pbxHeart).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbxTitle).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbxCaption).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbxFade).BeginInit();
			SuspendLayout();
			// 
			// btnClose
			// 
			btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnClose.FlatAppearance.BorderColor = Color.FromArgb(253, 211, 211);
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.Image = (Image)resources.GetObject("btnClose.Image");
			btnClose.Location = new Point(1226, 12);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(25, 25);
			btnClose.TabIndex = 2;
			btnClose.TabStop = false;
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// btnMaximize
			// 
			btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnMaximize.FlatAppearance.BorderColor = Color.FromArgb(253, 211, 211);
			btnMaximize.FlatAppearance.BorderSize = 0;
			btnMaximize.FlatStyle = FlatStyle.Flat;
			btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
			btnMaximize.Location = new Point(1195, 12);
			btnMaximize.Name = "btnMaximize";
			btnMaximize.Size = new Size(25, 25);
			btnMaximize.TabIndex = 3;
			btnMaximize.TabStop = false;
			btnMaximize.UseVisualStyleBackColor = true;
			btnMaximize.Click += btnMaximize_Click;
			// 
			// btnMinimize
			// 
			btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(253, 211, 211);
			btnMinimize.FlatAppearance.BorderSize = 0;
			btnMinimize.FlatStyle = FlatStyle.Flat;
			btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
			btnMinimize.ImageAlign = ContentAlignment.TopCenter;
			btnMinimize.Location = new Point(1164, 12);
			btnMinimize.Name = "btnMinimize";
			btnMinimize.Size = new Size(25, 25);
			btnMinimize.TabIndex = 4;
			btnMinimize.TabStop = false;
			btnMinimize.UseVisualStyleBackColor = true;
			btnMinimize.Click += btnMinimize_Click;
			// 
			// pbxHeart
			// 
			pbxHeart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pbxHeart.BackColor = Color.Transparent;
			pbxHeart.Cursor = Cursors.Hand;
			pbxHeart.Image = (Image)resources.GetObject("pbxHeart.Image");
			pbxHeart.Location = new Point(379, 248);
			pbxHeart.Name = "pbxHeart";
			pbxHeart.Size = new Size(505, 335);
			pbxHeart.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxHeart.TabIndex = 5;
			pbxHeart.TabStop = false;
			pbxHeart.Click += pbxHeart_Click;
			// 
			// pbxTitle
			// 
			pbxTitle.Image = (Image)resources.GetObject("pbxTitle.Image");
			pbxTitle.Location = new Point(379, 182);
			pbxTitle.Name = "pbxTitle";
			pbxTitle.Size = new Size(505, 60);
			pbxTitle.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxTitle.TabIndex = 6;
			pbxTitle.TabStop = false;
			// 
			// pbxCaption
			// 
			pbxCaption.Image = (Image)resources.GetObject("pbxCaption.Image");
			pbxCaption.Location = new Point(379, 589);
			pbxCaption.Name = "pbxCaption";
			pbxCaption.Size = new Size(505, 60);
			pbxCaption.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxCaption.TabIndex = 8;
			pbxCaption.TabStop = false;
			// 
			// pbxFade
			// 
			pbxFade.Image = (Image)resources.GetObject("pbxFade.Image");
			pbxFade.Location = new Point(379, 589);
			pbxFade.Name = "pbxFade";
			pbxFade.Size = new Size(505, 60);
			pbxFade.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxFade.TabIndex = 9;
			pbxFade.TabStop = false;
			// 
			// tToggle
			// 
			tToggle.Interval = 300;
			tToggle.Tick += tToggle_Tick;
			// 
			// lblGuide
			// 
			lblGuide.AutoSize = true;
			lblGuide.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblGuide.ForeColor = Color.FromArgb(236, 124, 132);
			lblGuide.Location = new Point(531, 674);
			lblGuide.Name = "lblGuide";
			lblGuide.Size = new Size(204, 19);
			lblGuide.TabIndex = 11;
			lblGuide.Text = "click the heart to continue !";
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			ClientSize = new Size(1263, 803);
			ControlBox = false;
			Controls.Add(lblGuide);
			Controls.Add(pbxCaption);
			Controls.Add(pbxTitle);
			Controls.Add(pbxHeart);
			Controls.Add(btnMinimize);
			Controls.Add(btnMaximize);
			Controls.Add(btnClose);
			Controls.Add(pbxFade);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Home";
			StartPosition = FormStartPosition.CenterScreen;
			Load += Home_Load;
			MouseDown += Home_MouseDown;
			Resize += Home_Resize;
			((System.ComponentModel.ISupportInitialize)pbxHeart).EndInit();
			((System.ComponentModel.ISupportInitialize)pbxTitle).EndInit();
			((System.ComponentModel.ISupportInitialize)pbxCaption).EndInit();
			((System.ComponentModel.ISupportInitialize)pbxFade).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private PictureBox pbxHeart;
        private PictureBox pbxTitle;
        private PictureBox pbxCaption;
        private PictureBox pbxFade;
        private System.Windows.Forms.Timer tToggle;
		private Label lblGuide;
	}
}
