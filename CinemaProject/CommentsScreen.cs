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
    public partial class CommentsScreen : Form
    {
        public CommentsScreen()
        {
            InitializeComponent();
        }
        int buttonCount = 0;

        private void CreateCommentBox(string FullName,string Date,string Body)
        {
            Guna2TextBox textBox = new Guna2TextBox();
            textBox.Font = Comment1.Font;
            textBox.Size = Comment1.Size;
            textBox.FillColor = Comment1.FillColor;
            textBox.ForeColor = Comment1.ForeColor;
            textBox.BackColor = Comment1.BackColor;
            textBox.Location = new Point(33,70*buttonCount);
            textBox.BorderColor = Comment1.BorderColor;
            textBox.ReadOnly = Comment1.ReadOnly;
            textBox.Multiline = Comment1.Multiline;
            textBox.BorderThickness = Comment1.BorderThickness;
            textBox.Animated = Comment1.Animated;
            textBox.HoverState.BorderColor = Comment1.HoverState.BorderColor;
            textBox.FocusedState.BorderColor = Comment1.FocusedState.BorderColor;
            textBox.BorderRadius = Comment1.BorderRadius;
            textBox.Text = FullName +" - "+ Date + Environment.NewLine + Body;
            textBox.TextOffset = Comment1.TextOffset;
            CommentsPanel.Controls.Add(textBox);

            buttonCount++;

        }

        private void PreaparingComments(Dictionary<string, List<string>> comments)
        {
            for(int i=0;i<comments.Count;i++)
            {
                CreateCommentBox(comments.Keys.ElementAt(i), clsComments.GetDate(comments.Values.ElementAt(i).ElementAt(0)), comments.Values.ElementAt(i).ElementAt(1));
            }
        }
       
        private void CommentsScreen_Load(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> comments = clsComments.getCommentsList(SessionData.movie.Title);

            if(comments.Count == 0 )
            {
                lbNoComments.Visible = true;
            }
            else
            {
                lbNoComments.Visible = false;
                PreaparingComments(comments);
            }
        }

        private void btnSendComment_Click(object sender, EventArgs e)
        {
            lbNoComments.Visible = false;

            if (txtComment.Text != string.Empty)
            {
                clsComments Comment = new clsComments(SessionData.currentUser.FullName, txtComment.Text, SessionData.movie.Title, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                CreateCommentBox(Comment.FullName, "a few seconds ago", Comment.body);
                Comment.Save();
                txtComment.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("you must enter comment :(","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
