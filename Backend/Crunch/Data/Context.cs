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

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserClass>()
               .HasKey(x => new { x.UserID, x.ClassID });

            //If you name your foreign keys correctly, then you don't need this.
            modelBuilder.Entity<UserClass>()
                .HasOne(uc => uc.user)
                .WithMany(p => p.userClasses)
                .HasForeignKey(uc => uc.UserID);

            modelBuilder.Entity<UserClass>()
                .HasOne(uc => uc.@class)
                .WithMany(t => t.userClasses)
                .HasForeignKey(uc => uc.ClassID);
        }


        public DbSet<User> users { get; set; }
        public DbSet<Class> classes { get; set; }
        public DbSet<Trainer> trainers { get; set; }
        public DbSet<Gym>  gyms{ get; set; }
        public DbSet<Promocode> promocodes{ get; set; }

    }
}
