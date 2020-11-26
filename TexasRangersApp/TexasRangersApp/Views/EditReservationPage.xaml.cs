using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TexasRangersApp.Models;
using TexasRangersApp.ViewModels;

namespace TexasRangersApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class EditReservationPage : ContentPage
    {

        public EditReservationPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var reservation = (Reservation)BindingContext;
            reservation.Timestamp = DateTime.UtcNow;
            await App.Database.SaveNoteAsync(reservation);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var reservation = (Reservation)BindingContext;
            await App.Database.DeleteNoteAsync(reservation);
            await Navigation.PopAsync();
        }
    }
}