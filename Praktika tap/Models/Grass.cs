using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_tap_.Models
{
    public class Grass : Food
    {
        public override int Calorie => 1200;
        // Implementing the Name property for grass
        public string Name { get; private set; }

        public Grass(string name)
        {
            // Validate and set the name during object initialization
            SetName(name);
        }

        // Method to set the name with validation
        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Grass name cannot be null or empty.");
            }
            Name = name;
        }

    }
}
