using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events_management_system
{
    class Booking
    {
        public Booking(int bookingID, int eventCode, string fullname, string address, int ticketAmount)
        {
            this.bookingID = bookingID;
            this.eventCode = eventCode;
            this.fullname = fullname;
            this.address = address;
            //this.ticketCostNew = ticketCostNew;
            this.ticketAmount = ticketAmount;
        }
        public int ticketAmount { get; private set; }
        public int bookingID { get; private set; }
        public int eventCode { get; private set; }
        public double ticketCostNew { get; private set; }


        public string fullname
        {
            get { return fullname; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length == 0)
                {
                    throw new Exception("Name is empty");
                }
                fullname = value;
            }
        }

        public string address
        {
            get { return address; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length == 0)
                {
                    throw new Exception("address is empty");
                }
                address = value;
            }
        }

    }
}
