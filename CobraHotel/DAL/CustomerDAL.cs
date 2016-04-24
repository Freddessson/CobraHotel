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
            conn.CloseConn(myConnection);
        }



        public static Customer FindCustomer(string searchVar,string searchtype)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();
            try
            {
                Customer c = new Customer();
                Console.WriteLine("SÖK PÅ EMAIL FÅN DAL1");
                SqlDataReader myReader = null;
                string pnrType = "pnr";
                string emailType = "email";
                Console.WriteLine("SÖK PÅ EMAIL FÅN DAL2");
                if (searchtype.Equals(pnrType))
                {
                    Console.WriteLine("SÖK PÅ EMAIL FÅN DAL3");
                    SqlCommand cmd = new SqlCommand("SELECT * FROM customer WHERE pnr = " + searchVar, myConnection);
                    myReader = cmd.ExecuteReader();
                }
                Console.WriteLine("SÖK PÅ EMAIL FÅN DAL4");
                if (searchtype.Equals(emailType))
                {
                    Console.WriteLine("SÖK PÅ EMAIL FÅN DAL5");
                    SqlCommand cmd = new SqlCommand("SELECT * FROM customer WHERE email LIKE 'heh'" + myConnection);
                    //cmd.Parameters.Add("@email", SqlDbType.Char, 50).Value = 'heh';
                    
                    myReader = cmd.ExecuteReader();
                    Console.WriteLine("SÖK PÅ EMAIL FÅN DAL6");
                }

                while (myReader.Read())
                {
                    Console.WriteLine("FR^ÅN DAL: "+c.phone);
                    c.pnr = myReader["pnr"].ToString();
                    c.name = myReader["name"].ToString();
                    c.email = myReader["email"].ToString();
                    c.phone = myReader["phone"].ToString();
                    c.address = myReader["address"].ToString();
                }
                return c;
                //Close connection to DB.
                conn.CloseConn(myConnection);

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
                //Close connection to DB.
                //conn.closeConn(myConnection);

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

            string sql = "Delete from customer WHERE pnr = " + pnr;
            SqlCommand cmd = new SqlCommand(sql, myConnection);
            cmd.ExecuteNonQuery();
            //conn.closeConn();
        }
        /*public static void UpdateCustomer(Customer c)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.connection();
            try
            {
                string sql = "UPDATE dbo.customer SET name = andratVärde"
                    //(pnr, name, email, phone, address) VALUES (@pnr, @name, @email, @phone, @address)"
                        + "WHERE pnr = " + c.pnr;
                //INFO SET id='" + txtId.Text + "', name='" + txtName.Text + "' where id='" + listBox1.SelectedItem.ToString() + "' and name= '" + listBox2.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, myConnection);

                cmd.Parameters.Add("@pnr", SqlDbType.VarChar).Value = c.pnr;
                cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = c.name;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = c.email;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = c.phone;
                cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = c.address;
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                Console.WriteLine("Can't update customer. SQL Exception");
                
            }
        }*/

        public static void UpdateCustomer(Customer c)
        {
            DBUtil conn = new DBUtil();
            SqlConnection myConnection = conn.Connection();

            Console.WriteLine(c.pnr);
            Console.WriteLine(c.name);
            Console.WriteLine(c.email);
            Console.WriteLine(c.address);
            Console.WriteLine(c.phone);
            try
            {
                using (myConnection)
                {
                    //string sql = "UPDATE customer SET name = hejsan WHERE pnr = 1";
                    string sql = "UPDATE dbo.customer SET name=@name, email=@email, phone=@phone, address=@address WHERE pnr=@pnr";
                    //string sql = "INSERT INTO dbo.customer (pnr, name, email, phone, address) VALUES (@pnr, @name, @email, @phone, @address)";
                    //string sql = "UPDATE dbo.customer (pnr, name, email, phone, address) VALUES (@pnr, @name, @email, @phone, @address" +
                    //"WHERE pnr = )"+c.pnr;
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
