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
        ETOUREntities db = new ETOUREntities();

        public signupForm()
        {
            InitializeComponent();
            loadData();
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
            if (txbUserName.Text == ""||txbPassword.Text == ""||txbAddress.Text == ""||txbPhoneNumber.Text == "" 
                || txbEmail.Text == "" || txbFullName.Text == "" || txbCitizenID.Text == "" || cbbGender.Text == "" 
                || cbbType.Text == "")
            {
                MessageBox.Show("Please fill all the informations!", "Sign up failed?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                var result = from c in db.CUSTOMERs
                             where c.Account == txbUserName.Text
                             select c;
                int i = result.ToList().Count;
                if (i == 0)
                {
                    CUSTOMER customer = new CUSTOMER();
                    customer.FullName = txbFullName.Text;
                    customer.PhoneNumber = int.Parse(txbPhoneNumber.Text);
                    customer.Address = txbAddress.Text;
                    if (cbbType.Text == "Home")
                    {
                        customer.Type = "True";
                    }
                    else
                    {
                        customer.Type = "False";
                    }
                    customer.Account = txbUserName.Text;
                    customer.Password = txbPassword.Text;
                    customer.CitizenID_Passport = int.Parse(txbCitizenID.Text);
                    customer.Expiration = dtpExpiration.Value;
                    customer.Gender = cbbGender.Text;
                    customer.Email = txbEmail.Text;

                    db.CUSTOMERs.Add(customer);
                    db.SaveChanges();
                    UserID.ID = customer.ID;
                    MessageBox.Show("Sign up successful", "Congratulation",MessageBoxButtons.OK);
                    loadData();
                    return true;
                }
                else
                {
                    MessageBox.Show("Username has existence!", "error");
                    return false;
                }               
            } 
        }

        private void phoneTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbType.Text == "Aboard")
            {
                lblExpiration.Visible = true;
                dtpExpiration.Visible = true;
                lblExpiration.Text = "Passport ID";
                dtpExpiration.Value = DateTime.Now.AddDays(DateTime.Now.Day + 7);
            }
            else if (cbbType.Text == "Aboard")
            {
                lblExpiration.Visible = false;
                dtpExpiration.Visible = false;
                lblExpiration.Text = "Citizen ID";
                dtpExpiration.Value = DateTime.Now.AddDays(DateTime.Now.Day + 7);
            }
        }

        void loadData()
        {
            lblExpiration.Visible = false;
            dtpExpiration.Visible = false;
            lblExpiration.Text = "Citizen ID";
        }

        private void dtpExpiration_ValueChanged(object sender, EventArgs e)
        {
            double day = dtpExpiration.Value.Subtract(DateTime.Now).TotalDays;
            if (day < 7)
            {
                MessageBox.Show("The date of Expiration must be higher than 7 days", "Failure !!!");
                dtpExpiration.Value = DateTime.Now.AddDays(DateTime.Now.Day + 7);
            }
        }
    }
}
