using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI1.Entities;

namespace WebAPI1.Data
{
    public class DataContext : DbContext
    {

        public DataContext (DbContextOptions options):base(options)
        {

        }


        public DbSet<AppUser> Users { get; set; }
    }
}
