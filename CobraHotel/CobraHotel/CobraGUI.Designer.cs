using System.Windows.Forms;

namespace View
{
    partial class CobraGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.textBoxPnr = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPnr = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelCreateCustomerTitle = new System.Windows.Forms.Label();
            this.labelSearchCustomer = new System.Windows.Forms.Label();
            this.textBoxSearchCByPnr = new System.Windows.Forms.TextBox();
            this.buttonFindCustomerByPnr = new System.Windows.Forms.Button();
            this.buttonFindAllCustomers = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonEditCustomer = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.buttonAvailableRoomsByPeriod = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.textBoxRoomnumber = new System.Windows.Forms.TextBox();
            this.textBoxBeds = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelRoomID = new System.Windows.Forms.Label();
            this.labelBeds = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelRoomnumber = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1Available = new System.Windows.Forms.TextBox();
            this.textBox1period = new System.Windows.Forms.TextBox();
            this.BokaRum = new System.Windows.Forms.Button();
            this.AllaRum = new System.Windows.Forms.Button();
            this.AllaKunder = new System.Windows.Forms.Button();
            this.dataGridViewBooking1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewBooking2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(68, 178);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCustomer.TabIndex = 10;
            this.btnCreateCustomer.Text = "Skapa Kund";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // textBoxPnr
            // 
            this.textBoxPnr.Location = new System.Drawing.Point(68, 75);
            this.textBoxPnr.Name = "textBoxPnr";
            this.textBoxPnr.Size = new System.Drawing.Size(100, 20);
            this.textBoxPnr.TabIndex = 6;
            this.textBoxPnr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(68, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Namn:";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPnr
            // 
            this.labelPnr.AutoSize = true;
            this.labelPnr.Location = new System.Drawing.Point(36, 82);
            this.labelPnr.Name = "labelPnr";
            this.labelPnr.Size = new System.Drawing.Size(26, 13);
            this.labelPnr.TabIndex = 1;
            this.labelPnr.Text = "Pnr:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(68, 102);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(68, 129);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(68, 156);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 9;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(27, 109);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            this.labelEmail.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(21, 136);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(14, 159);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Address:";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(169, 403);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelCreateCustomerTitle
            // 
            this.labelCreateCustomerTitle.AutoSize = true;
            this.labelCreateCustomerTitle.Location = new System.Drawing.Point(54, -81);
            this.labelCreateCustomerTitle.Name = "labelCreateCustomerTitle";
            this.labelCreateCustomerTitle.Size = new System.Drawing.Size(65, 13);
            this.labelCreateCustomerTitle.TabIndex = 12;
            this.labelCreateCustomerTitle.Text = "Skapa kund";
            this.labelCreateCustomerTitle.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // labelSearchCustomer
            // 
            this.labelSearchCustomer.AutoSize = true;
            this.labelSearchCustomer.Location = new System.Drawing.Point(266, 216);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(53, 13);
            this.labelSearchCustomer.TabIndex = 11;
            this.labelSearchCustomer.Text = "Sök kund";
            // 
            // textBoxSearchCByPnr
            // 
            this.textBoxSearchCByPnr.Location = new System.Drawing.Point(265, 259);
            this.textBoxSearchCByPnr.Name = "textBoxSearchCByPnr";
            this.textBoxSearchCByPnr.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchCByPnr.TabIndex = 13;
            this.textBoxSearchCByPnr.TextChanged += new System.EventHandler(this.textBoxSearchCByPnr_TextChanged);
            // 
            // buttonFindCustomerByPnr
            // 
            this.buttonFindCustomerByPnr.Location = new System.Drawing.Point(265, 285);
            this.buttonFindCustomerByPnr.Name = "buttonFindCustomerByPnr";
            this.buttonFindCustomerByPnr.Size = new System.Drawing.Size(75, 23);
            this.buttonFindCustomerByPnr.TabIndex = 14;
            this.buttonFindCustomerByPnr.Text = "Hitta kund";
            this.buttonFindCustomerByPnr.UseVisualStyleBackColor = true;
            this.buttonFindCustomerByPnr.Click += new System.EventHandler(this.buttonFindCustomerByPnr_Click);
            // 
            // buttonFindAllCustomers
            // 
            this.buttonFindAllCustomers.Location = new System.Drawing.Point(677, 259);
            this.buttonFindAllCustomers.Name = "buttonFindAllCustomers";
            this.buttonFindAllCustomers.Size = new System.Drawing.Size(75, 23);
            this.buttonFindAllCustomers.TabIndex = 16;
            this.buttonFindAllCustomers.Text = "Alla kunder";
            this.buttonFindAllCustomers.UseVisualStyleBackColor = true;
            this.buttonFindAllCustomers.Click += new System.EventHandler(this.buttonFindAllCustomers_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(265, 12);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(573, 201);
            this.dataGridViewCustomer.TabIndex = 18;
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(758, 259);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCustomer.TabIndex = 17;
            this.buttonDeleteCustomer.Text = "Ta bort";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.Location = new System.Drawing.Point(596, 259);
            this.buttonEditCustomer.Name = "buttonEditCustomer";
            this.buttonEditCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonEditCustomer.TabIndex = 15;
            this.buttonEditCustomer.Text = "Ändra";
            this.buttonEditCustomer.UseVisualStyleBackColor = true;
            this.buttonEditCustomer.Click += new System.EventHandler(this.buttonEditCustomer_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "pnr",
            "email"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(265, 232);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchType.TabIndex = 12;
            this.comboBoxSearchType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchType_SelectedIndexChanged);
            // 
            // buttonAvailableRoomsByPeriod
            // 
            this.buttonAvailableRoomsByPeriod.Location = new System.Drawing.Point(68, 285);
            this.buttonAvailableRoomsByPeriod.Name = "buttonAvailableRoomsByPeriod";
            this.buttonAvailableRoomsByPeriod.Size = new System.Drawing.Size(75, 23);
            this.buttonAvailableRoomsByPeriod.TabIndex = 19;
            this.buttonAvailableRoomsByPeriod.Text = "Lediga rum";
            this.buttonAvailableRoomsByPeriod.UseVisualStyleBackColor = true;
            this.buttonAvailableRoomsByPeriod.Click += new System.EventHandler(this.buttonAvailableRoomsByPeriod_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 577);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelPnr);
            this.tabPage1.Controls.Add(this.buttonDeleteCustomer);
            this.tabPage1.Controls.Add(this.buttonAvailableRoomsByPeriod);
            this.tabPage1.Controls.Add(this.btnCreateCustomer);
            this.tabPage1.Controls.Add(this.buttonEditCustomer);
            this.tabPage1.Controls.Add(this.comboBoxSearchType);
            this.tabPage1.Controls.Add(this.buttonFindAllCustomers);
            this.tabPage1.Controls.Add(this.textBoxPnr);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.labelName);
            this.tabPage1.Controls.Add(this.dataGridViewCustomer);
            this.tabPage1.Controls.Add(this.buttonFindCustomerByPnr);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Controls.Add(this.textBoxSearchCByPnr);
            this.tabPage1.Controls.Add(this.textBoxPhone);
            this.tabPage1.Controls.Add(this.labelSearchCustomer);
            this.tabPage1.Controls.Add(this.textBoxAddress);
            this.tabPage1.Controls.Add(this.labelEmail);
            this.tabPage1.Controls.Add(this.labelPhone);
            this.tabPage1.Controls.Add(this.labelCreateCustomerTitle);
            this.tabPage1.Controls.Add(this.labelAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(1075, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCreateRoom);
            this.tabPage2.Controls.Add(this.textBoxPeriod);
            this.tabPage2.Controls.Add(this.textBoxRoomnumber);
            this.tabPage2.Controls.Add(this.textBoxBeds);
            this.tabPage2.Controls.Add(this.textBoxPrice);
            this.tabPage2.Controls.Add(this.textBoxRoomID);
            this.tabPage2.Controls.Add(this.labelPeriod);
            this.tabPage2.Controls.Add(this.labelRoomID);
            this.tabPage2.Controls.Add(this.labelBeds);
            this.tabPage2.Controls.Add(this.labelPrice);
            this.tabPage2.Controls.Add(this.labelRoomnumber);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage2.Size = new System.Drawing.Size(1075, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Room";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(105, 211);
            this.btnCreateRoom.Margin = new System.Windows.Forms.Padding(1);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(84, 25);
            this.btnCreateRoom.TabIndex = 10;
            this.btnCreateRoom.Text = "Create room";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(186, 166);
            this.textBoxPeriod.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(85, 20);
            this.textBoxPeriod.TabIndex = 9;
            // 
            // textBoxRoomnumber
            // 
            this.textBoxRoomnumber.Location = new System.Drawing.Point(186, 143);
            this.textBoxRoomnumber.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxRoomnumber.Name = "textBoxRoomnumber";
            this.textBoxRoomnumber.Size = new System.Drawing.Size(85, 20);
            this.textBoxRoomnumber.TabIndex = 8;
            // 
            // textBoxBeds
            // 
            this.textBoxBeds.Location = new System.Drawing.Point(186, 119);
            this.textBoxBeds.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxBeds.Name = "textBoxBeds";
            this.textBoxBeds.Size = new System.Drawing.Size(85, 20);
            this.textBoxBeds.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(186, 99);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(85, 20);
            this.textBoxPrice.TabIndex = 6;
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(186, 76);
            this.textBoxRoomID.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.Size = new System.Drawing.Size(85, 20);
            this.textBoxRoomID.TabIndex = 5;
            this.textBoxRoomID.TextChanged += new System.EventHandler(this.textBoxRoomID_TextChanged);
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(101, 166);
            this.labelPeriod.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(40, 13);
            this.labelPeriod.TabIndex = 4;
            this.labelPeriod.Text = "Period:";
            // 
            // labelRoomID
            // 
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Location = new System.Drawing.Point(101, 76);
            this.labelRoomID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(49, 13);
            this.labelRoomID.TabIndex = 3;
            this.labelRoomID.Text = "RoomID:";
            // 
            // labelBeds
            // 
            this.labelBeds.AutoSize = true;
            this.labelBeds.Location = new System.Drawing.Point(101, 121);
            this.labelBeds.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBeds.Name = "labelBeds";
            this.labelBeds.Size = new System.Drawing.Size(34, 13);
            this.labelBeds.TabIndex = 2;
            this.labelBeds.Text = "Beds:";
            this.labelBeds.Click += new System.EventHandler(this.labelBeds_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(101, 99);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price:";
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // labelRoomnumber
            // 
            this.labelRoomnumber.AutoSize = true;
            this.labelRoomnumber.Location = new System.Drawing.Point(101, 143);
            this.labelRoomnumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelRoomnumber.Name = "labelRoomnumber";
            this.labelRoomnumber.Size = new System.Drawing.Size(73, 13);
            this.labelRoomnumber.TabIndex = 0;
            this.labelRoomnumber.Text = "Roomnumber:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1Available);
            this.tabPage3.Controls.Add(this.textBox1period);
            this.tabPage3.Controls.Add(this.BokaRum);
            this.tabPage3.Controls.Add(this.AllaRum);
            this.tabPage3.Controls.Add(this.AllaKunder);
            this.tabPage3.Controls.Add(this.dataGridViewBooking1);
            this.tabPage3.Controls.Add(this.dataGridViewBooking2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage3.Size = new System.Drawing.Size(1075, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Booking";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // textBox1Available
            // 
            this.textBox1Available.Location = new System.Drawing.Point(509, 352);
            this.textBox1Available.Name = "textBox1Available";
            this.textBox1Available.Size = new System.Drawing.Size(78, 20);
            this.textBox1Available.TabIndex = 6;
            this.textBox1Available.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // textBox1period
            // 
            this.textBox1period.Location = new System.Drawing.Point(509, 326);
            this.textBox1period.Name = "textBox1period";
            this.textBox1period.Size = new System.Drawing.Size(78, 20);
            this.textBox1period.TabIndex = 5;
            this.textBox1period.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // BokaRum
            // 
            this.BokaRum.Location = new System.Drawing.Point(509, 371);
            this.BokaRum.Name = "BokaRum";
            this.BokaRum.Size = new System.Drawing.Size(75, 23);
            this.BokaRum.TabIndex = 4;
            this.BokaRum.Text = "Boka rum";
            this.BokaRum.UseVisualStyleBackColor = true;
            this.BokaRum.Click += new System.EventHandler(this.button3_Click);
            // 
            // AllaRum
            // 
            this.AllaRum.Location = new System.Drawing.Point(593, 326);
            this.AllaRum.Name = "AllaRum";
            this.AllaRum.Size = new System.Drawing.Size(75, 23);
            this.AllaRum.TabIndex = 3;
            this.AllaRum.Text = "Alla rum";
            this.AllaRum.UseVisualStyleBackColor = true;
            this.AllaRum.Click += new System.EventHandler(this.button2_Click);
            // 
            // AllaKunder
            // 
            this.AllaKunder.Location = new System.Drawing.Point(19, 326);
            this.AllaKunder.Name = "AllaKunder";
            this.AllaKunder.Size = new System.Drawing.Size(75, 23);
            this.AllaKunder.TabIndex = 2;
            this.AllaKunder.Text = "Alla kunder";
            this.AllaKunder.UseVisualStyleBackColor = true;
            this.AllaKunder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridViewBooking1
            // 
            this.dataGridViewBooking1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking1.Location = new System.Drawing.Point(19, 14);
            this.dataGridViewBooking1.Name = "dataGridViewBooking1";
            this.dataGridViewBooking1.Size = new System.Drawing.Size(475, 288);
            this.dataGridViewBooking1.TabIndex = 1;
            this.dataGridViewBooking1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewBooking2
            // 
            this.dataGridViewBooking2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking2.Location = new System.Drawing.Point(509, 14);
            this.dataGridViewBooking2.Name = "dataGridViewBooking2";
            this.dataGridViewBooking2.Size = new System.Drawing.Size(472, 288);
            this.dataGridViewBooking2.TabIndex = 0;
            // 
            // CobraGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 447);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelMessage);
            this.Name = "CobraGUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CobraGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.TextBox textBoxPnr;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPnr;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelCreateCustomerTitle;
        private System.Windows.Forms.Label labelSearchCustomer;
        private System.Windows.Forms.TextBox textBoxSearchCByPnr;
        private System.Windows.Forms.Button buttonFindCustomerByPnr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name2;
        private System.Windows.Forms.Button buttonFindAllCustomers;
        private DataGridView dataGridViewCustomer;
        private Button buttonDeleteCustomer;
        private Button buttonEditCustomer;
        private ToolTip toolTip1;
        private ComboBox comboBoxSearchType;
        private Button buttonAvailableRoomsByPeriod;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label labelPeriod;
        private Label labelRoomID;
        private Label labelBeds;
        private Label labelPrice;
        private Label labelRoomnumber;
        private TabPage tabPage3;
        private TextBox textBoxBeds;
        private TextBox textBoxPrice;
        private TextBox textBoxRoomID;
        private TextBox textBoxPeriod;
        private TextBox textBoxRoomnumber;
        private Button btnCreateRoom;
        private Button AllaKunder;
        private DataGridView dataGridViewBooking1;
        private DataGridView dataGridViewBooking2;
        private Button AllaRum;
        private Button BokaRum;
        private TextBox textBox1period;
        private TextBox textBox1Available;
    }
}

