using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CinemaProject.clsCinema;
using static System.Windows.Forms.LinkLabel;

namespace CinemaProject
{
    internal class clsUser
    {

        private const string _fileName = @"C:\Users\ahmad\source\repos\CinemaProject\Users.txt";
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

        public string CardID { get; set; }

        public double AccountBalance { get; set; }
        public int PINCode { get; set; }

        public enum enMode { EmptyMode = 0, SearchMode = 1,AddNewMode = 2 };
        private enMode _Mode;

        private static string _ConverUserObjectToLine(clsUser User, char Seperator = '#')
        {

            string UserRecord = "";
            UserRecord += User.UserName + Seperator;
            UserRecord += EncryptText(User.Password) + Seperator;
            UserRecord += User.FullName + Seperator;
            UserRecord += EncryptText(Convert.ToString(User.PINCode)) + Seperator;
            UserRecord += EncryptText(User.CardID) + Seperator;
            UserRecord += User.AccountBalance;

            return UserRecord;

        }

        private static clsUser _ConvertLinetoUserObject(string Line, char Seperator = '#')
        {
            string[] vUserData = Line.Split(Seperator);

            

            return new clsUser(enMode.SearchMode,
                vUserData[0],
                DecryptText(vUserData[1]),
                vUserData[2],
                DecryptText(vUserData[4]),
                Convert.ToInt32(DecryptText(vUserData[3])),
                Convert.ToDouble(vUserData[5])
                );
        }

        public clsUser(enMode mode, string username, string password, string fullName, string cardNumber, int PINCode,double AccountBalance)
        {
            this._Mode = mode;
            this.UserName = username;
            this.Password = password;
            this.FullName = fullName;
            this.CardID = cardNumber;
            this.PINCode = PINCode;
            this.AccountBalance = AccountBalance;
        }
        private void _AddNew()
        {

            _AddDataLineToFile(_ConverUserObjectToLine(this));
        }

        private void _AddDataLineToFile(string stDataLine)
        {
            using (StreamWriter writer = new StreamWriter(_fileName, true))
            {
                writer.WriteLine(stDataLine);
            }
            
        }

        private static string EncryptText(string Text, short EncryptionKey = 2)
        {
            char[] chars = Text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != '-')
                    chars[i] = Convert.ToChar((int)chars[i] + EncryptionKey);
            }


            return new string(chars);
        }


        private static string DecryptText(string Text, short EncryptionKey = 2)
        {
            char[] chars = Text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != '-')
                    chars[i] = Convert.ToChar((int)chars[i] - EncryptionKey);
            }

            return new string(chars);
        }
        

        private static clsUser _GetEmptyUserObject()
        {
            return new clsUser(enMode.EmptyMode, "", "", "", "", 0,0);
        }


        

       
        public bool IsEmpty()
        {
            return (_Mode == enMode.EmptyMode);
        }

        public enum enSaveResults { svFaildEmptyObject = 0, svSucceeded = 1, svFaildUserExists = 2 };
        public enSaveResults Save()
        {

            switch (_Mode)
            {

                case enMode.EmptyMode:
                {
                    if (IsEmpty())
                    {
                        return enSaveResults.svFaildEmptyObject;
                    }

                    break;
                }

                case enMode.AddNewMode:
                {
                        //This will add new record to file or database
                     if (clsUser.IsUserExist(UserName))
                     {
                         return enSaveResults.svFaildUserExists;
                     }
                     else
                     {
                         _AddNew();
                         //We need to set the mode to update after add new
                         _Mode = enMode.SearchMode;
                         return enSaveResults.svSucceeded;
                     }
                      
                }
                                 
            }

            return enSaveResults.svFaildUserExists;
           


        }

        public static clsUser Find(string Username, string Password)
        {
            


            try
            {
                StreamReader reader = new StreamReader(_fileName);

                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    clsUser User = _ConvertLinetoUserObject(line);
                    if (User.UserName.Equals(Username) && User.Password.Equals(Password))
                    {
                        reader.Close();
                        return User;
                    }
                }

                reader.Close();


            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return _GetEmptyUserObject();


        }

        public static clsUser Find(string Username)
        {
            if (Username == string.Empty) return null;

            try
            {

                StreamReader reader = new StreamReader(_fileName);

                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    clsUser User = _ConvertLinetoUserObject(line);
                    if (User.UserName.Equals(Username))
                    {
                        reader.Close();
                        return User;
                    }
                }

                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return _GetEmptyUserObject();


        }

        public static bool IsCardIDExist(string CardID)
        {

            try
            {

                StreamReader reader = new StreamReader(_fileName);

                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    clsUser User = _ConvertLinetoUserObject(line);
                    if (User.CardID.Equals(CardID))
                    {
                        reader.Close();
                        return true;
                    }
                }

                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return false;


        }

        public static clsUser GetAddNewUserObject(string UserName)
        {
            return new clsUser(enMode.AddNewMode, UserName, "", "", "",0,50000);
        }

        public static bool IsUserExist(string UserName)
        {

            clsUser User = clsUser.Find(UserName);
            return (!User.IsEmpty());
        }

        private List<clsUser> _LoadUsersDataFromFile()
        {
            List < clsUser > users = new List<clsUser>();
            try
            {

                StreamReader reader = new StreamReader(_fileName);

                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    clsUser User = _ConvertLinetoUserObject(line);
                    users.Add(User);

                }

                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return users;   
        }
        private bool _SaveUsersDataToFile(List<clsUser> users)
        {
            using (StreamWriter writer = new StreamWriter(_fileName))
            {
                foreach (clsUser user in users)
                {
                    
                    string line = _ConverUserObjectToLine(user);
                    writer.Write(line + "\n");
                    
                }

                return true;
            }
        }

        public void Update()
        {
            List<clsUser> users = _LoadUsersDataFromFile();

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].UserName.Equals(UserName))
                {
                    users[i] = this;
                }
            }

            _SaveUsersDataToFile(users);
        }


        public bool Withdraw(int Amount)
        {
            if(Amount > this.AccountBalance) 
                return false;
            else
            {
                this.AccountBalance -= Amount;
                Update();
                return true;    
            }
        }
    }
}
