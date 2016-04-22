using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Room
    {
        public Room()
        {
        }
          public Room(int price, int beds, string roomNumber, string roomId, string available, string period)
        {
            this.price = price;
            this.beds = beds;
            this.roomNumber = roomNumber;
            this.roomId = roomId;
            this.available = available;
            this.period = period;
        }

        public int price { get; set; }
        public int beds { get; set; }
        public string roomNumber { get; set; }
        public string roomId { get; set; }
        public string available { get; set; }
        public string period { get; set; }
        
    }
}
