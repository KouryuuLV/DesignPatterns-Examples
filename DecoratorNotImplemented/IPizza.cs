namespace DecoratorNotImplemented
{
    // Blueprint for classes that will have decorators
    public abstract class IPizza
    {
        public abstract void SetDescription(string newDescription);
        public abstract string GetDescription();
        public abstract void SetCost(double newCost);
        public abstract double GetCost();

        // I could use getter and setter methods for every
        // potential IPizza topping
    }
}
