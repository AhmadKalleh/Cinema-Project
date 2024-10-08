using Guna.UI2.WinForms.Suite;
using Guna.UI2.WinForms;
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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            
            InitializeComponent();
        }

  
        public void LoadScreen(object sender)
        {
            if (PanelScreen.Controls.Count > 0)
                PanelScreen.Controls.Clear();

            Form form = sender as Form;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            PanelScreen.Controls.Add(form);
            form.Show();
        }

      
        private void moveimage(object sender)
        {
            Guna2Button button = (Guna2Button)sender;
            pictureBox1.Location = new Point(button.Location.X + 58, button.Location.Y - 46);
            pictureBox1.SendToBack();
        }
        private void HomeScreen_Load(object sender, EventArgs e)
        {
           
            LoadScreen(new MoviesScreen(this));
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
           moveimage(sender);
           LoadScreen(new TicketesScreen());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            moveimage(sender);
            LoadScreen(new ProfileScreen());
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
           moveimage(sender);
          //  LoadScreen(new ContactUsScreen());*/
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            moveimage(sender);
            LoadScreen(new MoviesScreen(this));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
        }
    }
}
