using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Charts;
using LiveCharts.Configurations;

namespace Charter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.DataContext = new SleepStagesViewModel();
        }


        public List<string> Labels => SampleData.MinutesOfDeepSleep.Select(d => d.Label).ToList();

        public SeriesCollection Series
        {
            get
            {
                SeriesCollection result = new();

                LineSeries deepSleepGarminSeries = new()
                {
                    Title = "Deep Sleep (Garmin)",
                    Values = new ChartValues<int>(SampleData.MinutesOfDeepSleep.Where(src => src.Foreground == Brushes.Green).Select(d => d.Value)),
                    Fill = Brushes.Yellow,
                    PointForeground = Brushes.Green,
                    PointGeometry = DefaultGeometries.Circle,
                };

                LineSeries remSleepGarminSeries = new()
                {
                    Title = "REM (Garmin)",
                    Values = new ChartValues<int>(SampleData.MinutesOfREMSleep.Where(src => src.Foreground == Brushes.Green).Select(d => d.Value)),
                    Fill = Brushes.Orange,
                    PointForeground = Brushes.Gold,
                    PointGeometry = DefaultGeometries.Circle,
                };


                LineSeries deepSleepMuseSeries = new()
                {
                    Title = "Deep Sleep (Muse)",
                    Values = new ChartValues<int>(SampleData.MinutesOfDeepSleep.Where(src => src.Foreground == Brushes.Red).Select(d => d.Value)),
                    Fill = Brushes.BlueViolet,
                };

                LineSeries remSleepMuseSeries = new()
                {
                    Title = "REM (Muse)",
                    Values = new ChartValues<int>(SampleData.MinutesOfREMSleep.Where(src => src.Foreground == Brushes.Red).Select(d => d.Value)),
                    Fill = Brushes.Red,
                };

                result.Add(deepSleepGarminSeries);
                result.Add(remSleepGarminSeries);
                result.Add(remSleepMuseSeries);
                result.Add(deepSleepMuseSeries);

                return result;
            }
        }
    }
}