using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling_step203
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            numList.Add(3);
            numList.Add(10);
            numList.Add(302);
            numList.Add(29);
            numList.Add(72);

            Console.WriteLine("Pick a whole number, greater than zero");


            try
            {
                int userNum = Convert.ToInt32(Console.ReadLine());
                foreach (int num in numList)
                {
                    Console.WriteLine(num / userNum);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please pick a whole number, we can only work with them.");
            }
            catch (DivideByZeroException exZ)
            {
                Console.WriteLine("Don\'t pick a zero, silly. We can\'t divide by zero!");
            }

            Console.WriteLine("We're out of the woods! No more catches!");
        }
    }
}
