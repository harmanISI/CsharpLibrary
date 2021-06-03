using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectAnmolHarmanHarpreet
{
    class Movie:Media
    {
        public int RunTime { get; private set; }
        public Movie(string title, string type, int numOfLents, bool isavailable, string borrower, int runTime) : base(title, type, numOfLents, isavailable, borrower)
        {
            this.RunTime = runTime;
        }
        public override string MediaInfo()
        {
            String hh = base.MediaInfo();

            return hh + "\nRun Time: " + Convert.ToString(RunTime);
        }
    }
}
