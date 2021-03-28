using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadEqualsOperator_step252
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee
            {
                Id = 1
            };
            Employee Emp2 = new Employee()
            {
                Id = 2
            };

            if (Emp1 == Emp2)
            {
                Console.WriteLine("They are the same employee");
            }
            else
            {
                Console.WriteLine("They are different");
            }

            if (Emp1 != Emp2)
            {
                Console.WriteLine("They are very different");
            }
            else
            {
                Console.WriteLine("They are exactly the same");
            }
            Console.ReadLine();
        }
    }
}
