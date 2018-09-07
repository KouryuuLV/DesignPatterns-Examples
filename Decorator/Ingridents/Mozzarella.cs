using System;

namespace Decorator.Ingridents
{
    public class Mozzarella : ToppingDecorator, IPizza
    {
        public Mozzarella(IPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Mozzarella");
        }
            // Returns the result of calling getDescription() for
            // PlainPizza and adds " mozzarella" to it
        public string GetDescription()
        {
            return base.GetDescription() + ", mozzarella";
        }

        public double GetCost()
        {
            Console.WriteLine("Cost of Mozzarella: " + .50);
            return base.GetCost() + .50;
        }
    }
}
