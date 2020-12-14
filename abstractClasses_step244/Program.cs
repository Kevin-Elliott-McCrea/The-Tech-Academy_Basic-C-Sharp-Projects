using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClasses_step244
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee Example = new Employee();

            Example.firstName = "Sample";
            Example.lastName = "Student";

            Example.SayName();
            Console.ReadLine();
        }
    }
}
