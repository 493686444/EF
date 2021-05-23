using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class SqlDbContext : DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<Problem> Problems { set; get; }
        public DbSet<Message> Messages { set; get; }


        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connstr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDatabase;Integrated Security=True";
            optionsBuilder.UseSqlServer(connstr);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
