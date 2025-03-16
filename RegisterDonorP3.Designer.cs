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
            lblHAddress = new Label();
            lblBMI = new Label();
            lblCNumber = new Label();
            btnBack = new ReaLTaiizor.Controls.FoxButton();
            tbxHomeAddress = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbxContactNumber = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbxBMI = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
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
            lblBType.Location = new Point(3, 202);
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
            cmbxBType.Location = new Point(3, 227);
            cmbxBType.Name = "cmbxBType";
            cmbxBType.Size = new Size(389, 31);
            cmbxBType.StartIndex = 0;
            cmbxBType.TabIndex = 72;
            // 
            // lblHAddress
            // 
            lblHAddress.AutoSize = true;
            lblHAddress.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblHAddress.ForeColor = Color.FromArgb(216, 85, 101);
            lblHAddress.Location = new Point(3, 4);
            lblHAddress.Name = "lblHAddress";
            lblHAddress.Size = new Size(113, 22);
            lblHAddress.TabIndex = 75;
            lblHAddress.Text = "Home Address";
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblBMI.ForeColor = Color.FromArgb(216, 85, 101);
            lblBMI.Location = new Point(3, 136);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(129, 22);
            lblBMI.TabIndex = 73;
            lblBMI.Text = "Body Mass Index";
            // 
            // lblCNumber
            // 
            lblCNumber.AutoSize = true;
            lblCNumber.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblCNumber.ForeColor = Color.FromArgb(216, 85, 101);
            lblCNumber.Location = new Point(3, 70);
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
            // tbxHomeAddress
            // 
            tbxHomeAddress.AllowPromptAsInput = true;
            tbxHomeAddress.AnimateReadOnly = false;
            tbxHomeAddress.AsciiOnly = false;
            tbxHomeAddress.BackgroundImageLayout = ImageLayout.None;
            tbxHomeAddress.BeepOnError = false;
            tbxHomeAddress.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbxHomeAddress.Depth = 0;
            tbxHomeAddress.Font = new Font("Arial Narrow", 13F);
            tbxHomeAddress.HidePromptOnLeave = false;
            tbxHomeAddress.HideSelection = true;
            tbxHomeAddress.InsertKeyMode = InsertKeyMode.Default;
            tbxHomeAddress.LeadingIcon = null;
            tbxHomeAddress.Location = new Point(3, 29);
            tbxHomeAddress.Mask = "";
            tbxHomeAddress.MaxLength = 32767;
            tbxHomeAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxHomeAddress.Name = "tbxHomeAddress";
            tbxHomeAddress.PasswordChar = '\0';
            tbxHomeAddress.PrefixSuffixText = null;
            tbxHomeAddress.PromptChar = '_';
            tbxHomeAddress.ReadOnly = false;
            tbxHomeAddress.RejectInputOnFirstFailure = false;
            tbxHomeAddress.ResetOnPrompt = true;
            tbxHomeAddress.ResetOnSpace = true;
            tbxHomeAddress.RightToLeft = RightToLeft.No;
            tbxHomeAddress.SelectedText = "";
            tbxHomeAddress.SelectionLength = 0;
            tbxHomeAddress.SelectionStart = 0;
            tbxHomeAddress.ShortcutsEnabled = true;
            tbxHomeAddress.Size = new Size(389, 36);
            tbxHomeAddress.SkipLiterals = true;
            tbxHomeAddress.TabIndex = 83;
            tbxHomeAddress.TabStop = false;
            tbxHomeAddress.TextAlign = HorizontalAlignment.Left;
            tbxHomeAddress.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbxHomeAddress.TrailingIcon = null;
            tbxHomeAddress.UseSystemPasswordChar = false;
            tbxHomeAddress.UseTallSize = false;
            tbxHomeAddress.ValidatingType = null;
            // 
            // tbxContactNumber
            // 
            tbxContactNumber.AllowPromptAsInput = true;
            tbxContactNumber.AnimateReadOnly = false;
            tbxContactNumber.AsciiOnly = false;
            tbxContactNumber.BackgroundImageLayout = ImageLayout.None;
            tbxContactNumber.BeepOnError = false;
            tbxContactNumber.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbxContactNumber.Depth = 0;
            tbxContactNumber.Font = new Font("Arial Narrow", 13F);
            tbxContactNumber.HidePromptOnLeave = false;
            tbxContactNumber.HideSelection = true;
            tbxContactNumber.InsertKeyMode = InsertKeyMode.Default;
            tbxContactNumber.LeadingIcon = null;
            tbxContactNumber.Location = new Point(3, 95);
            tbxContactNumber.Mask = "";
            tbxContactNumber.MaxLength = 32767;
            tbxContactNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxContactNumber.Name = "tbxContactNumber";
            tbxContactNumber.PasswordChar = '\0';
            tbxContactNumber.PrefixSuffixText = null;
            tbxContactNumber.PromptChar = '_';
            tbxContactNumber.ReadOnly = false;
            tbxContactNumber.RejectInputOnFirstFailure = false;
            tbxContactNumber.ResetOnPrompt = true;
            tbxContactNumber.ResetOnSpace = true;
            tbxContactNumber.RightToLeft = RightToLeft.No;
            tbxContactNumber.SelectedText = "";
            tbxContactNumber.SelectionLength = 0;
            tbxContactNumber.SelectionStart = 0;
            tbxContactNumber.ShortcutsEnabled = true;
            tbxContactNumber.Size = new Size(389, 36);
            tbxContactNumber.SkipLiterals = true;
            tbxContactNumber.TabIndex = 84;
            tbxContactNumber.TabStop = false;
            tbxContactNumber.TextAlign = HorizontalAlignment.Left;
            tbxContactNumber.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbxContactNumber.TrailingIcon = null;
            tbxContactNumber.UseSystemPasswordChar = false;
            tbxContactNumber.UseTallSize = false;
            tbxContactNumber.ValidatingType = null;
            // 
            // tbxBMI
            // 
            tbxBMI.AllowPromptAsInput = true;
            tbxBMI.AnimateReadOnly = false;
            tbxBMI.AsciiOnly = false;
            tbxBMI.BackgroundImageLayout = ImageLayout.None;
            tbxBMI.BeepOnError = false;
            tbxBMI.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbxBMI.Depth = 0;
            tbxBMI.Font = new Font("Arial Narrow", 13F);
            tbxBMI.HidePromptOnLeave = false;
            tbxBMI.HideSelection = true;
            tbxBMI.InsertKeyMode = InsertKeyMode.Default;
            tbxBMI.LeadingIcon = null;
            tbxBMI.Location = new Point(3, 161);
            tbxBMI.Mask = "";
            tbxBMI.MaxLength = 32767;
            tbxBMI.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxBMI.Name = "tbxBMI";
            tbxBMI.PasswordChar = '\0';
            tbxBMI.PrefixSuffixText = null;
            tbxBMI.PromptChar = '_';
            tbxBMI.ReadOnly = false;
            tbxBMI.RejectInputOnFirstFailure = false;
            tbxBMI.ResetOnPrompt = true;
            tbxBMI.ResetOnSpace = true;
            tbxBMI.RightToLeft = RightToLeft.No;
            tbxBMI.SelectedText = "";
            tbxBMI.SelectionLength = 0;
            tbxBMI.SelectionStart = 0;
            tbxBMI.ShortcutsEnabled = true;
            tbxBMI.Size = new Size(389, 36);
            tbxBMI.SkipLiterals = true;
            tbxBMI.TabIndex = 85;
            tbxBMI.TabStop = false;
            tbxBMI.TextAlign = HorizontalAlignment.Left;
            tbxBMI.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbxBMI.TrailingIcon = null;
            tbxBMI.UseSystemPasswordChar = false;
            tbxBMI.UseTallSize = false;
            tbxBMI.ValidatingType = null;
            // 
            // RegisterDonorP3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 211, 211);
            Controls.Add(tbxBMI);
            Controls.Add(tbxContactNumber);
            Controls.Add(tbxHomeAddress);
            Controls.Add(btnBack);
            Controls.Add(lblHAddress);
            Controls.Add(lblBMI);
            Controls.Add(lblBType);
            Controls.Add(lblPage);
            Controls.Add(btnRegister);
            Controls.Add(cmbxBType);
            Controls.Add(lblCNumber);
            Name = "RegisterDonorP3";
            Size = new Size(396, 382);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPage;
        private Label lblBType;
        private ReaLTaiizor.Controls.DungeonComboBox cmbxBType;
        private Label lblHAddress;
        private Label lblBMI;
        private Label lblCNumber;
        private ReaLTaiizor.Controls.FoxButton btnRegister;
        private ReaLTaiizor.Controls.FoxButton btnBack;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxHomeAddress;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxContactNumber;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxBMI;
    }
}
