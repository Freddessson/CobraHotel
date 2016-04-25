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
    class BookingDAL
    {
        public static void CreateBooking(Booking b, Customer c, Room r)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();
            try
            {
                using (myConnection)
                {
                    b.period = r.period;
                    b.price = r.price;
                    b.pnr = c.pnr;
                    b.roomNumber = r.roomNumber;

                    string sql = "INSERT INTO dbo.booking (roomNumber,pnr,price,bookingNbr,period) VALUES (@roomNumber,@pnr,@price,@bookingNbr,@period)";
                    SqlCommand cmd = new SqlCommand(sql, myConnection);
                    cmd.Parameters.Add("@roomNumber", SqlDbType.VarChar).Value = b.period;
                    cmd.Parameters.Add("@pnr", SqlDbType.VarChar, 50).Value = b.pnr;
                    cmd.Parameters.Add("@price", SqlDbType.VarChar, 50).Value = b.price;
                    cmd.Parameters.Add("@bookingNbr", SqlDbType.VarChar, 50).Value = b.bookingNbr;
                    cmd.Parameters.Add("@period", SqlDbType.VarChar, 50).Value = b.period;
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
    }
}
