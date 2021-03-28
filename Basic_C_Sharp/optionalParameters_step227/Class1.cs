using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalParameters_step227
{
    public class MathClass
    {
        public int NumAdd(int ans1, int ans2 = 5)
        {
            ans1 = ans1 + ans2;
            Console.WriteLine(ans1);
            return ans1;
        }
    }
}

