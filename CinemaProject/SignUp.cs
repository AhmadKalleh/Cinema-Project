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
    public partial class SignUp : Form
    {
        private LoginScreen loginScreen = new LoginScreen();
        public SignUp(LoginScreen login)
        {
            InitializeComponent();
            loginScreen = login;
        }

        

        private void pbEye_Click(object sender, EventArgs e)
        {
            if (pbEye.Tag.ToString() == "Closed")
            {
                txtPasswordSignUp.UseSystemPasswordChar = false;
                pbEye.Image = Resources.eye__1_;
                pbEye.Tag = "Open";
            }
            else
            {
                txtPasswordSignUp.UseSystemPasswordChar = true;
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
        private void lbLogin_Click(object sender, EventArgs e)
        {
            LoadScreen(new Login(loginScreen));
        }
      
        
        private void txtCardNumberSignUp_TextChanged(object sender, EventArgs e)
        {
            string input = txtCardNumberSignUp.Text.Replace("-", "");


            if (input.Length >= 16)
            {
                txtCardNumberSignUp.MaxLength = 18;
                return;
            }


            StringBuilder formattedInput = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i > 0 && i % 4 == 0)
                {
                    formattedInput.Append("-");
                }
                formattedInput.Append(input[i]);
            }


            txtCardNumberSignUp.Text = formattedInput.ToString();
            txtCardNumberSignUp.SelectionStart = txtCardNumberSignUp.Text.Length;
        }

        private void txtCardNumberSignUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح فقط للارقام والحذف
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar !='\b')
            {
                e.Handled = true;
            } 
        }

        private void DisvisibleAnothors()
        {
            txtCardNumberSignUp.Visible = false;
            txtFullNameSignUp.Visible = false;
            txtPasswordSignUp.Visible = false;
            txtUsernameSignUp.Visible = false;
            txtPINCodeSignUp.Visible = false;
            btnCreateAccount.Visible = false;
            lbLogin.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            pbEye.Visible = false;
            Loading.Visible = true;
            lbWait.Visible = true;

            
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if(txtUsernameSignUp.Text == string.Empty || txtPINCodeSignUp.Text == string.Empty ||
               txtPasswordSignUp.Text == string.Empty || txtCardNumberSignUp.Text == string.Empty ||
               txtFullNameSignUp.Text == string.Empty)
            {
                MessageBox.Show("You must Enter all Information :(", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (clsUser.IsCardIDExist(txtCardNumberSignUp.Text))
            {
                MessageBox.Show("This Card ID already Used, Please Enter Another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SessionData.currentUser = clsUser.GetAddNewUserObject(txtUsernameSignUp.Text);
                SessionData.currentUser.FullName = txtFullNameSignUp.Text;
                SessionData.currentUser.PINCode = Convert.ToInt32(txtPINCodeSignUp.Text);
                SessionData.currentUser.Password = txtPasswordSignUp.Text;
                SessionData.currentUser.CardID = txtCardNumberSignUp.Text;

                clsUser.enSaveResults results = SessionData.currentUser.Save();

                if(results == clsUser.enSaveResults.svSucceeded)
                {

                    DisvisibleAnothors();
                    timer1.Start();
                }

            }

            
            
        }

        int counter = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            

            if(counter==4)
            {
                timer1.Stop();
                Loading.Animated = false;
                this.Close();
                HomeScreen homeScreen = new HomeScreen();
                homeScreen.Show();

            }
        }

       
        private void txtPINCodeSignUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtPINCodeSignUp_TextChanged(object sender, EventArgs e)
        {
            if(txtCardNumberSignUp.Text.Length >= 6)
            {
                txtCardNumberSignUp.ReadOnly=true;
                return;
            }
        }

        private void txtUsernameSignUp_Leave(object sender, EventArgs e)
        {
            if(!txtUsernameSignUp.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Please Enter a Valid Username like this *****@gmail.com", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsernameSignUp.Focus();
                return;
            }
            if(clsUser.IsUserExist(txtUsernameSignUp.Text))
            {
                MessageBox.Show("This Username already Used, Please Enter Another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsernameSignUp.Focus();
                txtUsernameSignUp.Text = string.Empty;
                return;
            }
        }

        
    }
}
