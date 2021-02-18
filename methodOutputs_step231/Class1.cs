using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOutputs_step231
{
    public class MethodContainer
    {
        public void ChangeNumber(int num)
        {
            num = num / 2;
            Console.WriteLine(num);
        }


        public void OutNumber(out int z)
        {
            z = 10;
            Console.WriteLine(z);
        }
        

        public void OutNumber(out double z)
        {
            z = 5.5;
            Console.WriteLine(z);
        }
    }


    public static class NoUseMe
    {
        public static int T = 10;
    }
}
