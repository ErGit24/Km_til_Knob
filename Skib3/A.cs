using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skib3
{
    class A
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast hastighed i km/t: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double fartIKMT))
            {
                B bInstance = new B();
                double fartIknobs = bInstance.ConvertKmPerHourToKnots(fartIKMT);
                Console.WriteLine($"Hastighed i knob: {fartIknobs}");
            }
            else
            {
                Console.WriteLine("Ugyldigt input. Indtast et tal for hastigheden i km/t.");
            }

            Console.WriteLine("Tryk på en tast for at afslutte...");
            Console.ReadKey();
        }
    }
}
