using ChallengeUIDesign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChallengeUIDesign.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinancePage : ContentPage
    {
        public FinancePage()
        {
            InitializeComponent();

            var items = new List<FinanceItem>();
            items.Add(new FinanceItem { 
                Name = "Wise investment", 
                Info = "Investment: 60 days", 
                Info2 = "The remaining 3000", 
                FirstPercent = "8.6%", 
                SecondPercent = "+0.2%", 
                IsSecondPercent = true, 
                Icon = "package_variant_closed" 
            });
            items.Add(new FinanceItem
            {
                Name = "Artificial intelligence",
                Info = "Investment: 120 days",
                Info2 = "The remaining 56000",
                FirstPercent = "7.5%",
                Icon = "chemical_weapon"
            });
            items.Add(new FinanceItem
            {
                Name = "Chemical financing",
                Info = "Investment: 180 days",
                Info2 = "The remaining 16000",
                FirstPercent = "8.2%",
                Icon = "flask_empty_outline"
            });

            listViewCustom.ItemsSource = items;
        }
    }
}