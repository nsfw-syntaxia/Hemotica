namespace Hemotica
{
    partial class DonorD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorD));
            btnPrev = new AntdUI.Button();
            btnDay = new AntdUI.Button();
            btnNext = new AntdUI.Button();
            lblCalendar = new Label();
            flpCalendar = new FlowLayoutPanel();
            flpAppointments = new FlowLayoutPanel();
            pALists = new Panel();
            lblAppointments = new Label();
            btnAdd = new AntdUI.Button();
            flpAppointments.SuspendLayout();
            pALists.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrev.DefaultBack = Color.FromArgb(244, 148, 156);
            btnPrev.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnPrev.ForeColor = Color.FromArgb(252, 228, 228);
            btnPrev.Icon = (Image)resources.GetObject("btnPrev.Icon");
            btnPrev.Location = new Point(485, 3);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(47, 45);
            btnPrev.TabIndex = 17;
            // 
            // btnDay
            // 
            btnDay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDay.DefaultBack = Color.FromArgb(244, 148, 156);
            btnDay.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnDay.ForeColor = Color.FromArgb(252, 228, 228);
            btnDay.Location = new Point(538, 3);
            btnDay.Name = "btnDay";
            btnDay.Size = new Size(92, 45);
            btnDay.TabIndex = 18;
            btnDay.Text = "DAY";
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.DefaultBack = Color.FromArgb(244, 148, 156);
            btnNext.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnNext.ForeColor = Color.FromArgb(252, 228, 228);
            btnNext.Icon = (Image)resources.GetObject("btnNext.Icon");
            btnNext.Location = new Point(636, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(47, 45);
            btnNext.TabIndex = 19;
            // 
            // lblCalendar
            // 
            lblCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblCalendar.AutoSize = true;
            lblCalendar.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
            lblCalendar.ForeColor = Color.FromArgb(244, 148, 156);
            lblCalendar.Location = new Point(6, 11);
            lblCalendar.Name = "lblCalendar";
            lblCalendar.Padding = new Padding(5, 0, 0, 0);
            lblCalendar.Size = new Size(95, 33);
            lblCalendar.TabIndex = 20;
            lblCalendar.Text = "Month";
            // 
            // flpCalendar
            // 
            flpCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpCalendar.BackColor = Color.FromArgb(252, 228, 228);
            flpCalendar.Location = new Point(3, 54);
            flpCalendar.Name = "flpCalendar";
            flpCalendar.Size = new Size(678, 584);
            flpCalendar.TabIndex = 21;
            // 
            // flpAppointments
            // 
            flpAppointments.BackColor = Color.FromArgb(252, 228, 228);
            flpAppointments.Controls.Add(pALists);
            flpAppointments.Dock = DockStyle.Right;
            flpAppointments.Location = new Point(690, 0);
            flpAppointments.Name = "flpAppointments";
            flpAppointments.Size = new Size(330, 641);
            flpAppointments.TabIndex = 22;
            // 
            // pALists
            // 
            pALists.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pALists.Controls.Add(lblAppointments);
            pALists.Controls.Add(btnAdd);
            pALists.Location = new Point(3, 3);
            pALists.Name = "pALists";
            pALists.Size = new Size(327, 505);
            pALists.TabIndex = 0;
            // 
            // lblAppointments
            // 
            lblAppointments.AutoSize = true;
            lblAppointments.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
            lblAppointments.ForeColor = Color.FromArgb(244, 148, 156);
            lblAppointments.Location = new Point(3, 5);
            lblAppointments.Name = "lblAppointments";
            lblAppointments.Padding = new Padding(5, 5, 0, 5);
            lblAppointments.Size = new Size(188, 43);
            lblAppointments.TabIndex = 10;
            lblAppointments.Text = "Appointments";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.DefaultBack = Color.FromArgb(244, 148, 156);
            btnAdd.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(252, 228, 228);
            btnAdd.Icon = (Image)resources.GetObject("btnAdd.Icon");
            btnAdd.Location = new Point(277, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(47, 45);
            btnAdd.TabIndex = 23;
            // 
            // DonorD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 211, 211);
            Controls.Add(flpAppointments);
            Controls.Add(flpCalendar);
            Controls.Add(lblCalendar);
            Controls.Add(btnNext);
            Controls.Add(btnDay);
            Controls.Add(btnPrev);
            Name = "DonorD";
            Size = new Size(1020, 641);
            flpAppointments.ResumeLayout(false);
            pALists.ResumeLayout(false);
            pALists.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Button btnPrev;
        private AntdUI.Button btnDay;
        private AntdUI.Button btnNext;
        private Label lblCalendar;
        private FlowLayoutPanel flpCalendar;
        private FlowLayoutPanel flpAppointments;
        private Label lblAppointments;
        private Panel pALists;
        private AntdUI.Button btnAdd;
    }
}
