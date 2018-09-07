using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    public class ItalianSandwich : Sandwich
    {
        private readonly List<string> _meatUsed = new List<string>() {"Salami", "Pepperoni", "Capicola Ham"};
        private readonly List<string> _cheeseUsed = new List<string>() {"Provolone"};
        private readonly List<string> _veggiesUsed = new List<string>() {"Lettuce", "Tomatoes", "Onions", "Sweet Peppers"};
        private readonly List<string> _condimentsUsed = new List<string>() {"Oil", "Vinegar"};

        public override void AddMeat()
        {
            Console.Write("Adding the Meat: ");
            foreach (var meat in _meatUsed)
            {
                Console.Write(meat + " ");
            }
        }

        public override void AddCheese()
        {
            Console.Write("Adding the Cheese: ");
            foreach (var cheese in _cheeseUsed)
            {
                Console.Write(cheese + " ");
            }
        }

        public override void AddVegetables()
        {
            Console.Write("Adding the Vegetables: ");
            foreach (var vegetable in _veggiesUsed)
            {
                Console.Write(vegetable + " ");
            }
        }

        public override void AddCondiments()
        {
            Console.Write("Adding the Condiments: ");
            foreach (var condiment in _condimentsUsed)
            {
                Console.Write(condiment + " ");
            }
        }
    }
}