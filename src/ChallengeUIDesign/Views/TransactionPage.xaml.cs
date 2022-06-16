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
    public partial class TransactionPage : ContentPage
    {
        public TransactionPage()
        {
            InitializeComponent();

            var items = new List<ItemTransaction>();
            items.Add(new ItemTransaction { Name = "General", TextColor = "#6aaade", StartColor = "#90cdf5", EndColor = "#1e9ceb", Icon = "view_grid" });
            items.Add(new ItemTransaction { Name = "Transport", TextColor = "#786cc3", StartColor = "#aa8af4", EndColor = "#754df7", Icon = "bus" });
            items.Add(new ItemTransaction { Name = "Shopping", TextColor = "#ba53be", StartColor = "#f393e9", EndColor = "#f242dc", Icon = "shopping" });
            items.Add(new ItemTransaction { Name = "Bills", TextColor = "#d88b56", StartColor = "#f6bd95", EndColor = "#f4813d", Icon = "receipt" });
            items.Add(new ItemTransaction { Name = "Entertainment", TextColor = "#5daad7", StartColor = "#7e9de7", EndColor = "#4673f6", Icon = "movie_open" });
            items.Add(new ItemTransaction { Name = "Grocery", TextColor = "#3cb871", StartColor = "#85f58e", EndColor = "#21bb54", Icon = "fruit_watermelon" });

            collectionViewCustom.ItemsSource = items;
        }
    }
}