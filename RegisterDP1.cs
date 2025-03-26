using System;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class RegisterDP1 : UserControl
    {
        private Register register;

        public RegisterDP1(Register parent)
        {
            InitializeComponent();
            this.register = parent;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            register.showDP2();
        }
	}
}
