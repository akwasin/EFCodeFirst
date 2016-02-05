using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class Education
    {
        public int EducationID { get; set; }
        public string EducationName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
