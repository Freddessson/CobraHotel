using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobraHotel.Model
{
    public class Booking
    {
        private string bookingNbr;
        private int price;
        private string period;
        //private Customer customer { get; set; }
        //private Room room { get; set; }

        public Booking(string bookingNbr, int price, string period)
        {
            this.bookingNbr = bookingNbr;
            this.price = price;
            this.period = period;
        }

        public string BookingNbr
        {
            get
            {
                return bookingNbr;
            }

            set
            {
                bookingNbr = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Period
        {
            get
            {
                return period;
            }

            set
            {
                period = value;
            }
        }
    }
}
