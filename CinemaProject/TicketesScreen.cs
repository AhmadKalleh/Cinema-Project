using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProject
{
    public partial class TicketesScreen : Form
    {
        public TicketesScreen()
        {
            InitializeComponent();
        }

        private void PreaparingBookingsForCurrentUser()
        {
            List<clsCinema.clsBooking> bookings = clsCinema.clsBooking.GetTicktesListForCurrentUser();

            for(int i = 0; i < bookings.Count; i++)
            {             
                guna2DataGridView1.Rows.Add(bookings[i].TicketID, bookings[i].Title, bookings[i].ShowTime,"Hall 1 - Seat("+ bookings[i].SeatNumber + ")","500 $");
            }

            lbTicketCount.Text = Convert.ToString(guna2DataGridView1.RowCount);

        }

        private void TicketesScreen_Load(object sender, EventArgs e)
        {
            PreaparingBookingsForCurrentUser();
           
        }


        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            string ID = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string title = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string ShowTime = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            string Pattern = @"\((\d+)\)";
            Match match = Regex.Match(guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString(), Pattern);
            short SeatNumber = 0;
            if (match.Success)
            {
                SeatNumber = Convert.ToInt16(match.Groups[1].Value);
            }
            
            clsCinema.clsBooking booking = new clsCinema.clsBooking(ID, SessionData.currentUser.UserName, title, ShowTime, SeatNumber);

            booking.Delete();
            SessionData.movie = clsCinema.clsMovie.Find(title);
            SessionData.movie.UpdateSeatsAfterCanclingTicket(ShowTime);
            guna2DataGridView1.Rows.Clear();

            PreaparingBookingsForCurrentUser();

        }
       

      
    }
}