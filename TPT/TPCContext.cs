using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPT
{
    class TPCContext : DbContext
    {
        //kazdy typ konkretny dostanie swoja odzielna tabele (czyli ten co nie ma abstract)
        public DbSet<Computer> Computers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PC>().Map(map =>
            {
                map.MapInheritedProperties(); //przepisze z 
                map.ToTable("PCs");
            });
            modelBuilder.Entity<Laptop>().Map(map =>
            {
                map.MapInheritedProperties();
                map.ToTable("Laptop");
            });
        }
    }
}
