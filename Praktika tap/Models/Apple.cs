using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_tap_.Models
{
    internal class Apple:Fruit
    {
        public int VitaminA;
        public int VitaminB;
        public string Sort  = "Novu :Alma (default olaraq.)";

        public Apple(int vitamina , int vitaminb, int price, string sort):base(price, sort)
        {
            VitaminA = vitamina;
            VitaminB = vitaminb;
            Price = price;
            Sort = sort;
        }
        public override void Taste()
        {
            Console.WriteLine("Alma tursdur.");
        }

    }
}
