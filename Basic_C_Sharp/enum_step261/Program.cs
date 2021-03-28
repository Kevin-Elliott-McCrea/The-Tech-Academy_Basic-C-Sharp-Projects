using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_step261
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the current day of the week: ");

            bool T = false;
            while (T == false)
            {
                try
                {
                    DayOfWeek chosenDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine(), true);
                    Console.WriteLine("Yes, it sure is " + chosenDay);
                    T = true;
                }
                catch
                {
                    Console.WriteLine("Do you even know what the days of the week are??\nPlease enter an actual day of the week: ");
                };
            }
            
            Console.ReadLine();
            
        
        }
    }
}
