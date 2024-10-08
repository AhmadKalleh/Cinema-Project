using CinemaProject.Properties;
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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
           
        }

        public  Guna2Panel getPanel()
        { 
            return this.Panel;
        }

        private void LoadScreen(object sender)
        {
            if(Panel.Controls.Count > 0) 
                Panel.Controls.Clear();

            Form form = sender as Form;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            Panel.Controls.Add(form);
            form.Show();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            LoadScreen(new Login(this));
        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
