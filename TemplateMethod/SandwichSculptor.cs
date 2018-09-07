using System;

    //Template - https://www.youtube.com/watch?v=aR1B8MlwbRI
    //by Derek Banas https://www.youtube.com/channel/UCwRXb5dUK4cvsHbx-rGzSgw

namespace TemplateMethod
{
        public class SandwichSculptor
        {
        public static void Main(String[] args)
        {
            ItalianSandwich FirstSandwich = new ItalianSandwich();
            FirstSandwich.makeSandwich();
            Console.WriteLine();
            VeggieSandwich SecondSandwich = new VeggieSandwich();
            SecondSandwich.makeSandwich();
            Console.ReadKey();
        }
    }

}
