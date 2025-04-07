using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Hemotica
{
	public partial class HospitalProfile : UserControl
	{
		private Database db = new Database();
		private bool anyChanges = false;

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public HospitalProfile()
		{
			InitializeComponent();
		}

		public void roundControls()
		{
			pProfile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pProfile.Width, pProfile.Height, 20, 20));
			pbxProfile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxProfile.Width, pbxProfile.Height, 20, 20));
		}

		private void loadHospitals()
		{
			string query = @"SELECT [Email Address], Password, [First Name], [Middle Name], [Last Name], Gender, Age, Barangay, City, Province, [Contact Number], [Blood Type], Profile 
							 FROM Donors WHERE [Username] = ?";
			OleDbParameter[] parameters = { new OleDbParameter("?", UserLogs.Username) };
			DataTable dt = db.executeQuery(query, parameters);
		}

		private void HospitalProfile_Load(object sender, EventArgs e)
		{
			roundControls();
		}

		private void HospitalProfile_Resize(object sender, EventArgs e)
		{
			roundControls();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}
	}
}
