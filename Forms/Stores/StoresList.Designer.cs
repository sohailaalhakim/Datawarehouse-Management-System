namespace Project.Forms.Stores
{
    partial class StoresList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoresList));
            this.StoreGridView = new System.Windows.Forms.DataGridView();
            this.refreshListBTN = new System.Windows.Forms.Button();
            this.searchByNameBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchedName = new System.Windows.Forms.TextBox();
            this.searchByCodeBTN = new System.Windows.Forms.Button();
            this.codeSearch = new System.Windows.Forms.Label();
            this.searchedCode = new System.Windows.Forms.TextBox();
            this.storeManagerTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.storeAddressTxt = new System.Windows.Forms.TextBox();
            this.storeNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editNewStoreBTN = new System.Windows.Forms.Button();
            this.deleteStoreBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StoreGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StoreGridView
            // 
            this.StoreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoreGridView.Location = new System.Drawing.Point(28, 82);
            this.StoreGridView.MultiSelect = false;
            this.StoreGridView.Name = "StoreGridView";
            this.StoreGridView.ReadOnly = true;
            this.StoreGridView.RowHeadersWidth = 51;
            this.StoreGridView.RowTemplate.Height = 24;
            this.StoreGridView.Size = new System.Drawing.Size(613, 336);
            this.StoreGridView.TabIndex = 0;
            this.StoreGridView.SelectionChanged += new System.EventHandler(this.StoreGridView_SelectionChanged);
            // 
            // refreshListBTN
            // 
            this.refreshListBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshListBTN.BackgroundImage")));
            this.refreshListBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshListBTN.Location = new System.Drawing.Point(611, 38);
            this.refreshListBTN.Name = "refreshListBTN";
            this.refreshListBTN.Size = new System.Drawing.Size(30, 27);
            this.refreshListBTN.TabIndex = 14;
            this.refreshListBTN.UseVisualStyleBackColor = true;
            this.refreshListBTN.Click += new System.EventHandler(this.refreshListBTN_Click);
            // 
            // searchByNameBTN
            // 
            this.searchByNameBTN.Location = new System.Drawing.Point(530, 40);
            this.searchByNameBTN.Name = "searchByNameBTN";
            this.searchByNameBTN.Size = new System.Drawing.Size(75, 23);
            this.searchByNameBTN.TabIndex = 13;
            this.searchByNameBTN.Text = "Search";
            this.searchByNameBTN.UseVisualStyleBackColor = true;
            this.searchByNameBTN.Click += new System.EventHandler(this.searchByNameBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Store Name";
            // 
            // searchedName
            // 
            this.searchedName.Location = new System.Drawing.Point(355, 34);
            this.searchedName.Multiline = true;
            this.searchedName.Name = "searchedName";
            this.searchedName.Size = new System.Drawing.Size(169, 32);
            this.searchedName.TabIndex = 11;
            this.searchedName.TextChanged += new System.EventHandler(this.searchedName_TextChanged);
            // 
            // searchByCodeBTN
            // 
            this.searchByCodeBTN.Location = new System.Drawing.Point(189, 40);
            this.searchByCodeBTN.Name = "searchByCodeBTN";
            this.searchByCodeBTN.Size = new System.Drawing.Size(75, 23);
            this.searchByCodeBTN.TabIndex = 10;
            this.searchByCodeBTN.Text = "Search";
            this.searchByCodeBTN.UseVisualStyleBackColor = true;
            this.searchByCodeBTN.Click += new System.EventHandler(this.searchByCodeBTN_Click);
            // 
            // codeSearch
            // 
            this.codeSearch.AutoSize = true;
            this.codeSearch.Location = new System.Drawing.Point(12, 47);
            this.codeSearch.Name = "codeSearch";
            this.codeSearch.Size = new System.Drawing.Size(93, 16);
            this.codeSearch.TabIndex = 9;
            this.codeSearch.Text = "Store Address";
            this.codeSearch.Click += new System.EventHandler(this.codeSearch_Click);
            // 
            // searchedCode
            // 
            this.searchedCode.Location = new System.Drawing.Point(107, 34);
            this.searchedCode.Multiline = true;
            this.searchedCode.Name = "searchedCode";
            this.searchedCode.Size = new System.Drawing.Size(76, 32);
            this.searchedCode.TabIndex = 8;
            // 
            // storeManagerTxt
            // 
            this.storeManagerTxt.Location = new System.Drawing.Point(759, 215);
            this.storeManagerTxt.Multiline = true;
            this.storeManagerTxt.Name = "storeManagerTxt";
            this.storeManagerTxt.Size = new System.Drawing.Size(196, 33);
            this.storeManagerTxt.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Manager";
            // 
            // storeAddressTxt
            // 
            this.storeAddressTxt.Location = new System.Drawing.Point(759, 162);
            this.storeAddressTxt.Multiline = true;
            this.storeAddressTxt.Name = "storeAddressTxt";
            this.storeAddressTxt.Size = new System.Drawing.Size(196, 33);
            this.storeAddressTxt.TabIndex = 48;
            // 
            // storeNameTxt
            // 
            this.storeNameTxt.Location = new System.Drawing.Point(759, 108);
            this.storeNameTxt.Multiline = true;
            this.storeNameTxt.Name = "storeNameTxt";
            this.storeNameTxt.Size = new System.Drawing.Size(196, 33);
            this.storeNameTxt.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(690, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Name";
            // 
            // editNewStoreBTN
            // 
            this.editNewStoreBTN.BackColor = System.Drawing.Color.LightGray;
            this.editNewStoreBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editNewStoreBTN.Location = new System.Drawing.Point(695, 317);
            this.editNewStoreBTN.Name = "editNewStoreBTN";
            this.editNewStoreBTN.Size = new System.Drawing.Size(107, 37);
            this.editNewStoreBTN.TabIndex = 44;
            this.editNewStoreBTN.Text = "Edit";
            this.editNewStoreBTN.UseVisualStyleBackColor = false;
            this.editNewStoreBTN.Click += new System.EventHandler(this.editNewStoreBTN_Click);
            // 
            // deleteStoreBTN
            // 
            this.deleteStoreBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteStoreBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteStoreBTN.Location = new System.Drawing.Point(848, 317);
            this.deleteStoreBTN.Name = "deleteStoreBTN";
            this.deleteStoreBTN.Size = new System.Drawing.Size(107, 37);
            this.deleteStoreBTN.TabIndex = 51;
            this.deleteStoreBTN.Text = "Delete";
            this.deleteStoreBTN.UseVisualStyleBackColor = false;
            this.deleteStoreBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // StoresList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.deleteStoreBTN);
            this.Controls.Add(this.storeManagerTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.storeAddressTxt);
            this.Controls.Add(this.storeNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.editNewStoreBTN);
            this.Controls.Add(this.refreshListBTN);
            this.Controls.Add(this.searchByNameBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchedName);
            this.Controls.Add(this.searchByCodeBTN);
            this.Controls.Add(this.codeSearch);
            this.Controls.Add(this.searchedCode);
            this.Controls.Add(this.StoreGridView);
            this.Name = "StoresList";
            this.Text = "Stores List";
            ((System.ComponentModel.ISupportInitialize)(this.StoreGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StoreGridView;
        private System.Windows.Forms.Button refreshListBTN;
        private System.Windows.Forms.Button searchByNameBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchedName;
        private System.Windows.Forms.Button searchByCodeBTN;
        private System.Windows.Forms.Label codeSearch;
        private System.Windows.Forms.TextBox searchedCode;
        private System.Windows.Forms.TextBox storeManagerTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox storeAddressTxt;
        private System.Windows.Forms.TextBox storeNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editNewStoreBTN;
        private System.Windows.Forms.Button deleteStoreBTN;
    }
}