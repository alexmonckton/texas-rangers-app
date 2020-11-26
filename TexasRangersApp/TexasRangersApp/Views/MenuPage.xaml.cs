using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TexasRangersApp.Models;
using Newtonsoft.Json;
using RestSharp;

namespace TexasRangersApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        private Joke joke;
        public MenuPage()
        {
            InitializeComponent();

            var client = new RestClient("https://api.chucknorris.io/jokes/random");
            var request = new RestRequest(Method.GET);

            var response = client.Execute(request);

            joke = JsonConvert.DeserializeObject<Joke>(response.Content);
            ChuckNorrisJoke.Text = joke.value;
        }

        async void FoodMenuClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodMenuPage());
        }

        async void DrinksMenuClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DrinksMenuPage());
        }
    }
}