namespace Hemotica
{
    partial class RegisterDonorP3
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
            lblPage = new Label();
            btnRegister = new ReaLTaiizor.Controls.FoxButton();
            lblBType = new Label();
            cmbxBType = new ReaLTaiizor.Controls.DungeonComboBox();
            tbxHAddress = new TextBox();
            lblHAddress = new Label();
            tbxBMI = new TextBox();
            lblBMI = new Label();
            tbxCNumber = new TextBox();
            lblCNumber = new Label();
            btnBack = new ReaLTaiizor.Controls.FoxButton();
            SuspendLayout();
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblPage.ForeColor = Color.FromArgb(236, 124, 132);
            lblPage.Location = new Point(178, 297);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(38, 22);
            lblPage.TabIndex = 32;
            lblPage.Text = "3 / 3";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.BaseColor = Color.FromArgb(216, 85, 101);
            btnRegister.BorderColor = Color.FromArgb(216, 85, 101);
            btnRegister.DisabledBaseColor = Color.FromArgb(244, 148, 156);
            btnRegister.DisabledBorderColor = Color.FromArgb(244, 148, 156);
            btnRegister.DisabledTextColor = Color.FromArgb(244, 148, 156);
            btnRegister.DownColor = Color.FromArgb(236, 124, 132);
            btnRegister.EnabledCalc = true;
            btnRegister.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btnRegister.ForeColor = Color.FromArgb(241, 241, 241);
            btnRegister.Location = new Point(203, 334);
            btnRegister.Name = "btnRegister";
            btnRegister.OverColor = Color.FromArgb(216, 85, 101);
            btnRegister.Size = new Size(120, 40);
            btnRegister.TabIndex = 49;
            btnRegister.Text = "REGISTER";
            // 
            // lblBType
            // 
            lblBType.AutoSize = true;
            lblBType.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblBType.ForeColor = Color.FromArgb(216, 85, 101);
            lblBType.Location = new Point(3, 4);
            lblBType.Name = "lblBType";
            lblBType.Size = new Size(90, 22);
            lblBType.TabIndex = 70;
            lblBType.Text = "Blood Type";
            // 
            // cmbxBType
            // 
            cmbxBType.BackColor = Color.FromArgb(241, 241, 241);
            cmbxBType.ColorA = Color.FromArgb(236, 124, 132);
            cmbxBType.ColorB = Color.FromArgb(236, 124, 132);
            cmbxBType.ColorC = Color.FromArgb(242, 241, 240);
            cmbxBType.ColorD = Color.FromArgb(253, 252, 252);
            cmbxBType.ColorE = Color.FromArgb(239, 237, 236);
            cmbxBType.ColorF = Color.FromArgb(180, 180, 180);
            cmbxBType.ColorG = Color.FromArgb(119, 119, 118);
            cmbxBType.ColorH = Color.FromArgb(224, 222, 220);
            cmbxBType.ColorI = Color.FromArgb(250, 249, 249);
            cmbxBType.DrawMode = DrawMode.OwnerDrawFixed;
            cmbxBType.DropDownHeight = 100;
            cmbxBType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxBType.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            cmbxBType.ForeColor = Color.FromArgb(216, 85, 101);
            cmbxBType.FormattingEnabled = true;
            cmbxBType.HoverSelectionColor = Color.Empty;
            cmbxBType.IntegralHeight = false;
            cmbxBType.ItemHeight = 25;
            cmbxBType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cmbxBType.Location = new Point(3, 29);
            cmbxBType.Name = "cmbxBType";
            cmbxBType.Size = new Size(389, 31);
            cmbxBType.StartIndex = 0;
            cmbxBType.TabIndex = 72;
            // 
            // tbxHAddress
            // 
            tbxHAddress.BackColor = Color.FromArgb(241, 241, 241);
            tbxHAddress.BorderStyle = BorderStyle.None;
            tbxHAddress.Font = new Font("Arial Narrow", 13F);
            tbxHAddress.ForeColor = Color.FromArgb(216, 85, 101);
            tbxHAddress.Location = new Point(3, 156);
            tbxHAddress.Multiline = true;
            tbxHAddress.Name = "tbxHAddress";
            tbxHAddress.Size = new Size(389, 30);
            tbxHAddress.TabIndex = 76;
            // 
            // lblHAddress
            // 
            lblHAddress.AutoSize = true;
            lblHAddress.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblHAddress.ForeColor = Color.FromArgb(216, 85, 101);
            lblHAddress.Location = new Point(3, 131);
            lblHAddress.Name = "lblHAddress";
            lblHAddress.Size = new Size(113, 22);
            lblHAddress.TabIndex = 75;
            lblHAddress.Text = "Home Address";
            // 
            // tbxBMI
            // 
            tbxBMI.BackColor = Color.FromArgb(241, 241, 241);
            tbxBMI.BorderStyle = BorderStyle.None;
            tbxBMI.Font = new Font("Arial Narrow", 13F);
            tbxBMI.ForeColor = Color.FromArgb(216, 85, 101);
            tbxBMI.Location = new Point(3, 93);
            tbxBMI.Multiline = true;
            tbxBMI.Name = "tbxBMI";
            tbxBMI.Size = new Size(389, 30);
            tbxBMI.TabIndex = 74;
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblBMI.ForeColor = Color.FromArgb(216, 85, 101);
            lblBMI.Location = new Point(3, 68);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(129, 22);
            lblBMI.TabIndex = 73;
            lblBMI.Text = "Body Mass Index";
            // 
            // tbxCNumber
            // 
            tbxCNumber.BackColor = Color.FromArgb(241, 241, 241);
            tbxCNumber.BorderStyle = BorderStyle.None;
            tbxCNumber.Font = new Font("Arial Narrow", 13F);
            tbxCNumber.ForeColor = Color.FromArgb(216, 85, 101);
            tbxCNumber.Location = new Point(3, 219);
            tbxCNumber.Multiline = true;
            tbxCNumber.Name = "tbxCNumber";
            tbxCNumber.Size = new Size(389, 30);
            tbxCNumber.TabIndex = 78;
            // 
            // lblCNumber
            // 
            lblCNumber.AutoSize = true;
            lblCNumber.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblCNumber.ForeColor = Color.FromArgb(216, 85, 101);
            lblCNumber.Location = new Point(3, 194);
            lblCNumber.Name = "lblCNumber";
            lblCNumber.Size = new Size(124, 22);
            lblCNumber.TabIndex = 77;
            lblCNumber.Text = "Contact Number";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BaseColor = Color.FromArgb(216, 85, 101);
            btnBack.BorderColor = Color.FromArgb(216, 85, 101);
            btnBack.DisabledBaseColor = Color.FromArgb(244, 148, 156);
            btnBack.DisabledBorderColor = Color.FromArgb(244, 148, 156);
            btnBack.DisabledTextColor = Color.FromArgb(244, 148, 156);
            btnBack.DownColor = Color.FromArgb(236, 124, 132);
            btnBack.EnabledCalc = true;
            btnBack.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(241, 241, 241);
            btnBack.Location = new Point(72, 334);
            btnBack.Name = "btnBack";
            btnBack.OverColor = Color.FromArgb(216, 85, 101);
            btnBack.Size = new Size(120, 40);
            btnBack.TabIndex = 79;
            btnBack.Text = "BACK";
            btnBack.Click += btnBack_Click;
            // 
            // RegisterDonorP3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 211, 211);
            Controls.Add(btnBack);
            Controls.Add(tbxCNumber);
            Controls.Add(lblCNumber);
            Controls.Add(tbxHAddress);
            Controls.Add(lblHAddress);
            Controls.Add(tbxBMI);
            Controls.Add(lblBMI);
            Controls.Add(lblBType);
            Controls.Add(lblPage);
            Controls.Add(btnRegister);
            Controls.Add(cmbxBType);
            Name = "RegisterDonorP3";
            Size = new Size(396, 382);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPage;
        private Label lblBType;
        private ReaLTaiizor.Controls.DungeonComboBox cmbxBType;
        private TextBox tbxHAddress;
        private Label lblHAddress;
        private TextBox tbxBMI;
        private Label lblBMI;
        private TextBox tbxCNumber;
        private Label lblCNumber;
        private ReaLTaiizor.Controls.FoxButton btnRegister;
        private ReaLTaiizor.Controls.FoxButton btnBack;
    }
}
