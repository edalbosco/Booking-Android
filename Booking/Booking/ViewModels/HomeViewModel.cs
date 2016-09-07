using System;
using System.Collections.Generic;
using System.Linq;
using Booking.Models;

namespace Booking.ViewModels
{
	public class HomeViewModel
	{
		public HomeViewModel() {
		}
			
		public List<string> Images {
			get{ 
				return SampleData.SocialImageGalleryItems;
			}
		}

		public List<User> Friends 
		{ 
			get
			{
				return SampleData.Friends;
			}
		}


	}
}