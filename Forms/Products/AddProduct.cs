using Project.Entities;
using Project.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms.Products
{
    public partial class AddProduct : Form
    {
        Context db = new Context();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(productCodeTxt.Text=="" || productNameTxt.Text=="" || productUnitTxt.Text=="")
            {
                MessageBox.Show("Some Fields are required");
            }
            else
            {
                Product product = new Product();
                product.Name = productNameTxt.Text;
                product.Code = productCodeTxt.Text;
                product.UnitsOfPriMeasure = productUnitTxt.Text;
                product.Notes = productNotesTxt.Text;
                //handle parsing error
                int qty, price;
                DateTime productionDate, expiryDate;

                int.TryParse(productQuntityTxt.Text, out qty);
                int.TryParse(productPriceTxt.Text, out price);
                DateTime.TryParse(dateProductionPicker.Text, out productionDate);
                DateTime.TryParse(dateExpiryPicker.Text, out expiryDate);
                product.Price = price;
                product.Quantity = qty;
                product.ProductionDate = productionDate;
                product.Expirydate = expiryDate;
            
                db.Products.Add(product);
                db.SaveChanges();
                MessageBox.Show("Product Added Successfully");
                this.Close();
            }
            productNameTxt.Text = "";
            productCodeTxt.Text = "";
            productNotesTxt.Text = "";
            productPriceTxt.Text = "";
            productQuntityTxt.Text = "";
            productUnitTxt.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
