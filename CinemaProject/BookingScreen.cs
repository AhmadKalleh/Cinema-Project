using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProject
{
    public partial class BookingScreen : Form
    {
        public BookingScreen()
        {
            InitializeComponent();
        }

        private void PreaparingShowTimes()
        {
            cbShowTimes.Items.Add(SessionData.movie.TimesAndSeats.Keys.ElementAt(0));
            cbShowTimes.Items.Add(SessionData.movie.TimesAndSeats.Keys.ElementAt(1));
            cbShowTimes.Items.Add(SessionData.movie.TimesAndSeats.Keys.ElementAt(2));
        }

        int counter = 500;

        private void PreparePrice()
        {
            lbPrice.Text = "500 $";
            lbTotalPrice.Text = "500 $";
        }

        private void BookingScreen_Load(object sender, EventArgs e)
        {
            PreaparingShowTimes();
            PreparePrice();
        }

        private void NumberOfTicketes_ValueChanged(object sender, EventArgs e)
        {
            counter = 500 *  Convert.ToInt32(NumberOfTicketes.Value);
            lbTotalPrice.Text = counter.ToString() +" $";
        }

        private string GetSelectedShowTime()
        {
            switch(cbShowTimes.SelectedIndex)
            {
                case 0:
                    return cbShowTimes.Items[0].ToString();

                case 1:
                    return cbShowTimes.Items[1].ToString();

                case 2:
                    return cbShowTimes.Items[2].ToString();
            }

            return "";
        }

        short Seatcounter = 1;
        private void btnOrder_Click(object sender, EventArgs e)
        {
            clsCinema.clsMovie.enSaveResult result = SessionData.movie.CheckIfThereAvailableSeats(GetSelectedShowTime(),Convert.ToInt32(NumberOfTicketes.Value));
            int AvailableSeats = SessionData.movie.GetAvailableSeats(GetSelectedShowTime());


            if (result == clsCinema.clsMovie.enSaveResult.svAvailableSeatsLessThanNumberReservedSates)
            {
                MessageBox.Show("Sorry, Available Seats ("+AvailableSeats+") is less Than your Reservard Ticktes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (result == clsCinema.clsMovie.enSaveResult.svNotAvailableSeats)
            {
                MessageBox.Show("Sorry, There aren't any AvailableSeat int This ShowTime For this Movie ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            else if (result == clsCinema.clsMovie.enSaveResult.svSuccesseded)

            {
                if (MessageBox.Show("Are you sure of booking", "Conform", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Seatcounter = clsCinema.clsBooking.GetLastSeatNumber(SessionData.movie.Title, GetSelectedShowTime());
                    for (int i = 1; i <= NumberOfTicketes.Value; i++)
                    {

                        clsCinema.clsBooking booking = new clsCinema.clsBooking(Guid.NewGuid().ToString().Substring(0, 18),
                             SessionData.currentUser.UserName, SessionData.movie.Title, GetSelectedShowTime(), Seatcounter);

                        booking.Save();

                        Seatcounter++;
                    }


                    SessionData.currentUser.Withdraw(Convert.ToInt32(lbTotalPrice.Text.Substring(0, lbTotalPrice.Text.Length-2)));
                    SessionData.movie.TimesAndSeats[GetSelectedShowTime()] -= Convert.ToInt32(NumberOfTicketes.Value);
                    SessionData.movie.UpdateSeatsAfterBooking();
                    MessageBox.Show("Booking has been done :)", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            

            
        }
    }
}
