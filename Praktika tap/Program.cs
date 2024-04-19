using Praktika_tap_.Models;
using System.Reflection;

namespace Praktika_tap_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(12, 34, 5, "Qizil Ehmmed");

            Pineapple pineapple = new Pineapple(10, 18, 8, "Braziliya");

            Orange orange = new Orange(56, 4, "Talış");

            Fruit[] Basket = { apple, pineapple, orange };



            ////foreach (Fruit fruit in Basket)
            ////{
            ////    Console.WriteLine($"Meyve novu: {fruit.GetType().Name}");

            ////    foreach (var field in fruit.GetType().GetFields())
            ////    {
            ////        Console.WriteLine($"{field.Name}: {field.GetValue(fruit)}");
            ////    }

            //Apple app = fruit as Apple;
            //Pineapple pine = fruit as Pineapple;
            //Orange org = fruit as Orange;


            //if (app != null)
            //{   
            //    Console.WriteLine(app.VitaminA);
            //}
            //if (pine != null)
            //{
            //    Console.WriteLine(pine.VitaminE);
            //}
            //if (org != null)
            //{
            //    Console.WriteLine(org.Vitaminc);
            //}                }
            ////}
            //Console.WriteLine($"{apple.VitaminA} {apple.VitaminB} {apple.GetElement}");
            //Console.WriteLine($"{pineapple.VitaminE}  {pineapple.VitaminD}");
            //Console.WriteLine($"{orange.Vitaminc}  {apple.GetElement}");


            //foreach ( Fruit fruit in Basket)
            //{
            //if(fruit is Apple app)
            // {
            //     Console.WriteLine(app.VitaminA + " " + app.VitaminB);

            // }
            //else if(fruit is Pineapple pine)
            // {
            //     Console.WriteLine(pine.VitaminE + " " + pine.VitaminD);

            // }
            //else if(fruit is Orange org)
            // {
            //     Console.WriteLine(org.Vitaminc);

            // }



            //}
            Animal[] animals = new Animal[]
                       {
                new Cow("Shepherd"),
                new Lion("Lioness", false),
                new Cow("Holstein"),
                new Lion("Simba", true)
                       };

            // Her bir hayvan için işlemler
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Animal Type: {animal.GetType().Name}");

                // Hayvanın sesini çıkarma
                animal.MakeSound();

                // Hayvanın yediği yemeği belirleme
                animal.EatFood(new Grass("Clover")); // Örnek yiyecek
                Console.WriteLine(); // Her hayvan arasında boşluk bırakma

                // Lion sınıfı için özel işlemler
                if (animal is Lion lion)
                {
                    Console.WriteLine($"Is Pride Leader: {lion.IsPrideLeader}");
                }
            }
        }
        }
    
}