using System.Collections.Generic;
using System.Linq;

namespace Booking.Models
{
	public static class SampleData
	{
		public static string[] Names = {
            "Pat Davies",
            "Janis Spector",
			"Regina Joplin", 		
			"Dra. Alessandra Morelle",  	
			"Margaret Whites", 	
			"Skyler Harrisson",  
			"Al Pastorius", 		
		};

		public static List<string> SocialImageGalleryItems = new List<string>() { 
			"social_album_1.jpg",
			"social_album_2.jpg",
			"social_album_3.jpg",	
			"social_album_4.jpg",
			"social_album_5.jpg",
			"social_album_6.jpg", 
			"social_album_7.jpg",
			"social_album_8.jpg",
			"social_album_9.jpg"
		};
        
		public static List<string> UsersImagesList = new List<string>() { 
			"friend_thumbnail_27.jpg",
			"friend_thumbnail_31.jpg",
			"friend_thumbnail_34.jpg",
			"alessandra.jpg",
			"friend_thumbnail_71.jpg",
			"friend_thumbnail_75.jpg",
			"friend_thumbnail_93.jpg",
		};

		public static List<string> DashboardImagesList = new List<string>() { 
			"dashboard_thumbnail_0.jpg",
			"dashboard_thumbnail_1.jpg",
			"dashboard_thumbnail_2.jpg",
			"dashboard_thumbnail_3.jpg",
			"dashboard_thumbnail_4.jpg",
			"dashboard_thumbnail_5.jpg",
			"dashboard_thumbnail_6.jpg",
			"dashboard_thumbnail_7.jpg",
			"dashboard_thumbnail_8.jpg",
		};

		public static List<string> ProductsImagesList = new List<string>() { 
			"product_item_0.jpg",
			"product_item_1.jpg",
			"product_item_2.jpg",
			"product_item_3.jpg",
			"product_item_4.jpg",
			"product_item_5.jpg",
			"product_item_6.jpg",
			"product_item_7.jpg",
		};

		public static List<User> Users = new List<User> {
			new User( Names[0], UsersImagesList[0] ),
			new User( Names[1], UsersImagesList[1] ),
			new User( Names[2], UsersImagesList[2] ),
			new User( Names[3], UsersImagesList[3] ),
			new User( Names[4], UsersImagesList[4] ),
			new User( Names[5], UsersImagesList[5] ),
			new User( Names[6], UsersImagesList[6] ),
		};

		public static List<User> Friends = Users;
        
		public static List<Message> Messages = new List<Message> {
			new Message( 
				Friends[6], 
				7, 
				true,
				"July 7",
				"Hey check this out!",
                "Great food & service. I was hesitant after reading some of the reviews about the service, I went there on Friday night as a test run for my daughters birthday dinner. The hostess and staff were very professional & attentive, I could not fault the service or the food.",
                true,
				true
			),

			new Message( 
				Friends[5], 
				3, 
				false,
				"Yesterday",
				"Artina is awesome...you'll love it",
                "High class restaurant, clearly a lot of attention to detail but falls into the classic pitfall of small portions for high prices. Meals just don't satisfy the appetite for very long.",
                false,
				true
			),

			new Message( 
				Friends[4], 
				1, 
				true,
				"July 7",
				"Artina is awesome...you'll love it",
                "For us the best meal we had so far in 3 years in Sydney. We are not regular fine dinners but we were made to feel really comfortable. Vegetarian options were delicious.",
                false,
				false
			),

			new Message( 
				Friends[2], 
				2, 
				true,
				"July 7",
				"Artina is awesome...you'll love it",
                "The only thing more amazing than the views....is the superb dining experience. Service is second to none.", 
				false,
				false
			),

			new Message( 
				Friends[1], 
				10, 
				false,
				"3 minutes ago",
				"Artina is awesome...you'll love it",
                "Great food. Pricey but that's to be expected. Waiters are great. Amazing views and atmosphere.", 
				true,
				false
			),

			new Message( 
				Friends[0], 
				5, 
				false,
				"July 7",
				"Artina is awesome...you'll love it",
                "We used to really look forward to going here - but NOT anymore. Food is now highly overpriced for what you get and service has gone downhill with attitude of \"The customer is here for us\".", 
				true,
				true
			),

			new Message( 
				Friends[3], 
				7, 
				false,
				"July 7",
				"Artina is awesome...you'll love it",
                "Excellent venue and quality of food! Charge card concept, simply collect your own card on entry, head to your counter of choice, swipe your card, place your order and you're all set.", 
				true,
				false
			),

		};

        public static List<Restaurant> Booking = new List<Restaurant> {
            new Restaurant(
                "article_image_0.jpg",
                "article_image_0_ban.jpg",
                "Jamie's Italian Australia, Sydney",
                "107 Pitt St, Sydney",
                "11:30–22:00",
                true
            ),

            new Restaurant(
                "article_image_1.jpg",
                "article_image_1_ban.jpg",
                "ARIA Restaurant",
                "1 Macquarie St, Sydney",
                "12:00–14:30, 17:30–22:30",
                true
            ),

            new Restaurant(
                "article_image_2.jpg",
                "article_image_2_ban.jpg",
                "Vapiano",
                "Cnr King St &, York St, Sydney",
                "11:00–23:00",
                true
            ),

            new Restaurant(
                "article_image_3.jpg",
                "article_image_3_ban.jpg",
                "Tetsuya's Restaurant",
                "529 Kent St, Sydney",
                "17:30–00:00",
                true
            ),

            new Restaurant(
                "article_image_4.jpg",
                "article_image_4_ban.jpg",
                "Kobe Jones Sydney",
                "29 Lime St, Sydney",
                "11:00–23:00",
                true
            ),

            new Restaurant(
                "article_image_5.jpg",
                "article_image_5_ban.jpg",
                "Altitude Restaurant",
                "Shangri-La Hotel, Sydney",
                "18:00–22:00",
                true
            )
        };
        
        public static List<Message> Memos = new List<Message> {
            new Message(
                Friends[5],
                7,
                true,
                "July 7",
                "Hey check this out!",
                "Great food & service. I was hesitant after reading some of the reviews about the service, I went there on Friday night as a test run for my daughters birthday dinner. The hostess and staff were very professional & attentive, I could not fault the service or the food.",
                true,
                true
            ),

            new Message(
                Friends[1],
                3,
                false,
                "Yesterday",
                "Artina is awesome...you'll love it",
                "High class restaurant, clearly a lot of attention to detail but falls into the classic pitfall of small portions for high prices. Meals just don't satisfy the appetite for very long.",
                false,
                true
            ),

            new Message(
                Friends[2],
                1,
                true,
                "July 7",
                "Artina is awesome...you'll love it",
                "For us the best meal we had so far in 3 years in Sydney. We are not regular fine dinners but we were made to feel really comfortable. Vegetarian options were delicious.",
                false,
                false
            ),
        };

        public static List<Message> Diaries = new List<Message> {
            new Message(
                Friends[5],
                7,
                true,
                "July 7",
                "Hey check this out!",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                true,
                true
            ),

            new Message(
                Friends[1],
                3,
                false,
                "Yesterday",
                "Artina is awesome...you'll love it",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                false,
                true
            ),

            new Message(
                Friends[2],
                1,
                true,
                "July 7",
                "Artina is awesome...you'll love it",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                false,
                false
            ),
        };

        public static List<Message> Medicines = new List<Message> {
            new Message(
                Friends[5],
                7,
                true,
                "July 7",
                "Hey check this out!",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                true,
                true
            ),

            new Message(
                Friends[1],
                3,
                false,
                "Yesterday",
                "Artina is awesome...you'll love it",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                false,
                true
            ),

            new Message(
                Friends[2],
                1,
                true,
                "July 7",
                "Artina is awesome...you'll love it",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                false,
                false
            ),
        };





        public static List<Message> Comments = Messages.GetRange( (Messages.Count() / 2), (Messages.Count() / 2));	

		public static List<User> SmallUserList = Users.GetRange( 0, 2);	

		
	}
}