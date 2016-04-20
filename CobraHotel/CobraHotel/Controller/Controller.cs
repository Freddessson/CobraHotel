using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CobraHotel.Controller
{
    public class Controller
    {
        
    }
    public class CustomerController
    {
        string InpName = "Name";
        string InpPnr = "9312312";
        string InpEmail = "hej@gmail.com";
        string InpPhone = "0621312";
        string InpAddress = "gatan 27";

        //Customer c1 = new Customer(InpName, InpPnr, InpEmail, InpPhone, InpAddress);
        Customer c1 = new Customer("name {0}");
        

        




    }
    
}
