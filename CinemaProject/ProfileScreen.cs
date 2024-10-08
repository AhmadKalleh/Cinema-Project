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
    public partial class ProfileScreen : Form
    {
        public ProfileScreen()
        {
            InitializeComponent();
        }

        private void ProfileScreen_Load(object sender, EventArgs e)
        {
            txtFullName.Text = SessionData.currentUser.FullName;
            txtUsername.Text = SessionData.currentUser.UserName;
            txtPINCode.Text = SessionData.currentUser.PINCode.ToString();
            txtIDCard.Text= SessionData.currentUser.CardID;
            txtNetBalance.Text = SessionData.currentUser.AccountBalance.ToString();
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            SessionData.currentUser.FullName = txtFullName.Text;
            SessionData.currentUser.Update();
        }

        private void txtPINCode_Leave(object sender, EventArgs e)
        {
            SessionData.currentUser.PINCode =   Convert.ToInt32(txtPINCode.Text);
            SessionData.currentUser.Update();
        }
    }
}
