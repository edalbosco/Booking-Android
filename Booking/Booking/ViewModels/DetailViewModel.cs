using System;
using System.Collections.Generic;
using System.Linq;
using Booking.Helpers;
using Booking.Models;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Booking.Pages;

namespace Booking.ViewModels
{
	public class DetailViewModel: INotifyPropertyChanged
	{
        private Command loginCommand;

        public DetailViewModel() : this(new Restaurant("","","","","",false)) {
            Seats = 1;
		}

		public DetailViewModel(Restaurant post){
			this.Restaurant = post;
            LoginCommand = new Command(Login);

        }

        public Restaurant Restaurant { get; private set;}

		public List<Message> Comments {
			get{ 
				return SampleData.Comments;
			}
		}

        int _seats;

        private void Login(object obj)
        {
            App.Current.Navigation.PushModalAsync(new LoginPage());
        }

        public Command LoginCommand
        {
            get
            {
                return loginCommand;
            }

            set
            {
                loginCommand = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Seats
        {
            get { return _seats; }
            set { _seats = value; if (_seats < 1) _seats = 1;  OnPropertyChanged(); }
        }
    }
}