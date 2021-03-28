using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Comparison_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1\nHourly Rate:");
            int p1_hrlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            int p1_hrsPerWeek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2\nHourly Rate:");
            int p2_hrlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            int p2_hrsPerWeek = Convert.ToInt32(Console.ReadLine());

            int p1_salary = p1_hrlyRate * p1_hrsPerWeek * 52;
            int p2_salary = p2_hrlyRate * p2_hrsPerWeek * 52;
            
            Console.WriteLine("Annual salary of Person 1:\n " + p1_salary);
            Console.WriteLine("Annual salary of Person 2:\n " + p2_salary);

            bool p1LargerSalary = p1_salary > p2_salary;
            Convert.ToString(p1LargerSalary);

            Console.WriteLine("Does Person 1 make more money than Person 2?:\n " + p1LargerSalary);
        }
    }
}
