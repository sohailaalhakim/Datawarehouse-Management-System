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

namespace Project
{
    public partial class warehouseControlForm : Form
    {
        private Context dbRef;
        Context dbLoad = new Context();



        public warehouseControlForm()
        {
            InitializeComponent();
        }
        public warehouseControlForm(Context dbRef)
        {
            InitializeComponent();
            this.dbRef = dbRef;
        }

        private void warehouseControlForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void warehouseAddBTN_Click(object sender, EventArgs e)
        {
            warehouseControlForm warehouseForm = new warehouseControlForm(dbLoad);
            warehouseForm.ShowDialog();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
