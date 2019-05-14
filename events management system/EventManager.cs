using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events_management_system
{
    class EventManager
    {
        public static EventManager Instance { get; } = new EventManager();
        private SortedDictionary<int, Event> events = new SortedDictionary<int, Event>();
        ArrayList transactionLog = new ArrayList();
        private SortedDictionary<int, Booking> booking = new SortedDictionary<int, Booking>();


        public void AddEvent(int eventCode, String EventName, int numberOfTicketsAvailable, String dateAdded, double ticketCost)
        {
            Event e = new Event(eventCode, EventName, numberOfTicketsAvailable, dateAdded, ticketCost);
            events.Add(e.eventCode, e);

            transactionLog.Add("Event Added:" + eventCode + EventName + numberOfTicketsAvailable + dateAdded + ticketCost);
            events.Add(e.eventCode, e);
        }

        public void TransactionLog()
        {

            PrintValues(transactionLog);
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }

        public void DeleteEvent(int eventCode)

        {
            EventManager.Instance.DeleteEvent(eventCode);
            String dateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            events.Remove(eventCode);

            transactionLog.Add("event deleted:" + bookingID + dateAdded);



        }
        public Event FindEvent(int eventCode)
        {
            try
            {
                return events[eventCode];
                
            }
            catch (KeyNotFoundException)
            {
                throw new System.Exception("No event found with this event code");
            }
        }
        public Event[] DisplayEvents()
        {
            Event[] e = new Event[events.Count];
            events.Values.CopyTo(e, 0);
            return e;
        }

        public void UpdateEvent(int eventCode, String EventName, int numberOfTicketsAvailable, String dateAdded, double ticketCost)
        {
            
            
                String dateAddedUpdate = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                Event events = FindEvent(eventCode);
                DeleteEvent(eventCode);
                AddEvent(eventCode,EventName,numberOfTicketsAvailable, dateAdded, ticketCost);
                transactionLog.Add("Event updated:" + eventCode + dateAddedUpdate);
            
           
            
           
        }

        internal void BookTickets(int eventCode, string fullname, string address, int ticketAmount)
        {
            throw new NotImplementedException();
        }

        public int bookingID = 1;
        public void BookTickets(int eventCode,  int ticketCost, String fullname, String address, int ticketAmount)
        {

            FindEvent(eventCode);
            //if (numberOfTicketsAvailable > ticketAmount)
            //{
               // Console.Write("\nTickets unavailable.");
            //}
            //else
            //{
                bookingID++;
                //int ticketCostNew = ticketCost * ticketAmount;
                Booking b = new Booking(bookingID, eventCode, fullname, address,  ticketAmount);
                booking.Add(b.bookingID, b);
                Event events = FindEvent(eventCode);
                PrintValues(booking);
          //  }
           



        }
        public Booking FindBooking(int bookingID)
        {
            try
            {
                return booking[bookingID];
            }
            catch (KeyNotFoundException)
            {
                throw new System.Exception("No booking found with this booking id");
            }
        }
        public void cancelBooking (int bookingID)
        {
            
            String dateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            booking.Remove(bookingID);

            transactionLog.Add("booking cancelled:" + bookingID + dateAdded);
        }
    }
}
   





       


      



