using System;

    //Template - https://www.youtube.com/watch?v=aR1B8MlwbRI
    //by Derek Banas https://www.youtube.com/channel/UCwRXb5dUK4cvsHbx-rGzSgw

namespace TemplateMethod
{
    public class SandwichSculptor
    {
        public static void Main(string[] args)
        {
            var firstSandwich = new ItalianSandwich();
            firstSandwich.MakeSandwich();
            Console.WriteLine();
            var secondSandwich = new VeggieSandwich();
            secondSandwich.MakeSandwich();
            Console.ReadKey();
        }
    }
}
