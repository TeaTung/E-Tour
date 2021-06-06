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
    public partial class bookingForm : Form
    {
        public int id;
        E_TOUREntities db = new E_TOUREntities();
        public bookingForm()
        {
            InitializeComponent();
            Loaddata();
            LoaddataFinding();
        }
        private void Loaddata()
        {
            //datagridview
            var result = from c in db.TOURs
                         select new {ID = c.ID, StartPoint = c.StartPoint, Destination = c.Destination, TourType = c.TourType, StartDay = c.StartDay, TimeConsumed = c.TimeConsumed};
            guna2DataGridView1.DataSource = result.ToList();
            //Header name
            guna2DataGridView1.Columns[0].HeaderText = "ID";
            guna2DataGridView1.Columns[1].HeaderText = "Start Point";
            guna2DataGridView1.Columns[2].HeaderText = "Destination";
            guna2DataGridView1.Columns[3].HeaderText = "Tour Type";
            guna2DataGridView1.Columns[4].HeaderText = "Start Day";
            guna2DataGridView1.Columns[5].HeaderText = "Time consumed";
            //Width
            guna2DataGridView1.Columns[0].Width = 60;
            guna2DataGridView1.Columns[1].Width = 150;
            guna2DataGridView1.Columns[2].Width = 150;
            guna2DataGridView1.Columns[3].Width = 150;
            guna2DataGridView1.Columns[4].Width = 200;
            guna2DataGridView1.Columns[5].Width = 150;

            
        }
        private void LoaddataFinding()
        {
            //data departure
            var result1 = db.TOURs.Select(m => m.StartPoint).Distinct();
            departureCb.DataSource = result1.ToList();
            //data destination
            var result2 = db.TOURs.Select(m => m.Destination).Distinct();
            destinationCb.DataSource = result2.ToList();
            //data duration
            var result3 = db.TOURs.Select(m => m.TimeConsumed).Distinct();
            durationCb.DataSource = result3.ToList();
            //aboard
            passportTb.BackColor = Color.Brown;
            passportTb.ReadOnly = true;
            PassportExpiration.BackColor = Color.Brown;
            this.PassportExpiration.Enabled = false;
            visaDtp.BackColor = Color.Brown;
            this.visaDtp.Enabled = false;
            detailTxb.ReadOnly = true;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bookBtn_Click(object sender, EventArgs e) //Book only
        {
            TOUR tour = db.TOURs.Find(id);
            TimeSpan newdate = tour.StartDay.Value.Subtract(DateTime.Now);
            if (aboardCb.Checked == true)
            {
                if (ticketTb.Text == "")
                {
                    MessageBox.Show("Please enter number of tickets will book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (PassportExpiration.Value < tour.StartDay)
                {
                    MessageBox.Show("Your Passport has expired when the tour start!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (visaDtp.Value < tour.StartDay)
                {
                    MessageBox.Show("Your Visa has expired when the tour start!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(tour.TourType == "National")
                {
                    if(newdate.Days < 1)
                    {
                        MessageBox.Show("National tour must booked before 1 day / 24 hours!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else if(tour.TourType == "International")
                {
                    if(newdate.Days < 7)
                    {
                        MessageBox.Show("National tour must booked before 7 day(s) / 1 week!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DASHBOARD booked = new DASHBOARD() { BookTime = DateTime.Now, IDCustomer = UserID.ID, IDTour = id, IsPaid = "False", NumberOfTicket = Convert.ToInt32(numberticket.Text) };
                    CUSTOMER customer = db.CUSTOMERs.Find(UserID.ID);
                    customer.CitizenID_Passport = Convert.ToInt32(passportTb.Text);
                    customer.Expiration = PassportExpiration.Value;
                    db.DASHBOARDs.Add(booked);
                    db.SaveChanges();
                    MessageBox.Show("Congratulaion! Move to BookedTour to modify the information.\nNOTE : You must pay as soon as possible\n       Or we will delete it when time's up! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (ticketTb.Text == "")
                {
                    MessageBox.Show("Please enter number of tickets will book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DASHBOARD booked = new DASHBOARD() { BookTime = DateTime.Now, IDCustomer = UserID.ID, IDTour = id, IsPaid = "False", NumberOfTicket = Convert.ToInt32(numberticket.Text) };
                    db.DASHBOARDs.Add(booked);
                    db.SaveChanges();
                    MessageBox.Show("Congratulaion! Move to BookedTour to modify the information.\nNOTE : You must pay as soon as possible\n       Or we will delete it when time's up! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

       
        private void aboardCb_CheckedChanged(object sender, EventArgs e) //Aboard or not
        {
            CUSTOMER customer = db.CUSTOMERs.Find(UserID.ID);
           if(aboardCb.Checked == true)
            {
                UserID.aboard = true;
                aboardcheck.Text = "Yes";
                customer.Type = "Aboard";
                passportTb.BackColor = Color.White;
                passportTb.ReadOnly = false;
                PassportExpiration.BackColor = Color.White;
                this.PassportExpiration.Enabled = true;
                visaDtp.BackColor = Color.White;
                this.visaDtp.Enabled = true;
            }
           else
            {
                UserID.aboard = false;
                aboardcheck.Text = "No";
                customer.Type = "Foreign";
                passportTb.BackColor = Color.Brown;
                passportTb.ReadOnly = true;
                PassportExpiration.BackColor = Color.Brown;
                this.PassportExpiration.Enabled = false;
                visaDtp.BackColor = Color.Brown;
                this.visaDtp.Enabled = false;
            }
        }


        //Click datagridview and show information about the Tour
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow data = guna2DataGridView1.Rows[e.RowIndex];
                IDLb.Text = data.Cells[0].Value.ToString();
                id = Convert.ToInt32(IDLb.Text);
                TOUR tour = db.TOURs.Find(id);
                detailTxb.Text = tour.TourDetail;
                departureLb.Text = data.Cells[1].Value.ToString();
                destinationLb.Text = data.Cells[2].Value.ToString();
                durationLb.Text = data.Cells[5].Value.ToString();
                startdateLb.Text = data.Cells[4].Value.ToString();
                TICKET ticket = db.TICKETs.Where(p => p.TourID == id ).SingleOrDefault();
                //ticketTxb.Text = Convert.ToString(ticket.Number);
                priceTb.Text = ticket.Price.ToString();
            }
        }

        private void ticketTb_TextChanged(object sender, EventArgs e) //number of tockets will book
        {
            numberticket.Text = ticketTb.Text;
        }

        private void guna2Button1_Click(object sender, EventArgs e) // open the bookedTour form
        {
            bookedTour booked = new bookedTour();
            booked.ShowDialog();
        }

        private void payBtn_Click(object sender, EventArgs e) // Book & Pay
        {
            TOUR tour = db.TOURs.Find(id);
            if (aboardCb.Checked == true)
            {
                if (ticketTb.Text == "")
                {
                    MessageBox.Show("Please enter number of tickets will book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(PassportExpiration.Value < tour.StartDay)
                {
                    MessageBox.Show("Your Passport has expired when the tour start!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (visaDtp.Value < tour.StartDay)
                {
                    MessageBox.Show("Your Visa has expired when the tour start!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DASHBOARD booked = new DASHBOARD() { BookTime = DateTime.Now, IDCustomer = UserID.ID, IDTour = id, IsPaid = "True", NumberOfTicket = Convert.ToInt32(numberticket.Text) };
                    CUSTOMER customer = db.CUSTOMERs.Find(UserID.ID);
                    customer.CitizenID_Passport = Convert.ToInt32(passportTb.Text);
                    customer.Expiration = PassportExpiration.Value;
                    
                    TICKET ticket = db.TICKETs.Where(p=>p.TourID == id).SingleOrDefault();
                    int i = Convert.ToInt32(ticket.Number - booked.NumberOfTicket);
                    if(i>0)
                    {
                        ticket.Number = i;
                        MessageBox.Show("Congratulaion! Move to BookedTour to modify the information.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.DASHBOARDs.Add(booked);
                    }
                    else if(i == 0)
                    {
                        ticket.Number = i;
                        MessageBox.Show("You have booked the last ticket(s)! Move to BookedTour to modify the information.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.DASHBOARDs.Add(booked);
                    }
                    else if (i < 0)
                    {
                        MessageBox.Show("Not Enough ticket(s) for your order!");
                    }
                    db.SaveChanges();
                    
                }
            }
            else
            {
                if (ticketTb.Text == "")
                {
                    MessageBox.Show("Please enter number of tickets will book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DASHBOARD booked = new DASHBOARD() { BookTime = DateTime.Now, IDCustomer = UserID.ID, IDTour = id, IsPaid = "True", NumberOfTicket = Convert.ToInt32(numberticket.Text) };
                    TICKET ticket = db.TICKETs.Where(p => p.TourID == id).SingleOrDefault();
                    int i = Convert.ToInt32(ticket.Number - booked.NumberOfTicket);
                    if (i > 0)
                    {
                        ticket.Number = i;
                        MessageBox.Show("Congratulaion! Move to BookedTour to modify the information.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.DASHBOARDs.Add(booked);
                    }
                    else if (i == 0)
                    {
                        ticket.Number = i;
                        MessageBox.Show("You have booked the last ticket(s)! Move to BookedTour to modify the information.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.DASHBOARDs.Add(booked);
                    }
                    else if (i < 0)
                    {
                        MessageBox.Show("Not Enough ticket(s) for your order!");
                    }
                    
                    db.SaveChanges();
                    
                }
            }
        }
        private void departureCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                var result = from c in db.TOURs
                             where c.StartPoint == departureCb.Text
                             select c;
                guna2DataGridView1.DataSource = result.ToList();
        }


        private void destinationCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = from c in db.TOURs
                         where c.StartPoint == departureCb.Text && c.Destination == destinationCb.Text
                         select c;
            guna2DataGridView1.DataSource = result.ToList();
        }
    }
}
