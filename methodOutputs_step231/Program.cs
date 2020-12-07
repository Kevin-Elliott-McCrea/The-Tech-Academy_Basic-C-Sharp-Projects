using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOutputs_step231
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodContainer Methods = new MethodContainer();

            int a = Convert.ToInt32(Console.ReadLine());
            Methods.ChangeNumber(a);

            Console.ReadLine();
        }
    }
}
