using System;

//Decorator - https://www.youtube.com/watch?v=j40kRwSm4VE
//by Derek Banas https://www.youtube.com/channel/UCwRXb5dUK4cvsHbx-rGzSgw

namespace DecoratorNotImplemented
{
    class PizzaMaker
    {
        static void Main(string[] args)
        {
            // The PlainPizza object is sent to the Mozzarella constructor
            // and then to the TomatoSauce constructor

            IPizza basicPizza = new ThreeCheesePizza();
            //IPizza basicPizza = new SalamiCheesePizza();

            Console.WriteLine("Ingredients: " + basicPizza.GetDescription());
            Console.WriteLine("Price: " + basicPizza.GetCost());
            Console.ReadKey();
        }
    }
}
