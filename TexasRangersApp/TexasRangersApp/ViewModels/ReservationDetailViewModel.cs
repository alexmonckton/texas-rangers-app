using System;

using TexasRangersApp.Models;

namespace TexasRangersApp.ViewModels
{
    public class ReservationDetailViewModel : BaseViewModel
    {
        public Reservation Item { get; set; }
        public ReservationDetailViewModel(Reservation item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
