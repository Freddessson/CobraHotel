using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using Model;
using System.Data;

namespace DAL
{
    public class CustomerDAL
    {

        public static void CreateCustomer(Customer c)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.connection();
            string name = c.name;
            string pnr = c.pnr;
            string email = c.email;
            string phone = c.phone;
            string address = c.address;
            try
            {
                /*SqlCommand myCommand = new SqlCommand("INSERT INTO dbo.customer (pnr, name, email, phone, address) " +
                                "VALUES (@pnr, @name, @email, @phone, @address);", myConnection);
                //"Values (94, 'Otto', 'fredriksson.otto@gmail.com', 0732206670, 'NotarieG')", myConnection);*/
                string query = "INSERT INTO dbo.customer (pnr, name, email, phone, address) " +
                    "VALUES (@pnr, @name, @email, @phone, @address);";
                Console.WriteLine("crash 1");
                SqlCommand command = new SqlCommand(query, myConnection);
                Console.WriteLine("crash 2");
                command.Parameters.Add("@pnr", SqlDbType.NChar).Value = "abc";
                command.Parameters.Add("@name", SqlDbType.NChar).Value = "abc";
                command.Parameters.Add("@email", SqlDbType.NChar).Value = "abc";
                command.Parameters.Add("@phone", SqlDbType.NChar).Value = "abc";
                command.Parameters.Add("@address", SqlDbType.NChar).Value = "abc";
                Console.WriteLine("crash 3");
                myConnection.BeginTransaction();
                Console.WriteLine("crash 4");
                //myCommand.ExecuteNonQuery();
                Console.WriteLine("Efter SQL");
            }
            catch (SqlException)
            {
                //ERROR
                Console.Write("Kunde inte skapa kund.");
            }
            conn.closeConn(myConnection);
        }

        

        /*public Customer ShowCustomer(string pnr)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.connection();
            try
            {
                Customer c = new Customer();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from customer where pnr = " + pnr,
                                                         myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    c.Pnr = myReader["pnr"].ToString();
                    c.Name = myReader["name"].ToString();
                    c.Email = myReader["email"].ToString();
                    c.Phone = myReader["phone"].ToString();
                    c.Address = myReader["address"].ToString();
                }
                return c;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }*/
    }
}
