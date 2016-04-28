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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelRoom = new System.Windows.Forms.Label();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.buttonFindAllRooms = new System.Windows.Forms.Button();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
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
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnAllRooms = new System.Windows.Forms.Button();
            this.BokaRum = new System.Windows.Forms.Button();
            this.btnAllBookings = new System.Windows.Forms.Button();
            this.AllaKunder = new System.Windows.Forms.Button();
            this.dataGridViewBooking1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewBooking2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(68, 183);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(98, 23);
            this.btnCreateCustomer.TabIndex = 10;
            this.btnCreateCustomer.Text = "Skapa kund";
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
            this.labelName.Location = new System.Drawing.Point(24, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Namn:";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPnr
            // 
            this.labelPnr.AutoSize = true;
            this.labelPnr.Location = new System.Drawing.Point(24, 75);
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
            this.labelEmail.Location = new System.Drawing.Point(24, 102);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            this.labelEmail.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(24, 129);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(46, 13);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Telefon:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(24, 156);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(42, 13);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Adress:";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(66, 235);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 1;
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
            this.buttonFindAllCustomers.Location = new System.Drawing.Point(578, 259);
            this.buttonFindAllCustomers.Name = "buttonFindAllCustomers";
            this.buttonFindAllCustomers.Size = new System.Drawing.Size(75, 23);
            this.buttonFindAllCustomers.TabIndex = 16;
            this.buttonFindAllCustomers.Text = "Alla kunder";
            this.buttonFindAllCustomers.UseVisualStyleBackColor = true;
            this.buttonFindAllCustomers.Click += new System.EventHandler(this.buttonFindAllCustomers_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(265, 12);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(561, 201);
            this.dataGridViewCustomer.TabIndex = 18;
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(751, 259);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCustomer.TabIndex = 17;
            this.buttonDeleteCustomer.Text = "Ta bort";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.Location = new System.Drawing.Point(665, 259);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelPnr);
            this.tabPage1.Controls.Add(this.labelMessage);
            this.tabPage1.Controls.Add(this.buttonDeleteCustomer);
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
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Size = new System.Drawing.Size(993, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kund";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelRoom);
            this.tabPage2.Controls.Add(this.btnUpdateRoom);
            this.tabPage2.Controls.Add(this.buttonFindAllRooms);
            this.tabPage2.Controls.Add(this.dataGridViewRoom);
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
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage2.Size = new System.Drawing.Size(993, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rum";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(89, 211);
            this.labelRoom.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(0, 13);
            this.labelRoom.TabIndex = 19;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Location = new System.Drawing.Point(406, 285);
            this.btnUpdateRoom.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(107, 25);
            this.btnUpdateRoom.TabIndex = 12;
            this.btnUpdateRoom.Text = "Uppdatera";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // buttonFindAllRooms
            // 
            this.buttonFindAllRooms.Location = new System.Drawing.Point(294, 285);
            this.buttonFindAllRooms.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonFindAllRooms.Name = "buttonFindAllRooms";
            this.buttonFindAllRooms.Size = new System.Drawing.Size(94, 27);
            this.buttonFindAllRooms.TabIndex = 11;
            this.buttonFindAllRooms.Text = "Lista alla rum";
            this.buttonFindAllRooms.UseVisualStyleBackColor = true;
            this.buttonFindAllRooms.Click += new System.EventHandler(this.buttonFindAllRooms_Click);
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Location = new System.Drawing.Point(294, 24);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.RowTemplate.Height = 40;
            this.dataGridViewRoom.Size = new System.Drawing.Size(556, 241);
            this.dataGridViewRoom.TabIndex = 18;
            this.dataGridViewRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellContentClick);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(128, 165);
            this.btnCreateRoom.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(82, 23);
            this.btnCreateRoom.TabIndex = 10;
            this.btnCreateRoom.Text = "Skapa rum";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(128, 134);
            this.textBoxPeriod.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(85, 20);
            this.textBoxPeriod.TabIndex = 9;
            // 
            // textBoxRoomnumber
            // 
            this.textBoxRoomnumber.Location = new System.Drawing.Point(128, 62);
            this.textBoxRoomnumber.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxRoomnumber.Name = "textBoxRoomnumber";
            this.textBoxRoomnumber.Size = new System.Drawing.Size(85, 20);
            this.textBoxRoomnumber.TabIndex = 6;
            // 
            // textBoxBeds
            // 
            this.textBoxBeds.Location = new System.Drawing.Point(128, 111);
            this.textBoxBeds.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxBeds.Name = "textBoxBeds";
            this.textBoxBeds.Size = new System.Drawing.Size(85, 20);
            this.textBoxBeds.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(128, 86);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(85, 20);
            this.textBoxPrice.TabIndex = 7;
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(128, 39);
            this.textBoxRoomID.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.Size = new System.Drawing.Size(85, 20);
            this.textBoxRoomID.TabIndex = 5;
            this.textBoxRoomID.TextChanged += new System.EventHandler(this.textBoxRoomID_TextChanged);
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(43, 134);
            this.labelPeriod.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(40, 13);
            this.labelPeriod.TabIndex = 4;
            this.labelPeriod.Text = "Period:";
            // 
            // labelRoomID
            // 
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Location = new System.Drawing.Point(43, 39);
            this.labelRoomID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(48, 13);
            this.labelRoomID.TabIndex = 0;
            this.labelRoomID.Text = "RumsID:";
            // 
            // labelBeds
            // 
            this.labelBeds.AutoSize = true;
            this.labelBeds.Location = new System.Drawing.Point(43, 111);
            this.labelBeds.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBeds.Name = "labelBeds";
            this.labelBeds.Size = new System.Drawing.Size(69, 13);
            this.labelBeds.TabIndex = 3;
            this.labelBeds.Text = "Antal sängar:";
            this.labelBeds.Click += new System.EventHandler(this.labelBeds_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(43, 86);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(27, 13);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Pris:";
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // labelRoomnumber
            // 
            this.labelRoomnumber.AutoSize = true;
            this.labelRoomnumber.Location = new System.Drawing.Point(43, 62);
            this.labelRoomnumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelRoomnumber.Name = "labelRoomnumber";
            this.labelRoomnumber.Size = new System.Drawing.Size(74, 13);
            this.labelRoomnumber.TabIndex = 1;
            this.labelRoomnumber.Text = "Rumsnummer:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeleteBooking);
            this.tabPage3.Controls.Add(this.btnAllRooms);
            this.tabPage3.Controls.Add(this.BokaRum);
            this.tabPage3.Controls.Add(this.btnAllBookings);
            this.tabPage3.Controls.Add(this.AllaKunder);
            this.tabPage3.Controls.Add(this.dataGridViewBooking1);
            this.tabPage3.Controls.Add(this.dataGridViewBooking2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage3.Size = new System.Drawing.Size(993, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bokning";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(702, 326);
            this.btnDeleteBooking.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(92, 23);
            this.btnDeleteBooking.TabIndex = 6;
            this.btnDeleteBooking.Text = "Ta bort bokning";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnAllRooms
            // 
            this.btnAllRooms.Location = new System.Drawing.Point(509, 326);
            this.btnAllRooms.Name = "btnAllRooms";
            this.btnAllRooms.Size = new System.Drawing.Size(75, 23);
            this.btnAllRooms.TabIndex = 5;
            this.btnAllRooms.Text = "Lediga rum";
            this.btnAllRooms.UseVisualStyleBackColor = true;
            this.btnAllRooms.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // BokaRum
            // 
            this.BokaRum.Location = new System.Drawing.Point(906, 326);
            this.BokaRum.Name = "BokaRum";
            this.BokaRum.Size = new System.Drawing.Size(75, 23);
            this.BokaRum.TabIndex = 4;
            this.BokaRum.Text = "Boka rum";
            this.BokaRum.UseVisualStyleBackColor = true;
            this.BokaRum.Click += new System.EventHandler(this.buttonBookRoom_Click);
            // 
            // btnAllBookings
            // 
            this.btnAllBookings.Location = new System.Drawing.Point(597, 326);
            this.btnAllBookings.Name = "btnAllBookings";
            this.btnAllBookings.Size = new System.Drawing.Size(89, 23);
            this.btnAllBookings.TabIndex = 3;
            this.btnAllBookings.Text = "Alla bokningar";
            this.btnAllBookings.UseVisualStyleBackColor = true;
            this.btnAllBookings.Click += new System.EventHandler(this.btnAllBookings_Click);
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
            this.dataGridViewBooking1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooking1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking1.Location = new System.Drawing.Point(19, 14);
            this.dataGridViewBooking1.Name = "dataGridViewBooking1";
            this.dataGridViewBooking1.Size = new System.Drawing.Size(475, 288);
            this.dataGridViewBooking1.TabIndex = 1;
            this.dataGridViewBooking1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewBooking2
            // 
            this.dataGridViewBooking2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooking2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking2.Location = new System.Drawing.Point(509, 14);
            this.dataGridViewBooking2.Name = "dataGridViewBooking2";
            this.dataGridViewBooking2.Size = new System.Drawing.Size(472, 288);
            this.dataGridViewBooking2.TabIndex = 0;
            this.dataGridViewBooking2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooking2_CellContentClick);
            // 
            // CobraGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 441);
            this.Controls.Add(this.tabControl1);
            this.Name = "CobraGUI";
            this.Text = "CobraGUI";
            this.Load += new System.EventHandler(this.CobraGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking2)).EndInit();
            this.ResumeLayout(false);

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
        private Button btnAllBookings;
        private Button BokaRum;
        private DataGridView dataGridViewRoom;
        private Button buttonFindAllRooms;
        private Button btnUpdateRoom;
        private Button btnAllRooms;
        private Button btnDeleteBooking;
        private Label labelRoom;
    }
}

