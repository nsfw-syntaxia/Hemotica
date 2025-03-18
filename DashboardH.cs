using System;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class DashboardH : Form
    {
        public DashboardH()
        {
            InitializeComponent();
        }

        private void DashboardD_Load(object sender, EventArgs e)
        {
            btnSettings();
        }

        private void btnEffects(Button button, Color highlightColor)
        {
            button.FlatAppearance.BorderSize = 0;

            button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(50, highlightColor);
            button.MouseLeave += (s, e) => button.BackColor = Color.Transparent;
        }

        private void btnSettings()
        {
            btnEffects(btnClose, Color.Red);
            btnEffects(btnMaximize, Color.Lime);
            btnEffects(btnMinimize, Color.Yellow);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
