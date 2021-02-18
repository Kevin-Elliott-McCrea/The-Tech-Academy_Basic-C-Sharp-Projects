using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_step251
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var classRoom = new StudentsContext())
            {
                var stud = new Student() { Id = 1, Name = "Bill", Grade = 3 };

                classRoom.Students.Add(stud);
                classRoom.SaveChanges();
            }
        }
    }
}
