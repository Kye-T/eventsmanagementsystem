using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events_management_system
{
    
    class Admin_UI
    {
        public void AddEvent(int eventCode , string EventName, int numberOfTicketsAvailable,string dateAdded,  double ticketCost)
        {
            try
            {
                EventManager.Instance.AddEvent(eventCode, EventName, numberOfTicketsAvailable, dateAdded, ticketCost);
                Console.WriteLine("\nEvent successfully added.");
            }
           catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }


        public void DeleteEvent(int eventCode)
        {
            try
            {
                EventManager.Instance.DeleteEvent(eventCode);
                Console.WriteLine("\nEvent successfully deleted.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }


        public void UpdateEvent(int eventCode, string EventName, int numberOfTicketsAvailable, string dateAdded, double ticketCost)
        {
            try
            {
                EventManager.Instance.AddEvent(eventCode, EventName, numberOfTicketsAvailable, dateAdded, ticketCost);
                Console.WriteLine("\nEvent successfully updated.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        public void DisplayEvents()
        {
            try
            {
                EventManager.Instance.DisplayEvents();
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        public void TransactionLog()
        {
            try
            {
                EventManager.Instance.TransactionLog();
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }


        public void BookTickets(int eventCode, String fullname, String address, int ticketAmount)
        {
            try
            {
                EventManager.Instance.BookTickets(eventCode,fullname,address,ticketAmount);
                Console.WriteLine("\nBooking created.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        public void cancelBooking(int bookingID)
        {
            try
            {
                EventManager.Instance.cancelBooking(bookingID);
                Console.WriteLine("\nBooking Cancelled.");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            
        }

    }
}
