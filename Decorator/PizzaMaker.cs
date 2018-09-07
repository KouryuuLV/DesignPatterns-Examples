using System;

namespace Decorator
{
    class PizzaMaker
    {
        static void Main(string[] args)
        {

            // The PlainPizza object is sent to the Mozzarella constructor
            // and then to the TomatoSauce constructor

            IPizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

            Console.WriteLine("Ingredients: " + basicPizza.getDescription());

            Console.WriteLine("Price: " + basicPizza.getCost());
            Console.ReadKey();

        }
        
    }
}
