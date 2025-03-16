using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
