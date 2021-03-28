using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string[] strArray = { "flowers", "movie", "fancy dinner" };

        Console.WriteLine("Find out what your next romantic advice is for your friend by typing 0, 1, or 2: ");
        string userPick = Console.ReadLine();

        bool dataInput = false;

        while (dataInput == false)
        {
            if (Convert.ToInt32(userPick) >= 0 && Convert.ToInt32(userPick) <= 2)
            {
                Console.WriteLine("You will use " + strArray[Convert.ToInt32(userPick)]);
                dataInput = true;
            }
            else
            {
                Console.WriteLine("That is not actually an option, my friend.");
                Console.WriteLine("Please type 0, 1, or 2:");
                userPick = Console.ReadLine();
            }

        }


        int[] numArray = { 12, 42, 7 };

        Console.WriteLine("\nPick your new favorite number by typing in 0, 1, or 2: ");
        string userPick2 = Console.ReadLine();

        bool dataInput2 = false;

        while (dataInput2 == false)
        {
            if (Convert.ToInt32(userPick2) >= 0 && Convert.ToInt32(userPick2) <= 2)
            {
                Console.WriteLine("Your new favorite number is " + numArray[Convert.ToInt32(userPick2)]);
                dataInput2 = true;
            }
            else
            {
                Console.WriteLine("Oooh you did not pick a real option!\n");
                Console.WriteLine("Please type 0, 1, or 2:");
                userPick = Console.ReadLine();
            }
        }



        string[] nameArray = { "Bob", "Jim", "Jokombe" };
        List<string> strList = new List<string>(nameArray);

        Console.WriteLine("Find out who stole your lunch money by typing in 0, 1, or 2: ");
        string userPick3 = Console.ReadLine();

        bool dataInput3 = false;

        while (dataInput3 == false)
        {
            if (Convert.ToInt32(userPick3) >= 0 && Convert.ToInt32(userPick3) <= 2)
            {
                Console.WriteLine(strList[Convert.ToInt32(userPick3)] + " stole your dough. GET HIM!");
                dataInput3 = true;
            }
            else
            {
                Console.WriteLine("That is not actually an option, my friend.");
                Console.WriteLine("Please type 0, 1, or 2:");
                userPick3 = Console.ReadLine();
            }

        }

        //List<string> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Bobbo,");

        //Console.WriteLine(intList[1]);


        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000 };

        //numArray2[4] = 5500;

        //Console.WriteLine(numArray2[4]);
    }
}
