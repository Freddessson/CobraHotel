using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Controller.controller
{
    class BookingController
    {
        public List<Booking> FindAllBookings()
        {
            //CustomerDAL.FindAllCustomers();
            List<Booking> bookingList = new List<Booking>();
            bookingList = BookingDAL.FindAllBookings();
            return bookingList;
        }
    }
}
