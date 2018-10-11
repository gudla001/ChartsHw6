using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Entry = Microcharts.Entry;


namespace ChartsHw
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CreateCharts();
            MainPicker.Items.Add("BarChart");
            MainPicker.Items.Add("DonutChart");
            MainPicker.Items.Add("RadialGaugeChart");
            Chart1.IsVisible = !Chart1.IsVisible;
            Chart2.IsVisible = !Chart2.IsVisible;
            Chart3.IsVisible = !Chart3.IsVisible;

        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var name = MainPicker.Items[MainPicker.SelectedIndex];
            if(name == "BarChart")
            {
                Chart1.IsVisible = true;
                Chart2.IsVisible = false;
                Chart3.IsVisible = false;
            }
            else if (name == "DonutChart")
            {
                Chart1.IsVisible = false;
                Chart2.IsVisible = true;
                Chart3.IsVisible = false;
            }
            else if (name == "RadialGaugeChart")
            {
                Chart1.IsVisible = false;
                Chart2.IsVisible = false;
                Chart3.IsVisible = true;
            }

        }
        private void CreateCharts()
        {
            var entryList = new List<Entry>()
            {
                 new Entry(100)
                {
                    Label = "Goes to College",
                    Color = SKColor.Parse("#FF2918"),
                },
                new Entry(36)
                {
                    Label = "Gets Bachelors degree in 4 years",
                    Color = SKColor.Parse("#2FF234"),
                },
                new Entry(70)
                {
                    Label = "Graduate from college",
                    Color = SKColor.Parse("#23CCC2"),

                }
            };
            var barChart = new BarChart() { Entries = entryList };
            var donutChart = new DonutChart() { Entries = entryList };
            var someChart = new RadialGaugeChart() { Entries = entryList };
            Chart1.Chart = barChart;
            Chart2.Chart = donutChart;
            Chart3.Chart = someChart;
        }



    }
}
