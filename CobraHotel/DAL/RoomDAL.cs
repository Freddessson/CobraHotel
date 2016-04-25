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
        public static void CreateRoom(Room r)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();
            string roomId = r.roomId;
            int price = r.price;
            string beds = c.email;
            string phoneddtyjhgdh = c.phone;
            string address = c.address;

            try
            {
                using (myConnection)
                {

                    string sql = "INSERT INTO dbo.customer (pnr, name, email, phone, address) VALUES (@pnr, @name, @email, @phone, @address)";
                    SqlCommand cmd = new SqlCommand(sql, myConnection);
                    cmd.Parameters.Add("@pnr", SqlDbType.VarChar).Value = pnr;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = email;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = phone;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = address;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }


            }
            catch (SqlException)
            {
                //ERROR
                Console.Write("Kunde inte skapa kund.");
            }
            conn.CloseConn(myConnection);
        }

        public static List<Room> GetAvailableRoomsByPeriod(String period, string available)
        {

            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();

            List<Room> roomList = new List<Room>();

            try
            {
                SqlDataReader myReader = null;
                SqlCommand cmd = new SqlCommand("SELECT * FROM room WHERE available = @available ", myConnection);
                //period = "y";
                available = "y";
                //cmd.Parameters.Add("@period", SqlDbType.VarChar, 50).Value = period;
                cmd.Parameters.Add("@available", SqlDbType.VarChar, 50).Value = available;
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {

                    Room r = new Room();
                    r.available = myReader["available"].ToString();
                    r.beds = Convert.ToInt32(myReader["beds"]);
                    r.period = myReader["period"].ToString();
                    r.price = Convert.ToInt32(myReader["price"]);
                    r.roomId = myReader["roomId"].ToString();
                    r.roomNumber = myReader["roomNumber"].ToString();


                    roomList.Add(r);
                }
                foreach (Room r in roomList)
                {
                    Console.WriteLine("Available: " + r.available);
                }
            }
            catch (SqlException e)
            {

                Console.WriteLine(e.Message);
            }
            return roomList;
        }
    }
}