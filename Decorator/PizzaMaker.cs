using System;
using Decorator.Ingridents;

    //Decorator - https://www.youtube.com/watch?v=j40kRwSm4VE
    //by Derek Banas https://www.youtube.com/channel/UCwRXb5dUK4cvsHbx-rGzSgw

namespace Decorator
{
    class PizzaMaker
    {
        static void Main(string[] args)
        {
            // The PlainPizza object is sent to the Mozzarella constructor
            // and then to the TomatoSauce constructor
            // you can see the adding of salami in the seccond object and how the output changes.

            IPizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

            //Example of one more Decorator

            //IPizza basicPizza = new Salami(new TomatoSauce(new Mozzarella(new PlainPizza())));

            Console.WriteLine("Ingredients: " + basicPizza.GetDescription());
            Console.WriteLine("Price: " + basicPizza.GetCost());
            Console.ReadKey();
        }
    }
}
