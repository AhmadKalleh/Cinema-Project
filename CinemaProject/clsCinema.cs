using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static CinemaProject.clsUser;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CinemaProject
{
    internal class clsCinema
    {

        internal class clsMovie
        {
            public string Title {  get; set; }
            public string Description { get; set; }

            public string Type { get; set; }

            public Dictionary<string,int> TimesAndSeats = new Dictionary<string,int>();
            
            public double Rate {  get; set; }

            private const string _fileName = @"C:\Users\ahmad\source\repos\CinemaProject\Movies.txt";

            public clsMovie(string Title,string Type,string Description,string ShowTime1,string ShowTime2,string ShowTime3,int availableSeats1ForFirstPeriode,
                int availableSeats1ForSecondPeriode, int availableSeats1ForThirdPeriode, double Rate)
            {
                this.Title = Title;
                this.Type = Type;
                this.Description = Description;
                this.TimesAndSeats.Add(ShowTime1, availableSeats1ForFirstPeriode);
                this.TimesAndSeats.Add(ShowTime2, availableSeats1ForSecondPeriode);
                this.TimesAndSeats.Add(ShowTime3, availableSeats1ForThirdPeriode);
                this.Rate = Rate;
            }

          
            private static clsMovie _ConvertLinetoMovieObject(string Line, char Seperator = '#')
            {
                string[] vCommentData = Line.Split(Seperator);


                return new clsMovie(vCommentData[0], vCommentData[1], vCommentData[2],
                    vCommentData[3], vCommentData[4], vCommentData[5],
                    Convert.ToInt32(vCommentData[6]), Convert.ToInt32(vCommentData[7]), Convert.ToInt32(vCommentData[8]), 
                    Convert.ToDouble(vCommentData[9]));

            }

            private static string _ConverMovieObjectToLine(clsMovie Movie, char Seperator = '#')
            {

                string MovieRecord = "";
                MovieRecord += Movie.Title + Seperator;
                MovieRecord += Movie.Type + Seperator;
                MovieRecord += Movie.Description + Seperator;
                MovieRecord += Movie.TimesAndSeats.Keys.ElementAt(0) + Seperator;
                MovieRecord += Movie.TimesAndSeats.Keys.ElementAt(1) + Seperator;
                MovieRecord += Movie.TimesAndSeats.Keys.ElementAt(2) + Seperator;
                MovieRecord += Convert.ToString(Movie.TimesAndSeats.Values.ElementAt(0)) + Seperator;
                MovieRecord += Convert.ToString(Movie.TimesAndSeats.Values.ElementAt(1)) + Seperator;
                MovieRecord += Convert.ToString(Movie.TimesAndSeats.Values.ElementAt(2)) + Seperator;
                MovieRecord += Convert.ToString(Movie.Rate);
                return MovieRecord;

            }

            private static List<clsMovie> _LoadMoviesDataFromFile()
            {
                List<clsMovie> movies = new List<clsMovie>();
                try
                {
                    StreamReader reader = new StreamReader(_fileName);
                    string line = "";

                    while ((line = reader.ReadLine()) != null)
                    {
                        clsMovie movie = _ConvertLinetoMovieObject(line);
                        movies.Add(movie);
                    }

                    reader.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }

                return movies;
            }

            public static List<clsMovie> GetMoviesList()
            {
                return _LoadMoviesDataFromFile();
            }

            private bool _SaveMoviesDataToFile(List<clsMovie> movies)
            {
                using (StreamWriter writer = new StreamWriter(_fileName))
                {
                    foreach(clsMovie movie in  movies)
                    {
                        string line = _ConverMovieObjectToLine(movie);
                        writer.Write(line+"\n");
                    }

                    return true;
                }
            }

            public static clsMovie Find(string Title)
            {
                List<clsMovie> movies = GetMoviesList();

                for (int i = 0; i < movies.Count;i++)
                {
                    if (movies[i].Title == Title)
                        return movies[i];
                }

                return null;
            }
            private void _UpdateRate()
            {
                List<clsMovie> movies = _LoadMoviesDataFromFile();

                for(int i = 0; i < movies.Count; i++)
                {
                    if(movies[i].Title == Title)
                    {
                        movies[i] = this;
                        break;
                    }
                }

                _SaveMoviesDataToFile(movies);


            }

            public enum enSaveResult { svSuccesseded =0 , svAvailableSeatsLessThanNumberReservedSates =1, svNotAvailableSeats=2};

            public enSaveResult CheckIfThereAvailableSeats(string SelectedShowTime, int ReservedSeatsNumber)
            {
                List<clsMovie> movies = _LoadMoviesDataFromFile();

                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].Title.Equals(this.Title))
                    {
                        if (movies[i].TimesAndSeats[SelectedShowTime] > 0 && movies[i].TimesAndSeats[SelectedShowTime] >= ReservedSeatsNumber)
                        {                          
                            return enSaveResult.svSuccesseded;
                        }
                        else if (movies[i].TimesAndSeats[SelectedShowTime] < ReservedSeatsNumber && movies[i].TimesAndSeats[SelectedShowTime] !=0)
                        {
                            return enSaveResult.svAvailableSeatsLessThanNumberReservedSates;
                        }
                        else if (movies[i].TimesAndSeats[SelectedShowTime] == 0)
                        {
                            return enSaveResult.svNotAvailableSeats;
                        }


                    }
                }

                return enSaveResult.svNotAvailableSeats;
            }
            public bool UpdateSeatsAfterBooking()
            {
                List<clsMovie> movies = _LoadMoviesDataFromFile();

                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].Title.Equals(this.Title))
                    {
                        movies[i] = this;
                    }
                }

                _SaveMoviesDataToFile(movies);

                return true;

            }

            public int GetAvailableSeats(string SelectedShowTime)
            {
                List<clsMovie> movies = _LoadMoviesDataFromFile();

                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].Title.Equals(this.Title))
                    {
                        return movies[i].TimesAndSeats[SelectedShowTime];
                    }
                }

                return 0;
            }
            public bool UpdateSeatsAfterCanclingTicket(string SelectedShowTime)
            {
                List<clsMovie> movies = _LoadMoviesDataFromFile();

                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].Title.Equals(this.Title))
                    {
                        movies[i].TimesAndSeats[SelectedShowTime]++;
                        break;
                    }
                }

                _SaveMoviesDataToFile(movies);

                return true;
            }
           
            public void Save()
            {
                _UpdateRate();
            }

        }

        internal class clsBooking
        {
            public string TicketID { get; set; }
            public string Title { get; set; }
            public string ShowTime { get; set; }

            public short SeatNumber { get; set; }

            public string Username { get; set; }

            public static double _Price = 500;
            private bool _MarkedForDeleted = false;
            private const string _fileName = @"C:\Users\ahmad\source\repos\CinemaProject\Ticketes.txt";

            private short counter = 1;
            public clsBooking(string ticketID, string username,string title, string showTime, short seatNumber)
            {
                TicketID = ticketID;
                Username = username;
                Title = title;
                ShowTime = showTime;
                SeatNumber = seatNumber;
            }

            public bool MarkedForDeleted()
            {
                return _MarkedForDeleted;
            }
            private static string _ConverTicketObjectToLine(clsBooking ticket, char Seperator = '#')
            {

                string TicketRecord = "";
                TicketRecord += ticket.TicketID+ Seperator;
                TicketRecord += ticket.Username + Seperator;
                TicketRecord += ticket.Title + Seperator;
                TicketRecord += ticket.ShowTime + Seperator;
                TicketRecord += "Hall 1 - Seat("+Convert.ToString(ticket.SeatNumber)+")" + Seperator;
                TicketRecord += Convert.ToString(_Price);

                return TicketRecord;

            }

            private static clsBooking _ConvertLinetoTicketObject(string Line, char Seperator = '#')
            {
                string[] vUserData = Line.Split(Seperator);

                string Pattern = @"\((\d+)\)";
                Match match = Regex.Match(vUserData[4], Pattern);
                short Number = 0;
                if (match.Success)
                {
                     Number = Convert.ToInt16(match.Groups[1].Value);
                }
                return new clsBooking(vUserData[0],vUserData[1], vUserData[2],
                      vUserData[3], Number);
            }

            private static List<clsBooking> _LoadTicketesDataFromFile()
            {
                List<clsBooking> bookings = new List<clsBooking>();
                
                try
                {
                    StreamReader reader = new StreamReader(_fileName);
                    string line = "";

                    while ((line=reader.ReadLine()) !=null)
                    {
                        clsBooking booking = _ConvertLinetoTicketObject(line);                     
                        bookings.Add(booking);
                        
                        
                    }

                    reader.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }

                return bookings;

            }

            public static List<clsBooking> GetTicktesListForCurrentUser()
            {
                List<clsBooking> AllBookings = _LoadTicketesDataFromFile();
                List < clsBooking > Bookings = new List<clsBooking>();  

                for (int  i = 0; i < AllBookings.Count; i++)
                {
                    if(AllBookings[i].Username == SessionData.currentUser.UserName)
                    {
                        Bookings.Add(AllBookings[i]);
                    }
                }
                
                return Bookings;
            }
            public static List<clsBooking> GetTicketesList()
            {
                return _LoadTicketesDataFromFile();
            }
            private void _AddDataLineToFile(string stDataLine)
            {
                using (StreamWriter writer = new StreamWriter(_fileName, true))
                {
                    writer.WriteLine(stDataLine);
                }

            }

            public static short GetLastSeatNumber(string SelectedMovie,string SelectedShowTime)
            {
                short lastSeatNumber = 1;

                try
                {
                    StreamReader reader = new StreamReader(_fileName);

                    string line = "";

                    while ((line = reader.ReadLine()) != null)
                    {
                        clsBooking booking = _ConvertLinetoTicketObject(line);
                        if(booking.Title.Equals(SelectedMovie) && booking.ShowTime.Equals(SelectedShowTime))
                        {                           
                            lastSeatNumber = booking.SeatNumber;
                        }
                    }

                    reader.Close ();
                }
                catch (IOException e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }

                if (lastSeatNumber != 1)
                {
                    return ++lastSeatNumber;
                }
                else
                {
                    return lastSeatNumber;
                }
               
            }
            private void _AddNew()
            {
                _AddDataLineToFile(_ConverTicketObjectToLine(this));
            }
            public void Save()
            {
                _AddNew();
            }

            private bool _SaveBookingsDataToFile(List<clsBooking> bookings)
            {
                using (StreamWriter writer = new StreamWriter(_fileName))
                {
                    foreach (clsBooking booking in bookings)
                    {
                        if(booking.MarkedForDeleted() == false)
                        {
                            string line = _ConverTicketObjectToLine(booking);
                            writer.Write(line+"\n");
                        }
                        
                    }

                    return true;
                }
            }

            private void ShiftSeatsByOne()
            {
                List<clsBooking> bookings = GetTicketesList();

                bool isUpdated = false;
                for (int i = 0; i < bookings.Count; i++)
                {
                    if (bookings[i].Username.Equals(SessionData.currentUser.UserName) &&  bookings[i].SeatNumber >= counter)
                    {
                        bookings[i].SeatNumber--;
                        isUpdated = true;
                    }
                }

                if(isUpdated)
                    _SaveBookingsDataToFile(bookings);

                

            }
            public bool Delete()
            {
                List<clsBooking> bookings = GetTicketesList();
                counter = GetTicktesListForCurrentUser()[0].SeatNumber;


                for(int i=0;i<bookings.Count;i++)
                {
                    if (bookings[i].Username.Equals(SessionData.currentUser.UserName) && bookings[i].SeatNumber.Equals(this.SeatNumber))
                    {
                        bookings[i]._MarkedForDeleted = true;
                        break;
                    }
                    else if (bookings[i].Username.Equals(SessionData.currentUser.UserName))
                    {
                        counter++;
                    }
                }

                _SaveBookingsDataToFile(bookings);


                ShiftSeatsByOne();

                return true;
               

            }
        }
    }
}
