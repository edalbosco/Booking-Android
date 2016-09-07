using System;
using System.Collections.Generic;
using System.Linq;
using Booking.Helpers;
using Booking.Models;
using Xamarin.Forms;

namespace Booking.ViewModels
{
	public class ShowViewModel
	{
		public ShowViewModel() : this(new Restaurant("","","","","",false)) {
		}

		public ShowViewModel(Restaurant post){
			this.TVShow = post;
        }

		public Restaurant TVShow { get; private set;}

		public List<Message> Comments {
			get{ 
				return SampleData.Comments;
			}
		}
	}
}