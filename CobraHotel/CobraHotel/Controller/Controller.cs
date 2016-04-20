using CobraHotel.Model;
using CobraHotel.DAL;
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
        //CreateCustomer
        //Customer c1 = new Customer("name {0}");
        //Customer c2 = new Customer("namnfan", "pnr", "", "", "");
    }

    public void CobraHotel.DAL.CreateCustomer(string SocialSN, string Name, string Surname, string Email, string TelNr, string Gender, string ECName, string ECNumber)
    {
        CreateEmployee(SocialSN, Name, Surname, Email, TelNr, Gender, ECName, ECNumber);

    }
