namespace Project.Forms.Customers
{
    partial class CustomersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersList));
            this.refreshListBTN = new System.Windows.Forms.Button();
            this.searchByNameBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchedName = new System.Windows.Forms.TextBox();
            this.searchByMobileBTN = new System.Windows.Forms.Button();
            this.codeSearch = new System.Windows.Forms.Label();
            this.searchedMobile = new System.Windows.Forms.TextBox();
            this.CustomersGridViewList = new System.Windows.Forms.DataGridView();
            this.customerWebsiteTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.customerMobileTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerFaxTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customerEmailTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerTelephoneTxt = new System.Windows.Forms.TextBox();
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.editCustomerBTN = new System.Windows.Forms.Button();
            this.deleteCustomerBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshListBTN
            // 
            this.refreshListBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshListBTN.BackgroundImage")));
            this.refreshListBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshListBTN.Location = new System.Drawing.Point(717, 27);
            this.refreshListBTN.Name = "refreshListBTN";
            this.refreshListBTN.Size = new System.Drawing.Size(30, 27);
            this.refreshListBTN.TabIndex = 15;
            this.refreshListBTN.UseVisualStyleBackColor = true;
            this.refreshListBTN.Click += new System.EventHandler(this.refreshListBTN_Click);
            // 
            // searchByNameBTN
            // 
            this.searchByNameBTN.Location = new System.Drawing.Point(636, 29);
            this.searchByNameBTN.Name = "searchByNameBTN";
            this.searchByNameBTN.Size = new System.Drawing.Size(75, 23);
            this.searchByNameBTN.TabIndex = 14;
            this.searchByNameBTN.Text = "Search";
            this.searchByNameBTN.UseVisualStyleBackColor = true;
            this.searchByNameBTN.Click += new System.EventHandler(this.searchByNameBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer Name";
            // 
            // searchedName
            // 
            this.searchedName.Location = new System.Drawing.Point(461, 24);
            this.searchedName.Multiline = true;
            this.searchedName.Name = "searchedName";
            this.searchedName.Size = new System.Drawing.Size(169, 32);
            this.searchedName.TabIndex = 12;
            // 
            // searchByMobileBTN
            // 
            this.searchByMobileBTN.Location = new System.Drawing.Point(271, 27);
            this.searchByMobileBTN.Name = "searchByMobileBTN";
            this.searchByMobileBTN.Size = new System.Drawing.Size(75, 23);
            this.searchByMobileBTN.TabIndex = 11;
            this.searchByMobileBTN.Text = "Search";
            this.searchByMobileBTN.UseVisualStyleBackColor = true;
            this.searchByMobileBTN.Click += new System.EventHandler(this.searchByMobileBTN_Click);
            // 
            // codeSearch
            // 
            this.codeSearch.AutoSize = true;
            this.codeSearch.Location = new System.Drawing.Point(7, 32);
            this.codeSearch.Name = "codeSearch";
            this.codeSearch.Size = new System.Drawing.Size(108, 16);
            this.codeSearch.TabIndex = 10;
            this.codeSearch.Text = "Customer Mobile";
            // 
            // searchedMobile
            // 
            this.searchedMobile.Location = new System.Drawing.Point(121, 24);
            this.searchedMobile.Multiline = true;
            this.searchedMobile.Name = "searchedMobile";
            this.searchedMobile.Size = new System.Drawing.Size(144, 32);
            this.searchedMobile.TabIndex = 9;
            // 
            // CustomersGridViewList
            // 
            this.CustomersGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGridViewList.Location = new System.Drawing.Point(29, 72);
            this.CustomersGridViewList.MultiSelect = false;
            this.CustomersGridViewList.Name = "CustomersGridViewList";
            this.CustomersGridViewList.ReadOnly = true;
            this.CustomersGridViewList.RowHeadersWidth = 51;
            this.CustomersGridViewList.RowTemplate.Height = 24;
            this.CustomersGridViewList.Size = new System.Drawing.Size(718, 388);
            this.CustomersGridViewList.TabIndex = 8;
            this.CustomersGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridViewList_CellContentClick);
            this.CustomersGridViewList.SelectionChanged += new System.EventHandler(this.CustomersGridViewList_SelectionChanged);
            // 
            // customerWebsiteTxt
            // 
            this.customerWebsiteTxt.Location = new System.Drawing.Point(888, 328);
            this.customerWebsiteTxt.Multiline = true;
            this.customerWebsiteTxt.Name = "customerWebsiteTxt";
            this.customerWebsiteTxt.Size = new System.Drawing.Size(228, 31);
            this.customerWebsiteTxt.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(816, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Website";
            // 
            // customerMobileTxt
            // 
            this.customerMobileTxt.Location = new System.Drawing.Point(888, 282);
            this.customerMobileTxt.Multiline = true;
            this.customerMobileTxt.Name = "customerMobileTxt";
            this.customerMobileTxt.Size = new System.Drawing.Size(228, 31);
            this.customerMobileTxt.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(816, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Mobile";
            // 
            // customerFaxTxt
            // 
            this.customerFaxTxt.Location = new System.Drawing.Point(888, 234);
            this.customerFaxTxt.Multiline = true;
            this.customerFaxTxt.Name = "customerFaxTxt";
            this.customerFaxTxt.Size = new System.Drawing.Size(228, 31);
            this.customerFaxTxt.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(816, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "Fax";
            // 
            // customerEmailTxt
            // 
            this.customerEmailTxt.Location = new System.Drawing.Point(888, 183);
            this.customerEmailTxt.Multiline = true;
            this.customerEmailTxt.Name = "customerEmailTxt";
            this.customerEmailTxt.Size = new System.Drawing.Size(228, 31);
            this.customerEmailTxt.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(816, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Email";
            // 
            // customerTelephoneTxt
            // 
            this.customerTelephoneTxt.Location = new System.Drawing.Point(888, 130);
            this.customerTelephoneTxt.Multiline = true;
            this.customerTelephoneTxt.Name = "customerTelephoneTxt";
            this.customerTelephoneTxt.Size = new System.Drawing.Size(228, 33);
            this.customerTelephoneTxt.TabIndex = 64;
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.Location = new System.Drawing.Point(888, 82);
            this.customerNameTxt.Multiline = true;
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(228, 33);
            this.customerNameTxt.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(787, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Telephone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(816, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "Name";
            // 
            // editCustomerBTN
            // 
            this.editCustomerBTN.BackColor = System.Drawing.SystemColors.Control;
            this.editCustomerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCustomerBTN.Location = new System.Drawing.Point(819, 381);
            this.editCustomerBTN.Name = "editCustomerBTN";
            this.editCustomerBTN.Size = new System.Drawing.Size(107, 37);
            this.editCustomerBTN.TabIndex = 60;
            this.editCustomerBTN.Text = "Edit";
            this.editCustomerBTN.UseVisualStyleBackColor = false;
            this.editCustomerBTN.Click += new System.EventHandler(this.editCustomerBTN_Click);
            // 
            // deleteCustomerBTN
            // 
            this.deleteCustomerBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteCustomerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomerBTN.Location = new System.Drawing.Point(1009, 381);
            this.deleteCustomerBTN.Name = "deleteCustomerBTN";
            this.deleteCustomerBTN.Size = new System.Drawing.Size(107, 37);
            this.deleteCustomerBTN.TabIndex = 76;
            this.deleteCustomerBTN.Text = "Delete";
            this.deleteCustomerBTN.UseVisualStyleBackColor = false;
            this.deleteCustomerBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1198, 517);
            this.Controls.Add(this.deleteCustomerBTN);
            this.Controls.Add(this.customerWebsiteTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.customerMobileTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customerFaxTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.customerEmailTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerTelephoneTxt);
            this.Controls.Add(this.customerNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.editCustomerBTN);
            this.Controls.Add(this.refreshListBTN);
            this.Controls.Add(this.searchByNameBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchedName);
            this.Controls.Add(this.searchByMobileBTN);
            this.Controls.Add(this.codeSearch);
            this.Controls.Add(this.searchedMobile);
            this.Controls.Add(this.CustomersGridViewList);
            this.Name = "CustomersList";
            this.Text = "CustomersList";
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshListBTN;
        private System.Windows.Forms.Button searchByNameBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchedName;
        private System.Windows.Forms.Button searchByMobileBTN;
        private System.Windows.Forms.Label codeSearch;
        private System.Windows.Forms.TextBox searchedMobile;
        private System.Windows.Forms.DataGridView CustomersGridViewList;
        private System.Windows.Forms.TextBox customerWebsiteTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customerMobileTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerFaxTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox customerEmailTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerTelephoneTxt;
        private System.Windows.Forms.TextBox customerNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button editCustomerBTN;
        private System.Windows.Forms.Button deleteCustomerBTN;
    }
}