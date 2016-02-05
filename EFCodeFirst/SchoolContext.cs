using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFCodeFirst
{
    class SchoolContext : DbContext
    {
        public DbSet<Education> Education { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}
