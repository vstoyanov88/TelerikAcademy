using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Events
{
    public static class Messages
    {
        private static readonly StringBuilder Output = new StringBuilder();

        public static string OutputString
        {
            get
            {
                return Output.ToString();
            }
        }

        public static void EventAdded()
        {
            Output.Append("Event added\n");
        }

        public static void EventDeleted(int number)
        {
            if (number == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendFormat("{0} events deleted\n", number);
            }
        }

        public static void NoEventsFound()
        {
            Output.Append("No events found\n");
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.Append(eventToPrint + "\n");
            }
        }
    }
}
