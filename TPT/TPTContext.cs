using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPT
{
    public class TPTContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PC>().ToTable("Pecety"); //wez wpisz pcty do innej tabeli
            modelBuilder.Entity<Laptop>().ToTable("Laptopy"); //laptopy do innej tego nie było w tph
        }
    }
}
