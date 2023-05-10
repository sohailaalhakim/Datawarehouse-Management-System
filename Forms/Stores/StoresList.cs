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

namespace Project.Forms.Stores
{
    public partial class StoresList : Form
    {
        Context db = new Context();
        int id;
        public StoresList()
        {
            InitializeComponent();
            StoreGridView.DataSource = db.Store.ToList();

        }

        private void codeSearch_Click(object sender, EventArgs e)
        {

        }

        private void searchByCodeBTN_Click(object sender, EventArgs e)
        {
            StoreGridView.DataSource = db.Store.Where(x => x.Address == searchedCode.Text).ToList();

        }

        private void searchedName_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchByNameBTN_Click(object sender, EventArgs e)
        {
            StoreGridView.DataSource = db.Store.Where(x => x.Name.Contains(searchedName.Text)).ToList();

        }

        private void refreshListBTN_Click(object sender, EventArgs e)
        {
            StoreGridView.DataSource = db.Store.ToList();

        }

        private void StoreGridView_SelectionChanged(object sender, EventArgs e)
        {
            id = int.Parse(StoreGridView.CurrentRow.Cells[0].Value.ToString());
            var result = db.Store.SingleOrDefault(x => x.ID == id);
            storeNameTxt.Text = result.Name;
            storeAddressTxt.Text = result.Address;
            storeManagerTxt.Text = result.ResponsiblePerson.ToString();

        }

        private void editNewStoreBTN_Click(object sender, EventArgs e)
        {
            var result = db.Store.SingleOrDefault(x => x.ID == id);
            result.Name = storeNameTxt.Text;    
            result.Address = storeAddressTxt.Text;
            string storeManager = storeManagerTxt.Text;
            Manager manager = new Manager() { Name = storeManager };
            result.ResponsiblePerson = manager;
            db.SaveChanges();
            MessageBox.Show("Store Updated Successfully");
            StoreGridView.DataSource = db.Store.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = db.Store.Find(id);
            db.Store.Remove(result);
            db.SaveChanges();
            MessageBox.Show("Store Deleted Successfully");
            StoreGridView.DataSource = db.Store.ToList();
        }
    }
}
