using Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class AddNewUser : Form
    {
        Context db = new Context();
        string imagePath = "";
        public AddNewUser()
        {
            InitializeComponent();
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            if (confirmPasswordTxt.Text != passwordTxt.Text)
                MessageBox.Show("Passwords don't match");
            else
            {
                User user = new User();
                user.Username = userNameTxt.Text;
                user.Password = passwordTxt.Text;
                db.Users.Add(user);

                db.SaveChanges();
                //Saving usersImages in dynamic way in debug folder
                if(imagePath != null)
                {
                    string newImagePath = Environment.CurrentDirectory + "\\Images\\Users\\" + user.Id + ".jpg";
                    File.Copy(imagePath, newImagePath);
                    user.Image = newImagePath;
                    db.SaveChanges();
                    MessageBox.Show("User Added Successfully");
                }
             
            }
            
        }

        private void confirmPasswordTxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void NewUserImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath=openFileDialog.FileName;
                NewUserImage.ImageLocation=openFileDialog.FileName;
            }
        }
    }
}
