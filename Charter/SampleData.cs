using System.Windows.Media;

namespace Charter
{
    public class SampleData
    {
        static SampleData()
        {
            SampleData.MinutesOfDeepSleep = new()
            {
                new DataPoint { Value = 60, Label = "1/8", Foreground = Brushes.Red },
                new DataPoint { Value = 12, Label = "1/8", Foreground = Brushes.Green },

                new DataPoint { Value = 83, Label = "1/9", Foreground = Brushes.Red },
                new DataPoint { Value = 41, Label = "1/9", Foreground = Brushes.Green },

                new DataPoint { Value = 115, Label = "1/10", Foreground = Brushes.Red },
                new DataPoint { Value = 30, Label = "1/10", Foreground = Brushes.Green },

                new DataPoint { Value = 61, Label = "1/11", Foreground = Brushes.Red },
                new DataPoint { Value = 54, Label = "1/12", Foreground = Brushes.Red },
                new DataPoint { Value = 40, Label = "1/13", Foreground = Brushes.Red },
                new DataPoint { Value = 118, Label = "1/14", Foreground = Brushes.Red },
                new DataPoint { Value = 84, Label = "1/15", Foreground = Brushes.Red },
                new DataPoint { Value = 46, Label = "1/16", Foreground = Brushes.Red },
                new DataPoint { Value = 59, Label = "1/17", Foreground = Brushes.Red },
                new DataPoint { Value = 124, Label = "1/18", Foreground = Brushes.Red }
            };

            SampleData.MinutesOfREMSleep = new()
            {
                new DataPoint { Value = 125, Label = "1/8", Foreground = Brushes.Red, Margin = new(15, 5, 0, 5) },
                new DataPoint { Value = 75, Label = "1/8", Foreground = Brushes.Green, Margin = new(0, 5, 5, 5) },

                new DataPoint { Value = 120, Label = "1/9", Foreground = Brushes.Red, Margin = new(5, 5, 0, 5) },
                new DataPoint { Value = 149, Label = "1/9", Foreground = Brushes.Green, Margin = new(0, 5, 5, 5) },

                new DataPoint { Value = 113, Label = "1/10", Foreground = Brushes.Red, Margin = new(5, 5, 0, 5) },
                new DataPoint { Value = 152, Label = "1/10", Foreground = Brushes.Green, Margin = new(0, 5, 5, 5) },

                new DataPoint { Value = 90, Label = "1/11", Foreground = Brushes.Red, Margin = new(5, 5, 0, 5) },
                new DataPoint { Value = 115, Label = "1/11", Foreground = Brushes.Green, Margin = new(0, 5, 5, 5) },

                new DataPoint { Value = 58, Label = "1/12", Foreground = Brushes.Red, Margin = new(5, 5, 0, 5) },
                new DataPoint { Value = 88, Label = "1/12", Foreground = Brushes.Green, Margin = new(0, 5, 5, 5) },

                new DataPoint { Value = 119, Label = "1/13", Foreground = Brushes.Red, Margin = new(5, 5, 5, 5) },
                new DataPoint { Value = 121, Label = "1/14", Foreground = Brushes.Red, Margin = new(5, 5, 5, 5) },
                new DataPoint { Value = 127, Label = "1/15", Foreground = Brushes.Red, Margin = new(5, 5, 5, 5) },
                new DataPoint { Value = 110, Label = "1/16", Foreground = Brushes.Red, Margin = new(5, 5, 5, 5) },
                new DataPoint { Value = 81, Label = "1/17", Foreground = Brushes.Red, Margin = new(5, 5, 5, 5) },
                new DataPoint { Value = 82, Label = "1/18", Foreground = Brushes.Red, Margin = new(5, 5, 5, 5) }
            };
        }

        public static List<DataPoint> MinutesOfDeepSleep { get; set; }

        public static List<DataPoint> MinutesOfREMSleep { get; set; }
    }
}
