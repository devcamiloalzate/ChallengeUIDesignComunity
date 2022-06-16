using ChallengeUIDesign.Views;
using ChallengeUIDesign.Views.Fishing;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChallengeUIDesign
{
    public partial class App : Application
    {
        public bool isBusy = false;

        public App()
        {
            InitializeComponent();

            Accelerometer.ShakeDetected += Accelerometer_OnShaked;
            Accelerometer.Start(SensorSpeed.Default);

            MainPage = new SushiPage();
            //ShowMenu();
        }

        void Accelerometer_OnShaked(object sender, EventArgs e)
        {
            ShowMenu();
        }

        private async void ShowMenu()
        {
            if (!isBusy)
            {
                isBusy = true;
                var answer = await App.Current.MainPage.DisplayActionSheet("Select a view", "Cancel", null, "Wheater", "Clock", "SKClock", "Transaction", "Finance", "Sushi");

                switch (answer)
                {
                    case "Wheater":
                        MainPage = new WeatherPage();
                        break;
                    case "Clock":
                        MainPage = new ClockPage();
                        break;
                    case "SKClock":
                        MainPage = new SKClockPage();
                        break;
                    case "Transaction":
                        MainPage = new TransactionPage();
                        break;
                    case "Finance":
                        MainPage = new FinancePage();
                        break;
                    case "Sushi":
                        MainPage = new SushiPage();
                        break;
                }

                isBusy = false;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
