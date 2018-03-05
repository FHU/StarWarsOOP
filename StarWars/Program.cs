using System;
using System.Linq;

namespace StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var characters = SampleData.Characters;

            var humanCharacters = characters
                .Where(c => c.Species == "Human")
                .OrderByDescending(c => c.MidichlorianCount)
                .ThenBy(c => c.Name)
                .Select(c => new
                {
                    CharacterName = c.Name,
                    MidichlorianCount = c.MidichlorianCount
                });

            var humanCharacters2 =
                from c in characters
                where c.Species == "Human"
                orderby c.MidichlorianCount descending, c.Name
                select new { c.Name, c.MidichlorianCount };


            foreach (var c in humanCharacters2)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();


            characters.Add(new Character()
            {
                Name = "Qui-Gon Jinn",
                Species = "Human",
                MidichlorianCount = 10000
            });


            foreach (var c in humanCharacters2)
            {
                Console.WriteLine(c);
            }

            var avgMCofSpacePeople = characters
                .Where(c=> c.Name.Contains(" "))
                .Average(c => c.MidichlorianCount);

            Console.WriteLine(avgMCofSpacePeople);


        }
    }
}
