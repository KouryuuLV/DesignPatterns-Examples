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
            Console.ReadKey();
        }
    }
}
