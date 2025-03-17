using System;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            btnSettings();

            int centerX = this.Owner.Location.X + (this.Owner.Width - this.Width) / 2;
            int centerY = this.Owner.Location.Y + (this.Owner.Height - this.Height) / 2;
            this.Location = new Point(centerX, centerY);

            tEffect.Start();
        }

        private void btnEffects(System.Windows.Forms.Button button, Color highlightColor)
        {
            button.FlatAppearance.BorderSize = 0;

            button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(50, highlightColor);
            button.MouseLeave += (s, e) => button.BackColor = Color.Transparent;
        }

        private void btnSettings()
        {
            btnEffects(btnClose, Color.Red);
        }

        private void tEffect_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.07;
            }
            else
            {
                tEffect.Stop();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Activate();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;

            if (this.Owner is Home home)
            {
                home.showLogin();
            }

            this.Close();
        }
    }
}
