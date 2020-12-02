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
            mathClass math1 = new mathClass();

            Console.WriteLine("What number would you like to be changed? (Pick a whole number that isn't zero)");
            int userAns = Convert.ToInt32(Console.ReadLine());
            int ans1 = math1.numAdd(userAns);

            Console.WriteLine("What number would you like to be changed? (Pick any number that isn't zero)");
            decimal userAns2 = Convert.ToDecimal(Console.ReadLine());
            int ans2 = math1.numAdd(userAns2);

            Console.WriteLine("What number would you like to be changed? (Pick a whole number that isn't zero)");
            string userAns3 = Console.ReadLine();
            int ans3 = math1.numAdd(userAns3);
        }
    }
}