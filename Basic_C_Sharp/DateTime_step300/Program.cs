using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_step300
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Give me any number you like: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(num));
            Console.ReadLine();
        }
    }
}
