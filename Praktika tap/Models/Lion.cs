using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_tap_.Models
{
    public class Lion : Animal
    {
        public bool IsPrideLeader { get; }

        // Constructor for Lion class
        public Lion(string breed, bool isPrideLeader) : base(breed)
        {
            IsPrideLeader = isPrideLeader;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Lion roars: Roarrr!");
        }
        public override void EatFood(Food food)
        {
            // Check if the food is suitable for a Lion
            if (food is Meat)
            {
                Meat meat = (Meat)food;
                Console.WriteLine($"Eating meat: {meat.Type}");
            }
            else
            {
                Console.WriteLine("Incorrect food type for a lion.");
            }
        }
    }
}
