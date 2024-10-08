using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CinemaProject.clsUser;

namespace CinemaProject
{
    internal  class clsComments
    {
        public  string FullName { get; set; }

        public string Date { get; }
        public  string body { get; set; }
        public  string MovieTitle {  get; set; }

        private enum enPeroids
        {
            seconds = 0,
            minute = 1,
            minutes = 2,
            hour = 3,
            hours = 4,
            day = 5,
            days = 6,
            year = 7,
            years = 8

        };

        
        private const string _fileName = @"C:\Users\ahmad\source\repos\CinemaProject\Comments.txt";

        public  clsComments(string Fullname,string body,string MovieTilte,string Date)
        {
            this.FullName = Fullname;
            this.body = body;
            this.MovieTitle = MovieTilte;
            this.Date = Date;
        }

        private static string _ConverCommentObjectToLine(clsComments Comment, char Seperator = '#')
        {

            string CommentRecord = "";
            CommentRecord += Comment.FullName + Seperator;
            CommentRecord += Comment.body + Seperator;
            CommentRecord += Comment.MovieTitle + Seperator;
            CommentRecord += Comment.Date;
            return CommentRecord;

        }

        private static clsComments _ConvertLinetoCommentObject(string Line, char Seperator = '#')
        {
            string[] vCommentData = Line.Split(Seperator);


            return new clsComments(vCommentData[0], vCommentData[1], vCommentData[2], vCommentData[3]);
                 
        }

        private void _AddNew()
        {
            _AddDataLineToFile(_ConverCommentObjectToLine(this));
        }

        private void _AddDataLineToFile(string stDataLine)
        {
            using (StreamWriter writer = new StreamWriter(_fileName, true))
            {
                writer.WriteLine(stDataLine);
            }

        }

        public void Save()
        {
            _AddNew();
        }
    
        public static string GetDate(string Date)
        {
            DateTime dateTime = DateTime.ParseExact(Date, "yyyy-MM-dd HH:mm:ss", null);

            TimeSpan Time = DateTime.Now.Subtract(dateTime);

            if (Time.Seconds > 0 && Time.Minutes == 0 && Time.Hours == 0)
            {

                return Convert.ToString(Time.Seconds) + " " + Convert.ToString(enPeroids.seconds) + " ago";

            }

            else if (Time.Minutes > 0 && Time.Hours == 0)
            {
                if (Time.Minutes == 1)
                {
                    return Convert.ToString(Time.Minutes) + " " + Convert.ToString(enPeroids.minute) + " ago";
                }
                else

                {
                    return Convert.ToString(Time.Minutes) + " " + Convert.ToString(enPeroids.minutes) + " ago";
                }
            }

            else if (Time.Hours > 0 && Time.Hours < 24)
            {
                if (Time.Hours == 1)
                {
                    return Convert.ToString(Time.Hours) + " " + Convert.ToString(enPeroids.hour) + " ago";
                }
                else

                {
                    return Convert.ToString(Time.Hours) + " " + Convert.ToString(enPeroids.hours) + " ago";
                }
            }

            else if (Time.Days > 0 && Time.Days <= 364)
            {
                if (Time.Days == 1)
                {
                    return Convert.ToString(Time.Days) + " " + Convert.ToString(enPeroids.day) + " ago";
                }
                else

                {
                    return Convert.ToString(Time.Days) + " " + Convert.ToString(enPeroids.days) + " ago";
                }
            }

            else
            {
                if ((Time.Days / 365) == 1)
                {
                    return Convert.ToString(Time.Days) + " " + Convert.ToString(enPeroids.year) + " ago";
                }
                else

                {
                    return Convert.ToString(Time.Days) + " " + Convert.ToString(enPeroids.years) + " ago";
                }
            }
        }
        public static Dictionary<string, List<string>> getCommentsList(string MovieTitle)
        {
            Dictionary<string,List<string>> comments = new Dictionary<string, List<string>>();
            
            try
            {
                StreamReader reader = new StreamReader(_fileName);
                string line = "";

                while ((line=reader.ReadLine()) !=null)
                {
                    clsComments Comment = _ConvertLinetoCommentObject(line);

                    if(Comment.MovieTitle == MovieTitle)
                    {
                        List<string> commentsList = new List<string>();
                        commentsList.Add(Comment.Date);
                        commentsList.Add(Comment.body);
                        comments.Add(Comment.FullName,commentsList);
                    }
                }

                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return comments;

        }




    }
}
