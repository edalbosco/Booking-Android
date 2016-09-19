using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Booking.Pages
{
    public partial class LoginPage : ContentPage
    {

        string _email;

        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = this;
        }

        async void LoginClicked(object sender, EventArgs args)
        {

            App.Current.Authenticated = true;

            if (Email.ToLower() == "admin")
            {
                await App.Current.Navigation.PushAsync(new AdminPage());
                App.Current.Navigation.RemovePage(App.Current.Navigation.NavigationStack[0]);
            }
            await App.Current.Navigation.PopModalAsync();
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
    }
}