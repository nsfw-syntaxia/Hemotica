using System;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class RegisterDP2 : UserControl
    {
        private Register register;

        public RegisterDP2(Register parent)
        {
            InitializeComponent();
            this.register = parent;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            register.showDP3();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            register.showDP1();
        }
    }
}
