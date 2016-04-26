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
        
            try
            {
                using (myConnection)
                {

                    string sql = "INSERT INTO dbo.room (roomId, price, beds, roomNumber, period, available) VALUES (@roomId, @price, @beds, @roomNumber, @period, @available)";
                    
                    SqlCommand cmd = new SqlCommand(sql, myConnection);
                    cmd.Parameters.Add("@roomId", SqlDbType.VarChar).Value = r.roomId;
                    cmd.Parameters.Add("@price", SqlDbType.BigInt, 50).Value = r.price;
                    cmd.Parameters.Add("@beds", SqlDbType.BigInt, 50).Value = r.beds;
                    cmd.Parameters.Add("@roomNumber", SqlDbType.VarChar, 50).Value = r.roomNumber;
                    cmd.Parameters.Add("@period", SqlDbType.VarChar, 50).Value = r.period;
                    string available = "y";
                    cmd.Parameters.Add("@available", SqlDbType.VarChar, 50).Value =available;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }


            }
            catch (SqlException)
            {
                //ERROR
                Console.Write("Kunde inte skapa rum.");
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

        public static List<Room> GetAvailableRooms()
        {

            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();

            List<Room> roomList = new List<Room>();

            try
            {
                SqlDataReader myReader = null;
                SqlCommand cmd = new SqlCommand("SELECT * FROM room WHERE available = @available ", myConnection);
                //period = "y";
                string available = "y";
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


        public static void UpdateRoom(Room r)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();

            try
            {
                using (myConnection)
                {

                    string sql = "UPDATE dbo.room SET price=@price, beds=@beds, period=@period, available=@available, roomNumber=@roomNumber WHERE roomId=@roomId";
                    //string sql = "UPDATE dbo.customer SET name=@name, email=@email, phone=@phone, address=@address WHERE pnr=@pnr";
                    SqlCommand cmd = new SqlCommand(sql, myConnection);
                    cmd.Parameters.Add("@price", SqlDbType.BigInt).Value = r.price;
                    Console.WriteLine("PRIS: "+r.price);
                    Console.WriteLine("PRIS: " + r.beds);
                    Console.WriteLine("PRIS: " + r.period);
                    Console.WriteLine("PRIS: " + r.available);
                    Console.WriteLine("PRIS: " + r.roomNumber);
                    Console.WriteLine("PRIS: " + r.roomId);
                    cmd.Parameters.Add("@beds", SqlDbType.BigInt, 50).Value = r.beds;
                    cmd.Parameters.Add("@period", SqlDbType.VarChar, 50).Value = r.period;
                    cmd.Parameters.Add("@available", SqlDbType.VarChar, 50).Value = r.available;
                    cmd.Parameters.Add("@roomNumber", SqlDbType.VarChar, 50).Value = r.roomNumber;
                    cmd.Parameters.Add("@roomId", SqlDbType.VarChar, 50).Value = r.roomId;

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }


            }
            catch (SqlException)
            {
                //ERROR
                Console.Write("Kunde inte uppdatera rum.");
            }
            conn.CloseConn(myConnection);
        }
        public static List<Room> FindAllRooms()
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();
            try
            {

                List<Room> roomList = new List<Room>();
                SqlDataReader myReader = null;
                SqlCommand cmd = new SqlCommand("SELECT * FROM room", myConnection);
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    Room r = new Room();

                    //roomId, price, beds, roomNumber, period, available

                    r.roomId = myReader["roomId"].ToString();
                    r.price = Convert.ToInt32(myReader["price"]);
                    r.beds = Convert.ToInt32(myReader["beds"]);
                    r.roomNumber = myReader["roomNumber"].ToString();
                    r.period = myReader["period"].ToString();
                    r.available = myReader["available"].ToString();


                    roomList.Add(r);
                }



                return roomList;
                //Close connection to DB.
                //conn.closeConn(myConnection);

            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }
    }
}