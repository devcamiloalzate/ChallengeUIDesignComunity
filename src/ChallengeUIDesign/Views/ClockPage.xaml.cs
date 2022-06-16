using ChallengeUIDesign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChallengeUIDesign.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClockPage : ContentPage
    {
        Thread hilo;

        public ClockPage()
        {
            InitializeComponent();

            var items = new List<Clock>();
            items.Add(new Clock { Country = "USA", City = "New York", DateHour = "7:00AM" });
            items.Add(new Clock { Country = "Croatia", City = "Zagreb", DateHour = "5:00AM" });

            ListViewCustom.ItemsSource = items;

            hilo = new Thread(Tiempo);
            hilo.Start();            
        }

        int second = 0;
        int minute = 0;
        private void Tiempo()
        {
            Thread.Sleep(1000);
            second++;            
            secondHand.Rotation += 6;
            if (second == 60)
            {
                second = 0;
                minute++;
                minuteHand.Rotation += 6;

                if (minute == 60)
                {
                    minute = 0;
                    hourHand.Rotation += 6;
                }
            }                        
            Tiempo();
        }
    }
}