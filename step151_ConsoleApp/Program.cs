using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step151_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string times50str = Console.ReadLine();
            int times50 = Convert.ToInt32(times50str) * 50;
            Console.WriteLine(times50);

            string add25str = Console.ReadLine();
            int add25 = Convert.ToInt32(add25str) + 25;
            Console.WriteLine(add25);

            string divide12str = Console.ReadLine();
            float divide12 = Convert.ToSingle(divide12str) / Convert.ToSingle(12.5);
            Console.WriteLine(divide12);

            int morethan50 = Convert.ToInt32(Console.ReadLine());
            bool yesOrNo = morethan50 > 50;
            Console.WriteLine(yesOrNo);

            int remainBy7 = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.WriteLine(remainBy7);

            Console.ReadLine();
        }
    }
}
