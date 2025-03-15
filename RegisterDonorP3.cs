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
    public partial class RegisterDonorP3 : UserControl
    {
        private Register register;

        public RegisterDonorP3(Register parent)
        {
            InitializeComponent();
            this.register = parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            register.showP2();
        }
    }
}
