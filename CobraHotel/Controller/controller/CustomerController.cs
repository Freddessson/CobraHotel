using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Controller
{

    public class CustomerController
    {
        public void CreateCustomer(Customer c)
        {
            CustomerDAL.CreateCustomer(c);
        }

        public Customer FindCustomer(string pnr)
        {
            CustomerDAL.FindCustomer(pnr);
            Customer c = DAL.CustomerDAL.FindCustomer(pnr);
            return c;
        }

        public List<Customer> FindAllCustomers()
        {
            CustomerDAL.FindAllCustomers();
            List<Customer> customerList = new List<Customer>();
            customerList = DAL.CustomerDAL.FindAllCustomers();
            return customerList;
        }
        public void DeleteCustomer(string pnr)
        {
            CustomerDAL.DeleteCustomer(pnr);
        }
        public void UpdateCustomer(Customer c)
        {
            CustomerDAL.UpdateCustomer(c);
        }
    }
}
