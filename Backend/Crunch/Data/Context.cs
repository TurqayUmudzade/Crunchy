using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crunch.Models;

namespace Crunch.Data
{
    public class Context : DbContext
    {
        

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<Class> classes { get; set; }
        public DbSet<Trainer> trainers { get; set; }

    }
}
