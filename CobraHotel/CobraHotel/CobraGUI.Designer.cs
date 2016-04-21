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
            this.labelSearchCByPnr = new System.Windows.Forms.Label();
            this.buttonFindCustomerByPnr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.labelSearchCustomer.Location = new System.Drawing.Point(400, 59);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(53, 13);
            this.labelSearchCustomer.TabIndex = 13;
            this.labelSearchCustomer.Text = "Sök kund";
            // 
            // textBoxSearchCByPnr
            // 
            this.textBoxSearchCByPnr.Location = new System.Drawing.Point(403, 108);
            this.textBoxSearchCByPnr.Name = "textBoxSearchCByPnr";
            this.textBoxSearchCByPnr.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchCByPnr.TabIndex = 14;
            // 
            // labelSearchCByPnr
            // 
            this.labelSearchCByPnr.AutoSize = true;
            this.labelSearchCByPnr.Location = new System.Drawing.Point(363, 110);
            this.labelSearchCByPnr.Name = "labelSearchCByPnr";
            this.labelSearchCByPnr.Size = new System.Drawing.Size(26, 13);
            this.labelSearchCByPnr.TabIndex = 15;
            this.labelSearchCByPnr.Text = "Pnr:";
            // 
            // buttonFindCustomerByPnr
            // 
            this.buttonFindCustomerByPnr.Location = new System.Drawing.Point(403, 261);
            this.buttonFindCustomerByPnr.Name = "buttonFindCustomerByPnr";
            this.buttonFindCustomerByPnr.Size = new System.Drawing.Size(75, 23);
            this.buttonFindCustomerByPnr.TabIndex = 16;
            this.buttonFindCustomerByPnr.Text = "Hitta kund";
            this.buttonFindCustomerByPnr.UseVisualStyleBackColor = true;
            this.buttonFindCustomerByPnr.Click += new System.EventHandler(this.buttonFindCustomerByPnr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(582, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CobraGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 598);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonFindCustomerByPnr);
            this.Controls.Add(this.labelSearchCByPnr);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label labelSearchCByPnr;
        private System.Windows.Forms.Button buttonFindCustomerByPnr;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

