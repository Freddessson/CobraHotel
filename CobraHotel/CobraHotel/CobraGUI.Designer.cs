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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(220, 262);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCustomer.TabIndex = 0;
            this.btnCreateCustomer.Text = "Skapa Kund";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // textBoxPnr
            // 
            this.textBoxPnr.Location = new System.Drawing.Point(220, 134);
            this.textBoxPnr.Name = "textBoxPnr";
            this.textBoxPnr.Size = new System.Drawing.Size(100, 20);
            this.textBoxPnr.TabIndex = 1;
            this.textBoxPnr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(220, 108);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(176, 111);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Namn:";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPnr
            // 
            this.labelPnr.AutoSize = true;
            this.labelPnr.Location = new System.Drawing.Point(188, 141);
            this.labelPnr.Name = "labelPnr";
            this.labelPnr.Size = new System.Drawing.Size(26, 13);
            this.labelPnr.TabIndex = 4;
            this.labelPnr.Text = "Pnr:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(220, 161);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(220, 188);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(220, 215);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(179, 168);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            this.labelEmail.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(173, 195);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Phone:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(166, 218);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 10;
            this.labelAddress.Text = "Address:";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(169, 403);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 11;
            this.labelMessage.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelCreateCustomerTitle
            // 
            this.labelCreateCustomerTitle.AutoSize = true;
            this.labelCreateCustomerTitle.Location = new System.Drawing.Point(220, 59);
            this.labelCreateCustomerTitle.Name = "labelCreateCustomerTitle";
            this.labelCreateCustomerTitle.Size = new System.Drawing.Size(65, 13);
            this.labelCreateCustomerTitle.TabIndex = 12;
            this.labelCreateCustomerTitle.Text = "Skapa kund";
            this.labelCreateCustomerTitle.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // labelSearchCustomer
            // 
            this.labelSearchCustomer.AutoSize = true;
            this.labelSearchCustomer.Location = new System.Drawing.Point(579, 290);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(53, 13);
            this.labelSearchCustomer.TabIndex = 13;
            this.labelSearchCustomer.Text = "Sök kund";
            // 
            // textBoxSearchCByPnr
            // 
            this.textBoxSearchCByPnr.Location = new System.Drawing.Point(582, 346);
            this.textBoxSearchCByPnr.Name = "textBoxSearchCByPnr";
            this.textBoxSearchCByPnr.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchCByPnr.TabIndex = 14;
            this.textBoxSearchCByPnr.TextChanged += new System.EventHandler(this.textBoxSearchCByPnr_TextChanged);
            // 
            // buttonFindCustomerByPnr
            // 
            this.buttonFindCustomerByPnr.Location = new System.Drawing.Point(582, 372);
            this.buttonFindCustomerByPnr.Name = "buttonFindCustomerByPnr";
            this.buttonFindCustomerByPnr.Size = new System.Drawing.Size(75, 23);
            this.buttonFindCustomerByPnr.TabIndex = 16;
            this.buttonFindCustomerByPnr.Text = "Hitta kund";
            this.buttonFindCustomerByPnr.UseVisualStyleBackColor = true;
            this.buttonFindCustomerByPnr.Click += new System.EventHandler(this.buttonFindCustomerByPnr_Click);
            // 
            // buttonFindAllCustomers
            // 
            this.buttonFindAllCustomers.Location = new System.Drawing.Point(966, 280);
            this.buttonFindAllCustomers.Name = "buttonFindAllCustomers";
            this.buttonFindAllCustomers.Size = new System.Drawing.Size(75, 23);
            this.buttonFindAllCustomers.TabIndex = 18;
            this.buttonFindAllCustomers.Text = "Alla kunder";
            this.buttonFindAllCustomers.UseVisualStyleBackColor = true;
            this.buttonFindAllCustomers.Click += new System.EventHandler(this.buttonFindAllCustomers_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(582, 59);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(573, 201);
            this.dataGridViewCustomer.TabIndex = 20;
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(1047, 279);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCustomer.TabIndex = 21;
            this.buttonDeleteCustomer.Text = "Ta bort";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.Location = new System.Drawing.Point(885, 280);
            this.buttonEditCustomer.Name = "buttonEditCustomer";
            this.buttonEditCustomer.Size = new System.Drawing.Size(75, 23);
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
            this.comboBoxSearchType.Location = new System.Drawing.Point(582, 319);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchType.TabIndex = 23;
            this.comboBoxSearchType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchType_SelectedIndexChanged);
            // 
            // buttonAvailableRoomsByPeriod
            // 
            this.buttonAvailableRoomsByPeriod.Location = new System.Drawing.Point(220, 429);
            this.buttonAvailableRoomsByPeriod.Name = "buttonAvailableRoomsByPeriod";
            this.buttonAvailableRoomsByPeriod.Size = new System.Drawing.Size(75, 23);
            this.buttonAvailableRoomsByPeriod.TabIndex = 24;
            this.buttonAvailableRoomsByPeriod.Text = "Lediga rum";
            this.buttonAvailableRoomsByPeriod.UseVisualStyleBackColor = true;
            this.buttonAvailableRoomsByPeriod.Click += new System.EventHandler(this.buttonAvailableRoomsByPeriod_Click);
            // 
            // CobraGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 598);
            this.Controls.Add(this.buttonAvailableRoomsByPeriod);
            this.Controls.Add(this.comboBoxSearchType);
            this.Controls.Add(this.buttonEditCustomer);
            this.Controls.Add(this.buttonDeleteCustomer);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.buttonFindAllCustomers);
            this.Controls.Add(this.buttonFindCustomerByPnr);
            this.Controls.Add(this.textBoxSearchCByPnr);
            this.Controls.Add(this.labelSearchCustomer);
            this.Controls.Add(this.labelCreateCustomerTitle);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPnr);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPnr);
            this.Controls.Add(this.btnCreateCustomer);
            this.Name = "CobraGUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CobraGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
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
    }
}

