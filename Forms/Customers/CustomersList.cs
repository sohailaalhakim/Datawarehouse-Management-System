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

namespace Project.Forms.Customers
{
    public partial class CustomersList : Form
    {
        Context db = new Context();
        int id;
        Customer result;
        public CustomersList()
        {
            InitializeComponent();
            CustomersGridViewList.DataSource = db.Customers.ToList();
        }
        private void productGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void searchByMobileBTN_Click(object sender, EventArgs e)
        {
            CustomersGridViewList.DataSource = db.Customers.Where(x => x.Mobile == searchedMobile.Text).ToList();
        }

        private void searchByNameBTN_Click(object sender, EventArgs e)
        {
            CustomersGridViewList.DataSource = db.Customers.Where(x => x.Name.Contains(searchedName.Text)).ToList();
        }

        private void refreshListBTN_Click(object sender, EventArgs e)
        {
            CustomersGridViewList.DataSource = db.Customers.ToList();
        }

        private void CustomersGridViewList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(CustomersGridViewList.CurrentRow.Cells[0].Value.ToString());
                result = db.Customers.SingleOrDefault(x => x.ID == id);

                customerNameTxt.Text = result.Name;
                customerEmailTxt.Text = result.Email;
                customerMobileTxt.Text = result.Mobile;
                customerTelephoneTxt.Text = result.Telephone;
                customerWebsiteTxt.Text = result.website;
                customerFaxTxt.Text = result.Fax;
            }

            catch (NullReferenceException) { }
        }

        private void editCustomerBTN_Click(object sender, EventArgs e)
        {
            result.Name = customerNameTxt.Text;
            result.Email = customerEmailTxt.Text;
            result.Fax = customerFaxTxt.Text;
            result.Telephone = customerTelephoneTxt.Text;
            result.Mobile = customerMobileTxt.Text;
            result.website = customerWebsiteTxt.Text;

            db.SaveChanges();
            MessageBox.Show("Customer Updated Successfully");
            CustomersGridViewList.DataSource = db.Customers.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = db.Customers.Find(id);
            db.Customers.Remove(result);
            db.SaveChanges();
            MessageBox.Show("Customer Deleted Successfully");
            CustomersGridViewList.DataSource = db.Customers.ToList();
        }
    }
}
