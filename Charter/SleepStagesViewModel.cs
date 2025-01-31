using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Charter
{
    public class SleepStagesViewModel : ViewModel
    {
        private bool
            showGarminDeep, showGarminLight, showGarminRem, showGarminAwake, showGarminTotal,
            showMuseDeep, showMuseLight, showMuseRem, showMuseAwake, showMuseTotal
            ;

        public SleepStagesViewModel()
        {
            this.showGarminDeep = true;
            this.showGarminLight = true;
            this.showGarminRem = true;
            this.showGarminAwake = true;
            this.showGarminTotal = true;
            this.showMuseDeep = true;
            this.showMuseLight = true;
            this.showMuseRem = true;
            this.showMuseAwake = true;
            this.showMuseTotal = true;
        }

        public int[] GarminDeepSleepMinutes => new int[] { 83, 115, 61, 54, 40, 118, 84, 46, 59, 124, 66, 86, 69, 117, 74, 108, 110, 82, 82, 66, };

        public int[] MuseDeepSleepMinutes => new int[] { 12, 41, 30, 0, 0, 0, 6, 2, 0, 41, 53, 0, 37, 42, 33, 0, 0, 42, 0, 90, };

        public int[] GarminLightSleepMinutes => new int[] { 326, 301, 369, 414, 350, 294, 283, 354, 446, 299, 380, 364, 365, 334, 408, 412, 305, 383, 287, 397, };

        public int[] MuseLightSleepMinutes => new int[] { 425, 373, 389, 399, 383, 20, 437, 376, 111, 390, 305, 439, 365, 379, 392, 384, 404, 442, 416, 349, };

        public string[] Labels
        {
            get
            {
                List<string> result = [];

                DateTime current = new(2025, 1, 8);

                for (int i = 0; i < MuseDeepSleepMinutes.Length; i++)
                {
                    result.Add(current.ToString("MM/dd"));
                    current = current.AddDays(1);
                }

                return [.. result];
            }
        }

        public bool ShowGarminDeepSleep
        {
            get => this.showGarminDeep;
            set => this.SetPropertyValue<bool>(ref this.showGarminDeep, value, new string[] { nameof(this.ShowGarminDeepSleep), nameof(this.DataSeries) });
        }

        public bool ShowMuseDeepSleep
        {
            get => this.showMuseDeep;
            set => this.SetPropertyValue<bool>(ref this.showMuseDeep, value, new string[] { nameof(this.ShowMuseDeepSleep), nameof(this.DataSeries) });
        }

        public bool ShowGarminLightSleep
        {
            get => this.showGarminLight;
            set => this.SetPropertyValue<bool>(ref this.showGarminLight, value, new string[] { nameof(this.ShowGarminLightSleep), nameof(this.DataSeries) });
        }

        public bool ShowMuseLightSleep
        {
            get => this.showMuseLight;
            set => this.SetPropertyValue<bool>(ref this.showMuseLight, value, new string[] { nameof(this.ShowMuseLightSleep), nameof(this.DataSeries) });
        }

        public SeriesCollection DataSeries
        {
            get
            {
                SeriesCollection allDataSeries = new();

                if (this.ShowMuseLightSleep)
                {
                    LineSeries lightSleepMuseSeries = new()
                    {
                        Title = "Light Sleep (EEG)",
                        Values = new ChartValues<int>(MuseLightSleepMinutes),
                        Foreground = Brushes.Blue,
                        PointGeometry = DefaultGeometries.None,
                    };

                    allDataSeries.Add(lightSleepMuseSeries);
                }

                if (this.ShowGarminLightSleep)
                {
                    LineSeries lightSleepGarminSeries = new()
                    {
                        Title = "Light Sleep (Smart Watch)",
                        Values = new ChartValues<int>(this.GarminLightSleepMinutes),
                        Foreground = Brushes.LightBlue,
                        PointGeometry = DefaultGeometries.None,
                    };

                    allDataSeries.Add(lightSleepGarminSeries);
                }

                if (this.ShowGarminDeepSleep)
                {
                    LineSeries deepSleepGarminSeries = new()
                    {
                        Title = "Deep Sleep (Smart Watch)",
                        Values = new ChartValues<int>(this.GarminDeepSleepMinutes),
                        Foreground = Brushes.Green,
                        PointGeometry = DefaultGeometries.None,
                    };

                    allDataSeries.Add(deepSleepGarminSeries);
                }

                if (this.ShowMuseDeepSleep)
                {
                    LineSeries deepSleepMuseSeries = new()
                    {
                        Title = "Deep Sleep (EEG)",
                        Values = new ChartValues<int>(MuseDeepSleepMinutes),
                        Foreground = Brushes.DarkGreen,
                        //PointForeground = Brushes.Blue,
                        PointGeometry = DefaultGeometries.None,
                    };

                    allDataSeries.Add(deepSleepMuseSeries);
                }

                return allDataSeries;
            }
        }

    }
}
