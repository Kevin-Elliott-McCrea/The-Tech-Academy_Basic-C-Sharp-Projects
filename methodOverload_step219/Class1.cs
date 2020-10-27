using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethods_step216
{
    public class mathClass
    {
        public int numAdd(int numToAdd)
        {
            numToAdd = numToAdd + 5;
            Console.WriteLine(numToAdd);
            return numToAdd;
        }

        public int numAdd(decimal numToTimes)
        {
            numToTimes = numToTimes * 15;
            Console.WriteLine(numToTimes);
            return Convert.ToInt32(numToTimes);
        }

        public int numAdd(string numToDiv)
        {
            int numToDiv1 = Convert.ToInt32(numToDiv);
            numToDiv1 = numToDiv1 / 2;
            Console.WriteLine(numToDiv1);
            return numToDiv1;
        }

    }
}
