using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Booking.Helpers;
using Xamarin.Forms;
using System.ComponentModel;

namespace Booking
{
    public partial class App : Application
    {

        public NavigationService Navigation { get; set; }

        public static new App Current { get; private set; }

        public bool Authenticated
        {
            get
            {
                return authenticated;
            }

            set
            {
                authenticated = value; OnPropertyChanged();
            }
        }

        private bool authenticated;

        public App()
        {
            InitializeComponent();

            Current = this;
            MainPage = new Booking.Pages.RootPage(true);
            //MainPage = new Booking.Pages.LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


    }
}
