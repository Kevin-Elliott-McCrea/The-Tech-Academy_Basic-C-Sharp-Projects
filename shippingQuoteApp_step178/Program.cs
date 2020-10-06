using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shippingQuoteApp_step178
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is your package weight? (Only include the number)");
            int pacWeight = Convert.ToInt32(Console.ReadLine());
            if (pacWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("What is your package width?");
            }
            int pacWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your package height?");
            int pacHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your package length?");
            int pacLength = Convert.ToInt32(Console.ReadLine());
            if (50 < (pacHeight + pacLength + pacWidth))
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
            }
            int pacShipCost = ((pacWidth * pacLength * pacHeight) * pacWeight) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: " + "$" + Convert.ToString(pacShipCost) + ".00");
        }
    }
}
