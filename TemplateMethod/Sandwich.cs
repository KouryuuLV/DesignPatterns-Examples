using System;

namespace TemplateMethod
{

// A Template Method Pattern contains a method that provides
// the steps of the algorithm. It allows subclasses to override
// some of the methods
    public abstract class Sandwich
    {
        private bool _afterFirstCondiment = false;
        // This is the Template Method
        // Declare this method final to keep subclasses from
        // changing the algorithm
         public void MakeSandwich()
            {
            CutBun();
            if (CustomerWantsMeat())
                {
                AddMeat();
                // Here to handle new lines for spacing
                _afterFirstCondiment = true;
            }
            if (CustomerWantsCheese())
            {
                if (_afterFirstCondiment)
                {
                    Console.Write("\n");
                }
                AddCheese();
                _afterFirstCondiment = true;
            }
            if (CustomerWantsVegetables())
            {
                if (_afterFirstCondiment)
                {
                    Console.Write("\n");
                }
                AddVegetables();
                _afterFirstCondiment = true;
            }
            if (CustomerWantsCondiments())
            {
                if (_afterFirstCondiment)
                {
                    Console.Write("\n");
                }
                AddCondiments();
                _afterFirstCondiment = true;
            }
            WrapTheHoagie();
        }
        // These methods must be overridden by the extending subclasses
        public abstract void AddMeat();
        public abstract void AddCheese();
        public abstract void AddVegetables();
        public abstract void AddCondiments();
        public void CutBun()
        {
            Console.WriteLine("The Hoagie is Cut");
        }
        // These are called hooks
        // If the user wants to override these they can
        // Use abstract methods when you want to force the user
       // to override and use a hook when you want it to be optional
        public virtual bool CustomerWantsMeat() { return true; }
        public virtual bool CustomerWantsCheese() { return true; }
        public virtual bool CustomerWantsVegetables() { return true; }
        public virtual bool CustomerWantsCondiments() { return true; }

        public void WrapTheHoagie()
        {
        Console.WriteLine("\nWrap the Hoagie");
        }
    }
}
