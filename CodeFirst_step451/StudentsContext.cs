using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_step251
{
    public class StudentsContext : DbContext
    {
        public StudentsContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
