using System;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class Login : Form
    {
        int i;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnSettings();

            int centerX = Home.parentX + (this.Owner.Width - this.Width) / 2;
            int startY = Home.parentY - this.Height;
            int targetY = Home.parentY + (this.Owner.Height - this.Height) / 2;

            this.Location = new Point(centerX, startY);

            i = targetY;
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
            if (Opacity < 1)
            {
                Opacity += 0.07;
            }

            int currentY = this.Location.Y + 30;
            if (currentY >= i)
            {
                currentY = i;
                tEffect.Stop();
            }

            this.Location = new Point(this.Location.X, currentY);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Activate();
        }

        private void lblSIGNUP_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;

            if (this.Owner is Home home)
            {
                home.showRegister();
            }

            this.Close();
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;

            if (this.Owner is Home home)
            {
                home.showForgetPassword();
            }

            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUnEA.Text;
            string password = tbxPassword.Text;
            Form dashboard = null;

            if (username == "donor" && password == "donor123")
            {
                dashboard = new DashboardD();
            }
            else if (username == "hospital" && password == "hospital123")
            {
                dashboard = new DashboardH();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.Owner is Home home && home.WindowState == FormWindowState.Maximized)
            {
                dashboard.WindowState = FormWindowState.Maximized;
            }

            dashboard.Show();

            this.Opacity = 0;

            if (this.Owner is Home homeInstance)
            {
                homeInstance.Hide();
            }

            this.Close();
        }

        private void cbxSPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSPassword.Checked)
            {
                tbxPassword.UseSystemPasswordChar = false;
                tbxPassword.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
