using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Booking
    {
        public Booking()
        {
        }
        public Booking(string roomNumber, string pnr, int price, string bookingNbr, string period)
        {
            this.price = price;
            this.bookingNbr = bookingNbr;
            this.period = period;
            this.pnr = pnr;
            this.roomNumber = roomNumber;
            
            
        }

        public string bookingNbr { get; set; }
        public string period { get; set; }
        public int price { get; set; }
        public string pnr { get; set; }
        public string roomNumber { get; set; }
    }
}
 