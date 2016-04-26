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
    public class BookingDAL
    {
        public static void CreateBooking(Booking b)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();
            try
            {
                using (myConnection)
                {
                 
                    string sql = "INSERT INTO dbo.booking (roomNumber,pnr,price,bookingNbr,period, roomId) VALUES (@roomNumber,@pnr,@price,@bookingNbr,@period, @roomId)";
                    
                    SqlCommand cmd = new SqlCommand(sql, myConnection);
                    cmd.Parameters.Add("@roomNumber", SqlDbType.VarChar).Value = b.roomNumber;
                    cmd.Parameters.Add("@pnr", SqlDbType.VarChar, 50).Value = b.pnr;
                    cmd.Parameters.Add("@price", SqlDbType.BigInt, 50).Value = b.price;
                    cmd.Parameters.Add("@bookingNbr", SqlDbType.VarChar, 50).Value = b.bookingNbr;
                    cmd.Parameters.Add("@period", SqlDbType.VarChar, 50).Value = b.period;
                    cmd.Parameters.Add("@roomId", SqlDbType.VarChar, 50).Value = b.roomId;


                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    string sql2 = "UPDATE dbo.room SET available=@available WHERE roomId=@roomId";
                    SqlCommand cmd2 = new SqlCommand(sql2, myConnection);
                    cmd2.Parameters.Add("@roomId", SqlDbType.VarChar, 50).Value = b.roomId;
                    cmd2.Parameters.Add("@available", SqlDbType.VarChar, 50).Value = "n";

                    cmd2.CommandType = CommandType.Text;
                    cmd2.ExecuteNonQuery();

                    //  string sql2 = "INSERT INTO dbo.room (roomNumber,pnr,price,bookingNbr,period) VALUES (@roomNumber,@pnr,@price,@bookingNbr,@period)";
                    //SqlCommand cmd2 = new SqlCommand(sql, myConnection);
                    //cmd....
                }

            }
            catch (SqlException)
            {
                //ERROR
                Console.Write("Kunde inte skapa bokning.");
            }
            conn.CloseConn(myConnection);
        }
        public static List<Booking> FindAllBookings()
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();
            try
            {

                List<Booking> bookingList = new List<Booking>();
                SqlDataReader myReader = null;
                SqlCommand cmd = new SqlCommand("SELECT * FROM booking", myConnection);
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    Booking b = new Booking();
                    b.bookingNbr = myReader["bookingNbr"].ToString();
                    b.price = Convert.ToInt32(myReader["price"]);
                    b.period = myReader["period"].ToString();
                    b.pnr = myReader["pnr"].ToString();
                    b.roomNumber = myReader["roomNumber"].ToString();
                    b.roomId = myReader["roomId"].ToString();


                    bookingList.Add(b);
                }



                return bookingList;
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
