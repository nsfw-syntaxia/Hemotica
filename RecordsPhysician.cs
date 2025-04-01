using System;
using System.Data;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class RecordsPhysician : UserControl
	{
		HospitalRecords hospitalRecords;
		Patient patient = new Patient();
		Database db = new Database();

		public RecordsPhysician(HospitalRecords parent)
		{
			InitializeComponent();
			this.hospitalRecords = parent;
		}
	}
}
