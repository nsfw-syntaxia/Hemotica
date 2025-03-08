using System;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class UserLog : Form
    {
        int i;

        public UserLog()
        {
            InitializeComponent();
        }

        private void UserLog_Load(object sender, EventArgs e)
        {
            i = Home.parentY + 125;
            this.Location = new Point(Home.parentX + 305, Home.parentY + 125);

            tEffect.Start();
        }

        private void tEffect_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                tEffect.Stop();
            }
            else
            {
                Opacity += 0.03;
            }

            int y = Home.parentY += 3;
            this.Location = new Point(Home.parentX + 305, y);

            if (y >= i)
            {
                tEffect.Stop();
            }
        }
    }
}
