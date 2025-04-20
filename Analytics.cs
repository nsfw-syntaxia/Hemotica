using System;
using System.Data;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;
using OxyPlot.Legends;

namespace Hemotica
{
	internal class Analytics
	{
		private Database db = new Database();
		private Hospital hospital = new Hospital();

		public void displayBloodGroups(PlotView plotView)
		{
			DataTable dt = hospital.loadBarcodes(db);

			if (dt == null || dt.Rows.Count == 0)
				return;

			var bloodTypeCounts = new Dictionary<string, int>();

			foreach (DataRow row in dt.Rows)
			{
				string status = row["Status"].ToString();
				if (!status.Equals("Used", StringComparison.OrdinalIgnoreCase))
					continue;

				string bloodType = row["Blood Type"].ToString();

				if (!bloodTypeCounts.ContainsKey(bloodType))
					bloodTypeCounts[bloodType] = 0;

				bloodTypeCounts[bloodType]++;
			}

			if (bloodTypeCounts.Count == 0)
				return;

			var model = new PlotModel
			{
				Title = "BLOOD GROUPS DEMAND",
				IsLegendVisible = true,
				TextColor = OxyColor.FromRgb(216, 85, 101),
				PlotAreaBorderColor = OxyColors.Transparent,

				TitleFont = "Bahnschrift",
				TitleFontSize = 20,
				TitleFontWeight = FontWeights.Bold,
				DefaultFont = "Bahnschrift",
				DefaultFontSize = 15
			};

			var pieSeries = new PieSeries
			{
				StrokeThickness = 2.0,
				InsideLabelPosition = 0.8,
				AngleSpan = 360,
				StartAngle = 0,
				InsideLabelColor = OxyColors.White,
				OutsideLabelFormat = "{1} ({0})",
				InsideLabelFormat = "{0}",

				Font = "Bahnschrift",
				FontSize = 15,
				FontWeight = FontWeights.Bold
			};

			var bloodTypeColors = new Dictionary<string, OxyColor>
			{
				{ "A+", OxyColor.FromRgb(236, 124, 132) },
				{ "A-", OxyColor.FromRgb(244, 148, 156) },
				{ "B+", OxyColor.FromRgb(244, 180, 180) },
				{ "B-", OxyColor.FromRgb(252, 212, 212) },
				{ "AB+", OxyColor.FromRgb(252, 196, 196) },
				{ "AB-", OxyColor.FromRgb(252, 204, 204) },
				{ "O+", OxyColor.FromRgb(252, 220, 214) },
				{ "O-", OxyColor.FromRgb(252, 208, 224) }
			};

			foreach (var kvp in bloodTypeCounts)
			{
				OxyColor color = bloodTypeColors.ContainsKey(kvp.Key)
					? bloodTypeColors[kvp.Key]
					: OxyColors.Gray;

				pieSeries.Slices.Add(new PieSlice(kvp.Key, kvp.Value) { Fill = color });
			}

			model.Series.Add(pieSeries);
			plotView.Model = model;

		}

		public void displayPatients()
		{
			// this will be for displaying a bar graph showing the patients and their status (critical, high, medium, low, resolved) monthly using oxyplot (i used plotview)
		}

		public void displayExtractions()
		{
			// this will be for displaying a line graph showing the extractions monthly and weekly using oxyplot (i used plotview)
		}

		public void displayTransfusions()
		{
			// this will be for displaying a line graph showing the transfusions monthly and weekly using oxyplot (i used plotview)
		}
	}
}
