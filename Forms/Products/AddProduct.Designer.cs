namespace Project.Forms.Products
{
    partial class AddProduct
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
            this.productCodeTxt = new System.Windows.Forms.TextBox();
            this.productUnitTxt = new System.Windows.Forms.TextBox();
            this.productPriceTxt = new System.Windows.Forms.TextBox();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addCustomerBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.productQuntityTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productNotesTxt = new System.Windows.Forms.TextBox();
            this.dateProductionPicker = new System.Windows.Forms.DateTimePicker();
            this.dateExpiryPicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productCodeTxt
            // 
            this.productCodeTxt.Location = new System.Drawing.Point(95, 72);
            this.productCodeTxt.Multiline = true;
            this.productCodeTxt.Name = "productCodeTxt";
            this.productCodeTxt.Size = new System.Drawing.Size(211, 34);
            this.productCodeTxt.TabIndex = 0;
            // 
            // productUnitTxt
            // 
            this.productUnitTxt.Location = new System.Drawing.Point(95, 124);
            this.productUnitTxt.Multiline = true;
            this.productUnitTxt.Name = "productUnitTxt";
            this.productUnitTxt.Size = new System.Drawing.Size(211, 31);
            this.productUnitTxt.TabIndex = 5;
            // 
            // productPriceTxt
            // 
            this.productPriceTxt.Location = new System.Drawing.Point(398, 120);
            this.productPriceTxt.Multiline = true;
            this.productPriceTxt.Name = "productPriceTxt";
            this.productPriceTxt.Size = new System.Drawing.Size(211, 31);
            this.productPriceTxt.TabIndex = 7;
            // 
            // productNameTxt
            // 
            this.productNameTxt.Location = new System.Drawing.Point(398, 68);
            this.productNameTxt.Multiline = true;
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(211, 34);
            this.productNameTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = " Unit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // addCustomerBTN
            // 
            this.addCustomerBTN.BackColor = System.Drawing.Color.LightGray;
            this.addCustomerBTN.Location = new System.Drawing.Point(259, 325);
            this.addCustomerBTN.Name = "addCustomerBTN";
            this.addCustomerBTN.Size = new System.Drawing.Size(127, 45);
            this.addCustomerBTN.TabIndex = 14;
            this.addCustomerBTN.Text = "Save";
            this.addCustomerBTN.UseVisualStyleBackColor = false;
            this.addCustomerBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quantity";
            // 
            // productQuntityTxt
            // 
            this.productQuntityTxt.Location = new System.Drawing.Point(95, 171);
            this.productQuntityTxt.Multiline = true;
            this.productQuntityTxt.Name = "productQuntityTxt";
            this.productQuntityTxt.Size = new System.Drawing.Size(211, 31);
            this.productQuntityTxt.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Notes";
            // 
            // productNotesTxt
            // 
            this.productNotesTxt.Location = new System.Drawing.Point(398, 164);
            this.productNotesTxt.Multiline = true;
            this.productNotesTxt.Name = "productNotesTxt";
            this.productNotesTxt.Size = new System.Drawing.Size(211, 74);
            this.productNotesTxt.TabIndex = 17;
            // 
            // dateProductionPicker
            // 
            this.dateProductionPicker.Location = new System.Drawing.Point(95, 216);
            this.dateProductionPicker.Name = "dateProductionPicker";
            this.dateProductionPicker.Size = new System.Drawing.Size(200, 22);
            this.dateProductionPicker.TabIndex = 23;
            // 
            // dateExpiryPicker
            // 
            this.dateExpiryPicker.Location = new System.Drawing.Point(95, 255);
            this.dateExpiryPicker.Name = "dateExpiryPicker";
            this.dateExpiryPicker.Size = new System.Drawing.Size(200, 22);
            this.dateExpiryPicker.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = " Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Expire";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(70, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 16);
            this.label15.TabIndex = 40;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(70, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(70, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 16);
            this.label17.TabIndex = 42;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(70, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 16);
            this.label18.TabIndex = 43;
            this.label18.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(374, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(374, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "*";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(643, 413);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateExpiryPicker);
            this.Controls.Add(this.dateProductionPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productNotesTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productQuntityTxt);
            this.Controls.Add(this.addCustomerBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productPriceTxt);
            this.Controls.Add(this.productNameTxt);
            this.Controls.Add(this.productUnitTxt);
            this.Controls.Add(this.productCodeTxt);
            this.Name = "AddProduct";
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productCodeTxt;
        private System.Windows.Forms.TextBox productUnitTxt;
        private System.Windows.Forms.TextBox productPriceTxt;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCustomerBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productQuntityTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productNotesTxt;
        private System.Windows.Forms.DateTimePicker dateProductionPicker;
        private System.Windows.Forms.DateTimePicker dateExpiryPicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}