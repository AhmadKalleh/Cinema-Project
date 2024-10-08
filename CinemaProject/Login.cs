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
    public partial class Login : Form
    {

        private LoginScreen loginScreen = new LoginScreen();
        public Login(LoginScreen login)
        {
            InitializeComponent();
            loginScreen = login;

        }

        

        private void pbEye_Click(object sender, EventArgs e)
        {
            if (pbEye.Tag.ToString() == "Closed")
            {
                txtPasswordLogin.UseSystemPasswordChar = false;
                pbEye.Image = Resources.eye__1_;
                pbEye.Tag = "Open";
            }
            else
            {
                txtPasswordLogin.UseSystemPasswordChar = true;
                pbEye.Image = Resources.eye1;
                pbEye.Tag = "Closed";
            }
        }

        private void LoadScreen(object sender)
        {
            if (loginScreen.getPanel().Controls.Count > 0)
                loginScreen.getPanel().Controls.Clear();

            Form form = sender as Form;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            loginScreen.getPanel().Controls.Add(form);
            form.Show();
        }
        private void btnGoToCreateAccount_Click(object sender, EventArgs e)
        {          
            LoadScreen(new SignUp(loginScreen));        
        }


        short Counter = 59;
        short FaildLoginCount = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            SessionData.currentUser = clsUser.Find(txtUsernameLogin.Text, txtPasswordLogin.Text);

            bool LoginFaild = SessionData.currentUser.IsEmpty();
            

            if (LoginFaild)
            {
                MessageBox.Show("invailed Username/Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FaildLoginCount++;

                if(FaildLoginCount == 3)
                {
                    btnLogin.Enabled = false;
                    txtPasswordLogin.Text = txtUsernameLogin.Text = string.Empty;
                    lbWait2.Visible = lbWaitTimer.Visible = lbWait.Visible = true;
                    timer1.Start();
                }
            }
            else
            {
                this.Close();
                loginScreen.Visible = false;
                HomeScreen homeScreen = new HomeScreen();
                homeScreen.Show();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter--;
            lbWaitTimer.Text = Counter.ToString();

            if (Counter == 0)
            {
                timer1.Stop();
                btnLogin.Enabled = true;
                lbWait2.Visible = lbWaitTimer.Visible = lbWait.Visible = false;
                lbWaitTimer.Text = "59";
                Counter = 59;
                FaildLoginCount = 0;
            }
        }
    }
}
