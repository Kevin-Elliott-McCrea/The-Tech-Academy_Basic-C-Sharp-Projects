using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step228
{
    class SelectParameterByName
    {
        public void VoidMethod(int num, int num2)
        {
            num = num + 3;
            Console.WriteLine(num2);
            Console.WriteLine(num);
        }
    }
}
