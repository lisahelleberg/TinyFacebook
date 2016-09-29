using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Console.WriteLine("Test of part 2...");
            Status status1 = new Status("I am late for class!! OMG!!");

            Console.WriteLine($"{status1.GetStatusText()} (Likes: {status1.GetNoOfLikes()}, Dislikes: {status1.GetNoOfDislikes()})");

            status1.AddOneLike();
            status1.AddOneDislike();
            status1.AddOneLike();
            status1.AddOneLike();
            status1.AddOneDislike();
            status1.AddOneLike();

            Console.WriteLine($"{status1.GetStatusText()} (Likes: {status1.GetNoOfLikes()}, Dislikes: {status1.GetNoOfDislikes()})");

            Console.WriteLine("Test of part 3...");

            // The LAST line of code should be ABOVE this line
        }
    }
}
