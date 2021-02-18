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

            Console.WriteLine("Give me a whole number please.");
            int a = Convert.ToInt32(Console.ReadLine());
            Methods.ChangeNumber(a);

            Methods.OutNumber(out a);

            Console.WriteLine("Enter in a whole number or a decimal");
            double b = Convert.ToDouble(Console.ReadLine());
            Methods.OutNumber(out b);


            Console.WriteLine(NoUseMe.T);

            Console.ReadLine();
        }
    }
}
