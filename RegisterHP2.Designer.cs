namespace Hemotica
{
    partial class RegisterHP2
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
            lblName = new Label();
            lblID = new Label();
            lblHAddress = new Label();
            lblPage = new Label();
            lblCNumber = new Label();
            btnRegister = new ReaLTaiizor.Controls.FoxButton();
            btnBack = new ReaLTaiizor.Controls.FoxButton();
            tbxHospitalName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbxID = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbxHospitalAddress = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbxContactNumber = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(216, 85, 101);
            lblName.Location = new Point(3, 4);
            lblName.Name = "lblName";
            lblName.Size = new Size(111, 22);
            lblName.TabIndex = 22;
            lblName.Text = "Hospital Name";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblID.ForeColor = Color.FromArgb(216, 85, 101);
            lblID.Location = new Point(3, 70);
            lblID.Name = "lblID";
            lblID.Size = new Size(240, 22);
            lblID.TabIndex = 26;
            lblID.Text = "License Number / Registration ID";
            // 
            // lblHAddress
            // 
            lblHAddress.AutoSize = true;
            lblHAddress.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblHAddress.ForeColor = Color.FromArgb(216, 85, 101);
            lblHAddress.Location = new Point(3, 136);
            lblHAddress.Name = "lblHAddress";
            lblHAddress.Size = new Size(69, 22);
            lblHAddress.TabIndex = 50;
            lblHAddress.Text = "Address";
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
            lblPage.Text = "2 / 2";
            // 
            // lblCNumber
            // 
            lblCNumber.AutoSize = true;
            lblCNumber.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblCNumber.ForeColor = Color.FromArgb(216, 85, 101);
            lblCNumber.Location = new Point(3, 202);
            lblCNumber.Name = "lblCNumber";
            lblCNumber.Size = new Size(124, 22);
            lblCNumber.TabIndex = 52;
            lblCNumber.Text = "Contact Number";
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
            btnRegister.Text = "SIGN UP";
            btnRegister.Click += btnRegister_Click;
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
            btnBack.TabIndex = 71;
            btnBack.Text = "BACK";
            btnBack.Click += btnBack_Click;
            // 
            // tbxHospitalName
            // 
            tbxHospitalName.AllowPromptAsInput = true;
            tbxHospitalName.AnimateReadOnly = false;
            tbxHospitalName.AsciiOnly = false;
            tbxHospitalName.BackgroundImageLayout = ImageLayout.None;
            tbxHospitalName.BeepOnError = false;
            tbxHospitalName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbxHospitalName.Depth = 0;
            tbxHospitalName.Font = new Font("Arial Narrow", 13F);
            tbxHospitalName.HidePromptOnLeave = false;
            tbxHospitalName.HideSelection = true;
            tbxHospitalName.InsertKeyMode = InsertKeyMode.Default;
            tbxHospitalName.LeadingIcon = null;
            tbxHospitalName.Location = new Point(3, 29);
            tbxHospitalName.Mask = "";
            tbxHospitalName.MaxLength = 32767;
            tbxHospitalName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxHospitalName.Name = "tbxHospitalName";
            tbxHospitalName.PasswordChar = '\0';
            tbxHospitalName.PrefixSuffixText = null;
            tbxHospitalName.PromptChar = '_';
            tbxHospitalName.ReadOnly = false;
            tbxHospitalName.RejectInputOnFirstFailure = false;
            tbxHospitalName.ResetOnPrompt = true;
            tbxHospitalName.ResetOnSpace = true;
            tbxHospitalName.RightToLeft = RightToLeft.No;
            tbxHospitalName.SelectedText = "";
            tbxHospitalName.SelectionLength = 0;
            tbxHospitalName.SelectionStart = 0;
            tbxHospitalName.ShortcutsEnabled = true;
            tbxHospitalName.Size = new Size(389, 36);
            tbxHospitalName.SkipLiterals = true;
            tbxHospitalName.TabIndex = 72;
            tbxHospitalName.TabStop = false;
            tbxHospitalName.TextAlign = HorizontalAlignment.Left;
            tbxHospitalName.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbxHospitalName.TrailingIcon = null;
            tbxHospitalName.UseSystemPasswordChar = false;
            tbxHospitalName.UseTallSize = false;
            tbxHospitalName.ValidatingType = null;
            // 
            // tbxID
            // 
            tbxID.AllowPromptAsInput = true;
            tbxID.AnimateReadOnly = false;
            tbxID.AsciiOnly = false;
            tbxID.BackgroundImageLayout = ImageLayout.None;
            tbxID.BeepOnError = false;
            tbxID.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbxID.Depth = 0;
            tbxID.Font = new Font("Arial Narrow", 13F);
            tbxID.HidePromptOnLeave = false;
            tbxID.HideSelection = true;
            tbxID.InsertKeyMode = InsertKeyMode.Default;
            tbxID.LeadingIcon = null;
            tbxID.Location = new Point(3, 95);
            tbxID.Mask = "";
            tbxID.MaxLength = 32767;
            tbxID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxID.Name = "tbxID";
            tbxID.PasswordChar = '\0';
            tbxID.PrefixSuffixText = null;
            tbxID.PromptChar = '_';
            tbxID.ReadOnly = false;
            tbxID.RejectInputOnFirstFailure = false;
            tbxID.ResetOnPrompt = true;
            tbxID.ResetOnSpace = true;
            tbxID.RightToLeft = RightToLeft.No;
            tbxID.SelectedText = "";
            tbxID.SelectionLength = 0;
            tbxID.SelectionStart = 0;
            tbxID.ShortcutsEnabled = true;
            tbxID.Size = new Size(389, 36);
            tbxID.SkipLiterals = true;
            tbxID.TabIndex = 73;
            tbxID.TabStop = false;
            tbxID.TextAlign = HorizontalAlignment.Left;
            tbxID.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbxID.TrailingIcon = null;
            tbxID.UseSystemPasswordChar = false;
            tbxID.UseTallSize = false;
            tbxID.ValidatingType = null;
            // 
            // tbxHospitalAddress
            // 
            tbxHospitalAddress.AllowPromptAsInput = true;
            tbxHospitalAddress.AnimateReadOnly = false;
            tbxHospitalAddress.AsciiOnly = false;
            tbxHospitalAddress.BackgroundImageLayout = ImageLayout.None;
            tbxHospitalAddress.BeepOnError = false;
            tbxHospitalAddress.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbxHospitalAddress.Depth = 0;
            tbxHospitalAddress.Font = new Font("Arial Narrow", 13F);
            tbxHospitalAddress.HidePromptOnLeave = false;
            tbxHospitalAddress.HideSelection = true;
            tbxHospitalAddress.InsertKeyMode = InsertKeyMode.Default;
            tbxHospitalAddress.LeadingIcon = null;
            tbxHospitalAddress.Location = new Point(3, 161);
            tbxHospitalAddress.Mask = "";
            tbxHospitalAddress.MaxLength = 32767;
            tbxHospitalAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxHospitalAddress.Name = "tbxHospitalAddress";
            tbxHospitalAddress.PasswordChar = '\0';
            tbxHospitalAddress.PrefixSuffixText = null;
            tbxHospitalAddress.PromptChar = '_';
            tbxHospitalAddress.ReadOnly = false;
            tbxHospitalAddress.RejectInputOnFirstFailure = false;
            tbxHospitalAddress.ResetOnPrompt = true;
            tbxHospitalAddress.ResetOnSpace = true;
            tbxHospitalAddress.RightToLeft = RightToLeft.No;
            tbxHospitalAddress.SelectedText = "";
            tbxHospitalAddress.SelectionLength = 0;
            tbxHospitalAddress.SelectionStart = 0;
            tbxHospitalAddress.ShortcutsEnabled = true;
            tbxHospitalAddress.Size = new Size(389, 36);
            tbxHospitalAddress.SkipLiterals = true;
            tbxHospitalAddress.TabIndex = 74;
            tbxHospitalAddress.TabStop = false;
            tbxHospitalAddress.TextAlign = HorizontalAlignment.Left;
            tbxHospitalAddress.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbxHospitalAddress.TrailingIcon = null;
            tbxHospitalAddress.UseSystemPasswordChar = false;
            tbxHospitalAddress.UseTallSize = false;
            tbxHospitalAddress.ValidatingType = null;
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
            tbxContactNumber.Location = new Point(3, 227);
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
            tbxContactNumber.TabIndex = 75;
            tbxContactNumber.TabStop = false;
            tbxContactNumber.TextAlign = HorizontalAlignment.Left;
            tbxContactNumber.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbxContactNumber.TrailingIcon = null;
            tbxContactNumber.UseSystemPasswordChar = false;
            tbxContactNumber.UseTallSize = false;
            tbxContactNumber.ValidatingType = null;
            // 
            // RegisterHP2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 211, 211);
            Controls.Add(tbxContactNumber);
            Controls.Add(btnBack);
            Controls.Add(lblCNumber);
            Controls.Add(lblHAddress);
            Controls.Add(lblPage);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(btnRegister);
            Controls.Add(tbxHospitalName);
            Controls.Add(tbxID);
            Controls.Add(tbxHospitalAddress);
            Name = "RegisterHP2";
            Size = new Size(396, 382);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblID;
        private Label lblHAddress;
        private Label lblPage;
        private Label lblCNumber;
        private ReaLTaiizor.Controls.FoxButton btnRegister;
        private ReaLTaiizor.Controls.FoxButton btnBack;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxHospitalName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxID;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxHospitalAddress;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxContactNumber;
    }
}
