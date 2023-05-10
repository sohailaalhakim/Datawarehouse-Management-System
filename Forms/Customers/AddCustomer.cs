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
    public partial class AddCustomer : Form
    {
        Context db = new Context();

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void addNewStoreBTN_Click(object sender, EventArgs e)
        {
            if (customerNameTxt.Text == "" || customerMobileTxt.Text == "" || customerEmailTxt.Text == "")
            {
                MessageBox.Show("Some Fields are required");
            }
            else
            {
                Customer customer = new Customer();
                customer.Name = customerNameTxt.Text;
                customer.Mobile = customerMobileTxt.Text;
                customer.Telephone = customerTelephoneTxt.Text;
                customer.Email = customerEmailTxt.Text;
                customer.Fax = customerFaxTxt.Text;
                customer.website = customerWebsiteTxt.Text;
                db.Customers.Add(customer);
                db.SaveChanges();
                MessageBox.Show("Customer Added Successfully");
                this.Close();
            }
        }
    }
}
