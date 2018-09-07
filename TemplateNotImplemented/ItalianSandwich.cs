using System;

namespace TemplateMethod
{
    public class ItalianSandwich
    {
        public void makeSandwich()
        {
            cutBun();
            addMeat();
            addCheese();
            addVegetables();
            addCondiments();
            wrapTheHoagie();
        }

        public void cutBun()
        {
            Console.WriteLine("The Hoagie is Cut");
        }

        public void addMeat()
        {
            Console.WriteLine("Add Salami, Pepperoni and Capicola ham");
        }

        public void addCheese()
        {
            Console.WriteLine("Add Provolone");
        }

        public void addVegetables()
        {
            Console.WriteLine("Add Lettuce, Tomatoes, Onions and Sweet Peppers");
        }

        public void addCondiments()
        {
            Console.WriteLine("Add Oil and Vinegar");
        }

        public void wrapTheHoagie()
        {
            Console.WriteLine("Wrap the Hoagie");
        }
    }
}