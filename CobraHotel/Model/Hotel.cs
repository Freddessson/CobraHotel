using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Hotel
    {
        public Hotel()
        {
        }
        public Hotel(string name, string rating, string hotelId, string location)
        {
            this.name = name;
            this.rating = rating;
            this.hotelId = hotelId;
            this.location = location;
        }

        public string name { get; set; }
        public string rating { get; set; }
        public string hotelId { get; set; }
        public string location { get; set; }
      
    }
}
