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
   
    public partial class signupForm : Form
    {
        E_TOUREntities db = new E_TOUREntities();

        public signupForm()
        {
            InitializeComponent();
        }

        private void forgotLb_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (Signup())
            {
                bookingForm mainscreen = new bookingForm();
                this.Hide();
                mainscreen.ShowDialog();
                this.Show();
            }
        }

        public bool Signup()
        {
            if (usernameTb.Text == ""||passwordTb.Text == ""||addressTb.Text == ""||phoneTb.Text == "")
            {
                MessageBox.Show("Please fill all the informations!", "Sign up failed?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                var result = from c in db.CUSTOMERs
                             where c.Account == usernameTb.Text
                             select c;
                int i = result.ToList().Count;
                if (i == 0)
                {
                    CUSTOMER customer = new CUSTOMER() { Account = usernameTb.Text, Password = passwordTb.Text, PhoneNumber = Convert.ToInt32(phoneTb.Text), Address = addressTb.Text };
                    db.CUSTOMERs.Add(customer);
                    db.SaveChanges();
                    UserID.ID = customer.ID;
                    MessageBox.Show("Sign up successful", "Congratulation",MessageBoxButtons.OK);
                    return true;
                }
                else
                {
                    MessageBox.Show("Username has existence!", "error");
                    return false;
                }
                
            } 
        }
    }
}
