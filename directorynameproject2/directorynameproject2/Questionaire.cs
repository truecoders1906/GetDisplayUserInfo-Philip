using System;
using System.Collections.Generic;

namespace Questionaire
{
    public class Questionaire //the properties are here. these are the blueprint of your methods. cookie cutter, not the cookie
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal FavoriteNumber { get; set; }
        public decimal NumberOfPets { get; set; }
        //public List<string> NameOfPets { get; set; } = new List<string>();//this is now a list. was a string <failed attempt>
        public string NameOfPets { get; set;  }
    }
}

//more methods can be down here to get new methods (method within a method) see lemonade stand example for total revenue 