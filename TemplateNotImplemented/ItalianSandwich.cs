using System;

namespace TemplateNotImplemented
{
    public class ItalianSandwich
    {
        public void MakeSandwich()
        {
            CutBun();
            AddMeat();
            AddCheese();
            AddVegetables();
            AddCondiments();
            WrapTheHoagie();
        }

        public void CutBun()
        {
            Console.WriteLine("The Hoagie is Cut");
        }

        public void AddMeat()
        {
            Console.WriteLine("Add Salami, Pepperoni and Capicola ham");
        }

        public void AddCheese()
        {
            Console.WriteLine("Add Provolone");
        }

        public void AddVegetables()
        {
            Console.WriteLine("Add Lettuce, Tomatoes, Onions and Sweet Peppers");
        }

        public void AddCondiments()
        {
            Console.WriteLine("Add Oil and Vinegar");
        }

        public void WrapTheHoagie()
        {
            Console.WriteLine("Wrap the Hoagie");
        }
    }
}