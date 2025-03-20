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
	public partial class List : UserControl
	{
		public List()
		{
			InitializeComponent();
		}

		private void List_Load(object sender, EventArgs e)
		{

		}

		private void btnCalendar_Click(object sender, EventArgs e)
		{
			DashboardD dashboard = Application.OpenForms["DashboardD"] as DashboardD;

			if (dashboard != null)
			{
				dashboard.showDonorD();
			}
		}
	}
}
