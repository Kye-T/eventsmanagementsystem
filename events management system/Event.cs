using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events_management_system
{
    class Event
    {
        public int eventCode { get; private set; }

        public string Eventname
        {
            get { return EventName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length == 0)
                {
                    throw new Exception("Event Name is empty");
                }
                EventName = value;
            }
        }
        private string EventName;

        public int numberOfTicketsAvailable { get; private set; }

        public double ticketCost { get; private set; }

        public String Date
        {
            get { return dateAdded; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Error no date set.");
                }
                dateAdded = value;
            }
        }
        private String dateAdded;

        public Event(int eventCode, string eventName, int numberOfTicketsAvailable, string dateAdded, double ticketCost)
        {
            this.eventCode = eventCode;
            Eventname = eventName;
            this.numberOfTicketsAvailable = numberOfTicketsAvailable;
            this.dateAdded = dateAdded;
            this.ticketCost = ticketCost;
        }
       
    }



}
