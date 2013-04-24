using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;
using _01.Events;

namespace _01.Events
{
    public class Event : IComparable
    {
        private DateTime Date { get; set; }
        private String Title { get; set; }
        private String Location { get; set; }

        public Event(DateTime date, String title, String location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.Date.CompareTo(other.Date);
            int byTitle = this.Title.CompareTo(other.Title);
            int byLocation = this.Location.CompareTo(other.Location);
            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(Date.ToString("yyyy-MM-ddTHH:mm:ss"));
            result.Append(" | " + Title);
            if (Location != null && Location != "")
            {
                result.Append(" | " + Location);
            }
            return result.ToString();
        }
    }
}