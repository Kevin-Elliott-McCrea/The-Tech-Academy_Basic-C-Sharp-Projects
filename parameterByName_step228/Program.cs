using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step228
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectParameterByName Instance1 = new SelectParameterByName();

            Instance1.VoidMethod(2, 4);
            Instance1.VoidMethod(num2: 4, num: 2);
            Console.ReadLine();
        }
    }
}
