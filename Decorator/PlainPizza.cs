using System;

namespace Decorator
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

        public String getDescription()
        {
            return "Thin dough";
        }

        public double getCost()
        {
            Console.WriteLine("Cost of Dough: " + 4.00);
            return 4.00;
        }
    }
}
