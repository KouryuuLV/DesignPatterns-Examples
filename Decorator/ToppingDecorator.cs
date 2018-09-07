namespace Decorator
{
    // Has a "Has a" relationship with IPizza. This is an
    // Aggregation Relationship
    public abstract class ToppingDecorator : IPizza
    {
        private readonly IPizza _tempPizza;

        // Assigns the type instance to this attribute of a IPizza
        // All decorators can dynamically customize the IPizza
        // instance PlainPizza because of this

        protected ToppingDecorator(IPizza newPizza)
        {
            _tempPizza = newPizza;
        }

        public string GetDescription()
        {
                return _tempPizza.GetDescription();
        }

        public double GetCost()
        {
            return _tempPizza.GetCost();
        }
    }
}
