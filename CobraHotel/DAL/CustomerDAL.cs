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
            conn.closeConn(myConnection);
        }



        public static Customer FindCustomer(string pnr)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.connection();
            try
            {
                Customer c = new Customer();
                SqlDataReader myReader = null;
                SqlCommand cmd = new SqlCommand("SELECT * FROM customer WHERE pnr = " + pnr, myConnection);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    c.pnr = myReader["pnr"].ToString();
                    c.name = myReader["name"].ToString();
                    c.email = myReader["email"].ToString();
                    c.phone = myReader["phone"].ToString();
                    c.address = myReader["address"].ToString();
                }
                return c;
                //Close connection to DB.
                conn.closeConn(myConnection);

            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;

        }
        public static List<Customer> FindAllCustomers()
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.connection();
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
                //Close connection to DB.
                //conn.closeConn(myConnection);

            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }
        public void DeleteCustomer(string pnr)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.connection();

            string sql = "Delete from customer WHERE pnr = " + pnr;
            SqlCommand cmd = new SqlCommand(sql, myConnection);
            cmd.ExecuteNonQuery();
            conn.closeConn();
        }
    }
}
