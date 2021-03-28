using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_step236
{
    public class Person
    {
        public string FirstName = "Oona";
        public string LastName= "DragonSlayer";

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
