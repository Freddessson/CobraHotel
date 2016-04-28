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

        public Customer FindCustomer(string searchVar, string searchtype)
        {
            Customer c = CustomerDAL.FindCustomer(searchVar, searchtype);
            return c;
        }

        public List<Customer> FindAllCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            customerList = CustomerDAL.FindAllCustomers();
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
