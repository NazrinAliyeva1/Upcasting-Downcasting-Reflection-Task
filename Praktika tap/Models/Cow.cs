using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_tap_.Models
{
    public class Cow : Animal
    {
        // Constructor for Cow class
        public Cow(string breed) : base(breed)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cow says: Moooo!");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Milk produced.");
        }
        public override void EatFood(Food food)
        {
            // Check if the food is suitable for a Cow
            if (food is Grass)
            {
                Grass grass = (Grass)food;
                Console.WriteLine($"Eating grass: {grass.Name}");
                ProduceMilk(); // Süt üretimi
            }
            else
            {
                Console.WriteLine("Incorrect food type for a cow.");
            }
        }

    }
}
