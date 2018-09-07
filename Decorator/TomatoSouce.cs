using System;

namespace Decorator
{
    public class TomatoSauce : ToppingDecorator, IPizza
    {
        public TomatoSauce(IPizza newPizza) : base(newPizza)
        {
        Console.WriteLine("Adding Sauce");
        }

        // Returns the result of calling getDescription() for
        // PlainPizza, Mozzarella and then TomatoSauce

        public String getDescription()
        {
        return base.getDescription() + ", tomato sauce";
        }

        public double getCost()
        {
            Console.WriteLine("Cost of Sauce: " + .35);
            return base.getCost() + .35;
        }

    }
}
