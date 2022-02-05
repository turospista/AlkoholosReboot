using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace AlcoholCalculator
{
    class Drink
    {
        public string drinkName;
        public double alcoholPercent;
        public int drinkID;

        public string DrinkPrint()
        {
            string drinkType = $"{drinkName} {alcoholPercent} % -- ID: {drinkID}";
            return drinkType;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Drink> drinkList = new List<Drink>();
            List<Drink> consumedList = new List<Drink>();

            drinkList.Add(new Drink() { drinkName = "Beer", alcoholPercent = 4.8, drinkID = 1 });
            drinkList.Add(new Drink() { drinkName = "Wine", alcoholPercent = 12, drinkID = 2 });

            foreach(var Drink in drinkList)
            {
                Console.WriteLine(Drink.DrinkPrint());
            }

            
            do
            {
                var gotID = GetID(drinkList);

                foreach (var Drink in drinkList)
                {
                    if (gotID == Drink.drinkID)
                    {
                        consumedList.Add(Drink);
                        
                    }

                }
                var consumed = ConsumedList(consumedList);
                Console.WriteLine(consumed);
                Console.WriteLine("Need any more? (y/n)");

            } while (Console.ReadLine() == "y");

            Console.WriteLine("Thank you bye.");
            Console.ReadKey();
        }

        static int GetID(List<Drink> drinkList)
        {
            
            Console.WriteLine("Give the ID of the consumed drink");
            int consumedID = Convert.ToInt32(Console.ReadLine());
            return consumedID;
        }

        static string ConsumedList(List<Drink> consumedList)
        {
            Console.WriteLine("Nice. You have consumed:");
            foreach (var Drink in consumedList)
            {
                Console.WriteLine($"{Drink.drinkName}");
            }
            return null;
        }
    }
}