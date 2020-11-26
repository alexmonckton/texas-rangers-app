using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TexasRangersApp.Models;
using TexasRangersApp.Views;
using TexasRangersApp.ViewModels;

namespace TexasRangersApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    public partial class ReservationsPage : ContentPage
    {
        public ReservationsPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetNotesAsync();
        }

        async void OnReservationAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditReservationPage
            {
                BindingContext = new Reservation()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new EditReservationPage
                {
                    BindingContext = e.SelectedItem as Reservation
                });
            }
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}