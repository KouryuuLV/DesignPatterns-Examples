using System;

namespace DecoratorNotImplemented
{
    class PizzaMaker
    {
        static void Main(string[] args)
        {

            // The PlainPizza object is sent to the Mozzarella constructor
            // and then to the TomatoSauce constructor

            IPizza basicPizza = new ThreeCheesePizza();

            Console.WriteLine("Ingredients: " + basicPizza.getDescription());

            Console.WriteLine("Price: " + basicPizza.getCost());
            Console.ReadKey();

        }
        
    }
}
