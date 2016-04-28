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
            SqlConnection myConnection = conn.Connection();
            try
            {
                using (myConnection)
                {

                    string sql = "INSERT INTO dbo.customer (pnr, name, email, phone, address) VALUES (@pnr, @name, @email, @phone, @address)";
                    SqlCommand cmd = new SqlCommand(sql, myConnection);
                    cmd.Parameters.Add("@pnr", SqlDbType.VarChar).Value = c.pnr;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = c.name;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = c.email;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = c.phone;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = c.address;
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



        public static Customer FindCustomer(string searchVar,string searchtype)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();
            try
            {
                Customer c = new Customer();
                SqlDataReader myReader = null;
                string pnrType = "pnr";
                string emailType = "email";

                if (searchtype.Equals(pnrType))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM customer WHERE pnr = " + searchVar, myConnection);
                    myReader = cmd.ExecuteReader();
                }

                if (searchtype.Equals(emailType))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM customer WHERE email = @email ", myConnection);
                        cmd.Parameters.Add("@email", SqlDbType.Char, 50).Value = searchVar;

                        myReader = cmd.ExecuteReader();
                    }
                    catch (SqlException e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }

                while (myReader.Read())
                {
                    c.pnr = myReader["pnr"].ToString();
                    c.name = myReader["name"].ToString();
                    c.email = myReader["email"].ToString();
                    c.phone = myReader["phone"].ToString();
                    c.address = myReader["address"].ToString();
                }
                return c;

            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
            conn.CloseConn(myConnection);
        }

        public static List<Customer> FindAllCustomers()
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();
            try
            {

                List<Customer> customerList = new List<Customer>();
                SqlDataReader myReader = null;
                SqlCommand cmd = new SqlCommand("SELECT * FROM customer", myConnection);
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    Customer c = new Customer();
                    c.pnr = myReader["pnr"].ToString();
                    c.name = myReader["name"].ToString();
                    c.email = myReader["email"].ToString();
                    c.phone = myReader["phone"].ToString();
                    c.address = myReader["address"].ToString();


                    customerList.Add(c);
                }



                return customerList;

            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }
        public static void DeleteCustomer(string pnr)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();

            try
            {
                using (myConnection)
                {
                    string sql = "Delete from customer WHERE pnr = " + pnr;
                    SqlCommand cmd = new SqlCommand(sql, myConnection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Kunde inte ta bort kund");
            }

        }


        public static void UpdateCustomer(Customer c)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();

            try
            {
                using (myConnection)
                {
                    string sql = "UPDATE dbo.customer SET name=@name, email=@email, phone=@phone, address=@address WHERE pnr=@pnr";
                    SqlCommand cmd = new SqlCommand(sql, myConnection);
                    cmd.Parameters.Add("@pnr", SqlDbType.VarChar).Value = c.pnr;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = c.name;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = c.email;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = c.phone;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = c.address;

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }


            }
            catch (SqlException)
            {
                //ERROR
                Console.Write("Kunde inte uppdatera kund.");
            }
            conn.CloseConn(myConnection);
        }
    }
}
