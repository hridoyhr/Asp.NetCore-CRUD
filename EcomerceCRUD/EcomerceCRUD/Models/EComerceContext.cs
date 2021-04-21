using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomerceCRUD.Models
{
    public class EComerceContext : DbContext
    {
        public EComerceContext(DbContextOptions<EComerceContext> options)
            : base(options)
        {

        }

        public DbSet<EComerceModel> eComerces { get; set; }
    }
}
