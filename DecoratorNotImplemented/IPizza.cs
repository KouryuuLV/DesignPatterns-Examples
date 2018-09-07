using System;

namespace DecoratorNotImplemented
{
    // Blueprint for classes that will have decorators

    public abstract class IPizza
    {

        public abstract void setDescription(String newDescription);
        public abstract String getDescription();

        public abstract void setCost(double newCost);

        public abstract double getCost();

        // I could use getter and setter methods for every
        // potential IPizza topping
    }

}
