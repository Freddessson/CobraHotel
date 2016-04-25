﻿using Model;
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
        public static List <Room> GetAvailableRoomsByPeriod(String period, string available)
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
                    Console.WriteLine("Available: "+ r.available);
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
