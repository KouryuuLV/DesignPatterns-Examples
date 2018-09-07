using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    public class VeggieSandwich : Sandwich
    {
        private readonly List<string> _veggiesUsed = new List<string> {"Lettuce", "Tomatoes", "Onions", "Sweet Peppers"};
        private readonly List<string> _condimentsUsed = new List<string> {"Oil", "Vinegar"};

        public override bool CustomerWantsMeat()
        {
            return false;
        }

        public override bool CustomerWantsCheese()
        {
            return false;
        }

        public override void AddVegetables()
        {
            Console.Write("Adding the Vegetables: ");
            foreach (string vegetable in _veggiesUsed)
            {
                Console.Write(vegetable + " ");
            }
        }

        public override void AddCondiments()
        {
            Console.Write("Adding the Condiments: ");
            foreach (string condiment in _condimentsUsed)
            {
                Console.Write(condiment + " ");
            }
        }

        public override void AddMeat()
        {
        }

        public override void AddCheese()
        {
        }
    }
}

