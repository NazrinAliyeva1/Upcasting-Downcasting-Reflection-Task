using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_tap_.Models
{
    public abstract class Animal
    {
        public string Breed { get; }

        // Constructor for Animal class
        protected Animal(string breed)
        {
            Breed = breed;
        }

        // Abstract method to make the animal sound
        public abstract void MakeSound();

        // Method to eat food based on the animal type
        public virtual void EatFood(Food food)
        {
            Console.WriteLine($"Animal Type: {GetType().Name}");

            // Check the type of the animal and the type of food
            if (this is Cow && food is Grass)
            {
                // Correct food for Cow
                Console.WriteLine("Successfully fed with grass.");
            }
            else if (this is Lion && food is Meat)
            {
                // Correct food for Lion
                Console.WriteLine("Successfully fed with meat.");
            }
            else
            {
                // Incorrect food type for a cow (or Lion)
                Console.WriteLine($"Incorrect food type for a {GetType().Name}.");
            }
        }
    }
}
