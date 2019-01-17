using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspdotnetAssignment.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }


        public DbSet<User> user { get; set; }
    }
}
