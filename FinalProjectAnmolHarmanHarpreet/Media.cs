using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectAnmolHarmanHarpreet
{

    public abstract class Media
    {
        static int entryCount = 0;
        public string Title { get; private set; }
        public string Type { get; private set; }
        public int SerialNo { get; private set; }
        public int NumOfLents { get; private set; }
        public bool IsAvailable { get; set; }
        public string Borrower { get; private set; }

        public Media(string title, string type, int numOfLents, bool isavailable, string borrower)
        {
            this.Title = title;
            this.Type = type;
            this.NumOfLents = numOfLents;
            this.IsAvailable = isavailable;
            this.Borrower = borrower;
            this.SerialNo = entryCount;
            entryCount++;

        }
        public virtual string MediaInfo()
        {
            Console.WriteLine("Title: " + Title + " Type: " + Type + " SerialNumber: " + SerialNo + " Is Available: " + IsAvailable + "Number Of Times Lent: " + NumOfLents + "Current Borrower: " + Borrower);

            String sn = Convert.ToString(SerialNo);
            String nol = Convert.ToString(NumOfLents);
            String avl = Convert.ToString(IsAvailable);

            return "The details of Media that you selected: \n " + " \nTitile: " + Title + "\nType: " + Type + "\nSerial Number of Media: " + sn + "\nIs Available: " + avl + "\nNo of Lents: " + nol+".";
        }
    }
}
