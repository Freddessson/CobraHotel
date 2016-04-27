using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

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

            dataGridViewRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dataGridViewRoom.SelectionChanged += new EventHandler((s, e) =>
            {

            });
            dataGridViewRoom.MultiSelect = false;

            dataGridViewBooking1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooking1.SelectionChanged += new EventHandler((s, e) =>
            {

            });
            dataGridViewBooking1.MultiSelect = false;

            dataGridViewBooking2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooking2.SelectionChanged += new EventHandler((s, e) =>
            {

            });
            dataGridViewBooking2.MultiSelect = false;

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

            if (cCheck.pnr == c.pnr)
            {
                labelMessage.Text = "Personnumret du matade in finns redan.";
                //CController.CreateCustomer(c);
                //CController.ShowCustomer(c.pnr);
            }
            else
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

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            Console.WriteLine("searchType: " + searchtype);
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

        private void textBoxRoomID_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void labelBeds_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            //Create Customer via Controller!
            Room r = new Room();
            r.roomId = textBoxRoomID.Text;
            r.price = Int32.Parse(textBoxPrice.Text); //int
            r.beds = Int32.Parse(textBoxBeds.Text);
            r.roomNumber = textBoxRoomnumber.Text;
            r.period = textBoxPeriod.Text;
            r.available = "y";
            Console.WriteLine(r.price);

            RoomController RController = new RoomController();

            RController.CreateRoom(r);


            /*  textBoxName.Text = "";
              textBoxPnr.Text = "";
              textBoxEmail.Text = "";
              textBoxPhone.Text = "";
              textBoxAddress.Text = ""; */


            //Console.WriteLine("Du matade in { 0}.",c.pnr);


            /*  Customer cCheck = new Customer();
              //cCheck.pnr = "defaultValue";
              string searchVar = c.pnr;
              string searchtype = "pnr";
              cCheck = CController.FindCustomer(searchVar, searchtype);

              if (cCheck.pnr == c.pnr)
              {
                  labelMessage.Text = "Personnumret du matade in finns redan.";
                  //CController.CreateCustomer(c);
                  //CController.ShowCustomer(c.pnr);
              }
              else
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

              Customer cCheck = new Customer();
              c.pnr = "35";
              c = CController.ShowCustomer("000000423456");

              labelMessage.Text = c.pnr;
              Console.WriteLine(c.pnr);

              //Console.WriteLine("Pnr:"+cCheck.pnr);
              //if (kund redan finns med inmatat pnr, ERROR!!
              //else (tack som fan för att du valde att registrera dig hos CobraHoteL!!!:D
              */

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridViewBooking1.DataSource = dt;
            dataGridViewBooking1.ClearSelection();
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAllBookings_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridViewBooking2.DataSource = dt;
            dataGridViewBooking2.ClearSelection();

            dt.Columns.Add("Bokningsnummer");
            dt.Columns.Add("Pris");
            dt.Columns.Add("Period");
            dt.Columns.Add("Pnr");
            dt.Columns.Add("Rumsnummer");
            dt.Columns.Add("RumsID");
            

           // string period = textBox1period.Text;
            

           
            BookingController BController = new BookingController();

            //RController.GetAvailableRoomsByPeriod(period, available);
            
            List<Booking> bookingList = new List<Booking>();
            bookingList = BController.FindAllBookings();
            //for (int i = 0; i < customerList.Count; i++)
            foreach (Booking b in bookingList)
            {
                //dataGridViewCustomer.Rows.Add(c.name, c.pnr, c.email, c.phone, c.address);
                //dt.Columns.Add(c.name, c.pnr, c.email, c.phone, c.address);
                DataRow row = dt.NewRow();
                row["Bokningsnummer"] = b.bookingNbr;
                row["Pris"] = b.price;
                row["Period"] = b.period;
                row["Pnr"] = b.pnr;
                row["Rumsnummer"] = b.roomNumber;
                row["RumsID"] = b.roomId;
                dt.Rows.Add(row);
            }
        }


        private void buttonBookRoom_Click(object sender, EventArgs e)
        {
            Booking b = new Booking();
            DataGridViewRow row = dataGridViewBooking1.SelectedRows[0];
            b.pnr = row.Cells["Pnr"].Value.ToString();

            DataGridViewRow row2 = dataGridViewBooking2.SelectedRows[0];
            b.roomNumber = row2.Cells["Rumsnummer"].Value.ToString();
            b.period = row2.Cells["Period"].Value.ToString();
            b.roomId = row2.Cells["RumsID"].Value.ToString();
            string price = row2.Cells["Pris"].Value.ToString();
            b.price = Convert.ToInt32(price);

            Random rnd = new Random();
            int bookingNbr = rnd.Next(100, 10000);
            b.bookingNbr = bookingNbr.ToString();
     

           BookingController BController = new BookingController();
            BController.CreateBooking(b);
            //dataGridViewCustomer.ClearSelection();
            //buttonFindAllCustomers.PerformClick();

            /*Room r = new Room();
            r.available = row.Cells["Period"].Value.ToString();

            RoomController RController = new RoomController();
            RController.UpdateRoom(r);*/

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void dataGridViewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonFindAllRooms_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridViewRoom.DataSource = dt;
            dataGridViewRoom.ClearSelection();

            dt.Columns.Add("Rumsnummer");
            dt.Columns.Add("Pris");
            dt.Columns.Add("Antal Sängar");
            dt.Columns.Add("RumsID");
            dt.Columns.Add("Ledigt");
            dt.Columns.Add("Period");

            RoomController RController = new RoomController();

            List<Room> roomList = new List<Room>();
            roomList = RController.FindAllRooms();
            //for (int i = 0; i < customerList.Count; i++)
            foreach (Room r in roomList)
            {
                //dataGridViewCustomer.Rows.Add(c.name, c.pnr, c.email, c.phone, c.address);
                //dt.Columns.Add(c.name, c.pnr, c.email, c.phone, c.address);
                DataRow row = dt.NewRow();
                row["Rumsnummer"] = r.roomNumber;
                row["Pris"] = r.price;
                row["Antal Sängar"] = r.beds;
                row["RumsID"] = r.roomId;
                row["Ledigt"] = r.available;
                row["Period"] = r.period;
                dt.Rows.Add(row);

            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            DataGridViewRow row = dataGridViewRoom.SelectedRows[0];
            
            r.roomNumber = row.Cells["Rumsnummer"].Value.ToString();
            string price = row.Cells["Pris"].Value.ToString();
            r.price = Convert.ToInt32(price);
            Console.WriteLine("PRIS"+r.price);
            //r.price = Int32.Parse(row.Cells["Pris"]);
            string beds = row.Cells["Antal Sängar"].Value.ToString();
            r.beds = Convert.ToInt32(beds);
            r.roomId = row.Cells["RumsID"].Value.ToString();
            r.available = row.Cells["Ledigt"].Value.ToString();
            r.period = row.Cells["Period"].Value.ToString();

            RoomController RController = new RoomController();
            RController.UpdateRoom(r);
            dataGridViewRoom.ClearSelection();
            buttonFindAllRooms.PerformClick();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridViewBooking2.DataSource = dt;
            dataGridViewBooking2.ClearSelection();

            dt.Columns.Add("Rumsnummer");
            dt.Columns.Add("Pris");
            dt.Columns.Add("Antal Sängar");
            dt.Columns.Add("RumsID");
            dt.Columns.Add("Ledigt");
            dt.Columns.Add("Period");

            RoomController RController = new RoomController();

            List<Room> roomList = new List<Room>();
            roomList = RController.GetAvailableRooms();
            //for (int i = 0; i < customerList.Count; i++)
            foreach (Room r in roomList)
            {
                //dataGridViewCustomer.Rows.Add(c.name, c.pnr, c.email, c.phone, c.address);
                //dt.Columns.Add(c.name, c.pnr, c.email, c.phone, c.address);
                DataRow row = dt.NewRow();
                row["Rumsnummer"] = r.roomNumber;
                row["Pris"] = r.price;
                row["Antal Sängar"] = r.beds;
                row["RumsID"] = r.roomId;
                row["Ledigt"] = r.available;
                row["Period"] = r.period;
                dt.Rows.Add(row);

            }
        }

        private void dataGridViewBooking2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }

    

