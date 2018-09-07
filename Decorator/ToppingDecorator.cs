namespace Decorator
{
    // Has a "Has a" relationship with IPizza. This is an
    // Aggregation Relationship
    public abstract class ToppingDecorator : IPizza
    {
        private IPizza tempPizza;

        // Assigns the type instance to this attribute of a IPizza
        // All decorators can dynamically customize the IPizza
        // instance PlainPizza because of this

        public ToppingDecorator(IPizza newPizza)
        {
            tempPizza = newPizza;
        }

        public string GetDescription()
        {
                return tempPizza.GetDescription();
        }

        public double GetCost()
        {
            return tempPizza.GetCost();
        }
    }
}
