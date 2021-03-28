using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogTextFiles_step297
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Could you enter some numbers, good sir?");
            string text = Console.ReadLine();

            File.WriteAllText(@"C:\Test\log.txt", text);
            Console.WriteLine(File.ReadAllText(@"C:\Test\log.txt"));
            Console.ReadLine();
        }
    }
}
