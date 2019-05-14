using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace events_management_system
{
    class Program
    {
   
        //Commands for admin
        private const int AddEvent = 1;
        private const int UpdateEvent = 2;
        private const int DeleteEvent = 3;
        private const int DisplayListOfEvents = 4;
        private const int DisplayTransactionLog = 5;
        private const int BookTickets = 6;
        private const int CancelBooking = 8;
        private const int EXIT = 9;
       
      

      

        private static Admin_UI adminUI = new Admin_UI();
      
        

        static void Main(string[] args)
        {
            int firstMenuCommand = GetFirstMenuCommand();

            while (firstMenuCommand != EXIT)
            {
                switch (firstMenuCommand)
                {
                    case AddEvent:
                        UseCase_Admin_AddEvent();
                        break;
                    case UpdateEvent:
                        UseCase_Admin_UpdateEvent();
                        break;
                    case DeleteEvent:
                        UseCase_Admin_DeleteEvent();
                        break;
                    case DisplayListOfEvents:
                        Use_Case_Admin_DisplayListOfEvents();
                        break;
                    case DisplayTransactionLog:
                        Use_Case_Admin_DisplayTransactionLog();
                        break;
                    case BookTickets:
                        Use_Case_Admin_BookTickets();
                        break;
                    case CancelBooking:
                        Use_Case_Admin_CancelBooking();
                        break;

                    default:
                        Console.WriteLine("\nCommand not recognised");
                        break;
                }
                firstMenuCommand = GetFirstMenuCommand();
            }
        }


        private static int GetFirstMenuCommand()
        {
            Console.WriteLine("\n");
            Console.WriteLine("{0}. Add Event", AddEvent);
            Console.WriteLine("{0}. Update Event", UpdateEvent);
            Console.WriteLine("{0}. Delete Event", DeleteEvent);
            Console.WriteLine("{0}. Display List Of Events", DisplayListOfEvents);
            Console.WriteLine("{0}. Display transaction log", DisplayTransactionLog);
            Console.WriteLine("{0}. Book tickets", BookTickets);
            Console.WriteLine("{0}. Cancel booking", CancelBooking);

            Console.WriteLine("{0}. Exit", EXIT);

            return GetChoice("");
        }

        private static int GetChoice(string indent)
        {
            bool goodChoice = false;
            int choice = -1;

            Console.Write("\n{0}Choice: > ", indent);
            do
            {
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    goodChoice = true;
                }
                catch (FormatException)
                {
                    Console.Write("{0}Please enter a menu option number: > ", indent);
                }
            }
            while (!goodChoice);

            return choice;
        }


        private static int GetInteger()
        {
            bool dataOK = false;
            int num = -1;

            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    dataOK = true;
                }
                catch (FormatException)
                {
                    Console.Write("Please enter an integer: > ");
                }
            }
            while (!dataOK);

            return num;
        }
        
       

        
       

        private static void UseCase_Admin_AddEvent()
        {
            Console.Write("Event Code: > ");
            int eventCode = GetInteger();
            Console.Write("Event Name: > ");
            string EventName = Console.ReadLine();
            Console.Write("Number Of Tickets Available: >");
            int numberOfTicketsAvailable = GetInteger();
            Console.Write("Price Per Ticket");
            String dateAdded= DateTime.Now.ToString("dddd, dd MMMM yyyy");
            double ticketCost = double.Parse(Console.ReadLine());

            adminUI.AddEvent(eventCode, EventName, numberOfTicketsAvailable, dateAdded, ticketCost);
        }

        
        
        private static void UseCase_Admin_DeleteEvent()
        {
            Console.Write("Event Code > ");
            int eventCode = GetInteger();

            adminUI.DeleteEvent(eventCode);
        }

        private static void UseCase_Admin_UpdateEvent()
        {
            Console.Write("Event Code: > ");
            int eventCode = GetInteger();
            Console.Write("Event Name: > ");
            string EventName = Console.ReadLine();
            Console.Write("Number Of Tickets Available: >");
            int numberOfTicketsAvailable = GetInteger();
            Console.Write("Price Per Ticket");
            String dateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            double ticketCost = double.Parse(Console.ReadLine());

            adminUI.UpdateEvent(eventCode,EventName,numberOfTicketsAvailable,dateAdded,ticketCost);
        }

        private static void Use_Case_Admin_DisplayListOfEvents()
        {

            adminUI.DisplayEvents();
        }


        private static void Use_Case_Admin_BookTickets()
        {
            Console.Write("Event Code: > ");
            int eventCode = GetInteger();
            Console.Write("Full Name: > ");
            string fullname = Console.ReadLine();
            Console.Write("Address: >");
            string address = Console.ReadLine();
            Console.Write("Amount of tickets: >");
            int ticketAmount = GetInteger();
           
            String dateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy");
           

            adminUI.BookTickets( eventCode,fullname, address,ticketAmount);
        }

        private static void Use_Case_Admin_CancelBooking()
        {
            Console.Write("bookingID: > ");
            int bookingID = GetInteger();
            
            String dateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy");


            adminUI.cancelBooking(bookingID);
        }

        private static void Use_Case_Admin_DisplayTransactionLog()
        {
           adminUI.TransactionLog();
        }

       


      

     

      
    }
}
