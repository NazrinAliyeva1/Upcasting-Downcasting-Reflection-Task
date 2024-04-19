using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_tap_.Models
{

    internal class Orange : Fruit
    {
        public int Vitaminc;
        public string Sort = "Novu: Talış. (Default olaraq) ";
        public Orange(int vitaminc, int price, string sort):base(price, sort)
        {
            Vitaminc=vitaminc;
            Sort=sort;
        }
        public override void Taste()
        {
            Console.WriteLine("Portagal en dadlilardandir :)");
        }

    }
}
