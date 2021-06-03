using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectAnmolHarmanHarpreet
{
    public class LibraryMember
    {
        public string Name { get; private set; }
        public LibraryMember(string name)
        {
            this.Name = name;
        }

        public static List<Media> currentlyBorrowed = new List<Media>()
        {
             new Book("Classified Woman", "Book" , 0 , true ,"",445),
        };

        public static List<Media> borrowHistory = new List<Media>()
        {
             new Book("Classified Woman", "Book" , 0 , true ,"",445),
        };


        public String MemberInfo(String _name)
        {
            String BorwHistoryReturn = "";
            String currentMedia = "";
            foreach (Media bh in borrowHistory)
            {
                if (bh.Borrower == _name)
                {
                    String titleOfhistory = bh.Title;
                    String typeofhistory = bh.Type;
                    BorwHistoryReturn = "'"+ bh.Borrower +"'"+ " has Borrowing History of: \n "+"\nTitle of Media: " +titleOfhistory + "\nMedia Type: " +typeofhistory + ".\n";
                }
            }
            foreach (Media a in currentlyBorrowed)
            {
                if (a.Borrower == _name)
                {
                    String title = a.Title;
                    String type = a.Type;
                    return BorwHistoryReturn + "\n "+"'"+a.Borrower+"'" + "\nis having Title of Media: " +title+ "\nMedia Type: " + type + ".";
                }
            }
            return "No Transactio History.";
        }
    }
}
