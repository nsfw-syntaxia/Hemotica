using System;
using System.Data;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;
using OxyPlot.Legends;
using System.Globalization;

namespace Hemotica
{
	internal class Analytics
	{
		private Database db = new Database();
		private Hospital hospital = new Hospital();
		private Patient patient = new Patient();

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
				Title = "BLOOD GROUP TRANSFUSIONS",
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
				StrokeThickness = 1.0,
				Stroke = OxyColor.FromRgb(216, 85, 101),
				InsideLabelPosition = 0.7,
				AngleSpan = 360,
				StartAngle = 0,
				InsideLabelColor = OxyColor.FromRgb(216, 85, 101),
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

		public void displayPatients(PlotView plotView)
		{
			DataTable dt = patient.loadAllPatients(db);

			if (dt == null || dt.Rows.Count == 0)
				return;

			string[] priorities = { "Critical", "High", "Medium", "Low", "Resolved" };
			OxyColor[] colors = 
			{
				OxyColor.FromRgb(244, 148, 156),
				OxyColor.FromRgb(244, 180, 180),
				OxyColor.FromRgb(252, 196, 196),
				OxyColor.FromRgb(252, 212, 212),
				OxyColor.FromRgb(252, 208, 224)
			};

			Dictionary<string, int> priorityCounts = priorities.ToDictionary(p => p, p => 0);

			foreach (DataRow row in dt.Rows)
			{
				string priority = row["Priority"].ToString();
				if (priorityCounts.ContainsKey(priority))
					priorityCounts[priority]++;
			}

			if (priorityCounts.Count == 0)
				return;

			var model = new PlotModel
			{
				Title = "TOTAL PATIENTS BY PRIORITY LEVEL",
				TextColor = OxyColor.FromRgb(216, 85, 101),
				PlotAreaBorderColor = OxyColor.FromRgb(216, 85, 101),

				TitleFont = "Bahnschrift",
				TitleFontSize = 20,
				TitleFontWeight = FontWeights.Bold,
				DefaultFont = "Bahnschrift",
				DefaultFontSize = 15
			};

			var categoryAxis = new CategoryAxis
			{
				Position = AxisPosition.Left,
				Title = "PRIORITY",
				TitleColor = OxyColor.FromRgb(216, 85, 101),
				TextColor = OxyColor.FromRgb(216, 85, 101),
				ItemsSource = priorities.ToList(),
				AxislineColor = OxyColor.FromRgb(216, 85, 101),
				TicklineColor = OxyColor.FromRgb(216, 85, 101),
				GapWidth = 0.5,
				IsTickCentered = true,
			};

			var valueAxis = new LinearAxis
			{
				Position = AxisPosition.Bottom,
				Title = "NUMBER OF PATIENTS",
				TitleColor = OxyColor.FromRgb(216, 85, 101),
				TextColor = OxyColor.FromRgb(216, 85, 101),
				AxislineColor = OxyColor.FromRgb(216, 85, 101),
				TicklineColor = OxyColor.FromRgb(216, 85, 101),
				AbsoluteMinimum = 0,
				MinimumPadding = 0,
				MajorStep = 1,
				MinorStep = 1
			};

			var series = new BarSeries
			{
				LabelPlacement = LabelPlacement.Inside,
				LabelFormatString = "{0}",
				StrokeThickness = 1.0,
				StrokeColor = OxyColor.FromRgb(216, 85, 101),
				BarWidth = 1.0,
				LabelMargin = 5
			};

			for (int i = 0; i < priorities.Length; i++)
			{
				var bar = new BarItem(priorityCounts[priorities[i]])
				{
					Value = priorityCounts[priorities[i]],
					Color = colors[i]
				};
				series.Items.Add(bar);
			}

			model.Axes.Add(categoryAxis);
			model.Axes.Add(valueAxis);
			model.Series.Add(series);
			plotView.Model = model;
		}

		public void displayDailyExtractions(PlotView plotView)
		{
			DataTable dt = hospital.loadExtraction(db);

			Dictionary<string, int> dailyCounts = new Dictionary<string, int>();

			foreach (DataRow row in dt.Rows)
			{
				if (DateTime.TryParse(row["Extraction Date"].ToString(), out DateTime extractionDate))
				{
					string dayKey = extractionDate.ToString("MM-dd-yyyy");
					if (!dailyCounts.ContainsKey(dayKey))
						dailyCounts[dayKey] = 0;

					dailyCounts[dayKey]++;
				}
			}

			if (dailyCounts.Count == 0)
				return;

			var sortedDaily = dailyCounts.OrderBy(kvp => DateTime.ParseExact(kvp.Key, "MM-dd-yyyy", null)).ToList();
			LineSeries dailySeries = new LineSeries
			{
				MarkerType = MarkerType.Circle
			};

			List<string> dayLabels = new List<string>();
			for (int i = 0; i < sortedDaily.Count; i++)
			{
				dailySeries.Points.Add(new DataPoint(i, sortedDaily[i].Value));
				dayLabels.Add(sortedDaily[i].Key);
			}

			var plotModel = new PlotModel { Title = "BLOOD EXTRACTIONS (DAILY)" };
			plotModel.Series.Add(dailySeries);

			plotModel.Axes.Add(new OxyPlot.Axes.CategoryAxis
			{
				Position = OxyPlot.Axes.AxisPosition.Bottom,
				ItemsSource = dayLabels,
				Title = "Date",
				Angle = 45
			});

			plotModel.Axes.Add(new OxyPlot.Axes.LinearAxis
			{
				Position = OxyPlot.Axes.AxisPosition.Left,
				Title = "Total Extracted Units"
			});

			plotView.Model = plotModel;
		}

		public void displayExtractions(PlotView plotView)
		{
			DataTable dt = hospital.loadExtraction(db);

			if (dt == null || dt.Rows.Count == 0)
				return;

			Dictionary<DateTime, int> monthlyCounts = new Dictionary<DateTime, int>();

			foreach (DataRow row in dt.Rows)
			{
				if (DateTime.TryParse(row["Extraction Date"].ToString(), out DateTime extractionDate))
				{
					DateTime monthKey = new DateTime(extractionDate.Year, extractionDate.Month, 1);

					if (!monthlyCounts.ContainsKey(monthKey))
						monthlyCounts[monthKey] = 0;

					monthlyCounts[monthKey]++;
				}
			}

			if (monthlyCounts.Count == 0)
				return;

			var sortedMonthly = monthlyCounts.OrderBy(kvp => kvp.Key).ToList();

			LineSeries monthlySeries = new LineSeries
			{
				MarkerType = MarkerType.Circle
			};

			List<string> monthLabels = new List<string>();
			for (int i = 0; i < sortedMonthly.Count; i++)
			{
				monthlySeries.Points.Add(new DataPoint(i, sortedMonthly[i].Value));
				monthLabels.Add(sortedMonthly[i].Key.ToString("MM-yyyy"));
			}

			var plotModel = new PlotModel { Title = "MONTHLY BLOOD EXTRACTIONS" };
			plotModel.Series.Add(monthlySeries);

			plotModel.Axes.Add(new OxyPlot.Axes.CategoryAxis
			{
				Position = OxyPlot.Axes.AxisPosition.Bottom,
				ItemsSource = monthLabels,
				Title = "Date",
				Angle = 45
			});

			plotModel.Axes.Add(new OxyPlot.Axes.LinearAxis
			{
				Position = OxyPlot.Axes.AxisPosition.Left,
				Title = "Blood Bags Extracted"
			});

			plotView.Model = plotModel;
		}

		public void displayTransfusions()
		{
			// this will be for displaying a line graph showing the transfusions monthly and weekly using oxyplot (i used plotview)
		}
	}
}
