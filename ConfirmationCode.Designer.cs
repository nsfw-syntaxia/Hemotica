namespace Hemotica
{
	partial class ConfirmationCode
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
			lblHeader = new Label();
			lblL1Instruction = new Label();
			lblCode = new Label();
			tbxCode = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			btnBack = new ReaLTaiizor.Controls.FoxButton();
			btnSubmit = new ReaLTaiizor.Controls.FoxButton();
			label1 = new Label();
			SuspendLayout();
			// 
			// lblHeader
			// 
			lblHeader.AutoSize = true;
			lblHeader.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblHeader.ForeColor = Color.FromArgb(216, 85, 101);
			lblHeader.Location = new Point(96, 4);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(204, 24);
			lblHeader.TabIndex = 1;
			lblHeader.Text = "WE SENT YOU A CODE !";
			// 
			// lblL1Instruction
			// 
			lblL1Instruction.AutoSize = true;
			lblL1Instruction.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblL1Instruction.ForeColor = Color.FromArgb(236, 124, 132);
			lblL1Instruction.Location = new Point(18, 53);
			lblL1Instruction.Name = "lblL1Instruction";
			lblL1Instruction.Size = new Size(360, 22);
			lblL1Instruction.TabIndex = 2;
			lblL1Instruction.Text = "Check your email for the confirmation code. If you\r\n";
			// 
			// lblCode
			// 
			lblCode.AutoSize = true;
			lblCode.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblCode.ForeColor = Color.FromArgb(216, 85, 101);
			lblCode.Location = new Point(3, 129);
			lblCode.Name = "lblCode";
			lblCode.Size = new Size(47, 22);
			lblCode.TabIndex = 77;
			lblCode.Text = "Code";
			// 
			// tbxCode
			// 
			tbxCode.AllowPromptAsInput = true;
			tbxCode.AnimateReadOnly = false;
			tbxCode.AsciiOnly = false;
			tbxCode.BackgroundImageLayout = ImageLayout.None;
			tbxCode.BeepOnError = false;
			tbxCode.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			tbxCode.Depth = 0;
			tbxCode.Font = new Font("Arial Narrow", 13F);
			tbxCode.HidePromptOnLeave = false;
			tbxCode.HideSelection = true;
			tbxCode.InsertKeyMode = InsertKeyMode.Default;
			tbxCode.LeadingIcon = null;
			tbxCode.Location = new Point(3, 154);
			tbxCode.Mask = "";
			tbxCode.MaxLength = 32767;
			tbxCode.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
			tbxCode.Name = "tbxCode";
			tbxCode.PasswordChar = '\0';
			tbxCode.PrefixSuffixText = null;
			tbxCode.PromptChar = '_';
			tbxCode.ReadOnly = false;
			tbxCode.RejectInputOnFirstFailure = false;
			tbxCode.ResetOnPrompt = true;
			tbxCode.ResetOnSpace = true;
			tbxCode.RightToLeft = RightToLeft.No;
			tbxCode.SelectedText = "";
			tbxCode.SelectionLength = 0;
			tbxCode.SelectionStart = 0;
			tbxCode.ShortcutsEnabled = true;
			tbxCode.Size = new Size(389, 36);
			tbxCode.SkipLiterals = true;
			tbxCode.TabIndex = 78;
			tbxCode.TabStop = false;
			tbxCode.TextAlign = HorizontalAlignment.Left;
			tbxCode.TextMaskFormat = MaskFormat.IncludeLiterals;
			tbxCode.TrailingIcon = null;
			tbxCode.UseSystemPasswordChar = false;
			tbxCode.UseTallSize = false;
			tbxCode.ValidatingType = null;
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
			btnBack.Location = new Point(72, 218);
			btnBack.Name = "btnBack";
			btnBack.OverColor = Color.FromArgb(216, 85, 101);
			btnBack.Size = new Size(120, 40);
			btnBack.TabIndex = 80;
			btnBack.Text = "BACK";
			btnBack.Click += btnBack_Click;
			// 
			// btnSubmit
			// 
			btnSubmit.BackColor = Color.Transparent;
			btnSubmit.BaseColor = Color.FromArgb(216, 85, 101);
			btnSubmit.BorderColor = Color.FromArgb(216, 85, 101);
			btnSubmit.DisabledBaseColor = Color.FromArgb(244, 148, 156);
			btnSubmit.DisabledBorderColor = Color.FromArgb(244, 148, 156);
			btnSubmit.DisabledTextColor = Color.FromArgb(244, 148, 156);
			btnSubmit.DownColor = Color.FromArgb(236, 124, 132);
			btnSubmit.EnabledCalc = true;
			btnSubmit.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			btnSubmit.ForeColor = Color.FromArgb(241, 241, 241);
			btnSubmit.Location = new Point(203, 218);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.OverColor = Color.FromArgb(216, 85, 101);
			btnSubmit.Size = new Size(120, 40);
			btnSubmit.TabIndex = 79;
			btnSubmit.Text = "SUBMIT";
			btnSubmit.Click += btnSubmit_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(236, 124, 132);
			label1.Location = new Point(30, 80);
			label1.Name = "label1";
			label1.Size = new Size(336, 22);
			label1.TabIndex = 81;
			label1.Text = "need a new one, go back and request a resend.";
			// 
			// ConfirmationCode
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(label1);
			Controls.Add(btnBack);
			Controls.Add(btnSubmit);
			Controls.Add(lblCode);
			Controls.Add(tbxCode);
			Controls.Add(lblL1Instruction);
			Controls.Add(lblHeader);
			Name = "ConfirmationCode";
			Size = new Size(396, 266);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHeader;
		private Label lblL1Instruction;
		private Label lblCode;
		private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxCode;
		private ReaLTaiizor.Controls.FoxButton btnBack;
		private ReaLTaiizor.Controls.FoxButton btnSubmit;
		private Label label1;
	}
}
