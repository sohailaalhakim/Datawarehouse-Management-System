namespace Project.Forms.Stores
{
    partial class AddStore
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
            this.addNewStoreBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.storeNameTxt = new System.Windows.Forms.TextBox();
            this.storeAddressTxt = new System.Windows.Forms.TextBox();
            this.storeManagerTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addNewStoreBTN
            // 
            this.addNewStoreBTN.Location = new System.Drawing.Point(176, 307);
            this.addNewStoreBTN.Name = "addNewStoreBTN";
            this.addNewStoreBTN.Size = new System.Drawing.Size(107, 37);
            this.addNewStoreBTN.TabIndex = 0;
            this.addNewStoreBTN.Text = "Save";
            this.addNewStoreBTN.UseVisualStyleBackColor = true;
            this.addNewStoreBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // storeNameTxt
            // 
            this.storeNameTxt.Location = new System.Drawing.Point(135, 111);
            this.storeNameTxt.Multiline = true;
            this.storeNameTxt.Name = "storeNameTxt";
            this.storeNameTxt.Size = new System.Drawing.Size(196, 33);
            this.storeNameTxt.TabIndex = 3;
            // 
            // storeAddressTxt
            // 
            this.storeAddressTxt.Location = new System.Drawing.Point(135, 165);
            this.storeAddressTxt.Multiline = true;
            this.storeAddressTxt.Name = "storeAddressTxt";
            this.storeAddressTxt.Size = new System.Drawing.Size(196, 33);
            this.storeAddressTxt.TabIndex = 4;
            // 
            // storeManagerTxt
            // 
            this.storeManagerTxt.Location = new System.Drawing.Point(135, 218);
            this.storeManagerTxt.Multiline = true;
            this.storeManagerTxt.Name = "storeManagerTxt";
            this.storeManagerTxt.Size = new System.Drawing.Size(196, 31);
            this.storeManagerTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manager";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(113, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(113, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(113, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "*";
            // 
            // AddStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.storeManagerTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.storeAddressTxt);
            this.Controls.Add(this.storeNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewStoreBTN);
            this.Name = "AddStore";
            this.Text = "Add New Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewStoreBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox storeNameTxt;
        private System.Windows.Forms.TextBox storeAddressTxt;
        private System.Windows.Forms.TextBox storeManagerTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}