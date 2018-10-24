using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socialNote
{
    class Controller
    {
        List<Note> NoteList = new List<Note>();
        List<User> UserList = new List<User>();

        public Controller()
        {
            NoteList.Add(new Note(1, "APD Week 4", "The way to construct list: List <int> myList=new List<int>().", new DateTime(2018, 09, 01), Color.Black, Color.Black, 10, new List<int> { 1, 2 }));
            NoteList.Add(new Note(1, "Web Dev Week 3", "Back-end:asp.net MVC; Front-end:ReactJS.", new DateTime(2018, 08, 30), Color.Blue, Color.Brown, 10, new List<int> { 1, 2, 3 }));

            UserList.Add(new User(1, "Eric", "Zhou", "eric.zhou0815@gmail.com", "hily2018", "0234364365", new List<int> { 1, 2 }));
            UserList.Add(new User(2, "Ada", "Cheung", "adacheungnz@gmail.com", "123456", "0234338346", new List<int> { 1, 2 }));
            UserList.Add(new User(3, "Ariel", "Li", "arielli@gmail.com", "123456", "0218682268", new List<int> { 1 }));
            UserList.Add(new User(4, "Dong", "Chang", "dongchang@gmail.com", "123456", "02125248818", new List<int> { 2 }));
        }

        //load note cards after the login
        public Boolean loadNote()
        {
            return true;
        }

        public void saveNote(int noteID, string noteTitle, string noteContent, DateTime now, Color titleColor, Color fontColor, int noteFontSize, int userID)
        {
            if (noteID==0)//save Add
            {
                NoteList.Add(new Note(NoteList.Count+1, noteTitle, noteContent, now, titleColor, fontColor, noteFontSize, new List<int> { userID }));
            }
            else //save Edit
            {
                NoteList[noteID - 1].Title = noteTitle;
                NoteList[noteID - 1].Content = noteContent;
                NoteList[noteID - 1].Date = now;
                NoteList[noteID - 1].TitleColor = titleColor ;
                NoteList[noteID - 1].FontColor = fontColor;
                NoteList[noteID - 1].FontSize = noteFontSize;

                if(!NoteList[noteID - 1].UserList.Contains(userID))
                {
                    NoteList[noteID - 1].UserList.Add(userID);
                }
            }
        }


        public int LoginCheck(string loginAccount, string loginPassword) //check account and password
        {
            int theID = 0;
            foreach (User user in UserList)
            {
                if ((loginAccount== user.Email)&&(loginPassword== user.Password))
                {
                    theID=user.UserID;
                }

            }

            return theID;
        }

        public Note findNote(int noteID)
        {
            return NoteList[noteID-1];
        }

        public List<Note> sendNoteList()
        {
            return NoteList;
        }


        public void deleteNote(int noteID)
        {
            NoteList.RemoveAt(noteID - 1);
        }

        public List<User> loadUsers(int noteID)
        {
            List<User> userNames = new List<User>();
            List<int> idList=NoteList[noteID - 1].UserList;
            foreach (int id in idList)
            {
                userNames.Add(UserList[id]);
            }
            return userNames;
        }

    }

}
