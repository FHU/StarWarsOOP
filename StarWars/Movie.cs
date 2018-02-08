using System;
using System.Collections.Generic;

namespace StarWars
{
    public class Movie
    {
        public Movie()
        {
            Characters = new List<Character>();

        }

        public string Name
        {
            get;
            set;
        }


        public DateTime ReleaseDate
        {
            get;
            set;
        }
  
        public List<Character> Characters
        {
            get;
            set;
        }

        public override string ToString()
        {

            string charactersString = "";
            foreach( var c in Characters) {
                charactersString += c.Name + "\n";
            }

            return 
                string.Format("[Movie: Name={0}, ReleaseDate={1:D}, Characters={2}]", Name, ReleaseDate, charactersString);
        }
    
    }
}
