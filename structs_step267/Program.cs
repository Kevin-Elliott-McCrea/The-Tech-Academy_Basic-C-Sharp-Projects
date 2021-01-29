using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs_step267
{
    class Program
    {
        static void Main(string[] args)
        {
            Struct.Number test = new Struct.Number();
            test.Amount = 5.445636529834758293475892M;

            Console.WriteLine(test.Amount);
            Console.ReadLine();

            //print out test.amount after assigning

        }
    }
}
