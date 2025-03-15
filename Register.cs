using System;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class Register : Form
    {
        int i;

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
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
                Opacity += 0.3;
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

        public void showP1()
        {
            flpUserRegister.Controls.Clear();
            RegisterDonorP1 donorP1 = new RegisterDonorP1(this);
            flpUserRegister.Controls.Add(donorP1);
        }

        public void showP2()
        {
            flpUserRegister.Controls.Clear();
            RegisterDonorP2 donorP2 = new RegisterDonorP2(this);
            flpUserRegister.Controls.Add(donorP2);
        }

        public void showP3()
        {
            flpUserRegister.Controls.Clear();
            RegisterDonorP3 donorP3 = new RegisterDonorP3(this);
            flpUserRegister.Controls.Add(donorP3);
        }

        private void cmbxRUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpUserRegister.Controls.Clear();

            if (cmbxRUser.SelectedItem.ToString() == "Donor")
            {
                showP1();
            }
        }
    }
}
