using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class StudentInfoContext : DbContext
    {
        public StudentInfoContext(DbContextOptions<StudentInfoContext> options)
            : base(options)
        {

        }

        public DbSet<StudentModel> StudentModels { get; set; }
    }
}
