using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace consoleApp_step197_210
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part One of App

            //string[] names = { "Jombo ", "Balimbe ", "Bilbo " };
            //Console.WriteLine("Type something to add to the array:");
            //string strAdd = Console.ReadLine();

            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] += strAdd;
            //}

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}


            //Console App part 2

            //int testInt = 10;
            //while (testInt == 10)
            //{
            //    Console.WriteLine("10");
            //    testInt++;
            //}


            //Console App part 3

            //int bigNum = 12000;

            //while (11900 < bigNum)
            //{
            //    Console.WriteLine("I'm Pickle Rick!");
            //    bigNum = bigNum - 10;
            //}

            //while (11800 <= bigNum)
            //{
            //    Console.WriteLine("I'm Regular Rick...");
            //    bigNum = bigNum - 10;
            //}



            //Console App part 4

            //List<string> strList4 = new List<string>();
            //strList4.Add("Jingle");
            //strList4.Add("Bells");
            //strList4.Add("Rock");
            //strList4.Add("Jingle");

            //Console.WriteLine("Type in characters to see if that exact sequence exists in the list!");
            //string searchKeyword = Console.ReadLine();
            //if (strList4.Contains(searchKeyword))
            //{
            //    Console.WriteLine(searchKeyword);
            //    for (int i = 0; i < strList4.Count; i++)
            //    {
            //        if (strList4[i] == searchKeyword)
            //        {
            //            Console.WriteLine("Match Found");
            //            Console.WriteLine("Index is: " + i);
            //            // break; --- we take this out for part 5, but it exists for part 4
            //        }
            //        else
            //        {
            //            Console.WriteLine("That one is no match for you, my friend.");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Better luck next time buddy");
            //}



            //Console App part 5

            //For this section, I just took out the break statement for the if loop above, 
            //which allows it to iterate through the whole list to find all matches


            //Console App part 6

            List<string> strList6 = new List<string>();
            strList6.Add("Avatar");
            strList6.Add("Roku");
            strList6.Add("TV");
            strList6.Add("Roku");

            string alreadyAppeared = "";

            Console.WriteLine("Type in characters to see if that exact sequence exists in the list!");
            string searchKeyword6 = Console.ReadLine();
            if (strList6.Contains(searchKeyword6))
            {
                Console.WriteLine(searchKeyword6);
                for (int i = 0; i < strList6.Count; i++)
                {
                    if (strList6[i] == searchKeyword6)
                    {
                        Console.WriteLine("\n" + searchKeyword6);
                        
                        if (alreadyAppeared != "")
                        {
                            Console.WriteLine("This guy has already shown up once or twice!");
                        }
                        alreadyAppeared = searchKeyword6;
                    }
                    else
                    {
                        Console.WriteLine("That one is no match for you, my friend.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Better luck next time buddy");
            }
        }
    }
}
