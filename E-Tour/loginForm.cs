using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Tour
{
    public partial class loginForm : Form
    {
        ETOUREntities db = new ETOUREntities();
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            logIn();
        }
        bool adminLogin()
        {
            if (txbUserName.Text == "admin" && txbPassword.Text == "admin")

            {
                MessageBox.Show("Login by ADMIN account!", "Congratulation", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Login(string username, string password)
        {
            var result = from c in db.CUSTOMERs
                         where c.Account == username && c.Password == password
                         select c;
            int i = result.ToList().Count;
            if (i == 1)
            {
                CUSTOMER customer = db.CUSTOMERs.Where(p => p.Account == username).SingleOrDefault();
                UserID.ID = customer.ID;
                MessageBox.Show("Login successful", "Congratulation", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                MessageBox.Show("Username is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void newLb_Click(object sender, EventArgs e)
        {
            signupForm signup = new signupForm();
            this.Hide();
            signup.ShowDialog();
            this.Show();
        }


        private void logIn()
        {
            string username = txbUserName.Text;
            string password = txbPassword.Text;
            if (adminLogin() == true)
            {
                tourEditorForm mainscreen = new tourEditorForm();
                this.Hide();
                mainscreen.ShowDialog();
                this.Show();
            }
            else if (Login(username, password))
            {
                bookingForm mainscreen = new bookingForm();
                this.Hide();
                mainscreen.ShowDialog();
                this.Show();
            }
        }


        private void loginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logIn();
            }
        }
    }
}
