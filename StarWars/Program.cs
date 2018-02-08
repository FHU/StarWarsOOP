using System;

namespace StarWars
{
    class Program
    {
        static void Main(string[] args)
        {

            Character luke = new Character() 
            { 
                Name = "Luke Skywalker",
                Species = "Human",
                MidichlorianCount = 15000
            };

            Character ani = new Character()
            {
                Name = "Anakin Skywalker",
                Species = "Human",
                MidichlorianCount = 27000
            };

            Character leia = new Character()
            {
                Name = "Leia Organa",
                Species = "Human",
                MidichlorianCount = 15000
            };

            Character han = new Character()
            {
                Name = "Han Solo",
                Species = "Human",
                MidichlorianCount = 0
            
            };

            Character yoda = new Character()
            {
                Name = "Yoda",
                Species = "Unknown",
                MidichlorianCount = 17000
            };


            var empireStikesBack = new Movie()
            {
                Name="The Empire Strikes Back",
                ReleaseDate = new DateTime(1980,5,21)
            };

            empireStikesBack.Characters.Add(luke);
            empireStikesBack.Characters.Add(ani);
            empireStikesBack.Characters.Add(leia);
            empireStikesBack.Characters.Add(han);
            empireStikesBack.Characters.Add(yoda);

            Console.WriteLine(empireStikesBack);

            empireStikesBack.Characters.Sort();

            Console.WriteLine(empireStikesBack);

            if ( ani > luke) {
                //do something 
            }

        }
    }
}
