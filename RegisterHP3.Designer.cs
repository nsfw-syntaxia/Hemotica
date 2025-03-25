namespace Hemotica
{
    partial class RegisterHP3
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
			lblHAddress = new Label();
			lblPage = new Label();
			lblCNumber = new Label();
			btnRegister = new ReaLTaiizor.Controls.FoxButton();
			btnBack = new ReaLTaiizor.Controls.FoxButton();
			tbxHospitalAddress = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			tbxContactNumber = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			lblEnd = new Label();
			lblStart = new Label();
			cmbxEnd = new ReaLTaiizor.Controls.DungeonComboBox();
			cmbxStart = new ReaLTaiizor.Controls.DungeonComboBox();
			lblOHours = new Label();
			SuspendLayout();
			// 
			// lblHAddress
			// 
			lblHAddress.AutoSize = true;
			lblHAddress.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblHAddress.ForeColor = Color.FromArgb(216, 85, 101);
			lblHAddress.Location = new Point(3, 104);
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
			lblPage.Text = "3 / 3";
			// 
			// lblCNumber
			// 
			lblCNumber.AutoSize = true;
			lblCNumber.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblCNumber.ForeColor = Color.FromArgb(216, 85, 101);
			lblCNumber.Location = new Point(3, 170);
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
			tbxHospitalAddress.Location = new Point(3, 129);
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
			tbxContactNumber.Location = new Point(3, 195);
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
			// lblEnd
			// 
			lblEnd.AutoSize = true;
			lblEnd.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblEnd.ForeColor = Color.FromArgb(216, 85, 101);
			lblEnd.Location = new Point(15, 69);
			lblEnd.Name = "lblEnd";
			lblEnd.Size = new Size(38, 22);
			lblEnd.TabIndex = 86;
			lblEnd.Text = "End";
			// 
			// lblStart
			// 
			lblStart.AutoSize = true;
			lblStart.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblStart.ForeColor = Color.FromArgb(216, 85, 101);
			lblStart.Location = new Point(15, 32);
			lblStart.Name = "lblStart";
			lblStart.Size = new Size(44, 22);
			lblStart.TabIndex = 85;
			lblStart.Text = "Start";
			// 
			// cmbxEnd
			// 
			cmbxEnd.BackColor = Color.FromArgb(241, 241, 241);
			cmbxEnd.ColorA = Color.FromArgb(236, 124, 132);
			cmbxEnd.ColorB = Color.FromArgb(236, 124, 132);
			cmbxEnd.ColorC = Color.FromArgb(242, 241, 240);
			cmbxEnd.ColorD = Color.FromArgb(253, 252, 252);
			cmbxEnd.ColorE = Color.FromArgb(239, 237, 236);
			cmbxEnd.ColorF = Color.FromArgb(180, 180, 180);
			cmbxEnd.ColorG = Color.FromArgb(119, 119, 118);
			cmbxEnd.ColorH = Color.FromArgb(224, 222, 220);
			cmbxEnd.ColorI = Color.FromArgb(250, 249, 249);
			cmbxEnd.DrawMode = DrawMode.OwnerDrawFixed;
			cmbxEnd.DropDownHeight = 100;
			cmbxEnd.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbxEnd.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			cmbxEnd.ForeColor = Color.FromArgb(216, 85, 101);
			cmbxEnd.FormattingEnabled = true;
			cmbxEnd.HoverSelectionColor = Color.Empty;
			cmbxEnd.IntegralHeight = false;
			cmbxEnd.ItemHeight = 25;
			cmbxEnd.Items.AddRange(new object[] { "00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30" });
			cmbxEnd.Location = new Point(65, 66);
			cmbxEnd.Name = "cmbxEnd";
			cmbxEnd.Size = new Size(327, 31);
			cmbxEnd.StartIndex = 0;
			cmbxEnd.TabIndex = 84;
			// 
			// cmbxStart
			// 
			cmbxStart.BackColor = Color.FromArgb(241, 241, 241);
			cmbxStart.ColorA = Color.FromArgb(236, 124, 132);
			cmbxStart.ColorB = Color.FromArgb(236, 124, 132);
			cmbxStart.ColorC = Color.FromArgb(242, 241, 240);
			cmbxStart.ColorD = Color.FromArgb(253, 252, 252);
			cmbxStart.ColorE = Color.FromArgb(239, 237, 236);
			cmbxStart.ColorF = Color.FromArgb(180, 180, 180);
			cmbxStart.ColorG = Color.FromArgb(119, 119, 118);
			cmbxStart.ColorH = Color.FromArgb(224, 222, 220);
			cmbxStart.ColorI = Color.FromArgb(250, 249, 249);
			cmbxStart.DrawMode = DrawMode.OwnerDrawFixed;
			cmbxStart.DropDownHeight = 100;
			cmbxStart.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbxStart.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			cmbxStart.ForeColor = Color.FromArgb(216, 85, 101);
			cmbxStart.FormattingEnabled = true;
			cmbxStart.HoverSelectionColor = Color.Empty;
			cmbxStart.IntegralHeight = false;
			cmbxStart.ItemHeight = 25;
			cmbxStart.Items.AddRange(new object[] { "00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30" });
			cmbxStart.Location = new Point(65, 29);
			cmbxStart.Name = "cmbxStart";
			cmbxStart.Size = new Size(327, 31);
			cmbxStart.StartIndex = 0;
			cmbxStart.TabIndex = 83;
			// 
			// lblOHours
			// 
			lblOHours.AutoSize = true;
			lblOHours.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblOHours.ForeColor = Color.FromArgb(216, 85, 101);
			lblOHours.Location = new Point(3, 4);
			lblOHours.Name = "lblOHours";
			lblOHours.Size = new Size(204, 22);
			lblOHours.TabIndex = 82;
			lblOHours.Text = "Operating Hours (Saturday)";
			// 
			// RegisterHP3
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(lblEnd);
			Controls.Add(lblStart);
			Controls.Add(cmbxEnd);
			Controls.Add(cmbxStart);
			Controls.Add(lblOHours);
			Controls.Add(btnBack);
			Controls.Add(lblCNumber);
			Controls.Add(lblHAddress);
			Controls.Add(lblPage);
			Controls.Add(btnRegister);
			Controls.Add(tbxHospitalAddress);
			Controls.Add(tbxContactNumber);
			Name = "RegisterHP3";
			Size = new Size(396, 382);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblHAddress;
        private Label lblPage;
        private Label lblCNumber;
        private ReaLTaiizor.Controls.FoxButton btnRegister;
        private ReaLTaiizor.Controls.FoxButton btnBack;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxHospitalAddress;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxContactNumber;
		private Label lblEnd;
		private Label lblStart;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxEnd;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxStart;
		private Label lblOHours;
	}
}
