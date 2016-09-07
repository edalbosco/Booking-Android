using System;

namespace Booking.Models
{
    public class Restaurant
    {
        public string Poster
        {
            get;
            set;
        }

        public string Banner
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Where
        {
            get;
            set;
        }

        public string When
        {
            get;
            set;
        }

        public Boolean IsStared
        {
            get;
            set;
        }

        public Restaurant(
            string poster,
            string banner,
            string title,
            string where,
            string when,
            Boolean isStared
            )
        {
            Poster = poster;
            Banner = banner;
            Where = where;
            When = when;
            Title = title;
            IsStared = isStared;
        }
    }
}