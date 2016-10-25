using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    // This class could be part of an application similar to Facebook.
    // The class represents a status that a user can post - other users
    // can then "like" or "dislike" the status post 
    public class Status
    {
        private string statusText;
        private int likes;
        private int dislikes;
        private int numberOfReads;

        // Create the Status - initially, the status has zero likes
        // and zero dislikes
        public Status(string statusText)
        {
            this.statusText = statusText;
            this.likes = 0;
            this.dislikes = 0;
            this.numberOfReads = 0;
        }

        public void AddOneLike()
        {
            likes = likes + 1;
        }

        public void AddOneDislike()
        {
            dislikes = dislikes + 1;
        }

        public void ReadStatus()
        {
            numberOfReads = ++numberOfReads;
        }

        public string GetStatusText()
        {
            return statusText;
        }

        public int GetNoOfLikes()
        {
            return likes;
        }

        public int GetNoOfDislikes()
        {
            return dislikes;
        }

        public int GetNumberOfReads()
        {
            return numberOfReads;
        }

        public void PrintInformation()
        {
            Console.Write("The status '{0}' has {1} likes and {2} dislikes. ", GetStatusText(), GetNoOfLikes(), GetNoOfDislikes() );
            Console.WriteLine("The status has been read {0} times.", GetNumberOfReads());
        }
    }
}




//$"Bogen {aBook.GetISBN()} er tilføjet!"