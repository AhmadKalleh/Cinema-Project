using CinemaProject.Properties;
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
    public partial class MovieDetails : Form
    {

        HomeScreen Screen;
        
        float Rate = 0.0f;
        public MovieDetails(HomeScreen screen)
        {
            InitializeComponent();
            Screen = screen;
        }

        private void LoadScreen(object sender)
        {
            if (Panel.Controls.Count > 0)
                Panel.Controls.Clear();

            Form form = sender as Form;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            Panel.Controls.Add(form);
            form.Show();
        }

       
        private void FillSelectedMovieToForm()
        {
            lbMovieName.Text= SessionData.movie.Title;
            lbRate.Text = SessionData.movie.Rate.ToString();

            if (lbRate.Text.Length > 3)
            {
                lbRate.Text = lbRate.Text.Substring(0, 3);
            }
            pbMovieImage.Image = Image.FromFile(@"C:\Users\ahmad\Downloads\FilmsImages\"+SessionData.movie.Title+".jpeg");

            if (lbRate.Text == "10")
            {
                pb1.Visible = pb2.Visible = pb3.Visible = pb4.Visible = pb5.Visible = false;
                lbTopRated.Visible = true;
                pictureBox2.Visible = true;
            }

            lbDescription.Text = SessionData.movie.Description;

        }
        private void MovieDetails_Load(object sender, EventArgs e)
        {
            FillSelectedMovieToForm();
            LoadScreen(new CommentsScreen());

        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            LoadScreen(new CommentsScreen());
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            LoadScreen(new BookingScreen());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Screen.LoadScreen(new MoviesScreen(Screen));  
        }

        private void DisablePicturesAfterRating()
        {
            pb1.Enabled = false;
            pb2.Enabled = false;
            pb3.Enabled = false;
            pb4.Enabled = false;
            pb5.Enabled = false;
        }
        private void ChangeImage(PictureBox picture)
        {
            switch(picture.Tag)
            {
                case "1":

                    pb1.Image = Resources.favorite;                 
                    pb2.Image = Resources.white_star;                    
                    pb3.Image = Resources.white_star;                    
                    pb4.Image = Resources.white_star;                    
                    pb5.Image = Resources.white_star;                  
                    Rate = 0.1f;

                break;

                case "2":

                    pb1.Image = Resources.favorite;
                    pb2.Image = Resources.favorite;
                    pb3.Image = Resources.white_star;
                    pb4.Image = Resources.white_star;
                    pb5.Image = Resources.white_star;
                    Rate = 0.2f;

                break;

                case "3":

                    pb1.Image = Resources.favorite;
                    pb2.Image = Resources.favorite;
                    pb3.Image = Resources.favorite;
                    pb4.Image = Resources.white_star;
                    pb5.Image = Resources.white_star;
                    Rate = 0.3f;

                break;

                case "4":

                    pb1.Image = Resources.favorite;
                    pb2.Image = Resources.favorite;
                    pb3.Image = Resources.favorite;
                    pb4.Image = Resources.favorite;
                    pb5.Image = Resources.white_star;
                    Rate = 0.4f;

                break;

                case "5":

                    pb1.Image = Resources.favorite;
                    pb2.Image = Resources.favorite;
                    pb3.Image = Resources.favorite;
                    pb4.Image = Resources.favorite;
                    pb5.Image = Resources.favorite;
                    Rate = 0.5f;

                break;

            }

            DisablePicturesAfterRating();
        }
        private void pb_Click(object sender, EventArgs e)
        {
            ChangeImage(sender as PictureBox);
            SessionData.movie.Rate += Rate;
            SessionData.movie.Save();
        }
    }
}
