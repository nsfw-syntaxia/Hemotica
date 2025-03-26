using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class RegisterDP4 : UserControl
    {
        private Register register;

        public RegisterDP4(Register parent)
        {
            InitializeComponent();
            this.register = parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            register.showDP3();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register.Opacity = 0;

            if (register.Owner is Home home)
            {
                home.showLogin();
            }

            register.Close();
        }
    }
}
