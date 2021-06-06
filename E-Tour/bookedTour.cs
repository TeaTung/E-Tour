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
    public partial class bookedTour : Form
    {
        E_TOUREntities db = new E_TOUREntities();
        public int idtour, booked;
        public bookedTour()
        {
            InitializeComponent();
            Loaddata();
        }
        void Loaddata()
        {
            var result = from c in db.DASHBOARDs
                         where c.IDCustomer == UserID.ID
                         select c;
            guna2DataGridView1.DataSource = result.ToList();
            CUSTOMER customer = db.CUSTOMERs.Find(UserID.ID);
            addressTxb.Text = customer.Address;
            contactTxb.Text = customer.PhoneNumber.ToString();
            if(UserID.aboard == true)
            {
                aboardLb.Text = "Yes";
                CMND.Text = "Passport";
                CMNDTxb.Text = customer.CitizenID_Passport.ToString();
            }
            else
            {
                aboardLb.Text = "No";
            }
            nameTxb.Text = customer.FullName;
            contactTxb.Text = customer.PhoneNumber.ToString();
            CMNDTxb.Text = customer.CitizenID_Passport.ToString();
            genderCb.Text = customer.Gender;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e) //Update the information for account
        {
            CUSTOMER customer = db.CUSTOMERs.Find(UserID.ID);
            customer.FullName = nameTxb.Text;
            customer.Address = addressTxb.Text;
            customer.Gender = genderCb.Text;
            customer.PhoneNumber = Convert.ToInt32(contactTxb.Text);
            customer.CitizenID_Passport = Convert.ToInt32(CMNDTxb.Text);
            db.SaveChanges();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow data = guna2DataGridView1.Rows[e.RowIndex];
                booked = Convert.ToInt32(data.Cells[0].Value.ToString());
                TimepickedLb.Text = data.Cells[1].Value.ToString();
                TourID.Text = data.Cells[3].Value.ToString();
                idtour = Convert.ToInt32(TourID.Text);
                TOUR tour = db.TOURs.Find(idtour);
                departureLb.Text = tour.StartPoint;
                destinationLb.Text = tour.Destination;
                startdayLb.Text = tour.StartDay.ToString();
                durationLb.Text = tour.TimeConsumed;
                IspaidLb.Text = data.Cells[4].Value.ToString();
                ticketnumberLb.Text = data.Cells[6].Value.ToString();
                TICKET ticket = db.TICKETs.Where(p=>p.TourID == idtour).SingleOrDefault();
                PriceLb.Text = ticket.Price.ToString();
                totalLb.Text = ((Convert.ToInt32(PriceLb.Text))*(Convert.ToInt32(ticketnumberLb.Text))).ToString();
                
                //late return
                TimeSpan newdate = tour.StartDay.Value.Subtract(DateTime.Now);
                if(tour.TourType == "National")
                {
                    if(newdate.Hours > 4)
                    {
                        latereturnLb.Text = "0";
                    }
                    else if(newdate.Hours < 4)
                    {
                        latereturnLb.Text = "100000";
                    }
                }
                else if(tour.TourType == "International")
                {
                    if(newdate.Days > 3)
                    {
                        latereturnLb.Text = "0";
                    }
                    else if(newdate.Days <= 3)
                    {
                        latereturnLb.Text = "1150000"; //50USD
                    }
                }
                //return money
                if (ticket.Sale == true)
                {
                    returnmoneyLb.Text = Convert.ToInt32((Convert.ToInt32(totalLb.Text) * 80 / 100)-(Convert.ToInt32(latereturnLb.Text))).ToString();
                }
                else if (ticket.Sale == false)
                {
                    returnmoneyLb.Text = Convert.ToInt32(Convert.ToInt32(totalLb.Text) - (Convert.ToInt32(latereturnLb.Text))).ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DASHBOARD bookedticket = db.DASHBOARDs.Find(booked);
            if (bookedticket != null)
            {
                //TICKET ticket = db.TICKETs.Where(p=>p.TourID == bookedticket.IDTour).SingleOrDefault();
                //int i = Convert.ToInt32(ticket.Number + bookedticket.NumberOfTicket);
                //ticket.Number = i;
                db.DASHBOARDs.Remove(bookedticket);
                db.SaveChanges();
            }
            Loaddata();
        }
    }
}
