using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarChartLibrary
{
    public class BarChartValue
    {
        public float Shipments { get; set; }
        public string Label { get; set; }
        public String Color { get; set; }

        public BarChartValue( string label, float shipments, string color)
        {
            Shipments = shipments;
            Label = label;
            Color = color;
        }
    }
}
