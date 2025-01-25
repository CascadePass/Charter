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

namespace Charter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            this.MinutesOfDeepSleep = new()
            {
                new DataPoint { Value = 60, Label = "1/8", Foreground = Brushes.Red },
                new DataPoint { Value = 12, Label = "1/8", Foreground = Brushes.Green },

                new DataPoint { Value = 83, Label = "1/9", Foreground = Brushes.Red },
                new DataPoint { Value = 115, Label = "1/10", Foreground = Brushes.Red },
                new DataPoint { Value = 61, Label = "1/11", Foreground = Brushes.Red },
                new DataPoint { Value = 54, Label = "1/12", Foreground = Brushes.Red },
                new DataPoint { Value = 40, Label = "1/13", Foreground = Brushes.Red },
                new DataPoint { Value = 118, Label = "1/14", Foreground = Brushes.Red },
                new DataPoint { Value = 84, Label = "1/15", Foreground = Brushes.Red },
                new DataPoint { Value = 46, Label = "1/16", Foreground = Brushes.Red },
                new DataPoint { Value = 59, Label = "1/17", Foreground = Brushes.Red },
                new DataPoint { Value = 124, Label = "1/18", Foreground = Brushes.Red }
            };
        }

        public List<DataPoint> MinutesOfDeepSleep { get; set; }
    }

    public class DataPoint
    {
        public int Value { get; set; }
        public string Label { get; set; }
        public Brush Foreground { get; set; }
    }
}