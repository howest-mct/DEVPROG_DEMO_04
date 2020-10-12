using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DEVPROG_DEMO_04.Model;

namespace DEVPROG_DEMO_04
{
    public partial class MainPage : ContentPage
    {
        public List<Drink> DrinkList { get; set; }

        public MainPage()
        {
            InitializeComponent();

            FillDrinkList();
        }

        private void FillDrinkList()
        {
            DrinkList = new List<Drink>
            {
                new Soda() { Name = "Coca-cola", Price = 2, IsSugarFree = false },
                new Soda() { Name = "Fanta", Price = 2, IsSugarFree = false },
                new Soda() { Name = "Spa red/blue", Price = 2, IsSugarFree = true },
                new Soda() { Name = "Coca-cola zero", Price = 2, IsSugarFree = true },
                new Beer() { Name = "Cirstal Alken", Price=2, Alcohol=4.8, IsDraughtBeer= true },
                new Beer() { Name = "Cirstal Alken", Price=3, Alcohol=8.4, IsDraughtBeer= true },
                new Beer() { Name = "Kriek boon", Price=2, Alcohol=4, IsFruitBeer=true},
                new Beer() { Name = "Westmalle Tripel", Price=3, Alcohol=9.5},
                new Wine() { Name = "VilleHaute Blanc", Price=3.75, Country="France", Grapes = new List<string>{ "Colombard", "Sauvignon" }, Type=WineType.WHITE, PricePerBottle=18.5 },
                new Wine() { Name = "VilleHaute Blanc", Price=4.5, Country="Italy", Grapes = new List<string>{ "Grillo", "Pinot Grigio" }, Type=WineType.WHITE, PricePerBottle=22.5 },
                new Wine() { Name = "Vignerons de Puisserguier", Price=4.5, Country="France", Grapes = new List<string>{ "Merlot"}, Type=WineType.RED, PricePerBottle=22.5 },
                new Wine() { Name = "Zevenwacht", Price=5.5, Country="South Africa", Grapes = new List<string>{ "Syrah", "Merlot", "Cabernet Sauvignon" }, Type=WineType.RED, PricePerBottle=27.5 },
                new Wine() { Name = "Bulle de Blanquit", Price=8, Country="France", Grapes = new List<string>{ "Mauzac", "Chardonnay" }, Type=WineType.SPARKLING, PricePerBottle=38.50 },
                new Cocktail() { Name="Mixy maxy", Price=13, Ingredients=new List<Drink> { new Soda() { Name = "Coca-cola", Price = 2, IsSugarFree = false } , new Wine() { Name = "Bulle de Blanquit", Price = 8, Country = "France", Grapes = new List<string> { "Mauzac", "Chardonnay" }, Type = WineType.SPARKLING, PricePerBottle = 38.50 } } }
            };


            lvwDrinks.ItemsSource = DrinkList;
        }

        private void lvwDrinks_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Drink drink = lvwDrinks.SelectedItem as Drink;
            if (drink != null)
                drink.ShowServingInstructions();
        }
    }
}

