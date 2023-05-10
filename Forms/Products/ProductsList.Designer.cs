namespace Project.Forms.Products
{
    partial class ProductsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsList));
            this.productGridViewList = new System.Windows.Forms.DataGridView();
            this.searchedCode = new System.Windows.Forms.TextBox();
            this.codeSearch = new System.Windows.Forms.Label();
            this.searchByCodeBTN = new System.Windows.Forms.Button();
            this.searchByNameBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchedName = new System.Windows.Forms.TextBox();
            this.refreshListBTN = new System.Windows.Forms.Button();
            this.dateExpiryPicker = new System.Windows.Forms.DateTimePicker();
            this.dateProductionPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.productNotesTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productQuntityTxt = new System.Windows.Forms.TextBox();
            this.editProductBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.productPriceTxt = new System.Windows.Forms.TextBox();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.productUnitTxt = new System.Windows.Forms.TextBox();
            this.productCodeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteProductBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridViewList
            // 
            this.productGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridViewList.Location = new System.Drawing.Point(23, 93);
            this.productGridViewList.MultiSelect = false;
            this.productGridViewList.Name = "productGridViewList";
            this.productGridViewList.ReadOnly = true;
            this.productGridViewList.RowHeadersWidth = 51;
            this.productGridViewList.RowTemplate.Height = 24;
            this.productGridViewList.Size = new System.Drawing.Size(640, 388);
            this.productGridViewList.TabIndex = 0;
            this.productGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.productGridViewList.SelectionChanged += new System.EventHandler(this.productGridViewList_SelectionChanged);
            // 
            // searchedCode
            // 
            this.searchedCode.Location = new System.Drawing.Point(115, 45);
            this.searchedCode.Multiline = true;
            this.searchedCode.Name = "searchedCode";
            this.searchedCode.Size = new System.Drawing.Size(76, 32);
            this.searchedCode.TabIndex = 1;
            // 
            // codeSearch
            // 
            this.codeSearch.AutoSize = true;
            this.codeSearch.Location = new System.Drawing.Point(20, 53);
            this.codeSearch.Name = "codeSearch";
            this.codeSearch.Size = new System.Drawing.Size(89, 16);
            this.codeSearch.TabIndex = 2;
            this.codeSearch.Text = "Product Code";
            this.codeSearch.Click += new System.EventHandler(this.codeSearch_Click);
            // 
            // searchByCodeBTN
            // 
            this.searchByCodeBTN.Location = new System.Drawing.Point(197, 50);
            this.searchByCodeBTN.Name = "searchByCodeBTN";
            this.searchByCodeBTN.Size = new System.Drawing.Size(75, 23);
            this.searchByCodeBTN.TabIndex = 3;
            this.searchByCodeBTN.Text = "Search";
            this.searchByCodeBTN.UseVisualStyleBackColor = true;
            this.searchByCodeBTN.Click += new System.EventHandler(this.searchByCodeBTN_Click);
            // 
            // searchByNameBTN
            // 
            this.searchByNameBTN.Location = new System.Drawing.Point(552, 50);
            this.searchByNameBTN.Name = "searchByNameBTN";
            this.searchByNameBTN.Size = new System.Drawing.Size(75, 23);
            this.searchByNameBTN.TabIndex = 6;
            this.searchByNameBTN.Text = "Search";
            this.searchByNameBTN.UseVisualStyleBackColor = true;
            this.searchByNameBTN.Click += new System.EventHandler(this.searchByNameBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Name";
            // 
            // searchedName
            // 
            this.searchedName.Location = new System.Drawing.Point(377, 45);
            this.searchedName.Multiline = true;
            this.searchedName.Name = "searchedName";
            this.searchedName.Size = new System.Drawing.Size(169, 32);
            this.searchedName.TabIndex = 4;
            // 
            // refreshListBTN
            // 
            this.refreshListBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshListBTN.BackgroundImage")));
            this.refreshListBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshListBTN.Location = new System.Drawing.Point(633, 48);
            this.refreshListBTN.Name = "refreshListBTN";
            this.refreshListBTN.Size = new System.Drawing.Size(30, 27);
            this.refreshListBTN.TabIndex = 7;
            this.refreshListBTN.UseVisualStyleBackColor = true;
            this.refreshListBTN.Click += new System.EventHandler(this.refreshListBTN_Click);
            // 
            // dateExpiryPicker
            // 
            this.dateExpiryPicker.Location = new System.Drawing.Point(745, 279);
            this.dateExpiryPicker.Name = "dateExpiryPicker";
            this.dateExpiryPicker.Size = new System.Drawing.Size(211, 22);
            this.dateExpiryPicker.TabIndex = 42;
            // 
            // dateProductionPicker
            // 
            this.dateProductionPicker.Location = new System.Drawing.Point(745, 241);
            this.dateProductionPicker.Name = "dateProductionPicker";
            this.dateProductionPicker.Size = new System.Drawing.Size(211, 22);
            this.dateProductionPicker.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(962, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Notes";
            // 
            // productNotesTxt
            // 
            this.productNotesTxt.Location = new System.Drawing.Point(1012, 189);
            this.productNotesTxt.Multiline = true;
            this.productNotesTxt.Name = "productNotesTxt";
            this.productNotesTxt.Size = new System.Drawing.Size(211, 74);
            this.productNotesTxt.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Unit";
            // 
            // productQuntityTxt
            // 
            this.productQuntityTxt.Location = new System.Drawing.Point(745, 197);
            this.productQuntityTxt.Multiline = true;
            this.productQuntityTxt.Name = "productQuntityTxt";
            this.productQuntityTxt.Size = new System.Drawing.Size(211, 29);
            this.productQuntityTxt.TabIndex = 35;
            // 
            // editProductBTN
            // 
            this.editProductBTN.BackColor = System.Drawing.Color.LightGray;
            this.editProductBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProductBTN.Location = new System.Drawing.Point(745, 360);
            this.editProductBTN.Name = "editProductBTN";
            this.editProductBTN.Size = new System.Drawing.Size(127, 45);
            this.editProductBTN.TabIndex = 34;
            this.editProductBTN.Text = "Edit";
            this.editProductBTN.UseVisualStyleBackColor = false;
            this.editProductBTN.Click += new System.EventHandler(this.editProductBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(962, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Price";
            // 
            // productPriceTxt
            // 
            this.productPriceTxt.Location = new System.Drawing.Point(1012, 142);
            this.productPriceTxt.Multiline = true;
            this.productPriceTxt.Name = "productPriceTxt";
            this.productPriceTxt.Size = new System.Drawing.Size(211, 31);
            this.productPriceTxt.TabIndex = 32;
            // 
            // productNameTxt
            // 
            this.productNameTxt.Location = new System.Drawing.Point(1012, 87);
            this.productNameTxt.Multiline = true;
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(211, 34);
            this.productNameTxt.TabIndex = 31;
            // 
            // productUnitTxt
            // 
            this.productUnitTxt.Location = new System.Drawing.Point(745, 145);
            this.productUnitTxt.Multiline = true;
            this.productUnitTxt.Name = "productUnitTxt";
            this.productUnitTxt.Size = new System.Drawing.Size(211, 31);
            this.productUnitTxt.TabIndex = 30;
            // 
            // productCodeTxt
            // 
            this.productCodeTxt.Location = new System.Drawing.Point(745, 93);
            this.productCodeTxt.Multiline = true;
            this.productCodeTxt.Name = "productCodeTxt";
            this.productCodeTxt.Size = new System.Drawing.Size(211, 34);
            this.productCodeTxt.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(962, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(683, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(684, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Expire";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Date";
            // 
            // deleteProductBTN
            // 
            this.deleteProductBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteProductBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProductBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteProductBTN.Location = new System.Drawing.Point(965, 360);
            this.deleteProductBTN.Name = "deleteProductBTN";
            this.deleteProductBTN.Size = new System.Drawing.Size(127, 45);
            this.deleteProductBTN.TabIndex = 48;
            this.deleteProductBTN.Text = "Delete";
            this.deleteProductBTN.UseVisualStyleBackColor = false;
            this.deleteProductBTN.Click += new System.EventHandler(this.deleteProductBTN_Click);
            // 
            // ProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1244, 519);
            this.Controls.Add(this.deleteProductBTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateExpiryPicker);
            this.Controls.Add(this.dateProductionPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productNotesTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productQuntityTxt);
            this.Controls.Add(this.editProductBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productPriceTxt);
            this.Controls.Add(this.productNameTxt);
            this.Controls.Add(this.productUnitTxt);
            this.Controls.Add(this.productCodeTxt);
            this.Controls.Add(this.refreshListBTN);
            this.Controls.Add(this.searchByNameBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchedName);
            this.Controls.Add(this.searchByCodeBTN);
            this.Controls.Add(this.codeSearch);
            this.Controls.Add(this.searchedCode);
            this.Controls.Add(this.productGridViewList);
            this.MaximizeBox = false;
            this.Name = "ProductsList";
            this.Text = "Products List";
            this.Load += new System.EventHandler(this.ProductsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productGridViewList;
        private System.Windows.Forms.TextBox searchedCode;
        private System.Windows.Forms.Label codeSearch;
        private System.Windows.Forms.Button searchByCodeBTN;
        private System.Windows.Forms.Button searchByNameBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchedName;
        private System.Windows.Forms.Button refreshListBTN;
        private System.Windows.Forms.DateTimePicker dateExpiryPicker;
        private System.Windows.Forms.DateTimePicker dateProductionPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productNotesTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productQuntityTxt;
        private System.Windows.Forms.Button editProductBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productPriceTxt;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.TextBox productUnitTxt;
        private System.Windows.Forms.TextBox productCodeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deleteProductBTN;
    }
}