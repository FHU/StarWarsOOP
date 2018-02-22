using System;
using System.Collections.Generic;

namespace StarWars
{
    public class SampleData
    {
        public SampleData()
        {
        }

        public static List<Character> Characters
        {
            get
            {
                var chars = new List<Character>()
                {
                    new Character()
                    {
                        Name = "Luke Skywalker",
                        Species = "Human",
                        MidichlorianCount = 15000
                    },

                    new Character()
                    {
                        Name = "Anakin Skywalker",
                        Species = "Human",
                        MidichlorianCount = 27000
                    },

                     new Character()
                    {
                        Name = "Leia Organa",
                        Species = "Human",
                        MidichlorianCount = 15000
                    },

                     new Character()
                    {
                        Name = "Han Solo",
                        Species = "Human",
                        MidichlorianCount = 0

                    },

                     new Character()
                    {
                        Name = "Yoda",
                        Species = "Unknown",
                        MidichlorianCount = 17000
                    }
                };

                return chars;
            }
        }
    }
}
