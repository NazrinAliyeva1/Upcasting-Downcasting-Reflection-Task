using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Praktika_tap_.Models
{
    abstract class Fruit
    {
        public int Price;
        public virtual string Sort { get; set;}

        public abstract void Taste();
        public Fruit(int price, string sort)
        {
            Price = price;
        }
        public override string ToString()
        {
            return $"{{Meyvenin novu:  : {Sort}}}";

        }
        public void GetElement()
        {
            Console.WriteLine($"{Price} {Sort}");
        }
  
    }
}
