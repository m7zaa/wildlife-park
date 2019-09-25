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

            Console.WriteLine("How would you like to search for animals? type/age/danger-level");
            string searchType = Console.ReadLine();

             
                Console.WriteLine("What type of animal are you looking for a bear, tiger, sloth or squirrel?");
                string typeSearch = Console.ReadLine();
                    
            List<Animal> AnimalsMatchingSearch = new List<Animal>(0);
                    
                foreach (Animal animal in Animals)
                {
                    if (animal.GetType(typeSearch))
                    {
                        AnimalsMatchingSearch.Add(animal);
                    }
                }
                Console.WriteLine(AnimalsMatchingSearch);

            

        }

    }
}