using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_tap_.Models
{
    public class Meat : Food
    {
        public override int Calorie => 1500; // Example calorie value
        public string Type { get; }

        public Meat(string type)
        {
            if (string.IsNullOrWhiteSpace(type) || !IsValidMeatType(type))
            {
                throw new ArgumentException($"Invalid meat type: {type}");
            }
            Type = type;
        }

        private bool IsValidMeatType(string type)
        {
            string[] validMeatTypes = { "Mal", "Toyuq", "Baliq" };
            return Array.IndexOf(validMeatTypes, type) != -1;
        }
    }

}

