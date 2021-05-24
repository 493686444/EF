using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Sample
{
    public class SqlDbContext:DbContext
    {
        public DbSet<User> Users { set; get; }
        public SqlDbContext():base("EFsixWork")
        {
            Database.Log = Console.WriteLine;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
