using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        public static List<DataPoint> MinutesOfDeepSleep { get; set; }

    }
}
