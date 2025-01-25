using System.Windows;
using System.Windows.Media;

namespace Charter
{
    public class DataPoint
    {
        public int Value { get; set; }
        public string Label { get; set; }
        public Brush Foreground { get; set; }
        public Thickness Margin { get; set; }
    }
}