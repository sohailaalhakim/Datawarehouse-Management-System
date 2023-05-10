using Project.Entities;
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
    public partial class ProductsList : Form
    {
        Context db = new Context();
        int id;
        Product result;
        public ProductsList()
        {
            InitializeComponent();
           
            productGridViewList.DataSource = db.Products.ToList();
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void codeSearch_Click(object sender, EventArgs e)
        {

        }

        private void searchByCodeBTN_Click(object sender, EventArgs e)
        {
         productGridViewList.DataSource = db.Products.Where(x => x.Code == searchedCode.Text).ToList();
        }

       

        private void searchByNameBTN_Click(object sender, EventArgs e)
        {
            productGridViewList.DataSource = db.Products.Where(x => x.Name.Contains(searchedName.Text)).ToList();
        }
        private void refreshListBTN_Click(object sender, EventArgs e)
        {
            productGridViewList.DataSource = db.Products.ToList();
        }
        private void ProductsList_Load(object sender, EventArgs e)
        {

        }

        private void productGridViewList_SelectionChanged(object sender, EventArgs e)
        {
            id= int.Parse(productGridViewList.CurrentRow.Cells[0].Value.ToString());
            result =  db.Products.SingleOrDefault(x => x.ID == id);
            productCodeTxt.Text = result.Code;
            productNameTxt.Text = result.Name;
            productPriceTxt.Text = result.Price.ToString();
            productQuntityTxt.Text = result.Quantity.ToString();
            productUnitTxt.Text = result.UnitsOfPriMeasure;
            dateProductionPicker.Text = result.ProductionDate.ToString();
            dateExpiryPicker.Text = result.Expirydate.ToString();
        }

        private void editProductBTN_Click(object sender, EventArgs e)
        {
            result.Name = productNameTxt.Text;
            result.Code = productCodeTxt.Text;
            result.Price = decimal.Parse(productPriceTxt.Text);
            result.Quantity = int.Parse(productQuntityTxt.Text);
            result.UnitsOfPriMeasure = productUnitTxt.Text;
            result.ProductionDate = DateTime.Parse(dateProductionPicker.Text);
            result.Expirydate = DateTime.Parse(dateExpiryPicker.Text);
            result.Notes = productNotesTxt.Text;
            db.SaveChanges();
            MessageBox.Show("Product Updated Successfully");
            productGridViewList.DataSource = db.Products.ToList();
        }

        private void deleteProductBTN_Click(object sender, EventArgs e)
        {

            var result = db.Products.Find(id);
            db.Products.Remove(result);
            db.SaveChanges();
            MessageBox.Show("Product Deleted Successfully");
            productGridViewList.DataSource = db.Products.ToList();
        }
    }
}
