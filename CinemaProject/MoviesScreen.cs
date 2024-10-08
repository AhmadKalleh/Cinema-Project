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
    public partial class MoviesScreen : Form
    {

        private HomeScreen homeScreen;
        public MoviesScreen(HomeScreen homeScreen)
        {
            InitializeComponent();
            this.homeScreen = homeScreen;
        }

        public List<Guna2Button> buttons = new List<Guna2Button>();
        List<clsCinema.clsMovie> movies = clsCinema.clsMovie.GetMoviesList();
        private bool isDecorated = false;


        private void SetDecoration(Guna2Button button)
        {
            if (!isDecorated)
            {
                button.ShadowDecoration.Enabled = true;
                isDecorated = true;
            }


            
        }

        private void DeleteDecoration(Guna2Button button)
        {
            button.ShadowDecoration.Enabled = false;
            isDecorated = false;
        }
        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            SetDecoration(sender as Guna2Button);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            DeleteDecoration(sender as Guna2Button);
            //"C:\Users\ahmad\Downloads\FilmsImages\Before Sunrise.jpeg"
        }

        private void MoviesScreen_Load(object sender, EventArgs e)
        {
            buttons.Add(btn1);
            buttons.Add(btn2);
            buttons.Add(btn3);
            buttons.Add(btn4);
            buttons.Add(btn5);
            buttons.Add(btn6);
            buttons.Add(btn7);
            buttons.Add(btn8);
            buttons.Add(btn9);
            buttons.Add(btn10);
            buttons.Add(btn11);
            buttons.Add(btn12);
            buttons.Add(btn13);
            buttons.Add(btn14);
            buttons.Add(btn15);
            buttons.Add(btn16);
            buttons.Add(btn17);
            buttons.Add(btn18);
            buttons.Add(btn19);
            buttons.Add(btn20);
            buttons.Add(btn21);
            buttons.Add(btn22);
            buttons.Add(btn23);
            buttons.Add(btn24);
            buttons.Add(btn25);
            buttons.Add(btn26);
            buttons.Add(btn27);
            buttons.Add(btn28);
            buttons.Add(btn29);
            buttons.Add(btn30);
            buttons.Add(btn31);
            buttons.Add(btn32);
            buttons.Add(btn33);
            buttons.Add(btn34);
            buttons.Add(btn35);
            buttons.Add(btn36);
            buttons.Add(btn37);
            buttons.Add(btn38);
            buttons.Add(btn39);
            buttons.Add(btn40);
            buttons.Add(btn41);
            buttons.Add(btn42);
            buttons.Add(btn43);
            buttons.Add(btn44);
            buttons.Add(btn45);
            buttons.Add(btn46);
            buttons.Add(btn47);
            buttons.Add(btn48);

            
        }

        private clsCinema.clsMovie GetSelectedMovie(Guna2Button button)
        {
           
            for (int i = 0;movies.Count > 0;i++)
            {
                if (button.Tag.ToString().Equals(movies[i].Title))
                {
                    return movies[i];
                }
            }

            return null;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            SessionData.movie =  GetSelectedMovie((Guna2Button)sender);
            homeScreen.LoadScreen(new MovieDetails(homeScreen));
        }

        private void ShowAllMovies()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Visible = true;
                buttons[i].Location = new Point(X,Y);

                X += buttons[i].Width + buttonspace;

                if(X + buttons[i].Width > this.Width)
                {
                    X = 80;
                    Y += buttons[i].Height + buttonspace;
                }

            }

            X = 80;
            Y = 130;
        }

        
        private void txtSearch_IconRightClick(object sender, EventArgs e)
        {
            for(int i=0;i<buttons.Count;i++)
            {
                if(buttons[i].Tag.ToString().ToLower().Trim().Equals(txtSearch.Text.ToLower().Trim()))
                {
                    buttons[i].Visible = false;
                    btnSearchedMovie.Visible = true;
                    btnSearchedMovie.Image = buttons[i].Image;
                }
                else
                {
                    buttons[i].Visible = false;
                }
                    
            }
        }

        int X = 80, Y = 130;
        int buttonspace = 35;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            if(txtSearch.Text.Equals(string.Empty))
            {
                ShowAllMovies();
                return;
            }
        }

        private void ShowRelatedMoviesToThisType(string type)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Type.Equals(type))
                {
                    buttons[i].Visible = true;
                    buttons[i].Location = new Point(X, Y);

                    X += buttons[i].Width + buttonspace;

                    if (X + buttons[i].Width > this.Width)
                    {
                        X = 80;
                        Y += buttons[i].Height + buttonspace;
                    }
                }
            }

            X = 80;
            Y = 130;
        }
      

        private void HideAllMovies()
        {
            for(int i=0;i< buttons.Count;i++)
            {
                buttons[i].Visible=false;
            }
        }

        private void cbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbFilterType.SelectedIndex)
            {
                case 0:
                    ShowAllMovies();
                    break;

                case 1:
                    HideAllMovies();
                    ShowRelatedMoviesToThisType(cbFilterType.Items[1].ToString());
                    break;

                case 2:
                    HideAllMovies();
                    ShowRelatedMoviesToThisType(cbFilterType.Items[2].ToString());
                    break;

                case 3:
                    HideAllMovies();
                    ShowRelatedMoviesToThisType(cbFilterType.Items[3].ToString());
                    break;

                case 4:
                    HideAllMovies();
                    ShowRelatedMoviesToThisType(cbFilterType.Items[4].ToString());
                    break;

                case 5:
                    HideAllMovies();
                    ShowRelatedMoviesToThisType(cbFilterType.Items[5].ToString());
                    break;

                case 6:
                    HideAllMovies();
                    ShowRelatedMoviesToThisType(cbFilterType.Items[6].ToString());
                    break;

                case 7:
                    HideAllMovies();
                    ShowRelatedMoviesToThisType(cbFilterType.Items[7].ToString());
                    break;

                case 8:
                    HideAllMovies();
                    ShowRelatedMoviesToThisType(cbFilterType.Items[8].ToString());
                    break;

                case 9:
                    HideAllMovies();
                    ShowRelatedMoviesToThisType(cbFilterType.Items[9].ToString());
                    break;

                case 10:
                    HideAllMovies();
                    ShowRelatedMoviesToThisType(cbFilterType.Items[10].ToString());
                    break;

            }
        }
    }
}
