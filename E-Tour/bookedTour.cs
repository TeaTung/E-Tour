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
        DateTime startDay, bookedTime;
        String isTicketSale;
        int dashBoardId;

        ETOUREntities db = new ETOUREntities();
        public int idtour, booked;
        public bookedTour()
        {
            InitializeComponent();
            Loaddata();
        }

        void Loaddata()
        {
            var result = from cus in db.CUSTOMERs
                         join das in db.DASHBOARDs on cus.ID equals das.IDTour
                         join tou in db.TOURs on das.IDTour equals tou.ID
                         where das.IDCustomer == UserID.ID
                         select new
                         {
                             ID = tou.ID,
                             StartPoint = tou.StartPoint,
                             Destination = tou.Destination,
                             TourType = tou.TourType,
                             TimeConsumed = tou.TimeConsumed,
                             StartDay = tou.StartDay,
                             TourDetail = tou.TourDetail
                         };
            guna2DataGridView1.DataSource = result.ToList();

            //Header name
            guna2DataGridView1.Columns[0].HeaderText = "ID";
            guna2DataGridView1.Columns[1].HeaderText = "Start Point";
            guna2DataGridView1.Columns[2].HeaderText = "Destination";
            guna2DataGridView1.Columns[3].HeaderText = "Tour Type";
            guna2DataGridView1.Columns[4].HeaderText = "Time Consumed";
            guna2DataGridView1.Columns[5].HeaderText = "Start Day";
            guna2DataGridView1.Columns[6].HeaderText = "Tour Detail";


            //Column width
            guna2DataGridView1.Columns[0].Width = 30;
            guna2DataGridView1.Columns[1].Width = 100;
            guna2DataGridView1.Columns[2].Width = 100;
            guna2DataGridView1.Columns[3].Width = 100;
            guna2DataGridView1.Columns[4].Width = 130;
            guna2DataGridView1.Columns[5].Width = 100;
            guna2DataGridView1.Columns[6].Width = 100;


            CUSTOMER customer = db.CUSTOMERs.Find(UserID.ID);
            txbName.Text = customer.FullName;
            txbAddress.Text = customer.Address;
            txbEmail.Text = customer.Email;
            txbContact.Text = customer.PhoneNumber.ToString();
            txbId.Text = customer.CitizenID_Passport.ToString();
            if (customer.Gender == "Male")
            {
                cbbGender.Text = "Male";
            }
            else if (customer.Gender == "Female")
            {
                cbbGender.Text = "Female";
            }

            if (customer.Type == "True")
            {
                cbbType.Text = "True";
                lbId.Text = "Passport";
                lblExpiration.Visible = true;
                dtpExpiration.Visible = true;
                dtpExpiration.Value = customer.Expiration.Value;
            }
            else
            {
                cbbType.Text = "False";
                lblExpiration.Visible = false;
                dtpExpiration.Visible = false;
            }

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookingForm booking = new bookingForm();
            booking.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dashBoardId >= 0)
            {
                var removedDashBoard = (from das in db.DASHBOARDs
                                        where das.ID == dashBoardId
                                        select das).First();
                var resPaid = from t in db.TOURs
                              join ti in db.TICKETs on t.ID equals ti.TourID
                              join d in db.DASHBOARDs on t.ID equals d.IDTour
                              where dashBoardId == d.ID
                              select ti.ID;
                TICKET ticket = db.TICKETs.Find(resPaid.First());
                ticket.Number += int.Parse(lblNumberOfTicket.Text);
                db.DASHBOARDs.Remove(removedDashBoard);
                db.SaveChanges();
            }
            MessageBox.Show("Deleted Successfully", "Notification");
            lblTourID.Text = "";
            lblDeparture.Text = "";
            lblDestination.Text = "";
            lblStartDay.Text = "";
            lblDuration.Text = "";
            lblTourType.Text = "";
            lblNumberOfTicket.Text = "";
            lblTimePicked.Text = "";
            lblIsPaid.Text = "";
            lblPrice.Text = "";
            lblTotal.Text = "";
            lblReturnMoney.Visible = false;
            btnCancel.Visible = false;
            lblReturn.Visible = false;
            Loaddata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CUSTOMER customer = db.CUSTOMERs.Find(UserID.ID);
            customer.FullName = txbName.Text;
            customer.Email = txbEmail.Text;
            customer.Address = txbAddress.Text;
            customer.Type = cbbType.Text;
            customer.Gender = cbbGender.Text;
            customer.PhoneNumber = int.Parse(txbContact.Text);
            customer.CitizenID_Passport = int.Parse(txbId.Text);
            if (cbbType.Text == "True")
            {
                customer.Expiration = dtpExpiration.Value;
            }
            db.SaveChanges();
        }

        private void txbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void txbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void guna2DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int tourId = 0;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = guna2DataGridView1.Rows[e.RowIndex];
                tourId = int.Parse(dataGridViewRow.Cells[0].Value.ToString());
            }

            TOUR tour = db.TOURs.Find(tourId);
            lblTourID.Text = tour.ID.ToString();
            lblDeparture.Text = tour.StartPoint;
            lblDestination.Text = tour.Destination;
            lblStartDay.Text = tour.StartDay.ToString();
            lblDuration.Text = tour.TimeConsumed;
            lblTourType.Text = tour.TourType;
            startDay = DateTime.Parse(tour.StartDay.ToString());

            var dash = from das in db.DASHBOARDs
                       join tou in db.TOURs on das.IDTour equals tou.ID
                       where tou.ID == tourId
                       select das.ID;
            dashBoardId = dash.First();

            DASHBOARD dashBoardID = db.DASHBOARDs.Find(dashBoardId);
            lblNumberOfTicket.Text = dashBoardID.NumberOfTicket.ToString();
            lblTimePicked.Text = dashBoardID.BookTime.ToString();
            lblIsPaid.Text = dashBoardID.IsPaid;
            bookedTime = DateTime.Parse(dashBoardID.BookTime.ToString());

            int ticketID = 0;
            var tickett = from ticket in db.TICKETs
                          join tou in db.TOURs on ticket.TourID equals tou.ID
                          where tou.ID == tourId
                          select ticket.ID;
            ticketID = tickett.First();

            TICKET tICKET = db.TICKETs.Find(ticketID);
            lblPrice.Text = tICKET.Price.ToString();
            isTicketSale = tICKET.Sale.ToString();
            lblTotal.Text = "" + long.Parse(lblPrice.Text) * long.Parse(lblNumberOfTicket.Text);

        }

        private void btnReturnTicket_Click(object sender, EventArgs e)
        {
            if (lblTimePicked.Text != null)
            {
                int total = int.Parse(lblTotal.Text);
                int number = int.Parse(lblNumberOfTicket.Text);
                int returnMoney = 0;
                TimeSpan timeSpan = startDay.Subtract(bookedTime);

                if (lblTourType.Text == "Home")
                {
                    lblReturn.Visible = true;
                    lblReturnMoney.Visible = true;
                    if (timeSpan.TotalHours >= 4)
                    {
                        returnMoney = total;
                    }
                    else
                    {
                        returnMoney = total - 100000 * number;
                    }

                }
                else if (lblTourType.Text == "Aboard")
                {
                    lblReturn.Visible = true;
                    lblReturnMoney.Visible = true;
                    if (timeSpan.TotalDays >= 7)
                    {
                        lblReturnMoney.Text = lblTotal.Text;
                    }
                    else
                    {
                        lblReturnMoney.Text = "" + (total - number * 50);
                    }
                }

                if (isTicketSale == "True")
                {
                    returnMoney = returnMoney * 80 / 100;
                }

                lblReturnMoney.Text = returnMoney.ToString();
            }
        }
    }
}
