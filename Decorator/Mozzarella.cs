using System;

namespace Decorator
{

    public class Mozzarella : ToppingDecorator, IPizza
    {

        public Mozzarella(IPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Mozzarella");
        }

// Returns the result of calling getDescription() for
// PlainPizza and adds " mozzarella" to it

        public String getDescription()
        {

            return base.getDescription() + ", mozzarella";

        }

        public double getCost()
        {

            Console.WriteLine("Cost of Mozzarella: " + .50);

            return base.getCost() + .50;

        }

    }
}
