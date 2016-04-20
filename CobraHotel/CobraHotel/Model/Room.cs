using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobraHotel.Model
{
    public class Room
    {
        private int price;
        private int beds;
        private string roomNumber;
        private string roomId;
        private string available;
        private string period;
        //private Hotel hotel;
        //private Set<Booking> booking;

        public Room(int price, int beds, string roomNumber, string roomId, string available, string period)
        {
            this.Price = price;
            this.Beds = beds;
            this.RoomNumber = roomNumber;
            this.RoomId = roomId;
            this.Available = available;
            this.Period = period;
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

        public int Beds
        {
            get
            {
                return beds;
            }

            set
            {
                beds = value;
            }
        }

        public string RoomNumber
        {
            get
            {
                return roomNumber;
            }

            set
            {
                roomNumber = value;
            }
        }

        public string RoomId
        {
            get
            {
                return roomId;
            }

            set
            {
                roomId = value;
            }
        }

        public string Available
        {
            get
            {
                return available;
            }

            set
            {
                available = value;
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
