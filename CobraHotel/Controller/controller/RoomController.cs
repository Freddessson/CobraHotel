using Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class RoomController
    {
        public List<Room> GetAvailableRoomsByPeriod(String period)
        {
            List<Room> roomList = new List<Room>();
            roomList = RoomDAL.GetAvailableRoomsByPeriod(period);
            return roomList;
        }




        }
}
