using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class RegisterDP3 : UserControl
	{
		private Register register;

		public RegisterDP3(Register parent)
		{
			InitializeComponent();
			this.register = parent;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			register.showDP2();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			register.showDP4();
		}

		private void cmbxCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedCity = cmbxCity.SelectedItem.ToString();
			loadBarangays(selectedCity);
		}

		private void loadBarangays(string city)
		{
			/*
			string query = "SELECT Barangay FROM Address WHERE City = @City";
			OleDbParameter[] parameters = { new OleDbParameter("@City", city) };

			DataTable dt = db.ExecuteQuery(query, parameters);
			if (dt != null)
			{
				cmbxBarangay.Items.Clear();
				foreach (DataRow row in dt.Rows)
				{
					cmbxBarangay.Items.Add(row["Barangay"].ToString());
				}
			}
			*/
		}
	}
}
