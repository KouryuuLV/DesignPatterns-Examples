using System;

//Template - https://www.youtube.com/watch?v=aR1B8MlwbRI
//by Derek Banas https://www.youtube.com/channel/UCwRXb5dUK4cvsHbx-rGzSgw

namespace TemplateNotImplemented
{
    public class SandwichSculptor
    {
        public static void Main(string[] args)
        {
            var sandwich = new ItalianSandwich();
            sandwich.MakeSandwich();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
