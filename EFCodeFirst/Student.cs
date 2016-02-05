using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentAge { get; set; }
        public DateTime StudentBirthDate { get; set; }
        public string StudentAdress { get; set; }

        public Education Education { get; set; }
    }
}
