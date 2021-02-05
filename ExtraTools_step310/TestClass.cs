using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraTools_step310
{
    public class TestClass
    {
        public TestClass(int num1) : this(num1, 100)
        {

        }
        public TestClass(int num1, int num2)
        {
            int numHolder1 = num1;
            int numHolder2 = num2;
            string testPerson = "I have 2 arms";
            Console.WriteLine(testPerson);
            Console.WriteLine(numHolder1);
            Console.WriteLine(numHolder2);
        } 
    }
}
