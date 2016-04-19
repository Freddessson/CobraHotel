using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace CobraHotel
{
    class Program
    {
        static void Main(string[] args)
        {

            
       
            DBUtil d = new DBUtil();
            SqlConnection myConnection = d.connection();

            if (myConnection != null)
            {
                SqlCommand myCommand = new SqlCommand("INSERT INTO dbo.customer (pnr, name, email, phone, address) " +
                                    "Values (9412233222, 'Otto', 'fredriksson.otto@gmail.com', 0732206670, 'NotarieG')", myConnection);
                myCommand.ExecuteNonQuery();
                Console.WriteLine("Efter SQL");
            }
            else
            {
                Console.WriteLine("null");
            }
            d.closeConn(myConnection);
            Console.Read();

    }
}