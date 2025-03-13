using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hemotica
{
    public partial class Home : Form
    {
        private int normalWidth, normalHeight;
        public static int parentX, parentY;

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
            /*
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

                pbxHeart.Left = (this.ClientSize.Width - pbxHeart.Width) / 2;
                pbxHeart.Top = (this.ClientSize.Height - pbxHeart.Height) / 2;

                pbxTitle.Width = 505;
                pbxTitle.Height = 60;

                pbxTitle.Left = (this.ClientSize.Width - pbxTitle.Width) / 2;
                pbxTitle.Top = pbxHeart.Top - pbxTitle.Height - (int)(this.ClientSize.Height * 0.015);
            }

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

                pbxHeart.Left = centerX;
                pbxHeart.Top = (this.ClientSize.Height - pbxHeart.Height) / 2;

                int spacing = (int)(this.ClientSize.Height * 0.015);

                pbxTitle.Width = 505;
                pbxTitle.Height = 60;
                pbxTitle.Left = (this.ClientSize.Width - pbxTitle.Width) / 2;
                pbxTitle.Top = pbxHeart.Top - pbxTitle.Height - spacing;

            }*/

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

                pbxHeart.Left = centerX;
                pbxHeart.Top = (this.ClientSize.Height - pbxHeart.Height) / 2;

                int spacing = (int)(this.ClientSize.Height * 0.03);

                pbxTitle.Left = (this.ClientSize.Width - pbxTitle.Width) / 2;
                pbxTitle.Top = pbxHeart.Top - pbxTitle.Height - spacing;

                pbxCaption.Left = (this.ClientSize.Width - pbxCaption.Width) / 2;
                pbxCaption.Top = pbxHeart.Top + pbxHeart.Height + spacing;
            }
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            centerResize();
        }

        private void pbxHeart_Click(object sender, EventArgs e)
        {
            Form overlay = new Form
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

            UserLog userLog = new UserLog
            {
                Owner = this,
                ShowInTaskbar = false
            };

            parentX = this.Location.X;
            parentY = this.Location.Y;

            userLog.FormClosed += (s, args) =>
            {
                overlay.Dispose();
                btnSettings();
            };

            userLog.ShowDialog();
        }
    }
}
