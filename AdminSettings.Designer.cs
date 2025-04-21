namespace Hemotica
{
	partial class AdminSettings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSettings));
			pbxLogo = new PictureBox();
			btnCancel = new ReaLTaiizor.Controls.FoxButton();
			btnSave = new ReaLTaiizor.Controls.FoxButton();
			lblHeader = new Label();
			cbxSPassword = new ReaLTaiizor.Controls.HopeCheckBox();
			lblNewPassword = new Label();
			lblPassword = new Label();
			tbxPassword = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			tbxNewPassword = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
			SuspendLayout();
			// 
			// pbxLogo
			// 
			pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
			pbxLogo.Location = new Point(147, 17);
			pbxLogo.Name = "pbxLogo";
			pbxLogo.Size = new Size(125, 125);
			pbxLogo.TabIndex = 3;
			pbxLogo.TabStop = false;
			// 
			// btnCancel
			// 
			btnCancel.Anchor = AnchorStyles.Top;
			btnCancel.BackColor = Color.Transparent;
			btnCancel.BaseColor = Color.FromArgb(216, 85, 101);
			btnCancel.BorderColor = Color.FromArgb(216, 85, 101);
			btnCancel.DisabledBaseColor = Color.FromArgb(244, 148, 156);
			btnCancel.DisabledBorderColor = Color.FromArgb(244, 148, 156);
			btnCancel.DisabledTextColor = Color.FromArgb(244, 148, 156);
			btnCancel.DownColor = Color.FromArgb(236, 124, 132);
			btnCancel.EnabledCalc = true;
			btnCancel.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			btnCancel.ForeColor = Color.FromArgb(241, 241, 241);
			btnCancel.Location = new Point(81, 375);
			btnCancel.Name = "btnCancel";
			btnCancel.OverColor = Color.FromArgb(216, 85, 101);
			btnCancel.Size = new Size(120, 40);
			btnCancel.TabIndex = 84;
			btnCancel.Text = "CANCEL";
			btnCancel.Click += btnCancel_Click;
			// 
			// btnSave
			// 
			btnSave.Anchor = AnchorStyles.Top;
			btnSave.BackColor = Color.Transparent;
			btnSave.BaseColor = Color.FromArgb(216, 85, 101);
			btnSave.BorderColor = Color.FromArgb(216, 85, 101);
			btnSave.DisabledBaseColor = Color.FromArgb(244, 148, 156);
			btnSave.DisabledBorderColor = Color.FromArgb(244, 148, 156);
			btnSave.DisabledTextColor = Color.FromArgb(244, 148, 156);
			btnSave.DownColor = Color.FromArgb(236, 124, 132);
			btnSave.EnabledCalc = true;
			btnSave.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			btnSave.ForeColor = Color.FromArgb(241, 241, 241);
			btnSave.Location = new Point(212, 375);
			btnSave.Name = "btnSave";
			btnSave.OverColor = Color.FromArgb(216, 85, 101);
			btnSave.Size = new Size(120, 40);
			btnSave.TabIndex = 83;
			btnSave.Text = "SAVE";
			btnSave.Click += btnSave_Click;
			// 
			// lblHeader
			// 
			lblHeader.AutoSize = true;
			lblHeader.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblHeader.ForeColor = Color.FromArgb(216, 85, 101);
			lblHeader.Location = new Point(81, 162);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(254, 24);
			lblHeader.TabIndex = 2;
			lblHeader.Text = "SET NEW ADMIN PASSWORD !";
			// 
			// cbxSPassword
			// 
			cbxSPassword.AutoSize = true;
			cbxSPassword.CheckedColor = Color.FromArgb(236, 124, 132);
			cbxSPassword.DisabledColor = Color.FromArgb(241, 241, 241);
			cbxSPassword.DisabledStringColor = Color.FromArgb(241, 241, 241);
			cbxSPassword.Enable = true;
			cbxSPassword.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			cbxSPassword.EnabledStringColor = Color.FromArgb(216, 85, 101);
			cbxSPassword.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			cbxSPassword.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			cbxSPassword.ForeColor = Color.FromArgb(236, 124, 132);
			cbxSPassword.Location = new Point(254, 333);
			cbxSPassword.Name = "cbxSPassword";
			cbxSPassword.Size = new Size(147, 20);
			cbxSPassword.TabIndex = 87;
			cbxSPassword.Text = "Show Password";
			cbxSPassword.UseVisualStyleBackColor = true;
			cbxSPassword.CheckedChanged += cbxSPassword_CheckedChanged;
			// 
			// lblNewPassword
			// 
			lblNewPassword.AutoSize = true;
			lblNewPassword.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblNewPassword.ForeColor = Color.FromArgb(216, 85, 101);
			lblNewPassword.Location = new Point(12, 267);
			lblNewPassword.Name = "lblNewPassword";
			lblNewPassword.Size = new Size(174, 22);
			lblNewPassword.TabIndex = 86;
			lblNewPassword.Text = "Confirm New Password";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblPassword.ForeColor = Color.FromArgb(216, 85, 101);
			lblPassword.Location = new Point(12, 202);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(113, 22);
			lblPassword.TabIndex = 85;
			lblPassword.Text = "New Password";
			// 
			// tbxPassword
			// 
			tbxPassword.AllowPromptAsInput = true;
			tbxPassword.AnimateReadOnly = false;
			tbxPassword.AsciiOnly = false;
			tbxPassword.BackgroundImageLayout = ImageLayout.None;
			tbxPassword.BeepOnError = false;
			tbxPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			tbxPassword.Depth = 0;
			tbxPassword.Font = new Font("Arial Narrow", 13F);
			tbxPassword.HidePromptOnLeave = false;
			tbxPassword.HideSelection = true;
			tbxPassword.InsertKeyMode = InsertKeyMode.Default;
			tbxPassword.LeadingIcon = null;
			tbxPassword.Location = new Point(12, 227);
			tbxPassword.Mask = "";
			tbxPassword.MaxLength = 32767;
			tbxPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
			tbxPassword.Name = "tbxPassword";
			tbxPassword.PasswordChar = '●';
			tbxPassword.PrefixSuffixText = null;
			tbxPassword.PromptChar = '_';
			tbxPassword.ReadOnly = false;
			tbxPassword.RejectInputOnFirstFailure = false;
			tbxPassword.ResetOnPrompt = true;
			tbxPassword.ResetOnSpace = true;
			tbxPassword.RightToLeft = RightToLeft.No;
			tbxPassword.SelectedText = "";
			tbxPassword.SelectionLength = 0;
			tbxPassword.SelectionStart = 0;
			tbxPassword.ShortcutsEnabled = true;
			tbxPassword.Size = new Size(389, 36);
			tbxPassword.SkipLiterals = true;
			tbxPassword.TabIndex = 88;
			tbxPassword.TabStop = false;
			tbxPassword.TextAlign = HorizontalAlignment.Left;
			tbxPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
			tbxPassword.TrailingIcon = null;
			tbxPassword.UseSystemPasswordChar = false;
			tbxPassword.UseTallSize = false;
			tbxPassword.ValidatingType = null;
			// 
			// tbxNewPassword
			// 
			tbxNewPassword.AllowPromptAsInput = true;
			tbxNewPassword.AnimateReadOnly = false;
			tbxNewPassword.AsciiOnly = false;
			tbxNewPassword.BackgroundImageLayout = ImageLayout.None;
			tbxNewPassword.BeepOnError = false;
			tbxNewPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			tbxNewPassword.Depth = 0;
			tbxNewPassword.Font = new Font("Arial Narrow", 13F);
			tbxNewPassword.HidePromptOnLeave = false;
			tbxNewPassword.HideSelection = true;
			tbxNewPassword.InsertKeyMode = InsertKeyMode.Default;
			tbxNewPassword.LeadingIcon = null;
			tbxNewPassword.Location = new Point(12, 292);
			tbxNewPassword.Mask = "";
			tbxNewPassword.MaxLength = 32767;
			tbxNewPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
			tbxNewPassword.Name = "tbxNewPassword";
			tbxNewPassword.PasswordChar = '●';
			tbxNewPassword.PrefixSuffixText = null;
			tbxNewPassword.PromptChar = '_';
			tbxNewPassword.ReadOnly = false;
			tbxNewPassword.RejectInputOnFirstFailure = false;
			tbxNewPassword.ResetOnPrompt = true;
			tbxNewPassword.ResetOnSpace = true;
			tbxNewPassword.RightToLeft = RightToLeft.No;
			tbxNewPassword.SelectedText = "";
			tbxNewPassword.SelectionLength = 0;
			tbxNewPassword.SelectionStart = 0;
			tbxNewPassword.ShortcutsEnabled = true;
			tbxNewPassword.Size = new Size(389, 36);
			tbxNewPassword.SkipLiterals = true;
			tbxNewPassword.TabIndex = 89;
			tbxNewPassword.TabStop = false;
			tbxNewPassword.TextAlign = HorizontalAlignment.Left;
			tbxNewPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
			tbxNewPassword.TrailingIcon = null;
			tbxNewPassword.UseSystemPasswordChar = false;
			tbxNewPassword.UseTallSize = false;
			tbxNewPassword.ValidatingType = null;
			// 
			// AdminSettings
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = Color.FromArgb(253, 211, 211);
			ClientSize = new Size(413, 433);
			ControlBox = false;
			Controls.Add(cbxSPassword);
			Controls.Add(lblNewPassword);
			Controls.Add(lblPassword);
			Controls.Add(tbxPassword);
			Controls.Add(tbxNewPassword);
			Controls.Add(btnCancel);
			Controls.Add(btnSave);
			Controls.Add(pbxLogo);
			Controls.Add(lblHeader);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "AdminSettings";
			ShowIcon = false;
			ShowInTaskbar = false;
			SizeGripStyle = SizeGripStyle.Hide;
			StartPosition = FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private PictureBox pbxLogo;
		private ReaLTaiizor.Controls.FoxButton btnCancel;
		private ReaLTaiizor.Controls.FoxButton btnSave;
		private Label lblHeader;
		private ReaLTaiizor.Controls.HopeCheckBox cbxSPassword;
		private Label lblNewPassword;
		private Label lblPassword;
		private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxPassword;
		private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxNewPassword;
	}
}