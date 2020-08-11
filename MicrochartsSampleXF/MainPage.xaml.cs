using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;

namespace MicrochartsSampleXF
{
    public partial class MainPage : ContentPage
    {
        private readonly ChartEntry[] entries = new[]
        {
            new ChartEntry(212)
            {
                Label = "UWP",
                ValueLabel = "112",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(248)
            {
                Label = "Android",
                ValueLabel = "648",
                Color = SKColor.Parse("#77d065")
            },
            new ChartEntry(128)
            {
                Label = "iOS",
                ValueLabel = "428",
                Color = SKColor.Parse("#b455b6")
            },
            new ChartEntry(514)
            {
                Label = "Forms",
                ValueLabel = "214",
                Color = SKColor.Parse("#3498db")
            }
        };

        public MainPage()
        {
            InitializeComponent();

            chartViewBar.Chart = new BarChart { Entries = entries, ValueLabelOrientation = Orientation.Horizontal, LabelTextSize = 30 };
            chartViewPie.Chart = new PieChart { Entries = entries, HoleRadius = 0.3f };
            chartViewLine.Chart = new LineChart { Entries = entries, LineMode = LineMode.Straight };
        }
    }
}