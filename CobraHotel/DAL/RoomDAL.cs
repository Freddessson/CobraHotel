using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoomDAL
    {
        public static List <Room> GetAvailableRoomsByPeriod(String period)
        {

            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();

            List<Room> roomList = new List<Room>();

            try
            {
                SqlDataReader myReader = null;
                SqlCommand cmd = new SqlCommand("SELECT * FROM room WHERE period LIKE @prd", myConnection);
                cmd.Parameters.Add("@period", SqlDbType.VarChar, 50).Value = period = "y";
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {

                    Room r = new Room();
                    r.available = myReader["available"].ToString();
                    r.beds = Convert.ToInt32(myReader["beds"]);
                    r.period = myReader["period"].ToString();
                    r.price = Convert.ToInt32(myReader["price"]);
                    r.roomId = myReader["roomId"].ToString();
                    r.roomNumber = myReader["rooomNumber"].ToString();


                    roomList.Add(r);
                }
                foreach (Room r in roomList)
                {
                    Console.WriteLine("Available"+ r.available);
                }
            }
            catch (SqlException)
            {

                throw;
            }



            return roomList;
        }
    }
}
