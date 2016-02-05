using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                Student student = new Student() { StudentName = "New student", StudentBirthDate = DateTime.Now.AddYears(-30) };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}