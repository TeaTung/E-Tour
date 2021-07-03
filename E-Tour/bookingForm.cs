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
        ETOUREntities db = new ETOUREntities();
        int tourIdPicked;
        int ticketIdPicked;
        DateTime today = DateTime.Now;


        public bookingForm()
        {
            InitializeComponent();
            Loaddata();
            LoaddataFinding();
        }
        private void Loaddata()
        {
            //datagridview
            var result = from tou in db.TOURs
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
            dgvAvailableTour.DataSource = result.ToList();

            //Header name
            dgvAvailableTour.Columns[0].HeaderText = "ID";
            dgvAvailableTour.Columns[1].HeaderText = "Start Point";
            dgvAvailableTour.Columns[2].HeaderText = "Destination";
            dgvAvailableTour.Columns[3].HeaderText = "Tour Type";
            dgvAvailableTour.Columns[4].HeaderText = "Time Consumed";
            dgvAvailableTour.Columns[5].HeaderText = "Start Day";
            dgvAvailableTour.Columns[6].HeaderText = "Tour Detail";

            //Column width
            dgvAvailableTour.Columns[0].Width = 30;
            dgvAvailableTour.Columns[1].Width = 100;
            dgvAvailableTour.Columns[2].Width = 100;
            dgvAvailableTour.Columns[3].Width = 100;
            dgvAvailableTour.Columns[4].Width = 130;
            dgvAvailableTour.Columns[5].Width = 100;
            dgvAvailableTour.Columns[6].Width = 100;


        }
        private void LoaddataFinding()
        {
            var result1 = db.TOURs.Select(m => m.StartPoint).Distinct();
            cbbDeparture.DataSource = result1.ToList();
            var result2 = db.TOURs.Select(m => m.Destination).Distinct();
            cbbDestination.DataSource = result2.ToList();
            var result3 = db.TOURs.Select(m => m.TimeConsumed).Distinct();
            cbbDuration.DataSource = result3.ToList();
        }

        private void bookBtn_Click(object sender, EventArgs e) //Book only
        {
            if (cbbNumber.Text != "")
            {
                DASHBOARD newDashBoard = new DASHBOARD();
                newDashBoard.BookTime = today;
                newDashBoard.IDCustomer = UserID.ID;
                newDashBoard.IDTour = tourIdPicked;
                newDashBoard.IsPaid = "false";
                newDashBoard.NumberOfTicket = int.Parse(cbbNumber.Text);
                db.DASHBOARDs.Add(newDashBoard);
                db.SaveChanges();
                MessageBox.Show("Booked Successfully", "Success !!");
            }
            else
            {
                MessageBox.Show("Please choose the number of ticket", "Failure !!");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) // open the bookedTour form
        {
            this.Hide();
            bookedTour booked = new bookedTour();
            booked.ShowDialog();
        }

        private void payBtn_Click(object sender, EventArgs e) // Book & Pay
        {
            if (cbbNumber.Text != "")
            {
                DASHBOARD newDashBoard = new DASHBOARD();
                newDashBoard.BookTime = today;
                newDashBoard.IDCustomer = UserID.ID;
                newDashBoard.IDTour = tourIdPicked;
                newDashBoard.IsPaid = "true";
                newDashBoard.NumberOfTicket = int.Parse(cbbNumber.Text);

                TICKET ticket = db.TICKETs.Find(ticketIdPicked);
                ticket.Number -= int.Parse(cbbNumber.Text);
                db.DASHBOARDs.Add(newDashBoard);
                db.SaveChanges();
                MessageBox.Show("Booked Successfully", "Success !!");
            } else
            {
                MessageBox.Show("Please choose the number of ticket", "Failure !!");
            }
        }

        private void dgvAvailableTour_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow data = dgvAvailableTour.Rows[e.RowIndex];
                tourIdPicked = int.Parse(data.Cells[0].Value.ToString());

                loadTicketDetail(tourIdPicked);
            }
        }

        private void loadTicketDetail(int tourId)
        {
            var res = from tou in db.TOURs
                      join tic in db.TICKETs on tou.ID equals tic.TourID
                      where tourId == tou.ID
                      select tic.ID;
            ticketIdPicked = res.First();

            TOUR tour = db.TOURs.Find(tourId);
            lblTourId.Text = tour.ID.ToString();
            lblTourType.Text = tour.TourType;
            lblDeparture.Text = tour.StartPoint;
            lblDestination.Text = tour.Destination;
            lblStartDay.Text = tour.StartDay.ToString();
            lblTimeConsumed.Text = tour.TimeConsumed;
            txbTourDetail.Text = tour.TourDetail;

            TICKET ticket = db.TICKETs.Find(ticketIdPicked);
            lblPrice.Text = ticket.Price.ToString();
            lblTotal.Text = lblPrice.Text;
            cbbNumber.Text = "1";
            for (int i = 0; i < ticket.Number; i++)
            {
                cbbNumber.Items.Add(i + 1);
            }
        }

        private void cbbNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNumber.Text != "")
            {
                int number = int.Parse(cbbNumber.Text);
                int price = int.Parse(lblPrice.Text);
                int total = number * price;
                lblTotal.Text = "" + total;
            }
        }

        private void loadFilterTour()
        {
            TimeSpan timeSpan = today.Subtract(dtpStartDate.Value);

            var result = from tou in db.TOURs
                         where (tou.StartPoint == cbbDeparture.Text &&  tou.Destination == cbbDestination.Text && cbbDuration.Text == tou.TimeConsumed && timeSpan.TotalHours > 4)
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
            dgvAvailableTour.DataSource = result.ToList();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            loadFilterTour();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Loaddata();
            LoaddataFinding();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm booked = new loginForm();
            booked.ShowDialog();
        }
    }
}
