using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Booking.Pages
{
	public partial class LoginPage : ContentPage
	{

        string _email;

		public LoginPage ()
		{
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = this;
		}

        async void LoginClicked(object sender, EventArgs args)
        {
            await App.Current.Navigation.PopAsync();

            if (Email.ToLower() == "admin")
            {
                await App.Current.Navigation.PushAsync(new AdminPage());
            }
            else
            {
                await App.Current.Navigation.PushAsync(new MainPage());
            }
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