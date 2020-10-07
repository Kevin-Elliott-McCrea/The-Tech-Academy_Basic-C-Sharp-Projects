using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringApp_step184
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "I love jumping in the forest!\n";
            string b = "Wow, who are you?\n";
            string c = "I am Tom Bombadil!\n";

            c = c.ToUpper();
            Console.WriteLine(c);

            string z = a + b + c;
            Console.WriteLine(z);

            StringBuilder coolStr = new StringBuilder();
            coolStr.Append("My name is Inigo Montoya.\n");
            coolStr.Append("You killed my father.\n");
            coolStr.Append("Prepare to die!");
            Console.WriteLine(coolStr);
        }
    }
}
