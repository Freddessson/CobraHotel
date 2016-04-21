using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace View
{
    public partial class CobraGUI : Form
    {
        public CobraGUI()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            //Create Customer via Controller!
            Customer c = new Customer();
            c.name = textBoxName.Text;
            c.pnr = textBoxPnr.Text;
            c.email = textBoxEmail.Text;
            c.phone = textBoxPhone.Text;
            c.address = textBoxAddress.Text;
            
            CustomerController CController = new CustomerController();
            //if(c.pnr inte finns i databasen, kör: )

            Customer cCheck = new Customer();
            //cCheck.pnr = "defaultValue";
            cCheck = CController.FindCustomer(c.pnr);
            
            if (cCheck.pnr == c.pnr){
                labelMessage.Text = "Personnumret du matade in finns redan.";
                //CController.CreateCustomer(c);
                //CController.ShowCustomer(c.pnr);
            }else
            {
                CController.CreateCustomer(c);
                CController.FindCustomer(c.pnr);
                labelMessage.Text = "Kund skapad!";
                //Console.WriteLine("Du matade in { 0}.",c.pnr);
            }

            /*Customer cCheck = new Customer();
            c.pnr = "35";
            c = CController.ShowCustomer("000000423456");
            
            labelMessage.Text = c.pnr;
            Console.WriteLine(c.pnr);*/

            //Console.WriteLine("Pnr:"+cCheck.pnr);
            //if (kund redan finns med inmatat pnr, ERROR!!
            //else (tack som fan för att du valde att registrera dig hos CobraHoteL!!!:D


        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void CobraGUI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void buttonFindCustomerByPnr_Click(object sender, EventArgs e)
        {
            CustomerController CController = new CustomerController();
            Customer c = new Customer();
            c.pnr = textBoxSearchCByPnr.Text;
            Customer cCheck = new Customer();
            cCheck = CController.FindCustomer(c.pnr);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
