using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes_step129.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            Console.WriteLine("The Tech Academy.\nStudent Daily Report.");

            Console.WriteLine("\nWhat is your name?");
            string studentName = Console.ReadLine();

            Console.WriteLine("\nWhat course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("\nWhat page number?");
            string pageNum = Console.ReadLine();
            short pageNumber = Convert.ToInt16(pageNum);

            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false.");
            string makeBool = Console.ReadLine();
            bool isBool = Convert.ToBoolean(makeBool);

            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics.");
            string positiveXP = Console.ReadLine();

            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific");
            string othFeedback = Console.ReadLine();

            Console.WriteLine("\nHow many hours did you study today?");
            string strStudyHrs = Console.ReadLine();
            short studyHrs = Convert.ToInt16(strStudyHrs);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();


        }
    }
}
