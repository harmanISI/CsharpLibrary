using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectAnmolHarmanHarpreet
{
   static class Library
    {
        public static List<Media> entries = new List<Media>()
        {
            new Book("Classified Woman", "Book" , 0 , true ,"",445),
            new Book("Black Beauty", "Book" , 0, true ,"",43),
            new Book("Think and Grow Rich", "Book" , 0 , true ,"",437),
            new Book("Harry Potter and the Sorcerer's Stone", "Book" , 0 , true ,"",245),
            new Book("The Little Prince", "Book" , 0 , true ,"",415),


            new Magazine("Reader's Digest","magazine",0,true,"",490,567),
            new Magazine("Southern Living","magazine",0,true,"",100,568),
            new Magazine("Golf Magazine","magazine",0,true,"",80,569),
            new Magazine("Marie Claire","magazine",0,true,"",30,570),
            new Magazine("Discovery Girls","magazine",0,true,"",70,571),


            new Movie("Bad Education","movie",0,true,"",40),
            new Movie("Wolfwalkers","movie",0,true,"",20),
            new Movie("Bad Boys for Life","movie",0,true,"",90),
            new Movie("Avengers: Endgame","movie",0,true,"",50),
            new Movie("The Trip to Greece","movie",0,true,"",10),



        };
        public static List<LibraryMember> members = new List<LibraryMember>()
        {
            new LibraryMember("HarmanSingh"),
            new LibraryMember("AnmoldeepK"),
            new LibraryMember("HarpreetKaur"),
            new LibraryMember("JohnSmith"),
            new LibraryMember("JutinWinifred"),

        };
    }
}
