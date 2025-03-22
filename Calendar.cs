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
	public partial class Calendar : UserControl
	{
		public event Action<DateTime> daySlot;

		public Calendar()
		{
			InitializeComponent();
		}

		public void days(DateTime dayDate, DateTime currentMonth)
		{
			lblDays.Text = dayDate.Day.ToString();

			if (dayDate.Month < currentMonth.Month || dayDate.Month > currentMonth.Month)
			{
				pDays.BackColor = ColorTranslator.FromHtml("#F4B4B4");
				lblDays.ForeColor = ColorTranslator.FromHtml("#EC7C84");
			}
			else
			{
				pDays.BackColor = ColorTranslator.FromHtml("#FCE4E4");
				lblDays.ForeColor = ColorTranslator.FromHtml("#D85565");
			}

			if (dayDate.Date == DateTime.Today)
			{
				pDays.BackColor = ColorTranslator.FromHtml("#D85565");
				lblDays.ForeColor = ColorTranslator.FromHtml("#FCE4E4");
			}

			pDays.Click += (sender, e) =>
			{
				daySlot?.Invoke(dayDate);
			};
		}
	}
}
