using System;

namespace Decorator.Ingridents
{
    // Implements the IPizza interface with only the required
    // methods from the interface
    // Every IPizza made will start as a PlainPizza
    public class PlainPizza : IPizza
    {
        public PlainPizza()
        {
            Console.WriteLine("Thin dough");
        }
        public string GetDescription()
        {
            return "Thin dough";
        }
        public double GetCost()
        {
            Console.WriteLine("Cost of Dough: " + 4.00);
            return 4.00;
        }
    }
}
