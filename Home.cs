using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Hemotica
{
    public partial class Home : Form
    {
        private int normalWidth, normalHeight;
        public static int parentX, parentY;
        private bool popup = true;
        private Form overlay;

        public Home()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void Home_Load(object sender, EventArgs e)
        {
            btnSettings();
            centerResize();
            tToggle.Start();
        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender == pbxHeart) return;

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);
            }
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
            this.Close();
        }

        private void centerResize()
        {
            if (pbxHeart != null)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    pbxHeart.Width = normalWidth;
                    pbxHeart.Height = normalHeight;
                }
                else
                {
                    pbxHeart.Width = (int)(this.ClientSize.Width * 0.5);
                    pbxHeart.Height = (int)(this.ClientSize.Height * 0.5);

                    normalWidth = pbxHeart.Width;
                    normalHeight = pbxHeart.Height;
                }

                int centerX = (this.ClientSize.Width - pbxHeart.Width) / 2;
                int spacing = (int)(this.ClientSize.Height * 0.03);

                pbxHeart.Left = centerX;
                pbxHeart.Top = (this.ClientSize.Height - pbxHeart.Height) / 2;

                pbxTitle.Left = (this.ClientSize.Width - pbxTitle.Width) / 2;
                pbxTitle.Top = pbxHeart.Top - pbxTitle.Height - spacing;

                pbxCaption.Left = (this.ClientSize.Width - pbxCaption.Width) / 2;
                pbxCaption.Top = pbxHeart.Top + pbxHeart.Height + spacing;

                pbxFade.Left = pbxCaption.Left;
                pbxFade.Top = pbxCaption.Top;
            }
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            centerResize();
        }

        private void pbxHeart_Click(object sender, EventArgs e)
        {
            tToggle.Stop();

            overlay = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.5d,
                BackColor = Color.Black,
                Size = this.Size,
                Location = this.Location,
                ShowInTaskbar = false
            };

            overlay.Show();
            btnSettings();

            showLogin();
        }

        private void tToggle_Tick(object sender, EventArgs e)
        {
            pbxCaption.Visible = popup;
            pbxFade.Visible = !popup;
            popup = !popup;
        }

        public void showLogin()
        {
            Login login = new Login
            {
                Owner = this,
                ShowInTaskbar = false
            };

            parentX = this.Location.X;
            parentY = this.Location.Y;

            login.FormClosed += (s, args) =>
            {
                overlay.Dispose();
                btnSettings();
                this.Activate();
                tToggle.Start();
            };

            login.ShowDialog();
        }

        public void showRegister()
        {
            Register register = new Register
            {
                Owner = this,
                ShowInTaskbar = false
            };

            register.FormClosed += (s, args) =>
            {
                overlay.Dispose();
                btnSettings();
                this.Activate();
                tToggle.Start();
            };

            register.ShowDialog();
        }

        public void showForgetPassword()
        {
            ForgetPassword forgetPassword = new ForgetPassword
            {
                Owner = this,
                ShowInTaskbar = false
            };

            forgetPassword.FormClosed += (s, args) =>
            {
                overlay.Dispose();
                btnSettings();
                this.Activate();
                tToggle.Start();
            };

            forgetPassword.ShowDialog();
        }
    }
}
