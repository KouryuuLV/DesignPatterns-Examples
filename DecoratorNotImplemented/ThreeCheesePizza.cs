using System;

namespace DecoratorNotImplemented
{
// By going this route I'll have to create a new subclass
// for an infinite number of pizza.
// I'd also have to change prices in many classes
// when just 1 Pizza topping cost changes
// Inheritance is static while composition is dynamic
// Through composition I'll be able to add new functionality
// by writing new code rather than by changing current code

    public class ThreeCheesePizza : IPizza
    {
        private String description = "Mozzarella, Fontina, Parmesan Cheese Pizza";
        private double cost = 10.50;

        public override void setDescription(String newDescription)
        {
            description = newDescription;
        }

        public override String getDescription()
        {
            return description;
        }

        public override void setCost(double newCost)
        {
            cost = newCost;
        }

        public override double getCost()
        {
            return cost;
        }
    }
}
