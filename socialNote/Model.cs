using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socialNote
{
    public class Model
    {

    }

    public class Note
    {
        private int ID;
        private string title;
        private string content;
        private DateTime dateTime;
        private Color titleColor;
        private Color fontColor;
        private int fontSize;
        private List<int> userList;
        public Note(int ID, string title, string content, DateTime dateTime, Color titleColor, Color fontColor, int fontSize, List<int> userList)
        {
            this.ID = ID;
            this.title = title;
            this.content = content;
            this.dateTime = dateTime;
            this.titleColor = titleColor;
            this.fontColor = fontColor;
            this.fontSize = fontSize;
            this.userList = userList;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public DateTime Date
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        public Color TitleColor
        {
            get { return titleColor; }
            set { titleColor = value; }
        }
        public Color FontColor
        {
            get { return fontColor; }
            set { fontColor = value; }
        }
        public int FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }
        public List<int> UserList
        {
            get { return userList; }
            set { userList = value; }
        }

    }

    public class User
    {
        private int userID;
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string password;
        private string mobileNumber;
        private List<int> noteID;

        public User(int userID, string firstName, string lastName, string emailAddress, string password,string mobileNumber,List<int> noteID)
        {
            this.userID = userID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.mobileNumber = mobileNumber;
            this.password = password;
            this.noteID = noteID;
        }

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Mobile
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
        public List<int> NoteID
        {
            get { return noteID; }
            set { noteID = value; }
        }

    }

}
