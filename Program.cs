using System;
using System.Collections.Generic;


namespace Park
{
    public class Program
    {
        public static void Main()
        {
            Animal sloth = new Animal("sloth", "two-toed", 15, 10, "low");
            Animal tiger = new Animal("tiger", "bengal", 10, 10, "high");
            Animal bear = new Animal ("bear", "polar", 33, 33, "low");
            Animal squirrel = new Animal("squirrel", "grey" , 88, 1, "high");

            List<Animal> Animals = new List<Animal>() {sloth, tiger, bear, squirrel};
            Console.WriteLine("What would you like to do? Add/find");
            string AddFind = Console.ReadLine();
            if (AddFind == "Add" || AddFind == "add")
            {
                Console.WriteLine("Enter a species:");
                string speciesInput = Console.ReadLine();
                Console.WriteLine("Enter a type:");
                string typeInput = Console.ReadLine();

                Console.WriteLine("Enter animal's age:");
                int ageInput = int.Parse(Console.ReadLine()); 

                Console.WriteLine("Enter animal's time in captivity (years):");
                int captivityInput = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter animal's threat level:");
                string tempermentInput = Console.ReadLine();
                Animal newAnimal = new Animal(speciesInput, typeInput, ageInput, captivityInput, tempermentInput);
                Console.WriteLine(newAnimal.GetAnimalType());
            }


            Console.WriteLine("How would you like to search for animals? Species/Age/Danger-level");
            string searchType = Console.ReadLine();

            
            if (searchType == "species")
            {
            Console.WriteLine("What species of animal are you looking for a bear, tiger, sloth or squirrel?");
            string speciesSearch = Console.ReadLine();
                     
            List<Animal> AnimalsMatchingSearch = new List<Animal>(0);
                    
                foreach (Animal animal in Animals)
                {
                    if (animal.FindSpecies(speciesSearch))
                    {
                        AnimalsMatchingSearch.Add(animal);
                    }
                }
                foreach (Animal animal in AnimalsMatchingSearch)
                {
                Console.WriteLine(animal.GetSpecies());
                Console.WriteLine(animal.GetAnimalType());
                Console.WriteLine(animal.GetAge());
                Console.WriteLine("This animals threat level is " + animal.GetTemperment() + ".");
                }
            } 
            

        }

    }
}