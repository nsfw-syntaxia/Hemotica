namespace Hemotica
{
    partial class Register
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            tEffect = new System.Windows.Forms.Timer(components);
            pbxLogo = new PictureBox();
            pbxRegister = new PictureBox();
            btnClose = new Button();
            flpUserRegister = new FlowLayoutPanel();
            lblLOGIN = new Label();
            lblAHAA = new Label();
            cmbxRUser = new ReaLTaiizor.Controls.DungeonComboBox();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxRegister).BeginInit();
            SuspendLayout();
            // 
            // tEffect
            // 
            tEffect.Enabled = true;
            tEffect.Interval = 1;
            tEffect.Tick += tEffect_Tick;
            // 
            // pbxLogo
            // 
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(147, 17);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(125, 125);
            pbxLogo.TabIndex = 2;
            pbxLogo.TabStop = false;
            // 
            // pbxRegister
            // 
            pbxRegister.Image = (Image)resources.GetObject("pbxRegister.Image");
            pbxRegister.Location = new Point(97, 141);
            pbxRegister.Name = "pbxRegister";
            pbxRegister.Size = new Size(225, 55);
            pbxRegister.TabIndex = 3;
            pbxRegister.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(253, 211, 211);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(383, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // flpUserRegister
            // 
            flpUserRegister.Location = new Point(12, 249);
            flpUserRegister.Name = "flpUserRegister";
            flpUserRegister.Size = new Size(396, 382);
            flpUserRegister.TabIndex = 13;
            // 
            // lblLOGIN
            // 
            lblLOGIN.AutoSize = true;
            lblLOGIN.Cursor = Cursors.Hand;
            lblLOGIN.Font = new Font("Arial Narrow", 13F, FontStyle.Bold | FontStyle.Underline);
            lblLOGIN.ForeColor = Color.FromArgb(216, 85, 101);
            lblLOGIN.Location = new Point(182, 675);
            lblLOGIN.Name = "lblLOGIN";
            lblLOGIN.Size = new Size(57, 22);
            lblLOGIN.TabIndex = 53;
            lblLOGIN.Text = "LOGIN";
            lblLOGIN.Click += lblLOGIN_Click;
            // 
            // lblAHAA
            // 
            lblAHAA.AutoSize = true;
            lblAHAA.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblAHAA.ForeColor = Color.FromArgb(236, 124, 132);
            lblAHAA.Location = new Point(115, 648);
            lblAHAA.Name = "lblAHAA";
            lblAHAA.Size = new Size(190, 22);
            lblAHAA.TabIndex = 52;
            lblAHAA.Text = "Already have an account?";
            // 
            // cmbxRUser
            // 
            cmbxRUser.BackColor = Color.FromArgb(241, 241, 241);
            cmbxRUser.ColorA = Color.FromArgb(236, 124, 132);
            cmbxRUser.ColorB = Color.FromArgb(236, 124, 132);
            cmbxRUser.ColorC = Color.FromArgb(242, 241, 240);
            cmbxRUser.ColorD = Color.FromArgb(253, 252, 252);
            cmbxRUser.ColorE = Color.FromArgb(239, 237, 236);
            cmbxRUser.ColorF = Color.FromArgb(180, 180, 180);
            cmbxRUser.ColorG = Color.FromArgb(119, 119, 118);
            cmbxRUser.ColorH = Color.FromArgb(224, 222, 220);
            cmbxRUser.ColorI = Color.FromArgb(250, 249, 249);
            cmbxRUser.DrawMode = DrawMode.OwnerDrawFixed;
            cmbxRUser.DropDownHeight = 100;
            cmbxRUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxRUser.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            cmbxRUser.ForeColor = Color.FromArgb(216, 85, 101);
            cmbxRUser.FormattingEnabled = true;
            cmbxRUser.HoverSelectionColor = Color.Empty;
            cmbxRUser.IntegralHeight = false;
            cmbxRUser.ItemHeight = 25;
            cmbxRUser.Items.AddRange(new object[] { "Select user type", "Donor", "Hospital" });
            cmbxRUser.Location = new Point(18, 212);
            cmbxRUser.Name = "cmbxRUser";
            cmbxRUser.Size = new Size(389, 31);
            cmbxRUser.StartIndex = 0;
            cmbxRUser.TabIndex = 54;
            cmbxRUser.SelectedIndexChanged += cmbxRUser_SelectedIndexChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 211, 211);
            ClientSize = new Size(420, 720);
            ControlBox = false;
            Controls.Add(lblLOGIN);
            Controls.Add(lblAHAA);
            Controls.Add(flpUserRegister);
            Controls.Add(btnClose);
            Controls.Add(pbxRegister);
            Controls.Add(pbxLogo);
            Controls.Add(cmbxRUser);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Opacity = 0D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxRegister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer tEffect;
        private PictureBox pbxLogo;
        private PictureBox pbxRegister;
        private Button btnClose;
        private FlowLayoutPanel flpUserRegister;
        private Label lblLOGIN;
        private Label lblAHAA;
        private ReaLTaiizor.Controls.DungeonComboBox cmbxRUser;
    }
}