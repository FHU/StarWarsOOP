using System;
using System.Collections.Generic;

namespace StarWars
{
    public class Character : IComparable<Character>
    {
        public Character()
        {
            MovieAppearances = new List<Movie>();
        }

        public string Name
        {
            get;
            set;
        }

        public string Species
        {
            get;
            set;
        }


        public int MidichlorianCount
        {
            get;
            set;
        }

        public List<Movie> MovieAppearances
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("[Character: Name={0}, Species={1}, MidichlorianCount={2}]", Name, Species, MidichlorianCount);
        }

        public int CompareTo(Character other)
        {
            return this.MidichlorianCount.CompareTo(other.MidichlorianCount);

            /*if (this.MidichlorianCount > other.MidichlorianCount)
                return 1;
            else if (this.MidichlorianCount < other.MidichlorianCount)
                return -1;
            else
                return 0;*/
            
        }

        public static bool operator> (Character c1, Character c2) {
            return c1.CompareTo(c2) > 0;
        }

        public static bool operator<(Character c1, Character c2)
        {
            return c1.CompareTo(c2) < 0;
        }
    }
}
