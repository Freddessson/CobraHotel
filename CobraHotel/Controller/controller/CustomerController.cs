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
            //CreateCustomer(c);
            CustomerDAL.CreateCustomer(c);
        }
       
        public Customer FindCustomer(string pnr)
        {
            CustomerDAL.FindCustomer(pnr);
            Customer c = DAL.CustomerDAL.FindCustomer(pnr);
            return c;
        }
    }
}
