using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ChallengeUIDesign.Models;
using ChallengeUIDesign.Views;

namespace ChallengeUIDesign.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class WeatherPage : ContentPage
    {

        public WeatherPage()
        {
            InitializeComponent();

            SizeChanged += MainPageSizeChanged;

            var items = new List<Item>();
            items.Add(new Item { Id = "1", Day = "Saturday", Grades1 = "16°", Grades2 = "10°", Icon = "weather_pouring" });
            items.Add(new Item { Id = "2", Day = "Sunday", Grades1 = "19°", Grades2 = "14°", Icon = "weather_lightning_rainy" });
            items.Add(new Item { Id = "3", Day = "Monday", Grades1 = "19°", Grades2 = "13°", Icon = "weather_partly_cloudy" });

            ListViewCustom.ItemsSource = items;
        }

        void MainPageSizeChanged(object sender, EventArgs e)
        {
            bool isPortrait = this.Height > this.Width;
            stackPanel.Orientation = (isPortrait ? StackOrientation.Vertical : StackOrientation.Horizontal);
        }
    }
}