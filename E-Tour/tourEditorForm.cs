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
    public partial class tourEditorForm : Form
    {
        ETOUREntities db = new ETOUREntities();
        public int id;
        int tourIdPicked;
        int ticketIdPicked;
        int dashBoardPicked;
        int cusPicked;
        public tourEditorForm()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
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


            var resPaid = from d in db.DASHBOARDs
                            join c in db.CUSTOMERs on d.IDCustomer equals c.ID
                            join t in db.TOURs on d.IDTour equals t.ID
                            where d.IsPaid == "True"
                            select new { IDCus = c.ID, IdTour = t.ID, Name = c.FullName, Departure = t.StartPoint, StartDay = t.StartDay };
            dgvPaid.DataSource = resPaid.ToList();
            //Header name
            dgvPaid.Columns[0].HeaderText = "ID Customer";
            dgvPaid.Columns[1].HeaderText = "ID Tour";
            dgvPaid.Columns[2].HeaderText = "Customer name";
            dgvPaid.Columns[3].HeaderText = "Start Point";
            dgvPaid.Columns[4].HeaderText = "Start Day";
            //Column width
            dgvPaid.Columns[0].Width = 110;
            dgvPaid.Columns[1].Width = 70;
            dgvPaid.Columns[2].Width = 150;
            dgvPaid.Columns[3].Width = 100;
            dgvPaid.Columns[4].Width = 70;

            var resNotPaid = from d in db.DASHBOARDs
                              join c in db.CUSTOMERs on d.IDCustomer equals c.ID
                              join t in db.TOURs on d.IDTour equals t.ID
                              where d.IsPaid == "False"
                              select new { IDCus = c.ID, IdTour = t.ID, Name = c.FullName, Departure = t.StartPoint, StartDay = t.StartDay };
            dgvNotPaid.DataSource = resNotPaid.ToList();
            //Header name
            dgvNotPaid.Columns[0].HeaderText = "ID Customer";
            dgvNotPaid.Columns[1].HeaderText = "ID Tour";
            dgvNotPaid.Columns[2].HeaderText = "Customer name";
            dgvNotPaid.Columns[3].HeaderText = "Start Point";
            dgvNotPaid.Columns[4].HeaderText = "Start Day";
            //Column width
            dgvNotPaid.Columns[0].Width = 110;
            dgvNotPaid.Columns[1].Width = 70;
            dgvNotPaid.Columns[2].Width = 150;
            dgvNotPaid.Columns[3].Width = 100;
            dgvNotPaid.Columns[4].Width = 70;



            txbDeparture.Text = "";
            txbDestination.Text = "";
            txbDuration.Text = "";
            txbNumberOfTicket.Text = "";
            txbPrice.Text = "";
            txbCustomerId.Text = "";
            txbTourDetail.Text = "";
            cbbTourType.Text = "";
            txbCustomerId.Text = "";
            ckbSale.Checked = false;
            btnUpdate.Visible = false;
            btnRemoveUnpaidTicket.Visible = false;
            dtpStartDate.Value = DateTime.Now;
            tourIdPicked = -1;
            ticketIdPicked = -1;
            dashBoardPicked = -1;
            cusPicked = -1;
        }


        private void findBtn_Click(object sender, EventArgs e)
        {
            if (cbbTourType.Text != "" && txbDeparture.Text == "" && txbDestination.Text == "")
            {
                var result = from tou in db.TOURs
                             where tou.TourType == cbbTourType.Text
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
            else if (cbbTourType.Text == "" && txbDeparture.Text != "" && txbDestination.Text == "")
            {
                var result = from tou in db.TOURs
                             where tou.StartPoint == txbDeparture.Text
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
            else if (cbbTourType.Text == "" && txbDeparture.Text == "" && txbDestination.Text != "")
            {
                var result = from tou in db.TOURs
                             where tou.Destination == txbDestination.Text
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
            else if (cbbTourType.Text != "" && txbDeparture.Text != "" && txbDestination.Text == "")
            {
                var result = from tou in db.TOURs
                             where tou.TourType == cbbTourType.Text && tou.StartPoint == txbDeparture.Text
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
            else if (cbbTourType.Text == "" && txbDeparture.Text != "" && txbDestination.Text != "")
            {
                var result = from tou in db.TOURs
                             where tou.Destination == txbDestination.Text && tou.StartPoint == txbDeparture.Text
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
            else if (cbbTourType.Text != "" && txbDeparture.Text == "" && txbDestination.Text != "")
            {
                var result = from tou in db.TOURs
                             where tou.Destination == txbDestination.Text && tou.TourType == cbbTourType.Text
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
            else if (cbbTourType.Text != "" && txbDeparture.Text != "" && txbDestination.Text != "")
            {
                var result = from tou in db.TOURs
                             where tou.Destination == txbDestination.Text && tou.StartPoint == txbDeparture.Text && tou.TourType == cbbTourType.Text
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
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (cbbTourType.Text != "" && txbDeparture.Text != "" && txbDestination.Text != "" && txbDuration.Text != "" && txbNumberOfTicket.Text != "" && txbPrice.Text != "" && txbTourDetail.Text != "")
            {
                double time = (dtpStartDate.Value).Subtract(DateTime.Now).TotalDays;
                if (cbbTourType.Text == "Home")
                {                  
                    if (time >= 1)
                    {
                        addTour();
                        MessageBox.Show("Added Successfully", "Success !!!");
                    }   
                    else
                    {
                        dtpStartDate.Value = DateTime.Now;
                        MessageBox.Show("The start time of the tour must be higher than today with 1 day");
                    }
                }
                else if (cbbTourType.Text == "Aboard")
                {
                    if (time >= 8)
                    {
                        addTour();
                        MessageBox.Show("Added Successfully", "Success !!!");
                    }
                    else
                    {
                        dtpStartDate.Value = DateTime.Now;
                        MessageBox.Show("The start time of the tour must be higher than today with 8 day");
                    }
                }

            } else
            {
                MessageBox.Show("Please Fullfill all text box", "Failure !!!");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            TOUR tour = db.TOURs.Find(tourIdPicked);
            tour.TourType = cbbTourType.Text;
            tour.StartPoint = txbDeparture.Text;
            tour.Destination = txbDestination.Text;
            tour.TimeConsumed = txbDuration.Text;
            tour.TourDetail = txbTourDetail.Text;
            tour.StartDay = dtpStartDate.Value;

            TICKET ticket = db.TICKETs.Find(ticketIdPicked);
            ticket.Price = int.Parse(txbPrice.Text);
            ticket.Number = int.Parse(txbNumberOfTicket.Text);
            ticket.Sale = ckbSale.Checked.ToString();
            db.SaveChanges();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvAvailableTour_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUpdate.Visible = true;

            if (e.RowIndex != -1)
            {
                DataGridViewRow data = dgvAvailableTour.Rows[e.RowIndex];
                tourIdPicked = int.Parse(data.Cells[0].Value.ToString());

                var res = from tou in db.TOURs
                          join tic in db.TICKETs on tou.ID equals tic.TourID
                          where tourIdPicked == tou.ID
                          select tic.ID;
                ticketIdPicked = res.First();

                TOUR tour = db.TOURs.Find(tourIdPicked);
                txbDeparture.Text = tour.StartPoint;
                txbDestination.Text = tour.Destination;
                txbDuration.Text = tour.TimeConsumed;
                txbTourDetail.Text = tour.TourDetail;
                cbbTourType.Text = tour.TourType;
                dtpStartDate.Value = tour.StartDay.Value;

                TICKET ticket = db.TICKETs.Find(ticketIdPicked);
                txbPrice.Text = ticket.Price.ToString();
                txbNumberOfTicket.Text = ticket.Number.ToString();
                if (ticket.Sale == "True")
                {
                    ckbSale.Checked = true;
                } else
                {
                    ckbSale.Checked = false;
                }
            }

        }
        private void addTour()
        {
            TOUR tour = new TOUR();
            tour.TourType = cbbTourType.Text;
            tour.StartPoint = txbDeparture.Text;
            tour.Destination = txbDestination.Text;
            tour.TimeConsumed = txbDuration.Text;
            tour.TourDetail = txbTourDetail.Text;
            tour.StartDay = dtpStartDate.Value;
            db.TOURs.Add(tour);
            db.SaveChanges();

            var tourId = from t in db.TOURs
                         where (tour.TourType == cbbTourType.Text &&
                                tour.StartPoint == txbDeparture.Text &&
                                tour.Destination == txbDestination.Text &&
                                tour.TimeConsumed == txbDuration.Text &&
                                tour.TourDetail == txbTourDetail.Text &&
                                tour.StartDay == dtpStartDate.Value)
                         select t.ID;
            int tou = tourId.First();

            TICKET ticket = new TICKET();
            ticket.TourID = tou;
            ticket.Price = int.Parse(txbPrice.Text);
            ticket.Number = int.Parse(txbNumberOfTicket.Text);
            ticket.Sale = ckbSale.Checked.ToString();
            db.TICKETs.Add(ticket);
            db.SaveChanges();
        }

        private void dgvNotPaid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                btnRemoveUnpaidTicket.Visible = true;

                DataGridViewRow data = dgvNotPaid.Rows[e.RowIndex];
                ticketIdPicked = int.Parse(data.Cells[0].Value.ToString());
                cusPicked = int.Parse(data.Cells[1].Value.ToString());

                var resPaid = from t in db.TOURs
                              join ti in db.TICKETs on t.ID equals ti.TourID
                              join d in db.DASHBOARDs on t.ID equals d.IDTour
                              join c in db.CUSTOMERs on d.IDCustomer equals c.ID
                              where t.ID == ticketIdPicked && cusPicked == c.ID
                              select d.ID;
                dashBoardPicked = resPaid.First();
            }
        }

        private void btnRemoveUnpaidTicket_Click(object sender, EventArgs e)
        {
            DASHBOARD dash = db.DASHBOARDs.Find(dashBoardPicked);
            db.DASHBOARDs.Remove(dash);
            db.SaveChanges();
            MessageBox.Show("Removed Successfully", "Success !!!");
            LoadData();
        }

        private void findPaid_Click(object sender, EventArgs e)
        {
            if (txbCustomerId.Text != "")
            {
                int idCustomerNeededFind = -1;
                idCustomerNeededFind = int.Parse(txbCustomerId.Text);
                var resPaid = from d in db.DASHBOARDs
                              join c in db.CUSTOMERs on d.IDCustomer equals c.ID
                              join t in db.TOURs on d.IDTour equals t.ID
                              where d.IsPaid == "True" && c.ID == idCustomerNeededFind
                              select new { IDCus = c.ID, IdTour = t.ID, Name = c.FullName, Departure = t.StartPoint, StartDay = t.StartDay };
                dgvPaid.DataSource = resPaid.ToList();

                var resNotPaid = from d in db.DASHBOARDs
                                 join c in db.CUSTOMERs on d.IDCustomer equals c.ID
                                 join t in db.TOURs on d.IDTour equals t.ID
                                 where d.IsPaid == "False" && c.ID == idCustomerNeededFind
                                 select new { IDCus = c.ID, IdTour = t.ID, Name = c.FullName, Departure = t.StartPoint, StartDay = t.StartDay };
                dgvNotPaid.DataSource = resNotPaid.ToList();
            }
        }

        private void txbNumberOfTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void txbCustomerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }
    }
}
