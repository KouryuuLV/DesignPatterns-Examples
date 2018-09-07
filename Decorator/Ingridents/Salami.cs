using System;

namespace Decorator.Ingridents
{
    public class Salami : ToppingDecorator, IPizza
    {
        public Salami(IPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Salami");
        }

        // Returns the result of calling getDescription() for
        // PlainPizza and adds " mozzarella" to it

        public new string GetDescription()
        {
            return base.GetDescription() + ", salami";
        }

        public new double GetCost()
        {
            Console.WriteLine("Cost of Salami: " + 2.50);
            return base.GetCost() + 2.50;
        }
    }
}
