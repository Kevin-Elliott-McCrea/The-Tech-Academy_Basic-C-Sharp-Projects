using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_step314
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            try
            {
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer < 0)
                {
                    throw new BelowZeroException();
                }
                else if (answer == 0)
                {
                    throw new ZeroException();
                }
                answer = 2020 - answer;
                Console.WriteLine("This user was born in {0}", answer);
            }
            catch (ZeroException)
            {
                Console.WriteLine("Please enter a positive whole number");
            }
            catch (BelowZeroException)
            {
                Console.WriteLine("Please enter a positive whole number, buddy.");
            }
            catch (Exception e)
            {
                Console.WriteLine("You messed up");
            }
            Console.ReadLine();
        }
    }
}
