using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Status status1 = new Status("I'm happy");
            //Status status2 = new Status("I think this works!");

            status1.PrintInformation();

            status1.AddOneLike();
            status1.AddOneLike();
            status1.AddOneDislike();
            status1.ReadStatus();

            status1.PrintInformation();

            status1.ReadStatus();
            status1.ReadStatus();

            status1.PrintInformation();


            // The LAST line of code should be ABOVE this line
        }
    }
}
