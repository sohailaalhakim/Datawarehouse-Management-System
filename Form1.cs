using Project.Entities;
using Project.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
	public partial class Form1 : Form
	{
		Context db = new Context();
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
        private void button1_Click(object sender, EventArgs e)
        {
			//check for authentication 
			var result = db.Users.Where(x => x.Username == usernameTxt.Text && x.Password == passwordTxt.Text).ToList();
			if(result.Count() > 0)
			{
                this.Close();
                Thread thread = new Thread(openForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
			else
			{
				MessageBox.Show("Username or Password invalid");
			}
			/*MainForm mainForm = new MainForm();
			mainForm.Show();
			this.Close();*/

			//using threads
			

        }
		void openForm()
		{
			Application.Run(new MainForm());
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
