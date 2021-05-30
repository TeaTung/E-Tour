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
        void Loadbookeddata()
        {
            var result = from c in db.DASHBOARDs
                         where c.IDTour == id
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
            TOUR tour = new TOUR() { StartPoint = departureTxb.Text, Destination = destinationTxb.Text, StartDay = datetime.Value, TimeConsumed = durationTxb.Text };
            TICKET ticket = new TICKET() { Price = Convert.ToInt32(priceTxb.Text), Number = Convert.ToInt32(ticketTxb.Text) };
            db.TOURs.Add(tour);
            db.TICKETs.Add(ticket);
            db.SaveChanges();
            LoadData();
        }
        void RemoveTour()
        {
            int id = Convert.ToInt32(tourShowData.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            TOUR tour = db.TOURs.Find(id);
            db.TOURs.Remove(tour);
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
            int id = Convert.ToInt32(passportTb.Text);
            var result = from c in db.TOURs
                         where c.ID == id
                         select c;
            MessageBox.Show("" + id, "Show");
            tourShowData.DataSource = result.ToList();
            tourShowData.Update();
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
                durationTxb.Text = data.Cells[4].Value.ToString();
                TICKET ticket = db.TICKETs.Where(p => p.TourID == id).SingleOrDefault();
                ticketTxb.Text = Convert.ToString(ticket.Number);
                priceTxb.Text = ticket.Price.ToString();
                // show booked ticket follow each Tour
                Loadbookeddata();
            }
        }
    }
}
