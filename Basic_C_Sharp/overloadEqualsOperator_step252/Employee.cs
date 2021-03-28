using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadEqualsOperator_step252
{
    public class Employee
    {
        public int Id { get; set; }

        public static Boolean operator== (Employee Employee1, Employee Employee2)
        {
            return Employee1.Id == Employee2.Id;
        }
        public static Boolean operator!= (Employee Employee1, Employee Employee2)
        {
            return Employee1.Id != Employee2.Id;
        }
    }
}
