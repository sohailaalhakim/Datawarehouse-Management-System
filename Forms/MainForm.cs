using Project.Entities;
using Project.Forms.Customers;
using Project.Forms.Products;
using Project.Forms.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class MainForm : Form
    {
        Context db = new Context();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser addUserForm = new AddNewUser();
            addUserForm.Show();
        }

        private void productsListBTN_Click(object sender, EventArgs e)
        {
            ProductsList productList = new ProductsList();
            productList.Show();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct();
            addProductForm.Show();
        }

        private void productsListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStore addStore = new AddStore();
            addStore.Show();
        }

        private void storesListBTN_Click(object sender, EventArgs e)
        {
            StoresList storeList = new StoresList();
            storeList.Show();  
        }

        private void storeListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StoresList storeList = new StoresList();
            storeList.Show();
        }

        private void customersListBTN_Click(object sender, EventArgs e)
        {
         CustomersList customersList = new CustomersList();
            customersList.Show();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void customersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersList customersList = new CustomersList();
            customersList.Show();
        }
    }
}
