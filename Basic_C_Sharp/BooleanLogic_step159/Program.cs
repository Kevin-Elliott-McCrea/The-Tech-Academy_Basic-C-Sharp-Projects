using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic_step159
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int driverAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (Type Yes or No)");
            string driverDUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int driverTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are you qualified to be insured?");

            Console.WriteLine(driverAge > 15 && driverDUI == "No" && driverTickets < 4);
            Console.ReadLine();
        }
    }
}
