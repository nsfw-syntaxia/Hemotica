using System;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class DashboardD : Form
    {
        bool sidebarExpand = false;

        public DashboardD()
        {
            InitializeComponent();
        }

        private void DashboardD_Load(object sender, EventArgs e)
        {
            btnSettings();

            flpSideBar.Width = flpSideBar.MinimumSize.Width;
            sidebarExpand = false;

            showDonorDB();
            adjustLayout();
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
            flpSideBar.Height = this.ClientSize.Height;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flpSideBar.Width -= 10;
                if (flpSideBar.Width <= flpSideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    tSidebar.Stop();
                }
            }
            else
            {
                flpSideBar.Width += 10;
                if (flpSideBar.Width >= flpSideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    tSidebar.Stop();
                }
            }

            adjustLayout();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tSidebar.Start();
            adjustLayout();
        }

        private void DashboardD_Resize(object sender, EventArgs e)
        {
            flpSideBar.Height = this.ClientSize.Height;
            flpSideBar.MaximumSize = new Size(flpSideBar.MaximumSize.Width, this.ClientSize.Height);

            adjustLayout();
        }

        private void adjustLayout()
        {
            int sidebarWidth = flpSideBar.Width;

            pWelcome.Left = sidebarWidth + 10;
            pWelcome.Width = this.ClientSize.Width - sidebarWidth - 20;

            flpDashboard.Left = sidebarWidth + 10;
            flpDashboard.Width = this.ClientSize.Width - sidebarWidth - 20;

            foreach (Control ctrl in flpDashboard.Controls)
            {
                ctrl.Width = flpDashboard.Width;
                ctrl.Height = flpDashboard.Height;
            }
        }

        private async void btnLogout_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Home"] is Home home)
            {
                home.WindowState = FormWindowState.Normal;
                home.Show();
                home.Activate();
                await Task.Delay(1);
            }

            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            showDonorDB();
        }

        private void showDonorDB()
        {
            flpDashboard.Controls.Clear();

            DonorDB donorDB = new DonorDB { };

            flpDashboard.Controls.Add(donorDB);
            adjustLayout();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            showDonorD();
        }

        private void showDonorD()
        {
            flpDashboard.Controls.Clear();

            DonorD donorD = new DonorD
            {
                Width = flpDashboard.Width,
                Height = flpDashboard.Height
            };

            flpDashboard.Controls.Add(donorD);
            adjustLayout();
        }
    }
}
