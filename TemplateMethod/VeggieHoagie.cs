using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    public class VeggieHoagie : Hoagie
    {
        List<string> veggiesUsed = new List<string> {"Lettuce", "Tomatoes", "Onions", "Sweet Peppers"};
        List<string> condimentsUsed = new List<string> {"Oil", "Vinegar"};

        bool customerWantsMeat()
        {
            return false;
        }

        bool customerWantsCheese()
        {
            return false;
        }

        public override void addVegetables()
        {
            Console.Write("Adding the Vegetables: ");
            foreach (string vegetable in veggiesUsed)
            {
                Console.Write(vegetable + " ");
            }
        }

        public override void addCondiments()
        {
            Console.Write("Adding the Condiments: ");
            foreach (string condiment in condimentsUsed)
            {
                Console.Write(condiment + " ");
            }
        }

        public override void addMeat()
        {
        }

        public override void addCheese()
        {
        }
    }
}

