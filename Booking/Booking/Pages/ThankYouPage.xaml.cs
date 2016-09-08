using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Booking.Pages
{
	public partial class ThankYouPage : ContentPage
	{

        string _email;

		public ThankYouPage()
		{
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = this;
		}

        async void LoginClicked(object sender, EventArgs args)
        {
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