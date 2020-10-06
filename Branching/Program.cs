using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "Your favorite number sucks.";

            Console.WriteLine(result);
            


            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer that room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhh.... something went wrong");
            //}


            //int currentTemperature = 70;
            //int roomTempurature = 70;

            //if (currentTemperature == roomTempurature)
            //{
            //    Console.WriteLine("Ooooh it is just right");
            //}
            //else if (currentTemperature > roomTempurature)
            //{
            //    Console.WriteLine("Too much! Cool it!");
            //}
            //else if (roomTempurature > currentTemperature)
            //{
            //    Console.WriteLine("It's getting a bit chilly");
            //}
            //else
            //{
            //    Console.WriteLine("It's not that perfect temp");
            //}

        }
    }
}
