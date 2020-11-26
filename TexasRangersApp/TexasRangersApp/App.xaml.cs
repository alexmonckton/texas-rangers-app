using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TexasRangersApp.Views;
using TexasRangersApp.Data;
using SQLite;   

[assembly: ExportFont("OldenburgRegular.ttf", Alias = "CustomFont")]
namespace TexasRangersApp
{
    public partial class App : Application
    {
        static ReservationDatabase database;
        public static ReservationDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ReservationDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Reservations.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
