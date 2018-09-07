using System;

namespace Decorator.Ingridents
{
    public class TomatoSauce : ToppingDecorator, IPizza
    {
        public TomatoSauce(IPizza newPizza) : base(newPizza)
        {
        Console.WriteLine("Adding Sauce");
        }
            // Returns the result of calling getDescription() for
            // PlainPizza, Mozzarella and then TomatoSauce
        public new string GetDescription()
        {
        return base.GetDescription() + ", tomato sauce";
        }
        public new double GetCost()
        {
            Console.WriteLine("Cost of Sauce: " + .35);
            return base.GetCost() + .35;
        }
    }
}
