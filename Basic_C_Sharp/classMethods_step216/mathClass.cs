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

        public int numTimes(int numToTimes)
        {
            numToTimes = numToTimes * 15;
            Console.WriteLine(numToTimes);
            return numToTimes;
        }

        public int numDiv(int numToDiv)
        {
            numToDiv = numToDiv / 2;
            Console.WriteLine(numToDiv);
            return numToDiv;
        }

    }
}
