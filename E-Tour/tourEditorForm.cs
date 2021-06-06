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
        E_TOUREntities db = new E_TOUREntities();
        public int id;
        public tourEditorForm()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadbookeddataNotPaid()
        {
            var result = from c in db.DASHBOARDs
                         where c.IDTour == id && c.IsPaid == "False"
                         select c;
            bookeddataNotPaid.DataSource = result.ToList();
        }
        void LoadbookeddataWithPaid()
        {
            var result = from c in db.DASHBOARDs
                         where c.IDTour == id && c.IsPaid == "True"
                         select c;
            bookedticketData.DataSource = result.ToList();
        }
        void LoadData()
        {
            
            var result = from c in db.TOURs select c;
            tourShowData.DataSource = result.ToList();
        }
        void AddTour()
        {
            if (datetime.Value <= DateTime.Now)
            {
                MessageBox.Show("Startday must bigger than present", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            TOUR tour = new TOUR() { StartPoint = departureTxb.Text, Destination = destinationTxb.Text, StartDay = datetime.Value, TimeConsumed = durationTxb.Text, TourType = tourtypeCb.Text, TourDetail = tourdetailTxb.Text };
                db.TOURs.Add(tour);
                if (ticketsaleCb.Checked == true)
                {
                    TICKET ticket = new TICKET() { Price = Convert.ToInt32(priceTxb.Text), Number = Convert.ToInt32(ticketTxb.Text), Sale = true };
                    db.TICKETs.Add(ticket);
                }
                else if(ticketsaleCb.Checked== false)
                {
                    TICKET ticket = new TICKET() { Price = Convert.ToInt32(priceTxb.Text), Number = Convert.ToInt32(ticketTxb.Text), Sale = false };
                    db.TICKETs.Add(ticket);
                }              
                db.SaveChanges();
                LoadData();
            }
        }
        void RemoveTour()
        {   
            int id = Convert.ToInt32(tourShowData.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            var bookedticket = db.DASHBOARDs.Where(p => p.IDTour == id);
            List<DASHBOARD> listdelete = bookedticket.ToList();
            for(int i =0;i<listdelete.Count;i++)
            {
                db.DASHBOARDs.Remove( listdelete[i]);
            }
            TOUR tour = db.TOURs.Find(id);           
            TICKET ticket = db.TICKETs.Where(p => p.TourID == id).SingleOrDefault();            
            db.TOURs.Remove(tour);
            db.TICKETs.Remove(ticket);
            db.SaveChanges();
            LoadData();
        }
        void UpdateTour()
        {
            int id = Convert.ToInt32(passportTb.Text);
            TOUR tour = db.TOURs.Find(id);
            tour.StartPoint = departureTxb.Text;
            tour.Destination = destinationTxb.Text;
            tour.StartDay = datetime.Value;
            tour.TimeConsumed = durationTxb.Text;
            TICKET ticket = db.TICKETs.Where(p=>p.TourID == id).SingleOrDefault();
            ticket.Number = Convert.ToInt32(ticketTxb.Text);
            ticket.Price = Convert.ToInt32(priceTxb.Text);
            db.SaveChanges();
            LoadData();
        }
        void FindTour()
        {
            if(passportTb.Text != "" && departureTxb.Text != "" && destinationTxb.Text != "")
            {
                int id = Convert.ToInt32(passportTb.Text);
                string text1 = departureTxb.Text;
                string text = destinationTxb.Text;
                var result = from c in db.TOURs
                             where c.ID == id && c.StartPoint == text1 && c.Destination == text
                             select c;
                tourShowData.DataSource = result.ToList();
            }
            else if(passportTb.Text == "" && departureTxb.Text == "" && destinationTxb.Text == "")
            {
                LoadData();
            }
            else if (departureTxb.Text == "" && destinationTxb.Text == "")
            {
                int id = Convert.ToInt32(passportTb.Text);
                var result = from c in db.TOURs
                             where c.ID == id
                             select c;
                tourShowData.DataSource = result.ToList();
            }
            else if (passportTb.Text == "" && destinationTxb.Text == "")
            {
                string text = departureTxb.Text;
                var result = from c in db.TOURs
                             where c.StartPoint == text
                             select c;               
                tourShowData.DataSource = result.ToList();
            }
            else if (passportTb.Text == "" && departureTxb.Text == "")
            {
                string text = destinationTxb.Text;
                var result = from c in db.TOURs
                             where c.Destination == text
                             select c;
                tourShowData.DataSource = result.ToList();
            }
            else if (destinationTxb.Text == "")
            {
                int id = Convert.ToInt32(passportTb.Text);
                string text = departureTxb.Text;
                var result = from c in db.TOURs
                             where c.ID == id && c.StartPoint == text
                             select c;
                tourShowData.DataSource = result.ToList();
            }
            else if (departureTxb.Text == "")
            {
                int id = Convert.ToInt32(passportTb.Text);
                string text = destinationTxb.Text;
                var result = from c in db.TOURs
                             where c.ID == id && c.Destination == text
                             select c;
                tourShowData.DataSource = result.ToList();
            }
            else if(passportTb.Text == "")
            {
                string text1 = departureTxb.Text;
                string text = destinationTxb.Text;
                var result = from c in db.TOURs
                             where c.StartPoint == text1 && c.Destination == text
                             select c;
                tourShowData.DataSource = result.ToList();
            }
        }
        private void findBtn_Click(object sender, EventArgs e)
        {
            FindTour();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddTour();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            RemoveTour();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateTour();
        }

        private void updateticketBtn_Click(object sender, EventArgs e)
        {

        }

        private void tourShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow data = tourShowData.Rows[e.RowIndex];
                passportTb.Text = data.Cells[0].Value.ToString();
                id = Convert.ToInt32(passportTb.Text);
                departureTxb.Text = data.Cells[1].Value.ToString();
                destinationTxb.Text = data.Cells[2].Value.ToString();
                tourtypeCb.Text = data.Cells[3].Value.ToString();
                durationTxb.Text = data.Cells[4].Value.ToString();
                TICKET ticket = db.TICKETs.Where(p => p.TourID == id).SingleOrDefault();
                ticketTxb.Text = Convert.ToString(ticket.Number);
                priceTxb.Text = ticket.Price.ToString();
                tourdetailTxb.Text = data.Cells[6].Value.ToString();

                // show booked ticket follow each Tour
                LoadbookeddataWithPaid();
                LoadbookeddataNotPaid();
            }
        }

        private void findPaid_Click(object sender, EventArgs e)
        {
            if (textfindPaid.Text == "")
            {
                LoadbookeddataNotPaid();
            }
            else
            {
                int text = Convert.ToInt32(textfindPaid.Text);
                var result = from c in db.DASHBOARDs
                             where c.ID == text
                             select c;
                bookeddataNotPaid.DataSource = result.ToList();
            }
        }
    }
}
