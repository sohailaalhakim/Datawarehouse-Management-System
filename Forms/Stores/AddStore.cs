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
    public partial class AddStore : Form
    {
        Context db = new Context();

        public AddStore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(storeNameTxt.Text== "" || storeAddressTxt.Text== "" || storeManagerTxt.Text == "")
            {
                MessageBox.Show("Some Fields are required");
            }
            else
            {
                Store store = new Store();
                store.Name = storeNameTxt.Text;
                store.Address = storeAddressTxt.Text;
                string ResponsiblePersonValue = storeManagerTxt.Text;
                Manager manager = new Manager { Name = ResponsiblePersonValue };
                store.ResponsiblePerson = manager;
                db.Store.Add(store);
                db.SaveChanges();
                MessageBox.Show("Store Added Successfully");
                this.Close();
            }

            storeAddressTxt.Text = "";
            storeNameTxt.Text = "";
            storeManagerTxt.Text = "";

        }
    }
}
