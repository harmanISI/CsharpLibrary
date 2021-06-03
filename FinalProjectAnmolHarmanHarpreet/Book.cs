using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectAnmolHarmanHarpreet
{
    class Book : Media
    {
        public int PageCount { get; private set; }

        public Book(string title, string type, int numOfLents, bool isAvailable, string borrower, int pageCount) : base(title, type, numOfLents, isAvailable, borrower)
        {
            this.PageCount = pageCount;
        }
        public override string MediaInfo()
        {

            String bb = base.MediaInfo();

            return bb + "\nPage count: " + Convert.ToString(PageCount);
        }
    }
}
