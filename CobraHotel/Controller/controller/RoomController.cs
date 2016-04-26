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
        public List<Room> GetAvailableRoomsByPeriod(String period, string available)
        {
            List<Room> roomList = new List<Room>();
            roomList = RoomDAL.GetAvailableRoomsByPeriod(period, available);
            return roomList;
        }

        public void CreateRoom(Room r)
        {
            RoomDAL.CreateRoom(r);
           
        }
        public void UpdateRoom(Room r)
        {
            RoomDAL.UpdateRoom(r);
        }
        public List<Room> FindAllRooms()
        {
            List<Room> roomList = new List<Room>();
            roomList = RoomDAL.FindAllRooms();
            return roomList;
        }
    }
}
