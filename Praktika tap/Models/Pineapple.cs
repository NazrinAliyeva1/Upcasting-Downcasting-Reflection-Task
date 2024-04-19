using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_tap_.Models
{
    internal class Pineapple:Fruit
    {
        public int VitaminE;
        public int VitaminD;
        public string Sort = "Novu: Braziliya (Defaul olaraq.)";
        public Pineapple(int vitamine, int vitamind, int price, string sort):base(price, sort)
        {
            VitaminE = vitamine;
            VitaminD = vitamine;
            Price = price;
            Sort = sort;

        }
        public override void Taste()
        {
            Console.WriteLine("Ananas sirin dadlidir.");
        }
    }
}
