using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalParameters_step227
{
    class Program
    {
        public static void Main(string[] args)
        {
            MathClass math1 = new MathClass();

            Console.WriteLine("Pick a number to be changed: ");
            int userAns = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("(Optional) Pick another number to be changed: ");
            int userAns2;
            int result;
            string userStr = Console.ReadLine();

            if(userStr != "")
            {
                userAns2 = Convert.ToInt32(userStr);
                result = math1.NumAdd(userAns, userAns2);
            }
            else
            {
                result = math1.NumAdd(userAns);
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
