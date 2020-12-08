using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_step236
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sampleEmployee = new Employee();

            sampleEmployee.FirstName = "Sample";
            sampleEmployee.LastName = "Student";

            sampleEmployee.SayName();
            Console.ReadLine();
        }
    }
}
