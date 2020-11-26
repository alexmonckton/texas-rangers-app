using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using TexasRangersApp.Models;
using TexasRangersApp.Views;

namespace TexasRangersApp.ViewModels
{
    public class ReservationsViewModel : BaseViewModel
    {
        public ObservableCollection<Reservation> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

    }
}