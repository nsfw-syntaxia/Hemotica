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
            pbxLogo.BackColor = Color.Transparent;

            this.Controls.SetChildIndex(pbxLogo, 0);

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
        }
    }
}
