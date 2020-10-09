using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethods_step216
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to be changed? (Pick a whole number that isn't zero)");
            int userAns = Convert.ToInt32(Console.ReadLine());

            mathClass math1 = new mathClass();

            int ans1 = math1.numAdd(userAns);
            int ans2 = math1.numTimes(userAns);
            int ans3 = math1.numDiv(userAns);
        }
    }
}