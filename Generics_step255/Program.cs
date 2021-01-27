using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_step255
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> stringThings = new Employee<string>
            {
                things = new List<string> { "jim", "bob", "gabby" }
            };

            Employee<int> intThings = new Employee<int>
            {
                things = new List<int> { 1, 2, 5}
            };

            for (int i = 0; i < stringThings.things.Count; i++)
            {
                Console.WriteLine(stringThings.things[i]);
            }
            
            for (int i = 0; i < intThings.things.Count; i++)
            {
                Console.WriteLine(intThings.things[i]);
            }
            Console.ReadLine();
        }
    }
}
