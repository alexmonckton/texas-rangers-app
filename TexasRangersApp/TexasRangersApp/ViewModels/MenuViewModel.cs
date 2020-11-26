using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TexasRangersApp.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public MenuViewModel()
        {
            Title = "Menu";
            
        }

        public ICommand OpenWebCommand { get; }
    }
}