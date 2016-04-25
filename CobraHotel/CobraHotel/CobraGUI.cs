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
            dataGridViewCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomer.SelectionChanged += new EventHandler((s, e) =>
            {

            });
            dataGridViewCustomer.MultiSelect = false;
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
            string searchVar = c.pnr;
            string searchtype = "pnr";
            cCheck = CController.FindCustomer(searchVar, searchtype);
            
            if (cCheck.pnr == c.pnr){
                labelMessage.Text = "Personnumret du matade in finns redan.";
                //CController.CreateCustomer(c);
                //CController.ShowCustomer(c.pnr);
            }else
            {
                CController.CreateCustomer(c);
                //CController.FindCustomer(c.pnr);
                labelMessage.Text = "Kund skapad!";
                textBoxName.Text = "";
                textBoxPnr.Text = "";
                textBoxEmail.Text = "";
                textBoxPhone.Text = "";
                textBoxAddress.Text = "";
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
            string searchVar = textBoxSearchCByPnr.Text;
            string searchtype = comboBoxSearchType.Text;
            c = CController.FindCustomer(searchVar, searchtype);
            Console.WriteLine("searchType: "+searchtype);
            Console.WriteLine("searchVar: " + searchVar);
            
            DataTable dt = new DataTable();
            dataGridViewCustomer.DataSource = dt;
            dataGridViewCustomer.ClearSelection();
            dt.Columns.Add("Namn");
            dt.Columns.Add("Pnr");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");

            DataRow row = dt.NewRow();
            row["Namn"] = c.name;
            row["Pnr"] = c.pnr;
            row["Email"] = c.email;
            row["Phone"] = c.phone;
            row["Address"] = c.address;
            dt.Rows.Add(row);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFindAllCustomers_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridViewCustomer.DataSource = dt;
            dataGridViewCustomer.ClearSelection();
            dt.Columns.Add("Namn");
            dt.Columns.Add("Pnr");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Address");


            CustomerController CController = new CustomerController();
            
            List<Customer> customerList = new List<Customer>();
            customerList = CController.FindAllCustomers();
            //for (int i = 0; i < customerList.Count; i++)
            foreach (Customer c in customerList)
            {                
                //dataGridViewCustomer.Rows.Add(c.name, c.pnr, c.email, c.phone, c.address);
                //dt.Columns.Add(c.name, c.pnr, c.email, c.phone, c.address);
                DataRow row = dt.NewRow();
                row["Namn"] = c.name;
                row["Pnr"] = c.pnr;
                row["Email"] = c.email;
                row["Phone"] = c.phone;
                row["Address"] = c.address;
                dt.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewCustomer.SelectedRows[0];
            string pnr = row.Cells["Pnr"].Value.ToString();
            CustomerController CController = new CustomerController();
            CController.DeleteCustomer(pnr);
            dataGridViewCustomer.ClearSelection();
            buttonFindAllCustomers.PerformClick();
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            DataGridViewRow row = dataGridViewCustomer.SelectedRows[0];
            c.pnr = row.Cells["Pnr"].Value.ToString();
            c.name = row.Cells["Namn"].Value.ToString();
            c.email = row.Cells["Email"].Value.ToString();
            c.phone = row.Cells["Phone"].Value.ToString();
            c.address = row.Cells["Address"].Value.ToString();

            CustomerController CController = new CustomerController();
            CController.UpdateCustomer(c);
            dataGridViewCustomer.ClearSelection();
            buttonFindAllCustomers.PerformClick();
        }

        private void labelSearchCByPnr_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearchCByPnr_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAvailableRoomsByPeriod_Click(object sender, EventArgs e)
        {
            string period = "";
            string available = "";
            RoomController RController = new RoomController();
            RController.GetAvailableRoomsByPeriod(period, available);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
