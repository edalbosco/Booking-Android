using System;

namespace TVShows.Models
{
	public class ChatMessage
	{
		public User From {
			get;
			set;
		}

		public string When {
			get;
			set;
		}

		public string Body {
			get;
			set;
		}

		public ChatMessage (
			User from, 
			string when,
			string body 
			)
		{
			From 			= from;
			When 			= when;
			Body 			= body;
		}
	}
}

