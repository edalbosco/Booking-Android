using System;
using Booking.ViewModels;
using Xamarin.Forms;

namespace Booking.Pages
{
	public partial class ProfilePage : ContentPage
	{
		private TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();

		public ProfilePage()
		{
			InitializeComponent ();

			this.BindingContext = new HomeViewModel();
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			avatar.GestureRecognizers.Add(tapGestureRecognizer);
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();
			avatar.GestureRecognizers.Remove(tapGestureRecognizer);
		}

	}
}