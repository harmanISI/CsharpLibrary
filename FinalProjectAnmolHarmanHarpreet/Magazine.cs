using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectAnmolHarmanHarpreet
{
    class Magazine : Book
    {
        public int IssueNumber { get; private set; }
        public Magazine(string title, string type, int numOfLents, bool isAvailable, string borrower, int pageCount, int issuenumber) : base(title, type, numOfLents, isAvailable, borrower, pageCount)
        {
            this.IssueNumber = issuenumber;
        }
        public override string MediaInfo()
        {

            String hh = base.MediaInfo();

            return hh + " " + "\nIssue  Number: " + Convert.ToString(IssueNumber);
        }
    }
}
