using System;

namespace TemplateMethod
{
        public class SandwichSculptor
        {
        public static void Main(String[] args)
        {
            ItalianHoagie cust12Hoagie = new ItalianHoagie();
            cust12Hoagie.makeSandwich();
            Console.WriteLine();
            VeggieHoagie cust13Hoagie = new VeggieHoagie();
            cust13Hoagie.makeSandwich();
            Console.ReadKey();
        }
    }

}
