using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse_consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 20;
            int B = 15;

            if (A > B)
            {
                Console.WriteLine("A gets a double cheeseburger");
            }
            else if (B > A)
            {
                Console.WriteLine("B gets a new house");
            }
            else
            {
                Console.WriteLine("Too bad, no one gets a cookie");
            }

            if (A != B)
            {
                Console.WriteLine("\nI guess this computer works...");
            }
            else
            {
                Console.WriteLine("You're doomed");
            }

            string result = A > B ? "A is bigger and better" : "B kicks in your teeth before the big game";
            Console.WriteLine(result);
               
        }
    }
}
