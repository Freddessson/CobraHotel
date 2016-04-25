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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(182, 425);
            this.btnCreateCustomer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(200, 55);
            this.btnCreateCustomer.TabIndex = 0;
            this.btnCreateCustomer.Text = "Skapa Kund";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // textBoxPnr
            // 
            this.textBoxPnr.Location = new System.Drawing.Point(182, 180);
            this.textBoxPnr.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxPnr.Name = "textBoxPnr";
            this.textBoxPnr.Size = new System.Drawing.Size(260, 38);
            this.textBoxPnr.TabIndex = 1;
            this.textBoxPnr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(182, 118);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(260, 38);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(64, 125);
            this.labelName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(98, 32);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Namn:";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPnr
            // 
            this.labelPnr.AutoSize = true;
            this.labelPnr.Location = new System.Drawing.Point(96, 196);
            this.labelPnr.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelPnr.Name = "labelPnr";
            this.labelPnr.Size = new System.Drawing.Size(67, 32);
            this.labelPnr.TabIndex = 4;
            this.labelPnr.Text = "Pnr:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(182, 244);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(260, 38);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(182, 308);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(260, 38);
            this.textBoxPhone.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(182, 373);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(260, 38);
            this.textBoxAddress.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(72, 261);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(95, 32);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            this.labelEmail.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(56, 325);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(106, 32);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Phone:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(38, 380);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(127, 32);
            this.labelAddress.TabIndex = 10;
            this.labelAddress.Text = "Address:";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(451, 961);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 32);
            this.labelMessage.TabIndex = 11;
            this.labelMessage.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelCreateCustomerTitle
            // 
            this.labelCreateCustomerTitle.AutoSize = true;
            this.labelCreateCustomerTitle.Location = new System.Drawing.Point(145, -192);
            this.labelCreateCustomerTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelCreateCustomerTitle.Name = "labelCreateCustomerTitle";
            this.labelCreateCustomerTitle.Size = new System.Drawing.Size(165, 32);
            this.labelCreateCustomerTitle.TabIndex = 12;
            this.labelCreateCustomerTitle.Text = "Skapa kund";
            this.labelCreateCustomerTitle.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // labelSearchCustomer
            // 
            this.labelSearchCustomer.AutoSize = true;
            this.labelSearchCustomer.Location = new System.Drawing.Point(709, 514);
            this.labelSearchCustomer.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(133, 32);
            this.labelSearchCustomer.TabIndex = 13;
            this.labelSearchCustomer.Text = "Sök kund";
            // 
            // textBoxSearchCByPnr
            // 
            this.textBoxSearchCByPnr.Location = new System.Drawing.Point(707, 617);
            this.textBoxSearchCByPnr.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxSearchCByPnr.Name = "textBoxSearchCByPnr";
            this.textBoxSearchCByPnr.Size = new System.Drawing.Size(260, 38);
            this.textBoxSearchCByPnr.TabIndex = 14;
            this.textBoxSearchCByPnr.TextChanged += new System.EventHandler(this.textBoxSearchCByPnr_TextChanged);
            // 
            // buttonFindCustomerByPnr
            // 
            this.buttonFindCustomerByPnr.Location = new System.Drawing.Point(707, 679);
            this.buttonFindCustomerByPnr.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonFindCustomerByPnr.Name = "buttonFindCustomerByPnr";
            this.buttonFindCustomerByPnr.Size = new System.Drawing.Size(200, 55);
            this.buttonFindCustomerByPnr.TabIndex = 16;
            this.buttonFindCustomerByPnr.Text = "Hitta kund";
            this.buttonFindCustomerByPnr.UseVisualStyleBackColor = true;
            this.buttonFindCustomerByPnr.Click += new System.EventHandler(this.buttonFindCustomerByPnr_Click);
            // 
            // buttonFindAllCustomers
            // 
            this.buttonFindAllCustomers.Location = new System.Drawing.Point(1805, 617);
            this.buttonFindAllCustomers.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonFindAllCustomers.Name = "buttonFindAllCustomers";
            this.buttonFindAllCustomers.Size = new System.Drawing.Size(200, 55);
            this.buttonFindAllCustomers.TabIndex = 18;
            this.buttonFindAllCustomers.Text = "Alla kunder";
            this.buttonFindAllCustomers.UseVisualStyleBackColor = true;
            this.buttonFindAllCustomers.Click += new System.EventHandler(this.buttonFindAllCustomers_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(707, 28);
            this.dataGridViewCustomer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(1528, 479);
            this.dataGridViewCustomer.TabIndex = 20;
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(2021, 617);
            this.buttonDeleteCustomer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(200, 55);
            this.buttonDeleteCustomer.TabIndex = 21;
            this.buttonDeleteCustomer.Text = "Ta bort";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.Location = new System.Drawing.Point(1589, 617);
            this.buttonEditCustomer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonEditCustomer.Name = "buttonEditCustomer";
            this.buttonEditCustomer.Size = new System.Drawing.Size(200, 55);
            this.buttonEditCustomer.TabIndex = 22;
            this.buttonEditCustomer.Text = "Ändra";
            this.buttonEditCustomer.UseVisualStyleBackColor = true;
            this.buttonEditCustomer.Click += new System.EventHandler(this.buttonEditCustomer_Click);
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "pnr",
            "email"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(707, 553);
            this.comboBoxSearchType.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(316, 39);
            this.comboBoxSearchType.TabIndex = 23;
            this.comboBoxSearchType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchType_SelectedIndexChanged);
            // 
            // buttonAvailableRoomsByPeriod
            // 
            this.buttonAvailableRoomsByPeriod.Location = new System.Drawing.Point(182, 679);
            this.buttonAvailableRoomsByPeriod.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonAvailableRoomsByPeriod.Name = "buttonAvailableRoomsByPeriod";
            this.buttonAvailableRoomsByPeriod.Size = new System.Drawing.Size(200, 55);
            this.buttonAvailableRoomsByPeriod.TabIndex = 24;
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2888, 1375);
            this.tabControl1.TabIndex = 25;
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
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2868, 1317);
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
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2868, 1317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Room";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(281, 504);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(223, 60);
            this.btnCreateRoom.TabIndex = 10;
            this.btnCreateRoom.Text = "Create room";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(496, 397);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(220, 38);
            this.textBoxPeriod.TabIndex = 9;
            // 
            // textBoxRoomnumber
            // 
            this.textBoxRoomnumber.Location = new System.Drawing.Point(496, 340);
            this.textBoxRoomnumber.Name = "textBoxRoomnumber";
            this.textBoxRoomnumber.Size = new System.Drawing.Size(220, 38);
            this.textBoxRoomnumber.TabIndex = 8;
            // 
            // textBoxBeds
            // 
            this.textBoxBeds.Location = new System.Drawing.Point(496, 283);
            this.textBoxBeds.Name = "textBoxBeds";
            this.textBoxBeds.Size = new System.Drawing.Size(220, 38);
            this.textBoxBeds.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(496, 235);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(220, 38);
            this.textBoxPrice.TabIndex = 6;
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(496, 181);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.Size = new System.Drawing.Size(220, 38);
            this.textBoxRoomID.TabIndex = 5;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(269, 397);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(106, 32);
            this.labelPeriod.TabIndex = 4;
            this.labelPeriod.Text = "Period:";
            // 
            // labelRoomID
            // 
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Location = new System.Drawing.Point(269, 181);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(125, 32);
            this.labelRoomID.TabIndex = 3;
            this.labelRoomID.Text = "RoomID:";
            // 
            // labelBeds
            // 
            this.labelBeds.AutoSize = true;
            this.labelBeds.Location = new System.Drawing.Point(269, 289);
            this.labelBeds.Name = "labelBeds";
            this.labelBeds.Size = new System.Drawing.Size(88, 32);
            this.labelBeds.TabIndex = 2;
            this.labelBeds.Text = "Beds:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(269, 235);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(88, 32);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price:";
            // 
            // labelRoomnumber
            // 
            this.labelRoomnumber.AutoSize = true;
            this.labelRoomnumber.Location = new System.Drawing.Point(269, 340);
            this.labelRoomnumber.Name = "labelRoomnumber";
            this.labelRoomnumber.Size = new System.Drawing.Size(194, 32);
            this.labelRoomnumber.TabIndex = 0;
            this.labelRoomnumber.Text = "Roomnumber:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(2868, 1317);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Booking";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // CobraGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3587, 1426);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelMessage);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CobraGUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CobraGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}

