using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_step272
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> LambdaHouse = new List<Employee>
            {
                new Employee { FirstName = "Joe", LastName = "Condoin", ID = 1 },
                new Employee { FirstName = "Joe", LastName = "Gabowobby", ID = 2 },
                new Employee { FirstName = "Jimbo", LastName = "Gardener", ID = 3 },
                new Employee { FirstName = "Catherine", LastName = "Slandoloo", ID = 4 },
                new Employee { FirstName = "Beepo", LastName = "Smith", ID = 5 },
                new Employee { FirstName = "Miner", LastName = "Candolee", ID = 6 },
                new Employee { FirstName = "Vodka", LastName = "Pooh", ID = 7 },
                new Employee { FirstName = "Alice", LastName = "Tamborine", ID = 8 },
                new Employee { FirstName = "Sycorax", LastName = "Jumper", ID = 9 },
                new Employee { FirstName = "Gardoba", LastName = "Cockatoo", ID = 10 },
            };

            //List<Employee> NewAgeLambda = new List<Employee>();

            //foreach(Employee transfer in LambdaHouse)
            //{
            //    if(transfer.FirstName == "Joe")
            //    {
            //        NewAgeLambda.Add(transfer);
            //    }
            //}

            //foreach (Employee printout in NewAgeLambda)
            //{
            //    Console.WriteLine("{0} {1}", printout.FirstName, printout.LastName);
            //}


            //List<Employee> NewAgeLambda2 = LambdaHouse.Where(transfer => transfer.FirstName == "Joe").ToList();

            List<Employee> LambdaBigID = LambdaHouse.Where(x => x.ID > 5).ToList();

            foreach (Employee printout in LambdaBigID)
            {
                Console.WriteLine("{0} {1} {2}", printout.FirstName, printout.LastName, printout.ID);
            }

            Console.ReadLine();

        }
    }
}
