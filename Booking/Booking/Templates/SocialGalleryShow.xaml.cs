using System;
using System.Collections.Generic;
using Booking.Models;
using Booking.Pages;
using Booking.ViewModels;
using Xamarin.Forms;

namespace Booking.Templates
{
	public partial class SocialGalleryShow : ContentView
	{
	
        public static BindableProperty ShowProperty =
    BindableProperty.Create("Show", typeof(Restaurant),
        typeof(SocialGalleryShow),
        null,
        defaultBindingMode: BindingMode.OneWay
    );

        public Restaurant Show
        {
            get { return (Restaurant)GetValue(ShowProperty); }
            set { SetValue(ShowProperty, value); }
        }

        public SocialGalleryShow()
		{			
			InitializeComponent ();
		}

		private async void OnImageTapped(Object sender, EventArgs e){
            var selectedItem = (SocialGalleryShow)sender;

            await Navigation.PushAsync(new DetailViewPage(new ShowViewModel(selectedItem.Show)));
        }
	}
}